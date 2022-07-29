// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.ApplicationServices.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.ApplicationServices.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.ApplicationServices.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute(PartialTrustVisibilityLevel=System.Security.PartialTrustVisibilityLevel.NotVisibleByDefault)]
[assembly:System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level1, SkipVerificationInFullTrust=true)]
namespace System.Web.Configuration
{
    public enum MembershipPasswordCompatibilityMode
    {
        Framework20 = 0,
        Framework40 = 1,
    }
}
namespace System.Web.Hosting
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed partial class CustomLoaderAttribute : System.Attribute
    {
        public CustomLoaderAttribute(System.Type customLoaderType) { }
        public System.Type CustomLoaderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
namespace System.Web.Security
{
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public enum MembershipCreateStatus
    {
        DuplicateEmail = 7,
        DuplicateProviderUserKey = 10,
        DuplicateUserName = 6,
        InvalidAnswer = 4,
        InvalidEmail = 5,
        InvalidPassword = 2,
        InvalidProviderUserKey = 9,
        InvalidQuestion = 3,
        InvalidUserName = 1,
        ProviderError = 11,
        Success = 0,
        UserRejected = 8,
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.SerializableAttribute]
    public partial class MembershipCreateUserException : System.Exception
    {
        public MembershipCreateUserException() { }
        protected MembershipCreateUserException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MembershipCreateUserException(string message) { }
        public MembershipCreateUserException(string message, System.Exception innerException) { }
        public MembershipCreateUserException(System.Web.Security.MembershipCreateStatus statusCode) { }
        public System.Web.Security.MembershipCreateStatus StatusCode { get { throw null; } }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.SerializableAttribute]
    public partial class MembershipPasswordException : System.Exception
    {
        public MembershipPasswordException() { }
        protected MembershipPasswordException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MembershipPasswordException(string message) { }
        public MembershipPasswordException(string message, System.Exception innerException) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public enum MembershipPasswordFormat
    {
        Clear = 0,
        Encrypted = 2,
        Hashed = 1,
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public abstract partial class MembershipProvider : System.Configuration.Provider.ProviderBase
    {
        protected MembershipProvider() { }
        public abstract string ApplicationName { get; set; }
        public abstract bool EnablePasswordReset { get; }
        public abstract bool EnablePasswordRetrieval { get; }
        public abstract int MaxInvalidPasswordAttempts { get; }
        public abstract int MinRequiredNonAlphanumericCharacters { get; }
        public abstract int MinRequiredPasswordLength { get; }
        public abstract int PasswordAttemptWindow { get; }
        public abstract System.Web.Security.MembershipPasswordFormat PasswordFormat { get; }
        public abstract string PasswordStrengthRegularExpression { get; }
        public abstract bool RequiresQuestionAndAnswer { get; }
        public abstract bool RequiresUniqueEmail { get; }
        public event System.Web.Security.MembershipValidatePasswordEventHandler ValidatingPassword { add { } remove { } }
        public abstract bool ChangePassword(string username, string oldPassword, string newPassword);
        public abstract bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer);
        public abstract System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status);
        protected virtual byte[] DecryptPassword(byte[] encodedPassword) { throw null; }
        public abstract bool DeleteUser(string username, bool deleteAllRelatedData);
        protected virtual byte[] EncryptPassword(byte[] password) { throw null; }
        protected virtual byte[] EncryptPassword(byte[] password, System.Web.Configuration.MembershipPasswordCompatibilityMode legacyPasswordCompatibilityMode) { throw null; }
        public abstract System.Web.Security.MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
        public abstract System.Web.Security.MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
        public abstract System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
        public abstract int GetNumberOfUsersOnline();
        public abstract string GetPassword(string username, string answer);
        public abstract System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline);
        public abstract System.Web.Security.MembershipUser GetUser(string username, bool userIsOnline);
        public abstract string GetUserNameByEmail(string email);
        protected virtual void OnValidatingPassword(System.Web.Security.ValidatePasswordEventArgs e) { }
        public abstract string ResetPassword(string username, string answer);
        public abstract bool UnlockUser(string userName);
        public abstract void UpdateUser(System.Web.Security.MembershipUser user);
        public abstract bool ValidateUser(string username, string password);
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed partial class MembershipProviderCollection : System.Configuration.Provider.ProviderCollection
    {
        public MembershipProviderCollection() { }
        public new System.Web.Security.MembershipProvider this[string name] { get { throw null; } }
        public override void Add(System.Configuration.Provider.ProviderBase provider) { }
        public void CopyTo(System.Web.Security.MembershipProvider[] array, int index) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.SerializableAttribute]
    public partial class MembershipUser
    {
        protected MembershipUser() { }
        public MembershipUser(string providerName, string name, object providerUserKey, string email, string passwordQuestion, string comment, bool isApproved, bool isLockedOut, System.DateTime creationDate, System.DateTime lastLoginDate, System.DateTime lastActivityDate, System.DateTime lastPasswordChangedDate, System.DateTime lastLockoutDate) { }
        public virtual string Comment { get { throw null; } set { } }
        public virtual System.DateTime CreationDate { get { throw null; } }
        public virtual string Email { get { throw null; } set { } }
        public virtual bool IsApproved { get { throw null; } set { } }
        public virtual bool IsLockedOut { get { throw null; } }
        public virtual bool IsOnline { get { throw null; } }
        public virtual System.DateTime LastActivityDate { get { throw null; } set { } }
        public virtual System.DateTime LastLockoutDate { get { throw null; } }
        public virtual System.DateTime LastLoginDate { get { throw null; } set { } }
        public virtual System.DateTime LastPasswordChangedDate { get { throw null; } }
        public virtual string PasswordQuestion { get { throw null; } }
        public virtual string ProviderName { get { throw null; } }
        public virtual object ProviderUserKey { get { throw null; } }
        public virtual string UserName { get { throw null; } }
        public virtual bool ChangePassword(string oldPassword, string newPassword) { throw null; }
        public virtual bool ChangePasswordQuestionAndAnswer(string password, string newPasswordQuestion, string newPasswordAnswer) { throw null; }
        public virtual string GetPassword() { throw null; }
        public virtual string GetPassword(string passwordAnswer) { throw null; }
        public virtual string ResetPassword() { throw null; }
        public virtual string ResetPassword(string passwordAnswer) { throw null; }
        public override string ToString() { throw null; }
        public virtual bool UnlockUser() { throw null; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.SerializableAttribute]
    public sealed partial class MembershipUserCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public MembershipUserCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Web.Security.MembershipUser this[string name] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public void Add(System.Web.Security.MembershipUser user) { }
        public void Clear() { }
        public void CopyTo(System.Web.Security.MembershipUser[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(string name) { }
        public void SetReadOnly() { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public delegate void MembershipValidatePasswordEventHandler(object sender, System.Web.Security.ValidatePasswordEventArgs e);
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public abstract partial class RoleProvider : System.Configuration.Provider.ProviderBase
    {
        protected RoleProvider() { }
        public abstract string ApplicationName { get; set; }
        public abstract void AddUsersToRoles(string[] usernames, string[] roleNames);
        public abstract void CreateRole(string roleName);
        public abstract bool DeleteRole(string roleName, bool throwOnPopulatedRole);
        public abstract string[] FindUsersInRole(string roleName, string usernameToMatch);
        public abstract string[] GetAllRoles();
        public abstract string[] GetRolesForUser(string username);
        public abstract string[] GetUsersInRole(string roleName);
        public abstract bool IsUserInRole(string username, string roleName);
        public abstract void RemoveUsersFromRoles(string[] usernames, string[] roleNames);
        public abstract bool RoleExists(string roleName);
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed partial class ValidatePasswordEventArgs : System.EventArgs
    {
        public ValidatePasswordEventArgs(string userName, string password, bool isNewUser) { }
        public bool Cancel { get { throw null; } set { } }
        public System.Exception FailureInformation { get { throw null; } set { } }
        public bool IsNewUser { get { throw null; } }
        public string Password { get { throw null; } }
        public string UserName { get { throw null; } }
    }
}
