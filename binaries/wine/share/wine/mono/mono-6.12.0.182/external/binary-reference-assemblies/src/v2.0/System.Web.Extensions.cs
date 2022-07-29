// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("3.5.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Extensions.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Extensions.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Extensions.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("3.5.0.0")]
[assembly:System.Runtime.CompilerServices.DependencyAttribute("System,", (System.Runtime.CompilerServices.LoadHint)(1))]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Web.UI.TagPrefixAttribute("System.Web.UI", "asp")]
[assembly:System.Web.UI.TagPrefixAttribute("System.Web.UI.WebControls", "asp")]
[assembly:System.Web.UI.WebResourceAttribute("MicrosoftAjax.debug.js", "application/x-javascript")]
[assembly:System.Web.UI.WebResourceAttribute("MicrosoftAjax.js", "application/x-javascript")]
[assembly:System.Web.UI.WebResourceAttribute("MicrosoftAjaxTimer.debug.js", "application/x-javascript")]
[assembly:System.Web.UI.WebResourceAttribute("MicrosoftAjaxTimer.js", "application/x-javascript")]
[assembly:System.Web.UI.WebResourceAttribute("MicrosoftAjaxWebForms.debug.js", "application/x-javascript")]
[assembly:System.Web.UI.WebResourceAttribute("MicrosoftAjaxWebForms.js", "application/x-javascript")]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
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
namespace System.Web.ClientServices
{
    public partial class ClientFormsIdentity : System.IDisposable, System.Security.Principal.IIdentity
    {
        public ClientFormsIdentity(string name, string password, System.Web.Security.MembershipProvider provider, string authenticationType, bool isAuthenticated, System.Net.CookieContainer authenticationCookies) { }
        public System.Net.CookieContainer AuthenticationCookies { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string AuthenticationType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsAuthenticated { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Security.MembershipProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void Dispose() { }
        public void RevalidateUser() { }
    }
    public partial class ClientRolePrincipal : System.Security.Principal.IPrincipal
    {
        public ClientRolePrincipal(System.Security.Principal.IIdentity identity) { }
        public System.Security.Principal.IIdentity Identity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsInRole(string role) { throw null; }
    }
    public static partial class ConnectivityStatus
    {
        public static bool IsOffline { get { throw null; } set { } }
    }
}
namespace System.Web.ClientServices.Providers
{
    public partial class ClientFormsAuthenticationCredentials
    {
        public ClientFormsAuthenticationCredentials(string username, string password, bool rememberMe) { }
        public string Password { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool RememberMe { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string UserName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ClientFormsAuthenticationMembershipProvider : System.Web.Security.MembershipProvider
    {
        public ClientFormsAuthenticationMembershipProvider() { }
        public override string ApplicationName { get { throw null; } set { } }
        public override bool EnablePasswordReset { get { throw null; } }
        public override bool EnablePasswordRetrieval { get { throw null; } }
        public override int MaxInvalidPasswordAttempts { get { throw null; } }
        public override int MinRequiredNonAlphanumericCharacters { get { throw null; } }
        public override int MinRequiredPasswordLength { get { throw null; } }
        public override int PasswordAttemptWindow { get { throw null; } }
        public override System.Web.Security.MembershipPasswordFormat PasswordFormat { get { throw null; } }
        public override string PasswordStrengthRegularExpression { get { throw null; } }
        public override bool RequiresQuestionAndAnswer { get { throw null; } }
        public override bool RequiresUniqueEmail { get { throw null; } }
        public event System.EventHandler<System.Web.ClientServices.Providers.UserValidatedEventArgs> UserValidated { add { } remove { } }
        public override bool ChangePassword(string username, string oldPassword, string newPassword) { throw null; }
        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer) { throw null; }
        public override System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status) { status = default(System.Web.Security.MembershipCreateStatus); throw null; }
        public override bool DeleteUser(string username, bool deleteAllRelatedData) { throw null; }
        public override System.Web.Security.MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); throw null; }
        public override System.Web.Security.MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); throw null; }
        public override System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); throw null; }
        public override int GetNumberOfUsersOnline() { throw null; }
        public override string GetPassword(string username, string answer) { throw null; }
        public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline) { throw null; }
        public override System.Web.Security.MembershipUser GetUser(string username, bool userIsOnline) { throw null; }
        public override string GetUserNameByEmail(string email) { throw null; }
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
        public void Logout() { }
        public override string ResetPassword(string username, string answer) { throw null; }
        public override bool UnlockUser(string username) { throw null; }
        public override void UpdateUser(System.Web.Security.MembershipUser user) { }
        public override bool ValidateUser(string username, string password) { throw null; }
        public bool ValidateUser(string username, string password, bool rememberMe) { throw null; }
        public static bool ValidateUser(string username, string password, string serviceUri) { throw null; }
    }
    public partial class ClientRoleProvider : System.Web.Security.RoleProvider
    {
        public ClientRoleProvider() { }
        public override string ApplicationName { get { throw null; } set { } }
        public string ServiceUri { get { throw null; } set { } }
        public override void AddUsersToRoles(string[] usernames, string[] roleNames) { }
        public override void CreateRole(string roleName) { }
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole) { throw null; }
        public override string[] FindUsersInRole(string roleName, string usernameToMatch) { throw null; }
        public override string[] GetAllRoles() { throw null; }
        public override string[] GetRolesForUser(string username) { throw null; }
        public override string[] GetUsersInRole(string roleName) { throw null; }
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
        public override bool IsUserInRole(string username, string roleName) { throw null; }
        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames) { }
        public void ResetCache() { }
        public override bool RoleExists(string roleName) { throw null; }
    }
    public partial class ClientSettingsProvider : System.Configuration.SettingsProvider, System.Configuration.IApplicationSettingsProvider
    {
        public ClientSettingsProvider() { }
        public override string ApplicationName { get { throw null; } set { } }
        public static string ServiceUri { get { throw null; } set { } }
        public event System.EventHandler<System.Web.ClientServices.Providers.SettingsSavedEventArgs> SettingsSaved { add { } remove { } }
        public System.Configuration.SettingsPropertyValue GetPreviousVersion(System.Configuration.SettingsContext context, System.Configuration.SettingsProperty property) { throw null; }
        public static System.Configuration.SettingsPropertyCollection GetPropertyMetadata(string serviceUri) { throw null; }
        public override System.Configuration.SettingsPropertyValueCollection GetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection propertyCollection) { throw null; }
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
        public void Reset(System.Configuration.SettingsContext context) { }
        public override void SetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyValueCollection propertyValueCollection) { }
        public void Upgrade(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection properties) { }
    }
    public partial class ClientWindowsAuthenticationMembershipProvider : System.Web.Security.MembershipProvider
    {
        public ClientWindowsAuthenticationMembershipProvider() { }
        public override string ApplicationName { get { throw null; } set { } }
        public override bool EnablePasswordReset { get { throw null; } }
        public override bool EnablePasswordRetrieval { get { throw null; } }
        public override int MaxInvalidPasswordAttempts { get { throw null; } }
        public override int MinRequiredNonAlphanumericCharacters { get { throw null; } }
        public override int MinRequiredPasswordLength { get { throw null; } }
        public override int PasswordAttemptWindow { get { throw null; } }
        public override System.Web.Security.MembershipPasswordFormat PasswordFormat { get { throw null; } }
        public override string PasswordStrengthRegularExpression { get { throw null; } }
        public override bool RequiresQuestionAndAnswer { get { throw null; } }
        public override bool RequiresUniqueEmail { get { throw null; } }
        public override bool ChangePassword(string username, string oldPassword, string newPassword) { throw null; }
        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer) { throw null; }
        public override System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status) { status = default(System.Web.Security.MembershipCreateStatus); throw null; }
        public override bool DeleteUser(string username, bool deleteAllRelatedData) { throw null; }
        public override System.Web.Security.MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); throw null; }
        public override System.Web.Security.MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); throw null; }
        public override System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); throw null; }
        public override int GetNumberOfUsersOnline() { throw null; }
        public override string GetPassword(string username, string answer) { throw null; }
        public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline) { throw null; }
        public override System.Web.Security.MembershipUser GetUser(string username, bool userIsOnline) { throw null; }
        public override string GetUserNameByEmail(string email) { throw null; }
        public void Logout() { }
        public override string ResetPassword(string username, string answer) { throw null; }
        public override bool UnlockUser(string username) { throw null; }
        public override void UpdateUser(System.Web.Security.MembershipUser user) { }
        public override bool ValidateUser(string username, string password) { throw null; }
    }
    public partial interface IClientFormsAuthenticationCredentialsProvider
    {
        System.Web.ClientServices.Providers.ClientFormsAuthenticationCredentials GetCredentials();
    }
    public partial class SettingsSavedEventArgs : System.EventArgs
    {
        public SettingsSavedEventArgs(System.Collections.Generic.IEnumerable<string> failedSettingsList) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> FailedSettingsList { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class UserValidatedEventArgs : System.EventArgs
    {
        public UserValidatedEventArgs(string username) { }
        public string UserName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
namespace System.Web.Configuration
{
    public partial class Converter : System.Configuration.ConfigurationElement
    {
        public Converter() { }
        [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=true, IsKey=true, DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=1)]
        public string Name { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("type", IsRequired=true, DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=1)]
        public string Type { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.Configuration.Converter))]
    public partial class ConvertersCollection : System.Configuration.ConfigurationElementCollection
    {
        public ConvertersCollection() { }
        public System.Web.Configuration.Converter this[int index] { get { throw null; } set { } }
        public void Add(System.Web.Configuration.Converter converter) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(System.Web.Configuration.Converter converter) { }
    }
    public sealed partial class ScriptingAuthenticationServiceSection : System.Configuration.ConfigurationSection
    {
        public ScriptingAuthenticationServiceSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=false)]
        public bool Enabled { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("requireSSL", DefaultValue=false)]
        public bool RequireSSL { get { throw null; } set { } }
    }
    public sealed partial class ScriptingJsonSerializationSection : System.Configuration.ConfigurationSection
    {
        public ScriptingJsonSerializationSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("converters", IsKey=true)]
        public System.Web.Configuration.ConvertersCollection Converters { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("maxJsonLength", DefaultValue=2097152)]
        public int MaxJsonLength { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("recursionLimit", DefaultValue=100)]
        public int RecursionLimit { get { throw null; } set { } }
    }
    public sealed partial class ScriptingProfileServiceSection : System.Configuration.ConfigurationSection
    {
        public ScriptingProfileServiceSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=false)]
        public bool Enabled { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
        [System.Configuration.ConfigurationPropertyAttribute("readAccessProperties", DefaultValue=null)]
        public string[] ReadAccessProperties { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
        [System.Configuration.ConfigurationPropertyAttribute("writeAccessProperties", DefaultValue=null)]
        public string[] WriteAccessProperties { get { throw null; } set { } }
    }
    public sealed partial class ScriptingRoleServiceSection : System.Configuration.ConfigurationSection
    {
        public ScriptingRoleServiceSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=false)]
        public bool Enabled { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    public sealed partial class ScriptingScriptResourceHandlerSection : System.Configuration.ConfigurationSection
    {
        public ScriptingScriptResourceHandlerSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("enableCaching", DefaultValue=true)]
        public bool EnableCaching { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("enableCompression", DefaultValue=true)]
        public bool EnableCompression { get { throw null; } set { } }
    }
    public sealed partial class ScriptingSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public ScriptingSectionGroup() { }
        [System.Configuration.ConfigurationPropertyAttribute("scriptResourceHandler")]
        public System.Web.Configuration.ScriptingScriptResourceHandlerSection ScriptResourceHandler { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("webServices")]
        public System.Web.Configuration.ScriptingWebServicesSectionGroup WebServices { get { throw null; } }
    }
    public sealed partial class ScriptingWebServicesSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public ScriptingWebServicesSectionGroup() { }
        [System.Configuration.ConfigurationPropertyAttribute("authenticationService")]
        public System.Web.Configuration.ScriptingAuthenticationServiceSection AuthenticationService { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("jsonSerialization")]
        public System.Web.Configuration.ScriptingJsonSerializationSection JsonSerialization { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("profileService")]
        public System.Web.Configuration.ScriptingProfileServiceSection ProfileService { get { throw null; } }
    }
    public sealed partial class SystemWebExtensionsSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public SystemWebExtensionsSectionGroup() { }
        [System.Configuration.ConfigurationPropertyAttribute("scripting")]
        public System.Web.Configuration.ScriptingSectionGroup Scripting { get { throw null; } }
    }
}
namespace System.Web.DynamicData
{
    public enum DynamicDataSourceOperation
    {
        ContextCreate = 4,
        Delete = 0,
        Insert = 1,
        Select = 2,
        Update = 3,
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicValidatorEventArgs : System.EventArgs
    {
        public DynamicValidatorEventArgs(System.Exception exception, System.Web.DynamicData.DynamicDataSourceOperation operation) { }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.DynamicData.DynamicDataSourceOperation Operation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IDynamicDataSource : System.Web.UI.IDataSource
    {
        bool AutoGenerateWhereClause { get; set; }
        System.Type ContextType { get; set; }
        bool EnableDelete { get; set; }
        bool EnableInsert { get; set; }
        bool EnableUpdate { get; set; }
        string EntitySetName { get; set; }
        string Where { get; set; }
        System.Web.UI.WebControls.ParameterCollection WhereParameters { get; }
        event System.EventHandler<System.Web.DynamicData.DynamicValidatorEventArgs> Exception;
    }
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IDynamicValidatorException
    {
        System.Collections.Generic.IDictionary<string, System.Exception> InnerExceptions { get; }
    }
}
namespace System.Web.Handlers
{
    public partial class ScriptModule : System.Web.IHttpModule
    {
        public ScriptModule() { }
        protected virtual void Dispose() { }
        protected virtual void Init(System.Web.HttpApplication context) { }
        void System.Web.IHttpModule.Dispose() { }
        void System.Web.IHttpModule.Init(System.Web.HttpApplication context) { }
    }
    public partial class ScriptResourceHandler : System.Web.IHttpHandler
    {
        public ScriptResourceHandler() { }
        protected virtual bool IsReusable { get { throw null; } }
        bool System.Web.IHttpHandler.IsReusable { get { throw null; } }
        protected virtual void ProcessRequest(System.Web.HttpContext context) { }
        void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext context) { }
    }
}
namespace System.Web.Query.Dynamic
{
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class DynamicClass
    {
        protected DynamicClass() { }
        public override string ToString() { throw null; }
    }
    public partial class ParseException : System.Exception
    {
        public ParseException(string message, int position) { }
        public int Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string ToString() { throw null; }
    }
}
namespace System.Web.Script.Serialization
{
    public abstract partial class JavaScriptConverter
    {
        protected JavaScriptConverter() { }
        public abstract System.Collections.Generic.IEnumerable<System.Type> SupportedTypes { get; }
        public abstract object Deserialize(System.Collections.Generic.IDictionary<string, object> dictionary, System.Type type, System.Web.Script.Serialization.JavaScriptSerializer serializer);
        public abstract System.Collections.Generic.IDictionary<string, object> Serialize(object obj, System.Web.Script.Serialization.JavaScriptSerializer serializer);
    }
    public partial class JavaScriptSerializer
    {
        public JavaScriptSerializer() { }
        public JavaScriptSerializer(System.Web.Script.Serialization.JavaScriptTypeResolver resolver) { }
        public int MaxJsonLength { get { throw null; } set { } }
        public int RecursionLimit { get { throw null; } set { } }
        public T ConvertToType<T>(object obj) { throw null; }
        public object Deserialize(string input, System.Type targetType) { throw null; }
        public object DeserializeObject(string input) { throw null; }
        public T Deserialize<T>(string input) { throw null; }
        public void RegisterConverters(System.Collections.Generic.IEnumerable<System.Web.Script.Serialization.JavaScriptConverter> converters) { }
        public string Serialize(object obj) { throw null; }
        public void Serialize(object obj, System.Text.StringBuilder output) { }
    }
    public abstract partial class JavaScriptTypeResolver
    {
        protected JavaScriptTypeResolver() { }
        public abstract System.Type ResolveType(string id);
        public abstract string ResolveTypeId(System.Type type);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384))]
    public sealed partial class ScriptIgnoreAttribute : System.Attribute
    {
        public ScriptIgnoreAttribute() { }
    }
    public partial class SimpleTypeResolver : System.Web.Script.Serialization.JavaScriptTypeResolver
    {
        public SimpleTypeResolver() { }
        public override System.Type ResolveType(string id) { throw null; }
        public override string ResolveTypeId(System.Type type) { throw null; }
    }
}
namespace System.Web.Script.Services
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(1092), AllowMultiple=true)]
    public sealed partial class GenerateScriptTypeAttribute : System.Attribute
    {
        public GenerateScriptTypeAttribute(System.Type type) { }
        public string ScriptTypeId { get { throw null; } set { } }
        public System.Type Type { get { throw null; } }
    }
    public static partial class ProxyGenerator
    {
        public static string GetClientProxyScript(System.Type type, string path, bool debug) { throw null; }
    }
    public enum ResponseFormat
    {
        Json = 0,
        Xml = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class ScriptMethodAttribute : System.Attribute
    {
        public ScriptMethodAttribute() { }
        public System.Web.Script.Services.ResponseFormat ResponseFormat { get { throw null; } set { } }
        public bool UseHttpGet { get { throw null; } set { } }
        public bool XmlSerializeString { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028))]
    public sealed partial class ScriptServiceAttribute : System.Attribute
    {
        public ScriptServiceAttribute() { }
    }
}
namespace System.Web.UI
{
    public partial class AsyncPostBackErrorEventArgs : System.EventArgs
    {
        public AsyncPostBackErrorEventArgs(System.Exception exception) { }
        public System.Exception Exception { get { throw null; } }
    }
    public partial class AsyncPostBackTrigger : System.Web.UI.UpdatePanelControlTrigger
    {
        public AsyncPostBackTrigger() { }
        public new string ControlID { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string EventName { get { throw null; } set { } }
        protected internal override bool HasTriggered() { throw null; }
        protected internal override void Initialize() { }
        public void OnEvent(object sender, System.EventArgs e) { }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Path")]
    public partial class AuthenticationServiceManager
    {
        public AuthenticationServiceManager() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public string Path { get { throw null; } set { } }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Path")]
    public partial class CompositeScriptReference : System.Web.UI.ScriptReferenceBase
    {
        public const string COMPOSITE_SCRIPT_REFERENCE_PREFIX = "CSR:";
        public CompositeScriptReference() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("System.Web.UI.Design.CollectionEditorBase, System.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ScriptReferenceCollection Scripts { get { throw null; } }
        protected internal override string GetUrl(System.Web.UI.ScriptManager scriptManager, bool zip) { throw null; }
        protected internal override bool IsFromSystemWebExtensions() { throw null; }
    }
    public partial class CompositeScriptReferenceEventArgs : System.EventArgs
    {
        public CompositeScriptReferenceEventArgs(System.Web.UI.CompositeScriptReference compositeScript) { }
        public System.Web.UI.CompositeScriptReference CompositeScript { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.ComponentModel.DefaultPropertyAttribute("TargetControlID")]
    [System.Web.UI.NonVisualControlAttribute]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    public abstract partial class ExtenderControl : System.Web.UI.Control, System.Web.UI.IExtenderControl
    {
        protected ExtenderControl() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.IDReferencePropertyAttribute]
        public string TargetControlID { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override bool Visible { get { throw null; } set { } }
        protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors(System.Web.UI.Control targetControl);
        protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
        protected internal override void OnPreRender(System.EventArgs e) { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IExtenderControl.GetScriptDescriptors(System.Web.UI.Control targetControl) { throw null; }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IExtenderControl.GetScriptReferences() { throw null; }
    }
    public partial interface IExtenderControl
    {
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors(System.Web.UI.Control targetControl);
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
    }
    public partial interface IScriptControl
    {
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors();
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
    }
    public partial class PostBackTrigger : System.Web.UI.UpdatePanelControlTrigger
    {
        public PostBackTrigger() { }
        public new string ControlID { get { throw null; } set { } }
        protected internal override bool HasTriggered() { throw null; }
        protected internal override void Initialize() { }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Path")]
    public partial class ProfileServiceManager
    {
        public ProfileServiceManager() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
        public string[] LoadProperties { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public string Path { get { throw null; } set { } }
    }
    public sealed partial class RegisteredArrayDeclaration
    {
        internal RegisteredArrayDeclaration() { }
        public System.Web.UI.Control Control { get { throw null; } }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public sealed partial class RegisteredDisposeScript
    {
        internal RegisteredDisposeScript() { }
        public System.Web.UI.Control Control { get { throw null; } }
        public string Script { get { throw null; } }
    }
    public sealed partial class RegisteredExpandoAttribute
    {
        internal RegisteredExpandoAttribute() { }
        public System.Web.UI.Control Control { get { throw null; } }
        public string ControlId { get { throw null; } }
        public bool Encode { get { throw null; } }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public sealed partial class RegisteredHiddenField
    {
        internal RegisteredHiddenField() { }
        public System.Web.UI.Control Control { get { throw null; } }
        public string InitialValue { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public sealed partial class RegisteredScript
    {
        internal RegisteredScript() { }
        public bool AddScriptTags { get { throw null; } }
        public System.Web.UI.Control Control { get { throw null; } }
        public string Key { get { throw null; } }
        public string Script { get { throw null; } }
        public System.Web.UI.RegisteredScriptType ScriptType { get { throw null; } }
        public System.Type Type { get { throw null; } }
        public string Url { get { throw null; } }
    }
    public enum RegisteredScriptType
    {
        ClientScriptBlock = 1,
        ClientScriptInclude = 0,
        ClientStartupScript = 2,
        OnSubmitStatement = 3,
    }
    public partial class ScriptBehaviorDescriptor : System.Web.UI.ScriptComponentDescriptor
    {
        public ScriptBehaviorDescriptor(string type, string elementID) : base (default(string)) { }
        public override string ClientID { get { throw null; } }
        public string ElementID { get { throw null; } }
        public string Name { get { throw null; } set { } }
        protected internal override string GetScript() { throw null; }
    }
    public partial class ScriptComponentDescriptor : System.Web.UI.ScriptDescriptor
    {
        public ScriptComponentDescriptor(string type) { }
        public virtual string ClientID { get { throw null; } }
        public virtual string ID { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public void AddComponentProperty(string name, string componentID) { }
        public void AddElementProperty(string name, string elementID) { }
        public void AddEvent(string name, string handler) { }
        public void AddProperty(string name, object value) { }
        public void AddScriptProperty(string name, string script) { }
        protected internal override string GetScript() { throw null; }
    }
    public abstract partial class ScriptControl : System.Web.UI.WebControls.WebControl, System.Web.UI.IScriptControl
    {
        protected ScriptControl() { }
        protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors();
        protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
        protected internal override void OnPreRender(System.EventArgs e) { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors() { throw null; }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences() { throw null; }
    }
    public partial class ScriptControlDescriptor : System.Web.UI.ScriptComponentDescriptor
    {
        public ScriptControlDescriptor(string type, string elementID) : base (default(string)) { }
        public override string ClientID { get { throw null; } }
        public string ElementID { get { throw null; } }
        public override string ID { get { throw null; } set { } }
    }
    public abstract partial class ScriptDescriptor
    {
        protected ScriptDescriptor() { }
        protected internal abstract string GetScript();
    }
    [System.ComponentModel.DefaultPropertyAttribute("Scripts")]
    [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.ScriptManagerDesigner, System.Web.Extensions.Design, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.NonVisualControlAttribute]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class ScriptManager : System.Web.UI.Control, System.Web.UI.IPostBackDataHandler
    {
        public ScriptManager() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowCustomErrorsRedirect { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string AsyncPostBackErrorMessage { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string AsyncPostBackSourceElementID { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(90)]
        public int AsyncPostBackTimeout { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.AuthenticationServiceManager AuthenticationService { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.CompositeScriptReference CompositeScript { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnablePageMethods { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool EnablePartialRendering { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableScriptGlobalization { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableScriptLocalization { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsDebuggingEnabled { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInAsyncPostBack { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool LoadScriptsBeforeUI { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ProfileServiceManager ProfileService { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        public System.Web.UI.ScriptMode ScriptMode { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ScriptPath { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ScriptReferenceCollection Scripts { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ServiceReferenceCollection Services { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool SupportsPartialRendering { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override bool Visible { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.AsyncPostBackErrorEventArgs> AsyncPostBackError { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.CompositeScriptReferenceEventArgs> ResolveCompositeScriptReference { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.ScriptReferenceEventArgs> ResolveScriptReference { add { } remove { } }
        public static System.Web.UI.ScriptManager GetCurrent(System.Web.UI.Page page) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredArrayDeclaration> GetRegisteredArrayDeclarations() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript> GetRegisteredClientScriptBlocks() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredDisposeScript> GetRegisteredDisposeScripts() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredExpandoAttribute> GetRegisteredExpandoAttributes() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredHiddenField> GetRegisteredHiddenFields() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript> GetRegisteredOnSubmitStatements() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript> GetRegisteredStartupScripts() { throw null; }
        protected virtual bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection) { throw null; }
        protected internal virtual void OnAsyncPostBackError(System.Web.UI.AsyncPostBackErrorEventArgs e) { }
        protected internal override void OnInit(System.EventArgs e) { }
        protected internal override void OnPreRender(System.EventArgs e) { }
        protected virtual void OnResolveCompositeScriptReference(System.Web.UI.CompositeScriptReferenceEventArgs e) { }
        protected virtual void OnResolveScriptReference(System.Web.UI.ScriptReferenceEventArgs e) { }
        protected virtual void RaisePostDataChangedEvent() { }
        public static void RegisterArrayDeclaration(System.Web.UI.Control control, string arrayName, string arrayValue) { }
        public static void RegisterArrayDeclaration(System.Web.UI.Page page, string arrayName, string arrayValue) { }
        public void RegisterAsyncPostBackControl(System.Web.UI.Control control) { }
        public static void RegisterClientScriptBlock(System.Web.UI.Control control, System.Type type, string key, string script, bool addScriptTags) { }
        public static void RegisterClientScriptBlock(System.Web.UI.Page page, System.Type type, string key, string script, bool addScriptTags) { }
        public static void RegisterClientScriptInclude(System.Web.UI.Control control, System.Type type, string key, string url) { }
        public static void RegisterClientScriptInclude(System.Web.UI.Page page, System.Type type, string key, string url) { }
        public static void RegisterClientScriptResource(System.Web.UI.Control control, System.Type type, string resourceName) { }
        public static void RegisterClientScriptResource(System.Web.UI.Page page, System.Type type, string resourceName) { }
        public void RegisterDataItem(System.Web.UI.Control control, string dataItem) { }
        public void RegisterDataItem(System.Web.UI.Control control, string dataItem, bool isJsonSerialized) { }
        public void RegisterDispose(System.Web.UI.Control control, string disposeScript) { }
        public static void RegisterExpandoAttribute(System.Web.UI.Control control, string controlId, string attributeName, string attributeValue, bool encode) { }
        public void RegisterExtenderControl<TExtenderControl>(TExtenderControl extenderControl, System.Web.UI.Control targetControl) where TExtenderControl : System.Web.UI.Control, System.Web.UI.IExtenderControl { }
        public static void RegisterHiddenField(System.Web.UI.Control control, string hiddenFieldName, string hiddenFieldInitialValue) { }
        public static void RegisterHiddenField(System.Web.UI.Page page, string hiddenFieldName, string hiddenFieldInitialValue) { }
        public static void RegisterOnSubmitStatement(System.Web.UI.Control control, System.Type type, string key, string script) { }
        public static void RegisterOnSubmitStatement(System.Web.UI.Page page, System.Type type, string key, string script) { }
        public void RegisterPostBackControl(System.Web.UI.Control control) { }
        public void RegisterScriptControl<TScriptControl>(TScriptControl scriptControl) where TScriptControl : System.Web.UI.Control, System.Web.UI.IScriptControl { }
        public void RegisterScriptDescriptors(System.Web.UI.IExtenderControl extenderControl) { }
        public void RegisterScriptDescriptors(System.Web.UI.IScriptControl scriptControl) { }
        public static void RegisterStartupScript(System.Web.UI.Control control, System.Type type, string key, string script, bool addScriptTags) { }
        public static void RegisterStartupScript(System.Web.UI.Page page, System.Type type, string key, string script, bool addScriptTags) { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        public void SetFocus(string clientID) { }
        public void SetFocus(System.Web.UI.Control control) { }
        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection) { throw null; }
        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent() { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Scripts")]
    [System.Web.UI.NonVisualControlAttribute]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    public partial class ScriptManagerProxy : System.Web.UI.Control
    {
        public ScriptManagerProxy() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.AuthenticationServiceManager AuthenticationService { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.CompositeScriptReference CompositeScript { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ProfileServiceManager ProfileService { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ScriptReferenceCollection Scripts { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ServiceReferenceCollection Services { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override bool Visible { get { throw null; } set { } }
        protected internal override void OnInit(System.EventArgs e) { }
    }
    public enum ScriptMode
    {
        Auto = 0,
        Debug = 2,
        Inherit = 1,
        Release = 3,
    }
    [System.ComponentModel.DefaultPropertyAttribute("Path")]
    public partial class ScriptReference : System.Web.UI.ScriptReferenceBase
    {
        public ScriptReference() { }
        public ScriptReference(string path) { }
        public ScriptReference(string name, string assembly) { }
        public string Assembly { get { throw null; } set { } }
        public bool IgnoreScriptPath { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        [System.MonoTODOAttribute("Compression not supported yet.")]
        protected internal override string GetUrl(System.Web.UI.ScriptManager scriptManager, bool zip) { throw null; }
        protected internal override bool IsFromSystemWebExtensions() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class ScriptReferenceBase
    {
        protected ScriptReferenceBase() { }
        public bool NotifyScriptLoaded { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Path { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
        public string[] ResourceUICultures { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.ScriptMode ScriptMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected internal abstract string GetUrl(System.Web.UI.ScriptManager scriptManager, bool zip);
        protected internal abstract bool IsFromSystemWebExtensions();
        protected static string ReplaceExtension(string pathOrName) { throw null; }
    }
    public partial class ScriptReferenceCollection : System.Collections.ObjectModel.Collection<System.Web.UI.ScriptReference>
    {
        public ScriptReferenceCollection() { }
    }
    public partial class ScriptReferenceEventArgs : System.EventArgs
    {
        public ScriptReferenceEventArgs(System.Web.UI.ScriptReference script) { }
        public System.Web.UI.ScriptReference Script { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
    public sealed partial class ScriptResourceAttribute : System.Attribute
    {
        public ScriptResourceAttribute(string scriptName, string scriptResourceName, string typeName) { }
        public string ScriptName { get { throw null; } }
        public string ScriptResourceName { get { throw null; } }
        public string TypeName { get { throw null; } }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Path")]
    public partial class ServiceReference
    {
        public ServiceReference() { }
        public ServiceReference(string path) { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool InlineScript { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Path { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class ServiceReferenceCollection : System.Collections.ObjectModel.Collection<System.Web.UI.ServiceReference>
    {
        public ServiceReferenceCollection() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true)]
    public sealed partial class TargetControlTypeAttribute : System.Attribute
    {
        public TargetControlTypeAttribute(System.Type targetControlType) { }
        public System.Type TargetControlType { get { throw null; } }
    }
    [System.ComponentModel.DefaultEventAttribute("Tick")]
    [System.ComponentModel.DefaultPropertyAttribute("Interval")]
    [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.TimerDesigner, System.Web.Extensions.Design, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.NonVisualControlAttribute]
    [System.Web.UI.SupportsEventValidationAttribute]
    public partial class Timer : System.Web.UI.Control, System.Web.UI.IPostBackEventHandler, System.Web.UI.IScriptControl
    {
        public Timer() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Enabled { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(60000)]
        public int Interval { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override bool Visible { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.EventArgs> Tick { add { } remove { } }
        [System.Diagnostics.DebuggerHiddenAttribute]
        protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors() { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences() { throw null; }
        protected internal override void OnPreRender(System.EventArgs e) { }
        protected virtual void OnTick(System.EventArgs e) { }
        protected virtual void RaisePostBackEvent(string eventArgument) { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors() { throw null; }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences() { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Triggers")]
    [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.UpdatePanelDesigner, System.Web.Extensions.Design, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class UpdatePanel : System.Web.UI.Control
    {
        public UpdatePanel() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ChildrenAsTriggers { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateInstanceAttribute((System.Web.UI.TemplateInstance)(1))]
        public System.Web.UI.ITemplate ContentTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Web.UI.Control ContentTemplateContainer { get { throw null; } }
        public sealed override System.Web.UI.ControlCollection Controls { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInPartialRendering { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Layout")]
        public System.Web.UI.UpdatePanelRenderMode RenderMode { get { throw null; } set { } }
        protected internal virtual bool RequiresUpdate { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.UpdatePanelTriggerCollection Triggers { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute((System.Web.UI.UpdatePanelUpdateMode)(0))]
        public System.Web.UI.UpdatePanelUpdateMode UpdateMode { get { throw null; } set { } }
        protected virtual System.Web.UI.Control CreateContentTemplateContainer() { throw null; }
        protected sealed override System.Web.UI.ControlCollection CreateControlCollection() { throw null; }
        protected internal virtual void Initialize() { }
        protected internal override void OnInit(System.EventArgs e) { }
        protected internal override void OnLoad(System.EventArgs e) { }
        protected internal override void OnPreRender(System.EventArgs e) { }
        protected internal override void OnUnload(System.EventArgs e) { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        protected internal override void RenderChildren(System.Web.UI.HtmlTextWriter writer) { }
        public void Update() { }
    }
    public abstract partial class UpdatePanelControlTrigger : System.Web.UI.UpdatePanelTrigger
    {
        protected UpdatePanelControlTrigger() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.IDReferencePropertyAttribute]
        public string ControlID { get { throw null; } set { } }
        protected System.Web.UI.Control FindTargetControl(bool searchNamingContainers) { throw null; }
    }
    public enum UpdatePanelRenderMode
    {
        Block = 0,
        Inline = 1,
    }
    public abstract partial class UpdatePanelTrigger
    {
        protected UpdatePanelTrigger() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Web.UI.UpdatePanel Owner { get { throw null; } }
        protected internal abstract bool HasTriggered();
        protected internal virtual void Initialize() { }
    }
    public partial class UpdatePanelTriggerCollection : System.Collections.ObjectModel.Collection<System.Web.UI.UpdatePanelTrigger>
    {
        public UpdatePanelTriggerCollection(System.Web.UI.UpdatePanel owner) { }
        public System.Web.UI.UpdatePanel Owner { get { throw null; } }
        protected override void ClearItems() { }
        protected override void InsertItem(int index, System.Web.UI.UpdatePanelTrigger item) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.Web.UI.UpdatePanelTrigger item) { }
    }
    public enum UpdatePanelUpdateMode
    {
        Always = 0,
        Conditional = 1,
    }
    [System.ComponentModel.DefaultPropertyAttribute("AssociatedUpdatePanelID")]
    [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.UpdateProgressDesigner, System.Web.Extensions.Design, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    public partial class UpdateProgress : System.Web.UI.Control, System.Web.UI.IScriptControl
    {
        public UpdateProgress() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.UI.UpdatePanel))]
        public string AssociatedUpdatePanelID { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(500)]
        public int DisplayAfter { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool DynamicLayout { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.ITemplate ProgressTemplate { get { throw null; } set { } }
        [System.Diagnostics.DebuggerHiddenAttribute]
        protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors() { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences() { throw null; }
        protected internal override void OnPreRender(System.EventArgs e) { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors() { throw null; }
        System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences() { throw null; }
    }
}
namespace System.Web.UI.WebControls
{
    [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.WebControls.DataPagerDesigner, System.Web.Extensions.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.ComponentModel.ToolboxItemFilterAttribute("System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", (System.ComponentModel.ToolboxItemFilterType)(3))]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    [System.Web.UI.SupportsEventValidationAttribute]
    [System.Web.UI.ThemeableAttribute(true)]
    public partial class DataPager : System.Web.UI.Control, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, System.Web.UI.WebControls.ICompositeControlDesignerAccessor
    {
        public DataPager() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Web.UI.AttributeCollection Attributes { get { throw null; } }
        public override System.Web.UI.ControlCollection Controls { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Default")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("System.Web.UI.Design.WebControls.DataPagerFieldTypeEditor, System.Web.Extensions.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public virtual System.Web.UI.WebControls.DataPagerFieldCollection Fields { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int MaximumRows { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.UI.WebControls.IPageableItemContainer))]
        [System.Web.UI.ThemeableAttribute(false)]
        public virtual string PagedControlID { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(10)]
        public int PageSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string QueryStringField { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int StartRowIndex { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        protected virtual System.Web.UI.HtmlTextWriterTag TagKey { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int TotalRowCount { get { throw null; } }
        protected virtual void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer) { }
        protected virtual void ConnectToEvents(System.Web.UI.WebControls.IPageableItemContainer container) { }
        protected virtual void CreatePagerFields() { }
        public override void DataBind() { }
        protected virtual System.Web.UI.WebControls.IPageableItemContainer FindPageableItemContainer() { throw null; }
        protected internal override void LoadControlState(object savedState) { }
        protected override void LoadViewState(object savedState) { }
        protected override bool OnBubbleEvent(object source, System.EventArgs e) { throw null; }
        protected internal override void OnInit(System.EventArgs e) { }
        protected internal override void OnLoad(System.EventArgs e) { }
        protected virtual void OnTotalRowCountAvailable(object sender, System.Web.UI.WebControls.PageEventArgs e) { }
        protected virtual void RecreateChildControls() { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) { }
        protected virtual void RenderContents(System.Web.UI.HtmlTextWriter writer) { }
        protected internal override object SaveControlState() { throw null; }
        protected override object SaveViewState() { throw null; }
        public virtual void SetPageProperties(int startRowIndex, int maximumRows, bool databind) { }
        string System.Web.UI.IAttributeAccessor.GetAttribute(string key) { throw null; }
        void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value) { }
        void System.Web.UI.WebControls.ICompositeControlDesignerAccessor.RecreateChildControls() { }
        protected override void TrackViewState() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DataPagerCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs
    {
        public DataPagerCommandEventArgs(System.Web.UI.WebControls.DataPagerField pagerField, int totalRowCount, System.Web.UI.WebControls.CommandEventArgs originalArgs, System.Web.UI.WebControls.DataPagerFieldItem item) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
        public System.Web.UI.WebControls.DataPagerFieldItem Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int NewMaximumRows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int NewStartRowIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.WebControls.DataPagerField PagerField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int TotalRowCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class DataPagerField : System.Web.UI.IStateManager
    {
        protected DataPagerField() { }
        protected System.Web.UI.WebControls.DataPager DataPager { get { throw null; } }
        protected bool IsTrackingViewState { get { throw null; } }
        protected bool QueryStringHandled { get { throw null; } set { } }
        protected string QueryStringValue { get { throw null; } }
        bool System.Web.UI.IStateManager.IsTrackingViewState { get { throw null; } }
        protected System.Web.UI.StateBag ViewState { get { throw null; } }
        public bool Visible { get { throw null; } set { } }
        protected internal System.Web.UI.WebControls.DataPagerField CloneField() { throw null; }
        protected virtual void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
        public abstract void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex);
        protected abstract System.Web.UI.WebControls.DataPagerField CreateField();
        protected string GetQueryStringNavigateUrl(int pageNumber) { throw null; }
        public abstract void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e);
        protected virtual void LoadViewState(object savedState) { }
        protected virtual void OnFieldChanged() { }
        protected virtual object SaveViewState() { throw null; }
        void System.Web.UI.IStateManager.LoadViewState(object state) { }
        object System.Web.UI.IStateManager.SaveViewState() { throw null; }
        void System.Web.UI.IStateManager.TrackViewState() { }
        protected virtual void TrackViewState() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DataPagerFieldCollection : System.Web.UI.StateManagedCollection
    {
        public DataPagerFieldCollection(System.Web.UI.WebControls.DataPager dataPager) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Web.UI.WebControls.DataPagerField this[int index] { get { throw null; } }
        public event System.EventHandler FieldsChanged { add { } remove { } }
        public void Add(System.Web.UI.WebControls.DataPagerField field) { }
        public System.Web.UI.WebControls.DataPagerFieldCollection CloneFields(System.Web.UI.WebControls.DataPager pager) { throw null; }
        public bool Contains(System.Web.UI.WebControls.DataPagerField field) { throw null; }
        public void CopyTo(System.Web.UI.WebControls.DataPagerField[] array, int index) { }
        protected override object CreateKnownType(int index) { throw null; }
        protected override System.Type[] GetKnownTypes() { throw null; }
        public int IndexOf(System.Web.UI.WebControls.DataPagerField field) { throw null; }
        public void Insert(int index, System.Web.UI.WebControls.DataPagerField field) { }
        protected override void OnClearComplete() { }
        protected override void OnInsertComplete(int index, object value) { }
        protected override void OnRemoveComplete(int index, object value) { }
        protected override void OnValidate(object o) { }
        public void Remove(System.Web.UI.WebControls.DataPagerField field) { }
        public void RemoveAt(int index) { }
        protected override void SetDirtyObject(object o) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DataPagerFieldCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs
    {
        public DataPagerFieldCommandEventArgs(System.Web.UI.WebControls.DataPagerFieldItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
        public object CommandSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.UI.WebControls.DataPagerFieldItem Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DataPagerFieldItem : System.Web.UI.Control, System.Web.UI.INamingContainer
    {
        public DataPagerFieldItem(System.Web.UI.WebControls.DataPagerField field, System.Web.UI.WebControls.DataPager pager) { }
        public System.Web.UI.WebControls.DataPager Pager { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.UI.WebControls.DataPagerField PagerField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override bool OnBubbleEvent(object source, System.EventArgs e) { throw null; }
    }
    public enum InsertItemPosition
    {
        FirstItem = 1,
        LastItem = 2,
        None = 0,
    }
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IPageableItemContainer
    {
        int MaximumRows { get; }
        int StartRowIndex { get; }
        event System.EventHandler<System.Web.UI.WebControls.PageEventArgs> TotalRowCountAvailable;
        void SetPageProperties(int startRowIndex, int maximumRows, bool databind);
    }
    [System.ComponentModel.DefaultEventAttribute("Selecting")]
    [System.ComponentModel.DefaultPropertyAttribute("ContextTypeName")]
    [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.WebControls.LinqDataSourceDesigner, System.Web.Extensions.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.ComponentModel.ToolboxItemFilterAttribute("System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", (System.ComponentModel.ToolboxItemFilterType)(3))]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    public partial class LinqDataSource : System.Web.UI.DataSourceControl, System.Web.DynamicData.IDynamicDataSource, System.Web.UI.IDataSource
    {
        public LinqDataSource() { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AutoGenerateOrderByClause { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AutoGenerateWhereClause { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AutoPage { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AutoSort { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ContextTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection DeleteParameters { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableDelete { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableInsert { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableObjectTracking { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableUpdate { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string GroupBy { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection GroupByParameters { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection InsertParameters { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string OrderBy { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection OrderByParameters { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string OrderGroupsBy { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection OrderGroupsByParameters { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Select { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection SelectParameters { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool StoreOriginalValuesInViewState { get { throw null; } set { } }
        [System.MonoTODOAttribute("looks like we need System.Web.Query.Dynamic stuff or alternative")]
        System.Type System.Web.DynamicData.IDynamicDataSource.ContextType { get { throw null; } set { } }
        string System.Web.DynamicData.IDynamicDataSource.EntitySetName { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TableName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection UpdateParameters { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Where { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public System.Web.UI.WebControls.ParameterCollection WhereParameters { get { throw null; } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> ContextCreated { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceContextEventArgs> ContextCreating { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDisposeEventArgs> ContextDisposing { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Deleted { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDeleteEventArgs> Deleting { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Inserted { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceInsertEventArgs> Inserting { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Selected { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceSelectEventArgs> Selecting { add { } remove { } }
        event System.EventHandler<System.Web.DynamicData.DynamicValidatorEventArgs> System.Web.DynamicData.IDynamicDataSource.Exception { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Updated { add { } remove { } }
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceUpdateEventArgs> Updating { add { } remove { } }
        protected virtual System.Web.UI.WebControls.LinqDataSourceView CreateView() { throw null; }
        public int Delete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { throw null; }
        protected override System.Web.UI.DataSourceView GetView(string viewName) { throw null; }
        protected override System.Collections.ICollection GetViewNames() { throw null; }
        public int Insert(System.Collections.IDictionary values) { throw null; }
        protected override void LoadViewState(object savedState) { }
        protected internal override void OnInit(System.EventArgs e) { }
        protected internal override void OnUnload(System.EventArgs e) { }
        protected override object SaveViewState() { throw null; }
        protected override void TrackViewState() { }
        public int Update(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceContextEventArgs : System.EventArgs
    {
        public LinqDataSourceContextEventArgs() { }
        public LinqDataSourceContextEventArgs(System.Web.UI.DataSourceOperation operation) { }
        public object ObjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.DataSourceOperation Operation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceDeleteEventArgs : System.ComponentModel.CancelEventArgs
    {
        public LinqDataSourceDeleteEventArgs(object originalObject) { }
        public LinqDataSourceDeleteEventArgs(System.Web.UI.WebControls.LinqDataSourceValidationException exception) { }
        public System.Web.UI.WebControls.LinqDataSourceValidationException Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object OriginalObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceDisposeEventArgs : System.ComponentModel.CancelEventArgs
    {
        public LinqDataSourceDisposeEventArgs(object instance) { }
        public object ObjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceInsertEventArgs : System.ComponentModel.CancelEventArgs
    {
        public LinqDataSourceInsertEventArgs(object newObject) { }
        public LinqDataSourceInsertEventArgs(System.Web.UI.WebControls.LinqDataSourceValidationException exception) { }
        public System.Web.UI.WebControls.LinqDataSourceValidationException Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object NewObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceSelectEventArgs : System.ComponentModel.CancelEventArgs
    {
        public LinqDataSourceSelectEventArgs(System.Web.UI.DataSourceSelectArguments arguments, System.Collections.Generic.IDictionary<string, object> whereParameters, System.Collections.Specialized.IOrderedDictionary orderByParameters, System.Collections.Generic.IDictionary<string, object> groupByParameters, System.Collections.Generic.IDictionary<string, object> orderGroupsByParameters, System.Collections.Generic.IDictionary<string, object> selectParameters) { }
        public System.Web.UI.DataSourceSelectArguments Arguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> GroupByParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary OrderByParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> OrderGroupsByParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IDictionary<string, object> SelectParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> WhereParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceStatusEventArgs : System.EventArgs
    {
        public LinqDataSourceStatusEventArgs(System.Exception exception) { }
        public LinqDataSourceStatusEventArgs(object result) { }
        public LinqDataSourceStatusEventArgs(object result, int totalRowCount) { }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int TotalRowCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceUpdateEventArgs : System.ComponentModel.CancelEventArgs
    {
        public LinqDataSourceUpdateEventArgs(object originalObject, object newObject) { }
        public LinqDataSourceUpdateEventArgs(System.Web.UI.WebControls.LinqDataSourceValidationException exception) { }
        public System.Web.UI.WebControls.LinqDataSourceValidationException Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object NewObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object OriginalObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.SerializableAttribute]
    public partial class LinqDataSourceValidationException : System.Exception, System.Runtime.Serialization.ISerializable
    {
        public LinqDataSourceValidationException() { }
        [System.MonoTODOAttribute]
        protected LinqDataSourceValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public LinqDataSourceValidationException(string message) { }
        public LinqDataSourceValidationException(string message, System.Collections.Generic.IDictionary<string, System.Exception> innerExceptions) { }
        public LinqDataSourceValidationException(string message, System.Exception innerException) { }
        public System.Collections.Generic.IDictionary<string, System.Exception> InnerExceptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class LinqDataSourceView : System.Web.UI.DataSourceView, System.Web.UI.IStateManager
    {
        public LinqDataSourceView(System.Web.UI.WebControls.LinqDataSource owner, string name, System.Web.HttpContext context) : base (default(System.Web.UI.IDataSource), default(string)) { }
        [System.MonoTODOAttribute]
        public bool AutoGenerateOrderByClause { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool AutoGenerateWhereClause { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool AutoPage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool AutoSort { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool CanDelete { get { throw null; } }
        public override bool CanInsert { get { throw null; } }
        public override bool CanPage { get { throw null; } }
        public override bool CanRetrieveTotalRowCount { get { throw null; } }
        public override bool CanSort { get { throw null; } }
        public override bool CanUpdate { get { throw null; } }
        protected virtual System.Type ContextType { get { throw null; } }
        public virtual string ContextTypeName { get { throw null; } set { } }
        public System.Web.UI.WebControls.ParameterCollection DeleteParameters { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool EnableDelete { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool EnableInsert { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool EnableObjectTracking { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool EnableUpdate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public string GroupBy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.WebControls.ParameterCollection GroupByParameters { get { throw null; } }
        public System.Web.UI.WebControls.ParameterCollection InsertParameters { get { throw null; } }
        protected bool IsTrackingViewState { get { throw null; } }
        [System.MonoTODOAttribute]
        public string OrderBy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.WebControls.ParameterCollection OrderByParameters { get { throw null; } }
        [System.MonoTODOAttribute]
        public string OrderGroupsBy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.WebControls.ParameterCollection OrderGroupsByParameters { get { throw null; } }
        [System.MonoTODOAttribute]
        public string SelectNew { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.WebControls.ParameterCollection SelectNewParameters { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool StoreOriginalValuesInViewState { get { throw null; } set { } }
        bool System.Web.UI.IStateManager.IsTrackingViewState { get { throw null; } }
        [System.MonoTODOAttribute]
        public string TableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.WebControls.ParameterCollection UpdateParameters { get { throw null; } }
        [System.MonoTODOAttribute]
        public string Where { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.UI.WebControls.ParameterCollection WhereParameters { get { throw null; } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> ContextCreated { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceContextEventArgs> ContextCreating { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDisposeEventArgs> ContextDisposing { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Deleted { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDeleteEventArgs> Deleting { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Inserted { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceInsertEventArgs> Inserting { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Selected { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceSelectEventArgs> Selecting { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Updated { add { } remove { } }
        [System.MonoTODOAttribute]
        public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceUpdateEventArgs> Updating { add { } remove { } }
        protected virtual object CreateContext(System.Type contextType) { throw null; }
        public int Delete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { throw null; }
        protected virtual void DeleteDataObject(object dataContext, object table, object oldDataObject) { }
        [System.MonoTODOAttribute]
        protected override int ExecuteDelete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { throw null; }
        protected override int ExecuteInsert(System.Collections.IDictionary values) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.MonoTODOAttribute]
        protected internal override System.Collections.IEnumerable ExecuteSelect(System.Web.UI.DataSourceSelectArguments arguments) { throw null; }
        [System.MonoTODOAttribute]
        protected override int ExecuteUpdate(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { throw null; }
        [System.MonoTODOAttribute]
        protected virtual System.Type GetDataObjectType(System.Type tableType) { throw null; }
        protected virtual System.Reflection.MemberInfo GetTableMemberInfo(System.Type contextType) { throw null; }
        public int Insert(System.Collections.IDictionary values) { throw null; }
        protected virtual void InsertDataObject(object dataContext, object table, object newDataObject) { }
        protected virtual void LoadViewState(object savedState) { }
        protected virtual void OnContextCreated(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
        protected virtual void OnContextCreating(System.Web.UI.WebControls.LinqDataSourceContextEventArgs e) { }
        protected virtual void OnContextDisposing(System.Web.UI.WebControls.LinqDataSourceDisposeEventArgs e) { }
        protected virtual void OnDeleted(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
        protected virtual void OnDeleting(System.Web.UI.WebControls.LinqDataSourceDeleteEventArgs e) { }
        protected virtual void OnException(System.Web.DynamicData.DynamicValidatorEventArgs e) { }
        protected virtual void OnInserted(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
        protected virtual void OnInserting(System.Web.UI.WebControls.LinqDataSourceInsertEventArgs e) { }
        protected virtual void OnSelected(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
        protected virtual void OnSelecting(System.Web.UI.WebControls.LinqDataSourceSelectEventArgs e) { }
        protected virtual void OnUpdated(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
        protected virtual void OnUpdating(System.Web.UI.WebControls.LinqDataSourceUpdateEventArgs e) { }
        [System.MonoTODOAttribute]
        protected virtual void ResetDataObject(object table, object dataObject) { }
        protected virtual object SaveViewState() { throw null; }
        public System.Collections.IEnumerable Select(System.Web.UI.DataSourceSelectArguments arguments) { throw null; }
        void System.Web.UI.IStateManager.LoadViewState(object savedState) { }
        object System.Web.UI.IStateManager.SaveViewState() { throw null; }
        void System.Web.UI.IStateManager.TrackViewState() { }
        protected virtual void TrackViewState() { }
        public int Update(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { throw null; }
        protected virtual void UpdateDataObject(object dataContext, object table, object oldDataObject, object newDataObject) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateContextType(System.Type contextType, bool selecting) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateDeleteSupported(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateInsertSupported(System.Collections.IDictionary values) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateOrderByParameter(string name, string value) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateParameterName(string name) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateTableType(System.Type tableType, bool selecting) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateUpdateSupported(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { }
    }
    [System.ComponentModel.DefaultEventAttribute("SelectedIndexChanged")]
    [System.ComponentModel.DefaultPropertyAttribute("SelectedValue")]
    [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.WebControls.ListViewDesigner, System.Web.Extensions.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.ComponentModel.ToolboxItemFilterAttribute("System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", (System.ComponentModel.ToolboxItemFilterType)(3))]
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.UI.WebControls.ListView), "ListView.ico")]
    [System.Web.UI.ControlValuePropertyAttribute("SelectedValue")]
    [System.Web.UI.SupportsEventValidationAttribute]
    public partial class ListView : System.Web.UI.WebControls.DataBoundControl, System.Web.UI.INamingContainer, System.Web.UI.WebControls.IPageableItemContainer
    {
        public ListView() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override string AccessKey { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
        public virtual System.Web.UI.ITemplate AlternatingItemTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Drawing.Color BackColor { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Drawing.Color BorderColor { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Web.UI.WebControls.BorderStyle BorderStyle { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Web.UI.WebControls.Unit BorderWidth { get { throw null; } set { } }
        public override System.Web.UI.ControlCollection Controls { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public virtual bool ConvertEmptyStringToNull { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Web.UI.CssClassPropertyAttribute]
        public override string CssClass { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("System.Web.UI.Design.WebControls.DataFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
        public virtual string[] DataKeyNames { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual System.Web.UI.WebControls.DataKeyArray DataKeys { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Default")]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public virtual int EditIndex { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual System.Web.UI.WebControls.ListViewItem EditItem { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
        public virtual System.Web.UI.ITemplate EditItemTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListView))]
        public virtual System.Web.UI.ITemplate EmptyDataTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
        public virtual System.Web.UI.ITemplate EmptyItemTemplate { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.MonoTODOAttribute("Figure out where it is used and what's the effect of setting it to true.")]
        public virtual bool EnableModelValidation { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Web.UI.WebControls.FontInfo Font { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Drawing.Color ForeColor { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Default")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public virtual int GroupItemCount { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("groupPlaceholder")]
        public virtual string GroupPlaceholderID { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
        public virtual System.Web.UI.ITemplate GroupSeparatorTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
        public virtual System.Web.UI.ITemplate GroupTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Web.UI.WebControls.Unit Height { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual System.Web.UI.WebControls.ListViewItem InsertItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Default")]
        [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.InsertItemPosition)(0))]
        public virtual System.Web.UI.WebControls.InsertItemPosition InsertItemPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem), (System.ComponentModel.BindingDirection)(1))]
        public virtual System.Web.UI.ITemplate InsertItemTemplate { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("itemPlaceholder")]
        public virtual string ItemPlaceholderID { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem> Items { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
        public virtual System.Web.UI.ITemplate ItemSeparatorTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
        public virtual System.Web.UI.ITemplate ItemTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListView))]
        public virtual System.Web.UI.ITemplate LayoutTemplate { get { throw null; } set { } }
        protected virtual int MaximumRows { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual System.Web.UI.WebControls.DataKey SelectedDataKey { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Default")]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public virtual int SelectedIndex { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
        public virtual System.Web.UI.ITemplate SelectedItemTemplate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual System.Web.UI.WebControls.DataKey SelectedPersistedDataKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public object SelectedValue { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.SortDirection)(0))]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        public virtual System.Web.UI.WebControls.SortDirection SortDirection { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual string SortExpression { get { throw null; } }
        protected virtual int StartRowIndex { get { throw null; } }
        int System.Web.UI.WebControls.IPageableItemContainer.MaximumRows { get { throw null; } }
        int System.Web.UI.WebControls.IPageableItemContainer.StartRowIndex { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override short TabIndex { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override string ToolTip { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Web.UI.WebControls.Unit Width { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewCancelEventArgs> ItemCanceling { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewCommandEventArgs> ItemCommand { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewItemEventArgs> ItemCreated { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewItemEventArgs> ItemDataBound { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewDeletedEventArgs> ItemDeleted { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewDeleteEventArgs> ItemDeleting { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewEditEventArgs> ItemEditing { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewInsertedEventArgs> ItemInserted { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewInsertEventArgs> ItemInserting { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewUpdatedEventArgs> ItemUpdated { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewUpdateEventArgs> ItemUpdating { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        public event System.EventHandler LayoutCreated { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        public event System.EventHandler PagePropertiesChanged { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        public event System.EventHandler<System.Web.UI.WebControls.PagePropertiesChangingEventArgs> PagePropertiesChanging { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler SelectedIndexChanged { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewSelectEventArgs> SelectedIndexChanging { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler Sorted { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Action")]
        public event System.EventHandler<System.Web.UI.WebControls.ListViewSortEventArgs> Sorting { add { } remove { } }
        event System.EventHandler<System.Web.UI.WebControls.PageEventArgs> System.Web.UI.WebControls.IPageableItemContainer.TotalRowCountAvailable { add { } remove { } }
        protected virtual void AddControlToContainer(System.Web.UI.Control control, System.Web.UI.Control container, int addLocation) { }
        protected internal override void CreateChildControls() { }
        protected virtual int CreateChildControls(System.Collections.IEnumerable dataSource, bool dataBinding) { throw null; }
        protected override System.Web.UI.WebControls.Style CreateControlStyle() { throw null; }
        protected virtual System.Web.UI.WebControls.ListViewDataItem CreateDataItem(int dataItemIndex, int displayIndex) { throw null; }
        protected override System.Web.UI.DataSourceSelectArguments CreateDataSourceSelectArguments() { throw null; }
        protected virtual void CreateEmptyDataItem() { }
        protected virtual System.Web.UI.WebControls.ListViewItem CreateEmptyItem() { throw null; }
        protected virtual System.Web.UI.WebControls.ListViewItem CreateInsertItem() { throw null; }
        protected virtual System.Web.UI.WebControls.ListViewItem CreateItem(System.Web.UI.WebControls.ListViewItemType itemType) { throw null; }
        protected virtual System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem> CreateItemsInGroups(System.Web.UI.WebControls.ListViewPagedDataSource dataSource, bool dataBinding, System.Web.UI.WebControls.InsertItemPosition insertPosition, System.Collections.ArrayList keyArray) { throw null; }
        protected virtual System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem> CreateItemsWithoutGroups(System.Web.UI.WebControls.ListViewPagedDataSource dataSource, bool dataBinding, System.Web.UI.WebControls.InsertItemPosition insertPosition, System.Collections.ArrayList keyArray) { throw null; }
        protected virtual void CreateLayoutTemplate() { }
        public virtual void DeleteItem(int itemIndex) { }
        protected virtual void EnsureLayoutTemplate() { }
        public virtual void ExtractItemValues(System.Collections.Specialized.IOrderedDictionary itemValues, System.Web.UI.WebControls.ListViewItem item, bool includePrimaryKey) { }
        protected virtual System.Web.UI.Control FindPlaceholder(string containerID, System.Web.UI.Control container) { throw null; }
        public virtual void InsertNewItem(bool causesValidation) { }
        protected virtual void InstantiateEmptyDataTemplate(System.Web.UI.Control container) { }
        protected virtual void InstantiateEmptyItemTemplate(System.Web.UI.Control container) { }
        protected virtual void InstantiateGroupSeparatorTemplate(System.Web.UI.Control container) { }
        protected virtual void InstantiateGroupTemplate(System.Web.UI.Control container) { }
        protected virtual void InstantiateInsertItemTemplate(System.Web.UI.Control container) { }
        protected virtual void InstantiateItemSeparatorTemplate(System.Web.UI.Control container) { }
        protected virtual void InstantiateItemTemplate(System.Web.UI.Control container, int displayIndex) { }
        protected internal override void LoadControlState(object savedState) { }
        protected override void LoadViewState(object savedState) { }
        protected override bool OnBubbleEvent(object source, System.EventArgs e) { throw null; }
        protected internal override void OnInit(System.EventArgs e) { }
        protected virtual void OnItemCanceling(System.Web.UI.WebControls.ListViewCancelEventArgs e) { }
        protected virtual void OnItemCommand(System.Web.UI.WebControls.ListViewCommandEventArgs e) { }
        protected virtual void OnItemCreated(System.Web.UI.WebControls.ListViewItemEventArgs e) { }
        protected virtual void OnItemDataBound(System.Web.UI.WebControls.ListViewItemEventArgs e) { }
        protected virtual void OnItemDeleted(System.Web.UI.WebControls.ListViewDeletedEventArgs e) { }
        protected virtual void OnItemDeleting(System.Web.UI.WebControls.ListViewDeleteEventArgs e) { }
        protected virtual void OnItemEditing(System.Web.UI.WebControls.ListViewEditEventArgs e) { }
        protected virtual void OnItemInserted(System.Web.UI.WebControls.ListViewInsertedEventArgs e) { }
        protected virtual void OnItemInserting(System.Web.UI.WebControls.ListViewInsertEventArgs e) { }
        protected virtual void OnItemUpdated(System.Web.UI.WebControls.ListViewUpdatedEventArgs e) { }
        protected virtual void OnItemUpdating(System.Web.UI.WebControls.ListViewUpdateEventArgs e) { }
        protected virtual void OnLayoutCreated(System.EventArgs e) { }
        protected virtual void OnPagePropertiesChanged(System.EventArgs e) { }
        protected virtual void OnPagePropertiesChanging(System.Web.UI.WebControls.PagePropertiesChangingEventArgs e) { }
        protected virtual void OnSelectedIndexChanged(System.EventArgs e) { }
        protected virtual void OnSelectedIndexChanging(System.Web.UI.WebControls.ListViewSelectEventArgs e) { }
        protected virtual void OnSorted(System.EventArgs e) { }
        protected virtual void OnSorting(System.Web.UI.WebControls.ListViewSortEventArgs e) { }
        protected virtual void OnTotalRowCountAvailable(System.Web.UI.WebControls.PageEventArgs e) { }
        protected internal override void PerformDataBinding(System.Collections.IEnumerable data) { }
        protected override void PerformSelect() { }
        protected virtual void RemoveItems() { }
        protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
        protected internal override object SaveControlState() { throw null; }
        protected override object SaveViewState() { throw null; }
        protected virtual void SetPageProperties(int startRowIndex, int maximumRows, bool databind) { }
        public virtual void Sort(string sortExpression, System.Web.UI.WebControls.SortDirection sortDirection) { }
        void System.Web.UI.WebControls.IPageableItemContainer.SetPageProperties(int startRowIndex, int maximumRows, bool databind) { }
        public virtual void UpdateItem(int itemIndex, bool causesValidation) { }
    }
    public partial class ListViewCancelEventArgs : System.ComponentModel.CancelEventArgs
    {
        public ListViewCancelEventArgs(int itemIndex, System.Web.UI.WebControls.ListViewCancelMode cancelMode) { }
        public System.Web.UI.WebControls.ListViewCancelMode CancelMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int ItemIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum ListViewCancelMode
    {
        CancelingEdit = 0,
        CancelingInsert = 1,
    }
    public partial class ListViewCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs
    {
        public ListViewCommandEventArgs(System.Web.UI.WebControls.ListViewItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
        public object CommandSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.UI.WebControls.ListViewItem Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ListViewDataItem : System.Web.UI.WebControls.ListViewItem, System.Web.UI.IDataItemContainer, System.Web.UI.INamingContainer
    {
        public ListViewDataItem(int dataItemIndex, int displayIndex) : base (default(System.Web.UI.WebControls.ListViewItemType)) { }
        public virtual object DataItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int DataItemIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual int DisplayIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override bool OnBubbleEvent(object source, System.EventArgs e) { throw null; }
    }
    public partial class ListViewDeletedEventArgs : System.EventArgs
    {
        public ListViewDeletedEventArgs(int affectedRows, System.Exception exception) { }
        public int AffectedRows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Specialized.IOrderedDictionary Keys { get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary Values { get { throw null; } }
    }
    public partial class ListViewDeleteEventArgs : System.ComponentModel.CancelEventArgs
    {
        public ListViewDeleteEventArgs(int itemIndex) { }
        public int ItemIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary Keys { get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary Values { get { throw null; } }
    }
    public partial class ListViewEditEventArgs : System.ComponentModel.CancelEventArgs
    {
        public ListViewEditEventArgs(int newEditIndex) { }
        public int NewEditIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ListViewInsertedEventArgs : System.EventArgs
    {
        public ListViewInsertedEventArgs(int affectedRows, System.Exception exception) { }
        public int AffectedRows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool KeepInInsertMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Specialized.IOrderedDictionary Values { get { throw null; } }
    }
    public partial class ListViewInsertEventArgs : System.ComponentModel.CancelEventArgs
    {
        public ListViewInsertEventArgs(System.Web.UI.WebControls.ListViewItem item) { }
        public System.Web.UI.WebControls.ListViewItem Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary Values { get { throw null; } }
    }
    [System.ComponentModel.ToolboxItemAttribute(false)]
    public partial class ListViewItem : System.Web.UI.Control, System.Web.UI.INamingContainer
    {
        public ListViewItem(System.Web.UI.WebControls.ListViewItemType itemType) { }
        public System.Web.UI.WebControls.ListViewItemType ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override bool OnBubbleEvent(object source, System.EventArgs e) { throw null; }
    }
    public partial class ListViewItemEventArgs : System.EventArgs
    {
        public ListViewItemEventArgs(System.Web.UI.WebControls.ListViewItem item) { }
        public System.Web.UI.WebControls.ListViewItem Item { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum ListViewItemType
    {
        DataItem = 0,
        EmptyItem = 2,
        InsertItem = 1,
    }
    public partial class ListViewPagedDataSource : System.Collections.ICollection, System.Collections.IEnumerable, System.ComponentModel.ITypedList
    {
        public ListViewPagedDataSource() { }
        public bool AllowServerPaging { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int Count { get { throw null; } }
        public System.Collections.IEnumerable DataSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int DataSourceCount { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsServerPagingEnabled { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public int MaximumRows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int StartRowIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object SyncRoot { get { throw null; } }
        public int TotalRowCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        public string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
    }
    public partial class ListViewSelectEventArgs : System.ComponentModel.CancelEventArgs
    {
        public ListViewSelectEventArgs(int newSelectedIndex) { }
        public int NewSelectedIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ListViewSortEventArgs : System.ComponentModel.CancelEventArgs
    {
        public ListViewSortEventArgs(string sortExpression, System.Web.UI.WebControls.SortDirection sortDirection) { }
        public System.Web.UI.WebControls.SortDirection SortDirection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string SortExpression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ListViewUpdatedEventArgs : System.EventArgs
    {
        public ListViewUpdatedEventArgs(int affectedRows, System.Exception exception) { }
        public int AffectedRows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool KeepInEditMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Specialized.IOrderedDictionary NewValues { get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary OldValues { get { throw null; } }
    }
    public partial class ListViewUpdateEventArgs : System.ComponentModel.CancelEventArgs
    {
        public ListViewUpdateEventArgs(int itemIndex) { }
        public int ItemIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary Keys { get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary NewValues { get { throw null; } }
        public System.Collections.Specialized.IOrderedDictionary OldValues { get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class NextPreviousPagerField : System.Web.UI.WebControls.DataPagerField
    {
        public NextPreviousPagerField() { }
        public string ButtonCssClass { get { throw null; } set { } }
        public System.Web.UI.WebControls.ButtonType ButtonType { get { throw null; } set { } }
        public string FirstPageImageUrl { get { throw null; } set { } }
        public string FirstPageText { get { throw null; } set { } }
        public string LastPageImageUrl { get { throw null; } set { } }
        public string LastPageText { get { throw null; } set { } }
        public string NextPageImageUrl { get { throw null; } set { } }
        public string NextPageText { get { throw null; } set { } }
        public string PreviousPageImageUrl { get { throw null; } set { } }
        public string PreviousPageText { get { throw null; } set { } }
        public bool RenderDisabledButtonsAsLabels { get { throw null; } set { } }
        public bool RenderNonBreakingSpacesBetweenControls { get { throw null; } set { } }
        public bool ShowFirstPageButton { get { throw null; } set { } }
        public bool ShowLastPageButton { get { throw null; } set { } }
        public bool ShowNextPageButton { get { throw null; } set { } }
        public bool ShowPreviousPageButton { get { throw null; } set { } }
        protected override void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
        public override void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex) { }
        protected override System.Web.UI.WebControls.DataPagerField CreateField() { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class NumericPagerField : System.Web.UI.WebControls.DataPagerField
    {
        public NumericPagerField() { }
        public int ButtonCount { get { throw null; } set { } }
        public System.Web.UI.WebControls.ButtonType ButtonType { get { throw null; } set { } }
        public string CurrentPageLabelCssClass { get { throw null; } set { } }
        public string NextPageImageUrl { get { throw null; } set { } }
        public string NextPageText { get { throw null; } set { } }
        public string NextPreviousButtonCssClass { get { throw null; } set { } }
        public string NumericButtonCssClass { get { throw null; } set { } }
        public string PreviousPageImageUrl { get { throw null; } set { } }
        public string PreviousPageText { get { throw null; } set { } }
        public bool RenderNonBreakingSpacesBetweenControls { get { throw null; } set { } }
        protected override void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
        public override void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex) { }
        protected override System.Web.UI.WebControls.DataPagerField CreateField() { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class PageEventArgs : System.EventArgs
    {
        public PageEventArgs(int startRowIndex, int maximumRows, int totalRowCount) { }
        public int MaximumRows { get { throw null; } }
        public int StartRowIndex { get { throw null; } }
        public int TotalRowCount { get { throw null; } }
    }
    public partial class PagePropertiesChangingEventArgs : System.EventArgs
    {
        public PagePropertiesChangingEventArgs(int startRowIndex, int maximumRows) { }
        public int MaximumRows { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int StartRowIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class TemplatePagerField : System.Web.UI.WebControls.DataPagerField
    {
        public TemplatePagerField() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
        [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.DataPagerFieldItem), (System.ComponentModel.BindingDirection)(1))]
        public virtual System.Web.UI.ITemplate PagerTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public event System.EventHandler<System.Web.UI.WebControls.DataPagerCommandEventArgs> PagerCommand { add { } remove { } }
        protected override void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
        public override void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex) { }
        protected override System.Web.UI.WebControls.DataPagerField CreateField() { throw null; }
        public override void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e) { }
        protected virtual void OnPagerCommand(System.Web.UI.WebControls.DataPagerCommandEventArgs e) { }
    }
}
