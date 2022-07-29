// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("10.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Microsoft.VisualBasic.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Microsoft.VisualBasic.dll")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Microsoft.VisualBasic.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(true)]
[assembly:System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName="")]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(2))]
namespace Microsoft.VisualBasic
{
    public enum AppWinStyle : short
    {
        Hide = (short)0,
        MaximizedFocus = (short)3,
        MinimizedFocus = (short)2,
        MinimizedNoFocus = (short)6,
        NormalFocus = (short)1,
        NormalNoFocus = (short)4,
    }
    public enum AudioPlayMode
    {
        Background = 1,
        BackgroundLoop = 2,
        WaitToComplete = 0,
    }
    public enum CallType
    {
        Get = 2,
        Let = 4,
        Method = 1,
        Set = 8,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute("Microsoft.VisualBasic.Collection.CollectionDebugView")]
    [System.SerializableAttribute]
    public sealed partial class Collection : System.Collections.ICollection, System.Collections.IList, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public Collection() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public object this[object Index] { get { throw null; } }
        public object this[string Key] { get { throw null; } }
        public object this[int Index] { get { throw null; } }
        public void Add(object Item, string Key=null, object Before=null, object After=null) { }
        public bool Contains(string Key) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(int Index) { }
        public void Remove(string Key) { }
        object System.Collections.IList.this[int Index] { get { throw null; } set { } }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
    public sealed partial class ComClassAttribute : System.Attribute
    {
        public ComClassAttribute() { }
        public ComClassAttribute(string _ClassID) { }
        public ComClassAttribute(string _ClassID, string _InterfaceID) { }
        public ComClassAttribute(string _ClassID, string _InterfaceID, string _EventId) { }
        public string ClassID { get { throw null; } }
        public string EventID { get { throw null; } }
        public string InterfaceID { get { throw null; } }
        public bool InterfaceShadows { get { throw null; } set { } }
    }
    public enum CompareMethod
    {
        Binary = 0,
        Text = 1,
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class Constants
    {
        internal Constants() { }
        public const Microsoft.VisualBasic.MsgBoxResult vbAbort = (Microsoft.VisualBasic.MsgBoxResult)(3);
        public const Microsoft.VisualBasic.MsgBoxStyle vbAbortRetryIgnore = (Microsoft.VisualBasic.MsgBoxStyle)(2);
        public const Microsoft.VisualBasic.MsgBoxStyle vbApplicationModal = (Microsoft.VisualBasic.MsgBoxStyle)(0);
        public const Microsoft.VisualBasic.FileAttribute vbArchive = (Microsoft.VisualBasic.FileAttribute)(32);
        public const Microsoft.VisualBasic.VariantType vbArray = (Microsoft.VisualBasic.VariantType)(8192);
        public const string vbBack = "\b";
        public const Microsoft.VisualBasic.CompareMethod vbBinaryCompare = (Microsoft.VisualBasic.CompareMethod)(0);
        public const Microsoft.VisualBasic.VariantType vbBoolean = (Microsoft.VisualBasic.VariantType)(11);
        public const Microsoft.VisualBasic.VariantType vbByte = (Microsoft.VisualBasic.VariantType)(17);
        public const Microsoft.VisualBasic.MsgBoxResult vbCancel = (Microsoft.VisualBasic.MsgBoxResult)(2);
        public const string vbCr = "\r";
        public const Microsoft.VisualBasic.MsgBoxStyle vbCritical = (Microsoft.VisualBasic.MsgBoxStyle)(16);
        public const string vbCrLf = "\r\n";
        public const Microsoft.VisualBasic.VariantType vbCurrency = (Microsoft.VisualBasic.VariantType)(6);
        public const Microsoft.VisualBasic.VariantType vbDate = (Microsoft.VisualBasic.VariantType)(7);
        public const Microsoft.VisualBasic.VariantType vbDecimal = (Microsoft.VisualBasic.VariantType)(14);
        public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton1 = (Microsoft.VisualBasic.MsgBoxStyle)(0);
        public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton2 = (Microsoft.VisualBasic.MsgBoxStyle)(256);
        public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton3 = (Microsoft.VisualBasic.MsgBoxStyle)(512);
        public const Microsoft.VisualBasic.FileAttribute vbDirectory = (Microsoft.VisualBasic.FileAttribute)(16);
        public const Microsoft.VisualBasic.VariantType vbDouble = (Microsoft.VisualBasic.VariantType)(5);
        public const Microsoft.VisualBasic.VariantType vbEmpty = (Microsoft.VisualBasic.VariantType)(0);
        public const Microsoft.VisualBasic.MsgBoxStyle vbExclamation = (Microsoft.VisualBasic.MsgBoxStyle)(48);
        public const Microsoft.VisualBasic.TriState vbFalse = (Microsoft.VisualBasic.TriState)(0);
        public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstFourDays = (Microsoft.VisualBasic.FirstWeekOfYear)(2);
        public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstFullWeek = (Microsoft.VisualBasic.FirstWeekOfYear)(3);
        public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstJan1 = (Microsoft.VisualBasic.FirstWeekOfYear)(1);
        public const string vbFormFeed = "\f";
        public const Microsoft.VisualBasic.FirstDayOfWeek vbFriday = (Microsoft.VisualBasic.FirstDayOfWeek)(6);
        public const Microsoft.VisualBasic.DateFormat vbGeneralDate = (Microsoft.VisualBasic.DateFormat)(0);
        public const Microsoft.VisualBasic.CallType vbGet = (Microsoft.VisualBasic.CallType)(2);
        public const Microsoft.VisualBasic.FileAttribute vbHidden = (Microsoft.VisualBasic.FileAttribute)(2);
        public const Microsoft.VisualBasic.AppWinStyle vbHide = (Microsoft.VisualBasic.AppWinStyle)(0);
        public const Microsoft.VisualBasic.VbStrConv vbHiragana = (Microsoft.VisualBasic.VbStrConv)(32);
        public const Microsoft.VisualBasic.MsgBoxResult vbIgnore = (Microsoft.VisualBasic.MsgBoxResult)(5);
        public const Microsoft.VisualBasic.MsgBoxStyle vbInformation = (Microsoft.VisualBasic.MsgBoxStyle)(64);
        public const Microsoft.VisualBasic.VariantType vbInteger = (Microsoft.VisualBasic.VariantType)(3);
        public const Microsoft.VisualBasic.VbStrConv vbKatakana = (Microsoft.VisualBasic.VbStrConv)(16);
        public const Microsoft.VisualBasic.CallType vbLet = (Microsoft.VisualBasic.CallType)(4);
        public const string vbLf = "\n";
        public const Microsoft.VisualBasic.VbStrConv vbLinguisticCasing = (Microsoft.VisualBasic.VbStrConv)(1024);
        public const Microsoft.VisualBasic.VariantType vbLong = (Microsoft.VisualBasic.VariantType)(20);
        public const Microsoft.VisualBasic.DateFormat vbLongDate = (Microsoft.VisualBasic.DateFormat)(1);
        public const Microsoft.VisualBasic.DateFormat vbLongTime = (Microsoft.VisualBasic.DateFormat)(3);
        public const Microsoft.VisualBasic.VbStrConv vbLowerCase = (Microsoft.VisualBasic.VbStrConv)(2);
        public const Microsoft.VisualBasic.AppWinStyle vbMaximizedFocus = (Microsoft.VisualBasic.AppWinStyle)(3);
        public const Microsoft.VisualBasic.CallType vbMethod = (Microsoft.VisualBasic.CallType)(1);
        public const Microsoft.VisualBasic.AppWinStyle vbMinimizedFocus = (Microsoft.VisualBasic.AppWinStyle)(2);
        public const Microsoft.VisualBasic.AppWinStyle vbMinimizedNoFocus = (Microsoft.VisualBasic.AppWinStyle)(6);
        public const Microsoft.VisualBasic.FirstDayOfWeek vbMonday = (Microsoft.VisualBasic.FirstDayOfWeek)(2);
        public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxHelp = (Microsoft.VisualBasic.MsgBoxStyle)(16384);
        public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxRight = (Microsoft.VisualBasic.MsgBoxStyle)(524288);
        public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxRtlReading = (Microsoft.VisualBasic.MsgBoxStyle)(1048576);
        public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxSetForeground = (Microsoft.VisualBasic.MsgBoxStyle)(65536);
        public const Microsoft.VisualBasic.VbStrConv vbNarrow = (Microsoft.VisualBasic.VbStrConv)(8);
        public const string vbNewLine = "\r\n";
        public const Microsoft.VisualBasic.MsgBoxResult vbNo = (Microsoft.VisualBasic.MsgBoxResult)(7);
        public const Microsoft.VisualBasic.FileAttribute vbNormal = (Microsoft.VisualBasic.FileAttribute)(0);
        public const Microsoft.VisualBasic.AppWinStyle vbNormalFocus = (Microsoft.VisualBasic.AppWinStyle)(1);
        public const Microsoft.VisualBasic.AppWinStyle vbNormalNoFocus = (Microsoft.VisualBasic.AppWinStyle)(4);
        public const Microsoft.VisualBasic.VariantType vbNull = (Microsoft.VisualBasic.VariantType)(1);
        public const string vbNullChar = "\0";
        public const string vbNullString = null;
        public const Microsoft.VisualBasic.VariantType vbObject = (Microsoft.VisualBasic.VariantType)(9);
        public const int vbObjectError = -2147221504;
        public const Microsoft.VisualBasic.MsgBoxResult vbOK = (Microsoft.VisualBasic.MsgBoxResult)(1);
        public const Microsoft.VisualBasic.MsgBoxStyle vbOKCancel = (Microsoft.VisualBasic.MsgBoxStyle)(1);
        public const Microsoft.VisualBasic.MsgBoxStyle vbOKOnly = (Microsoft.VisualBasic.MsgBoxStyle)(0);
        public const Microsoft.VisualBasic.VbStrConv vbProperCase = (Microsoft.VisualBasic.VbStrConv)(3);
        public const Microsoft.VisualBasic.MsgBoxStyle vbQuestion = (Microsoft.VisualBasic.MsgBoxStyle)(32);
        public const Microsoft.VisualBasic.FileAttribute vbReadOnly = (Microsoft.VisualBasic.FileAttribute)(1);
        public const Microsoft.VisualBasic.MsgBoxResult vbRetry = (Microsoft.VisualBasic.MsgBoxResult)(4);
        public const Microsoft.VisualBasic.MsgBoxStyle vbRetryCancel = (Microsoft.VisualBasic.MsgBoxStyle)(5);
        public const Microsoft.VisualBasic.FirstDayOfWeek vbSaturday = (Microsoft.VisualBasic.FirstDayOfWeek)(7);
        public const Microsoft.VisualBasic.CallType vbSet = (Microsoft.VisualBasic.CallType)(8);
        public const Microsoft.VisualBasic.DateFormat vbShortDate = (Microsoft.VisualBasic.DateFormat)(2);
        public const Microsoft.VisualBasic.DateFormat vbShortTime = (Microsoft.VisualBasic.DateFormat)(4);
        public const Microsoft.VisualBasic.VbStrConv vbSimplifiedChinese = (Microsoft.VisualBasic.VbStrConv)(256);
        public const Microsoft.VisualBasic.VariantType vbSingle = (Microsoft.VisualBasic.VariantType)(4);
        public const Microsoft.VisualBasic.VariantType vbString = (Microsoft.VisualBasic.VariantType)(8);
        public const Microsoft.VisualBasic.FirstDayOfWeek vbSunday = (Microsoft.VisualBasic.FirstDayOfWeek)(1);
        public const Microsoft.VisualBasic.FileAttribute vbSystem = (Microsoft.VisualBasic.FileAttribute)(4);
        public const Microsoft.VisualBasic.MsgBoxStyle vbSystemModal = (Microsoft.VisualBasic.MsgBoxStyle)(4096);
        public const string vbTab = "\t";
        public const Microsoft.VisualBasic.CompareMethod vbTextCompare = (Microsoft.VisualBasic.CompareMethod)(1);
        public const Microsoft.VisualBasic.FirstDayOfWeek vbThursday = (Microsoft.VisualBasic.FirstDayOfWeek)(5);
        public const Microsoft.VisualBasic.VbStrConv vbTraditionalChinese = (Microsoft.VisualBasic.VbStrConv)(512);
        public const Microsoft.VisualBasic.TriState vbTrue = (Microsoft.VisualBasic.TriState)(-1);
        public const Microsoft.VisualBasic.FirstDayOfWeek vbTuesday = (Microsoft.VisualBasic.FirstDayOfWeek)(3);
        public const Microsoft.VisualBasic.VbStrConv vbUpperCase = (Microsoft.VisualBasic.VbStrConv)(1);
        public const Microsoft.VisualBasic.TriState vbUseDefault = (Microsoft.VisualBasic.TriState)(-2);
        public const Microsoft.VisualBasic.VariantType vbUserDefinedType = (Microsoft.VisualBasic.VariantType)(36);
        public const Microsoft.VisualBasic.FirstWeekOfYear vbUseSystem = (Microsoft.VisualBasic.FirstWeekOfYear)(0);
        public const Microsoft.VisualBasic.FirstDayOfWeek vbUseSystemDayOfWeek = (Microsoft.VisualBasic.FirstDayOfWeek)(0);
        public const Microsoft.VisualBasic.VariantType vbVariant = (Microsoft.VisualBasic.VariantType)(12);
        public const string vbVerticalTab = "\v";
        public const Microsoft.VisualBasic.FileAttribute vbVolume = (Microsoft.VisualBasic.FileAttribute)(8);
        public const Microsoft.VisualBasic.FirstDayOfWeek vbWednesday = (Microsoft.VisualBasic.FirstDayOfWeek)(4);
        public const Microsoft.VisualBasic.VbStrConv vbWide = (Microsoft.VisualBasic.VbStrConv)(4);
        public const Microsoft.VisualBasic.MsgBoxResult vbYes = (Microsoft.VisualBasic.MsgBoxResult)(6);
        public const Microsoft.VisualBasic.MsgBoxStyle vbYesNo = (Microsoft.VisualBasic.MsgBoxStyle)(4);
        public const Microsoft.VisualBasic.MsgBoxStyle vbYesNoCancel = (Microsoft.VisualBasic.MsgBoxStyle)(3);
    }
    public sealed partial class ControlChars
    {
        public const char Back = '\b';
        public const char Cr = '\r';
        public const string CrLf = "\r\n";
        public const char FormFeed = '\f';
        public const char Lf = '\n';
        public const string NewLine = "\r\n";
        public const char NullChar = '\0';
        public const char Quote = '"';
        public const char Tab = '\t';
        public const char VerticalTab = '\v';
        public ControlChars() { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class Conversion
    {
        internal Conversion() { }
        public static object CTypeDynamic(object Expression, System.Type TargetType) { throw null; }
        public static TargetType CTypeDynamic<TargetType>(object Expression) { throw null; }
        public static string ErrorToString() { throw null; }
        public static string ErrorToString(int ErrorNumber) { throw null; }
        public static decimal Fix(decimal Number) { throw null; }
        public static double Fix(double Number) { throw null; }
        public static short Fix(short Number) { throw null; }
        public static int Fix(int Number) { throw null; }
        public static long Fix(long Number) { throw null; }
        public static object Fix(object Number) { throw null; }
        public static float Fix(float Number) { throw null; }
        public static string Hex(byte Number) { throw null; }
        public static string Hex(short Number) { throw null; }
        public static string Hex(int Number) { throw null; }
        public static string Hex(long Number) { throw null; }
        public static string Hex(object Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Hex(sbyte Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Hex(ushort Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Hex(uint Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Hex(ulong Number) { throw null; }
        public static decimal Int(decimal Number) { throw null; }
        public static double Int(double Number) { throw null; }
        public static short Int(short Number) { throw null; }
        public static int Int(int Number) { throw null; }
        public static long Int(long Number) { throw null; }
        public static object Int(object Number) { throw null; }
        public static float Int(float Number) { throw null; }
        public static string Oct(byte Number) { throw null; }
        public static string Oct(short Number) { throw null; }
        public static string Oct(int Number) { throw null; }
        public static string Oct(long Number) { throw null; }
        public static string Oct(object Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Oct(sbyte Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Oct(ushort Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Oct(uint Number) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string Oct(ulong Number) { throw null; }
        public static string Str(object Number) { throw null; }
        public static int Val(char Expression) { throw null; }
        public static double Val(object Expression) { throw null; }
        public static double Val(string InputStr) { throw null; }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class DateAndTime
    {
        internal DateAndTime() { }
        public static string DateString { get { throw null; } [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]set { } }
        public static System.DateTime Now { get { throw null; } }
        public static System.DateTime TimeOfDay { get { throw null; } [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]set { } }
        public static double Timer { get { throw null; } }
        public static string TimeString { get { throw null; } [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]set { } }
        public static System.DateTime Today { get { throw null; } [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]set { } }
        public static System.DateTime DateAdd(Microsoft.VisualBasic.DateInterval Interval, double Number, System.DateTime DateValue) { throw null; }
        public static System.DateTime DateAdd(string Interval, double Number, object DateValue) { throw null; }
        public static long DateDiff(Microsoft.VisualBasic.DateInterval Interval, System.DateTime Date1, System.DateTime Date2, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { throw null; }
        public static long DateDiff(string Interval, object Date1, object Date2, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { throw null; }
        public static int DatePart(Microsoft.VisualBasic.DateInterval Interval, System.DateTime DateValue, Microsoft.VisualBasic.FirstDayOfWeek FirstDayOfWeekValue=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear FirstWeekOfYearValue=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { throw null; }
        public static int DatePart(string Interval, object DateValue, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { throw null; }
        public static System.DateTime DateSerial(int Year, int Month, int Day) { throw null; }
        public static System.DateTime DateValue(string StringDate) { throw null; }
        public static int Day(System.DateTime DateValue) { throw null; }
        public static int Hour(System.DateTime TimeValue) { throw null; }
        public static int Minute(System.DateTime TimeValue) { throw null; }
        public static int Month(System.DateTime DateValue) { throw null; }
        public static string MonthName(int Month, bool Abbreviate=false) { throw null; }
        public static int Second(System.DateTime TimeValue) { throw null; }
        public static System.DateTime TimeSerial(int Hour, int Minute, int Second) { throw null; }
        public static System.DateTime TimeValue(string StringTime) { throw null; }
        public static int Weekday(System.DateTime DateValue, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1)) { throw null; }
        public static string WeekdayName(int Weekday, bool Abbreviate=false, Microsoft.VisualBasic.FirstDayOfWeek FirstDayOfWeekValue=(Microsoft.VisualBasic.FirstDayOfWeek)(0)) { throw null; }
        public static int Year(System.DateTime DateValue) { throw null; }
    }
    public enum DateFormat
    {
        GeneralDate = 0,
        LongDate = 1,
        LongTime = 3,
        ShortDate = 2,
        ShortTime = 4,
    }
    public enum DateInterval
    {
        Day = 4,
        DayOfYear = 3,
        Hour = 7,
        Minute = 8,
        Month = 2,
        Quarter = 1,
        Second = 9,
        Weekday = 6,
        WeekOfYear = 5,
        Year = 0,
    }
    public enum DueDate
    {
        BegOfPeriod = 1,
        EndOfPeriod = 0,
    }
    public sealed partial class ErrObject
    {
        internal ErrObject() { }
        public string Description { get { throw null; } set { } }
        public int Erl { get { throw null; } }
        public int HelpContext { get { throw null; } set { } }
        public string HelpFile { get { throw null; } set { } }
        public int LastDllError { [System.Security.SecurityCriticalAttribute]get { throw null; } }
        public int Number { get { throw null; } set { } }
        public string Source { get { throw null; } set { } }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Clear() { }
        public System.Exception GetException() { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public void Raise(int Number, object Source=null, object Description=null, object HelpFile=null, object HelpContext=null) { }
    }
    [System.FlagsAttribute]
    public enum FileAttribute
    {
        Archive = 32,
        Directory = 16,
        Hidden = 2,
        Normal = 0,
        ReadOnly = 1,
        System = 4,
        Volume = 8,
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public sealed partial class FileSystem
    {
        internal FileSystem() { }
        public static void ChDir(string Path) { }
        public static void ChDrive(char Drive) { }
        public static void ChDrive(string Drive) { }
        public static string CurDir() { throw null; }
        public static string CurDir(char Drive) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static string Dir() { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static string Dir(string PathName, Microsoft.VisualBasic.FileAttribute Attributes=(Microsoft.VisualBasic.FileAttribute)(0)) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static bool EOF(int FileNumber) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static Microsoft.VisualBasic.OpenMode FileAttr(int FileNumber) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileClose(params int[] FileNumbers) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileCopy(string Source, string Destination) { }
        public static System.DateTime FileDateTime(string PathName) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref System.Array Value, long RecordNumber=(long)-1, bool ArrayIsDynamic=false, bool StringIsFixedLength=false) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref bool Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref byte Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref char Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref System.DateTime Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref decimal Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref double Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref short Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref int Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref long Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref float Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref string Value, long RecordNumber=(long)-1, bool StringIsFixedLength=false) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGet(int FileNumber, ref System.ValueType Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileGetObject(int FileNumber, ref object Value, long RecordNumber=(long)-1) { }
        public static long FileLen(string PathName) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileOpen(int FileNumber, string FileName, Microsoft.VisualBasic.OpenMode Mode, Microsoft.VisualBasic.OpenAccess Access=(Microsoft.VisualBasic.OpenAccess)(-1), Microsoft.VisualBasic.OpenShare Share=(Microsoft.VisualBasic.OpenShare)(-1), int RecordLength=-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, System.Array Value, long RecordNumber=(long)-1, bool ArrayIsDynamic=false, bool StringIsFixedLength=false) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, bool Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, byte Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, char Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, System.DateTime Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, decimal Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, double Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, short Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, int Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, long Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, float Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, string Value, long RecordNumber=(long)-1, bool StringIsFixedLength=false) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePut(int FileNumber, System.ValueType Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.ObsoleteAttribute("This member has been deprecated. Please use FilePutObject to write Object types, or coerce FileNumber and RecordNumber to Integer for writing non-Object types. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static void FilePut(object FileNumber, object Value, object RecordNumber=null) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FilePutObject(int FileNumber, object Value, long RecordNumber=(long)-1) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void FileWidth(int FileNumber, int RecordWidth) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static int FreeFile() { throw null; }
        public static Microsoft.VisualBasic.FileAttribute GetAttr(string PathName) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref bool Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref byte Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref char Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref System.DateTime Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref decimal Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref double Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref short Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref int Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref long Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref object Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref float Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Input(int FileNumber, ref string Value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static string InputString(int FileNumber, int CharCount) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Kill(string PathName) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static string LineInput(int FileNumber) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static long Loc(int FileNumber) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Lock(int FileNumber) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Lock(int FileNumber, long Record) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Lock(int FileNumber, long FromRecord, long ToRecord) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static long LOF(int FileNumber) { throw null; }
        public static void MkDir(string Path) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Print(int FileNumber, params object[] Output) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void PrintLine(int FileNumber, params object[] Output) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Rename(string OldPath, string NewPath) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Reset() { }
        public static void RmDir(string Path) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static long Seek(int FileNumber) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Seek(int FileNumber, long Position) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void SetAttr(string PathName, Microsoft.VisualBasic.FileAttribute Attributes) { }
        public static Microsoft.VisualBasic.SpcInfo SPC(short Count) { throw null; }
        public static Microsoft.VisualBasic.TabInfo TAB() { throw null; }
        public static Microsoft.VisualBasic.TabInfo TAB(short Column) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Unlock(int FileNumber) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Unlock(int FileNumber, long Record) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Unlock(int FileNumber, long FromRecord, long ToRecord) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void Write(int FileNumber, params object[] Output) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static void WriteLine(int FileNumber, params object[] Output) { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class Financial
    {
        internal Financial() { }
        public static double DDB(double Cost, double Salvage, double Life, double Period, double Factor=2) { throw null; }
        public static double FV(double Rate, double NPer, double Pmt, double PV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { throw null; }
        public static double IPmt(double Rate, double Per, double NPer, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { throw null; }
        public static double IRR(ref double[] ValueArray, double Guess=0.1) { throw null; }
        public static double MIRR(ref double[] ValueArray, double FinanceRate, double ReinvestRate) { throw null; }
        public static double NPer(double Rate, double Pmt, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { throw null; }
        public static double NPV(double Rate, ref double[] ValueArray) { throw null; }
        public static double Pmt(double Rate, double NPer, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { throw null; }
        public static double PPmt(double Rate, double Per, double NPer, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { throw null; }
        public static double PV(double Rate, double NPer, double Pmt, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { throw null; }
        public static double Rate(double NPer, double Pmt, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0), double Guess=0.1) { throw null; }
        public static double SLN(double Cost, double Salvage, double Life) { throw null; }
        public static double SYD(double Cost, double Salvage, double Life, double Period) { throw null; }
    }
    public enum FirstDayOfWeek
    {
        Friday = 6,
        Monday = 2,
        Saturday = 7,
        Sunday = 1,
        System = 0,
        Thursday = 5,
        Tuesday = 3,
        Wednesday = 4,
    }
    public enum FirstWeekOfYear
    {
        FirstFourDays = 2,
        FirstFullWeek = 3,
        Jan1 = 1,
        System = 0,
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class Globals
    {
        internal Globals() { }
        public static string ScriptEngine { get { throw null; } }
        public static int ScriptEngineBuildVersion { get { throw null; } }
        public static int ScriptEngineMajorVersion { get { throw null; } }
        public static int ScriptEngineMinorVersion { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
    public sealed partial class HideModuleNameAttribute : System.Attribute
    {
        public HideModuleNameAttribute() { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class Information
    {
        internal Information() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static int Erl() { throw null; }
        public static Microsoft.VisualBasic.ErrObject Err() { throw null; }
        public static bool IsArray(object VarName) { throw null; }
        public static bool IsDate(object Expression) { throw null; }
        public static bool IsDBNull(object Expression) { throw null; }
        public static bool IsError(object Expression) { throw null; }
        public static bool IsNothing(object Expression) { throw null; }
        public static bool IsNumeric(object Expression) { throw null; }
        public static bool IsReference(object Expression) { throw null; }
        public static int LBound(System.Array Array, int Rank=1) { throw null; }
        public static int QBColor(int Color) { throw null; }
        public static int RGB(int Red, int Green, int Blue) { throw null; }
        public static string SystemTypeName(string VbName) { throw null; }
        public static string TypeName(object VarName) { throw null; }
        public static int UBound(System.Array Array, int Rank=1) { throw null; }
        public static Microsoft.VisualBasic.VariantType VarType(object VarName) { throw null; }
        public static string VbTypeName(string UrtName) { throw null; }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class Interaction
    {
        internal Interaction() { }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public static void AppActivate(int ProcessId) { }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public static void AppActivate(string Title) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Beep() { }
        public static object CallByName(object ObjectRef, string ProcName, Microsoft.VisualBasic.CallType UseCallType, params object[] Args) { throw null; }
        public static object Choose(double Index, params object[] Choice) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Command() { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public static object CreateObject(string ProgId, string ServerName="") { throw null; }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public static void DeleteSetting(string AppName, string Section=null, string Key=null) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Environ(int Expression) { throw null; }
        public static string Environ(string Expression) { throw null; }
        public static string[,] GetAllSettings(string AppName, string Section) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public static object GetObject(string PathName=null, string Class=null) { throw null; }
        public static string GetSetting(string AppName, string Section, string Key, string Default="") { throw null; }
        public static object IIf(bool Expression, object TruePart, object FalsePart) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(128))]
        public static string InputBox(string Prompt, string Title="", string DefaultResponse="", int XPos=-1, int YPos=-1) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(128))]
        public static Microsoft.VisualBasic.MsgBoxResult MsgBox(object Prompt, Microsoft.VisualBasic.MsgBoxStyle Buttons=(Microsoft.VisualBasic.MsgBoxStyle)(0), object Title=null) { throw null; }
        public static string Partition(long Number, long Start, long Stop, long Interval) { throw null; }
        public static void SaveSetting(string AppName, string Section, string Key, string Setting) { }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public static int Shell(string PathName, Microsoft.VisualBasic.AppWinStyle Style=(Microsoft.VisualBasic.AppWinStyle)(2), bool Wait=false, int Timeout=-1) { throw null; }
        public static object Switch(params object[] VarExpr) { throw null; }
    }
    public enum MsgBoxResult
    {
        Abort = 3,
        Cancel = 2,
        Ignore = 5,
        No = 7,
        Ok = 1,
        Retry = 4,
        Yes = 6,
    }
    [System.FlagsAttribute]
    public enum MsgBoxStyle
    {
        AbortRetryIgnore = 2,
        ApplicationModal = 0,
        Critical = 16,
        DefaultButton1 = 0,
        DefaultButton2 = 256,
        DefaultButton3 = 512,
        Exclamation = 48,
        Information = 64,
        MsgBoxHelp = 16384,
        MsgBoxRight = 524288,
        MsgBoxRtlReading = 1048576,
        MsgBoxSetForeground = 65536,
        OkCancel = 1,
        OkOnly = 0,
        Question = 32,
        RetryCancel = 5,
        SystemModal = 4096,
        YesNo = 4,
        YesNoCancel = 3,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public sealed partial class MyGroupCollectionAttribute : System.Attribute
    {
        public MyGroupCollectionAttribute(string typeToCollect, string createInstanceMethodName, string disposeInstanceMethodName, string defaultInstanceAlias) { }
        public string CreateMethod { get { throw null; } }
        public string DefaultInstanceAlias { get { throw null; } }
        public string DisposeMethod { get { throw null; } }
        public string MyGroupName { get { throw null; } }
    }
    public enum OpenAccess
    {
        Default = -1,
        Read = 1,
        ReadWrite = 3,
        Write = 2,
    }
    public enum OpenMode
    {
        Append = 8,
        Binary = 32,
        Input = 1,
        Output = 2,
        Random = 4,
    }
    public enum OpenShare
    {
        Default = -1,
        LockRead = 2,
        LockReadWrite = 0,
        LockWrite = 1,
        Shared = 3,
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SpcInfo
    {
        public short Count;
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class Strings
    {
        internal Strings() { }
        public static int Asc(char String) { throw null; }
        public static int Asc(string String) { throw null; }
        public static int AscW(char String) { throw null; }
        public static int AscW(string String) { throw null; }
        public static char Chr(int CharCode) { throw null; }
        public static char ChrW(int CharCode) { throw null; }
        public static string[] Filter(object[] Source, string Match, bool Include=true, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static string[] Filter(string[] Source, string Match, bool Include=true, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static string Format(object Expression, string Style="") { throw null; }
        public static string FormatCurrency(object Expression, int NumDigitsAfterDecimal=-1, Microsoft.VisualBasic.TriState IncludeLeadingDigit=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState GroupDigits=(Microsoft.VisualBasic.TriState)(-2)) { throw null; }
        public static string FormatDateTime(System.DateTime Expression, Microsoft.VisualBasic.DateFormat NamedFormat=(Microsoft.VisualBasic.DateFormat)(0)) { throw null; }
        public static string FormatNumber(object Expression, int NumDigitsAfterDecimal=-1, Microsoft.VisualBasic.TriState IncludeLeadingDigit=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState GroupDigits=(Microsoft.VisualBasic.TriState)(-2)) { throw null; }
        public static string FormatPercent(object Expression, int NumDigitsAfterDecimal=-1, Microsoft.VisualBasic.TriState IncludeLeadingDigit=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState GroupDigits=(Microsoft.VisualBasic.TriState)(-2)) { throw null; }
        public static char GetChar(string str, int Index) { throw null; }
        public static int InStr(int Start, string String1, string String2, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static int InStr(string String1, string String2, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static int InStrRev(string StringCheck, string StringMatch, int Start=-1, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static string Join(object[] SourceArray, string Delimiter=" ") { throw null; }
        public static string Join(string[] SourceArray, string Delimiter=" ") { throw null; }
        public static char LCase(char Value) { throw null; }
        public static string LCase(string Value) { throw null; }
        public static string Left(string str, int Length) { throw null; }
        public static int Len(bool Expression) { throw null; }
        public static int Len(byte Expression) { throw null; }
        public static int Len(char Expression) { throw null; }
        public static int Len(System.DateTime Expression) { throw null; }
        public static int Len(decimal Expression) { throw null; }
        public static int Len(double Expression) { throw null; }
        public static int Len(short Expression) { throw null; }
        public static int Len(int Expression) { throw null; }
        public static int Len(long Expression) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int Len(object Expression) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int Len(sbyte Expression) { throw null; }
        public static int Len(float Expression) { throw null; }
        public static int Len(string Expression) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int Len(ushort Expression) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int Len(uint Expression) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int Len(ulong Expression) { throw null; }
        public static string LSet(string Source, int Length) { throw null; }
        public static string LTrim(string str) { throw null; }
        public static string Mid(string str, int Start) { throw null; }
        public static string Mid(string str, int Start, int Length) { throw null; }
        public static string Replace(string Expression, string Find, string Replacement, int Start=1, int Count=-1, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static string Right(string str, int Length) { throw null; }
        public static string RSet(string Source, int Length) { throw null; }
        public static string RTrim(string str) { throw null; }
        public static string Space(int Number) { throw null; }
        public static string[] Split(string Expression, string Delimiter=" ", int Limit=-1, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static int StrComp(string String1, string String2, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { throw null; }
        public static string StrConv(string str, Microsoft.VisualBasic.VbStrConv Conversion, int LocaleID=0) { throw null; }
        public static string StrDup(int Number, char Character) { throw null; }
        public static object StrDup(int Number, object Character) { throw null; }
        public static string StrDup(int Number, string Character) { throw null; }
        public static string StrReverse(string Expression) { throw null; }
        public static string Trim(string str) { throw null; }
        public static char UCase(char Value) { throw null; }
        public static string UCase(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TabInfo
    {
        public short Column;
    }
    public enum TriState
    {
        False = 0,
        True = -1,
        UseDefault = -2,
    }
    public enum VariantType
    {
        Array = 8192,
        Boolean = 11,
        Byte = 17,
        Char = 18,
        Currency = 6,
        DataObject = 13,
        Date = 7,
        Decimal = 14,
        Double = 5,
        Empty = 0,
        Error = 10,
        Integer = 3,
        Long = 20,
        Null = 1,
        Object = 9,
        Short = 2,
        Single = 4,
        String = 8,
        UserDefinedType = 36,
        Variant = 12,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false, AllowMultiple=false)]
    public sealed partial class VBFixedArrayAttribute : System.Attribute
    {
        public VBFixedArrayAttribute(int UpperBound1) { }
        public VBFixedArrayAttribute(int UpperBound1, int UpperBound2) { }
        public int[] Bounds { get { throw null; } }
        public int Length { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false, AllowMultiple=false)]
    public sealed partial class VBFixedStringAttribute : System.Attribute
    {
        public VBFixedStringAttribute(int Length) { }
        public int Length { get { throw null; } }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
    public sealed partial class VBMath
    {
        internal VBMath() { }
        public static void Randomize() { }
        public static void Randomize(double Number) { }
        public static float Rnd() { throw null; }
        public static float Rnd(float Number) { throw null; }
    }
    [System.FlagsAttribute]
    public enum VbStrConv
    {
        Hiragana = 32,
        Katakana = 16,
        LinguisticCasing = 1024,
        Lowercase = 2,
        Narrow = 8,
        None = 0,
        ProperCase = 3,
        SimplifiedChinese = 256,
        TraditionalChinese = 512,
        Uppercase = 1,
        Wide = 4,
    }
}
namespace Microsoft.VisualBasic.ApplicationServices
{
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class ApplicationBase
    {
        public ApplicationBase() { }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        public Microsoft.VisualBasic.ApplicationServices.AssemblyInfo Info { [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]get { throw null; } }
        public Microsoft.VisualBasic.Logging.Log Log { get { throw null; } }
        public System.Globalization.CultureInfo UICulture { get { throw null; } }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public void ChangeCulture(string cultureName) { }
        public void ChangeUICulture(string cultureName) { }
        public string GetEnvironmentVariable(string name) { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class AssemblyInfo
    {
        public AssemblyInfo(System.Reflection.Assembly currentAssembly) { }
        public string AssemblyName { get { throw null; } }
        public string CompanyName { get { throw null; } }
        public string Copyright { get { throw null; } }
        public string Description { get { throw null; } }
        public string DirectoryPath { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.Assembly> LoadedAssemblies { get { throw null; } }
        public string ProductName { get { throw null; } }
        public string StackTrace { get { throw null; } }
        public string Title { get { throw null; } }
        public string Trademark { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public long WorkingSet { get { throw null; } }
    }
    public enum AuthenticationMode
    {
        ApplicationDefined = 1,
        Windows = 0,
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(Microsoft.VisualBasic.ApplicationServices.BuiltInRoleConverter))]
    public enum BuiltInRole
    {
        AccountOperator = 548,
        Administrator = 544,
        BackupOperator = 551,
        Guest = 546,
        PowerUser = 547,
        PrintOperator = 550,
        Replicator = 552,
        SystemOperator = 549,
        User = 545,
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SharedState=true)]
    public partial class BuiltInRoleConverter : System.ComponentModel.TypeConverter
    {
        public BuiltInRoleConverter() { }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.SerializableAttribute]
    public partial class CantStartSingleInstanceException : System.Exception
    {
        public CantStartSingleInstanceException() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected CantStartSingleInstanceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CantStartSingleInstanceException(string message) { }
        public CantStartSingleInstanceException(string message, System.Exception inner) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class ConsoleApplicationBase : Microsoft.VisualBasic.ApplicationServices.ApplicationBase
    {
        public ConsoleApplicationBase() { }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> CommandLineArgs { get { throw null; } }
#if false
        public System.Deployment.Application.ApplicationDeployment Deployment { get { throw null; } }
#endif
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected System.Collections.ObjectModel.ReadOnlyCollection<string> InternalCommandLine { set { } }
        public bool IsNetworkDeployed { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.SerializableAttribute]
    public partial class NoStartupFormException : System.Exception
    {
        public NoStartupFormException() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected NoStartupFormException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public NoStartupFormException(string message) { }
        public NoStartupFormException(string message, System.Exception inner) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public delegate void ShutdownEventHandler(object sender, System.EventArgs e);
    public enum ShutdownMode
    {
        AfterAllFormsClose = 1,
        AfterMainFormCloses = 0,
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class StartupEventArgs : System.ComponentModel.CancelEventArgs
    {
        public StartupEventArgs(System.Collections.ObjectModel.ReadOnlyCollection<string> args) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> CommandLine { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public delegate void StartupEventHandler(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e);
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public partial class StartupNextInstanceEventArgs : System.EventArgs
    {
        public StartupNextInstanceEventArgs(System.Collections.ObjectModel.ReadOnlyCollection<string> args, bool bringToForegroundFlag) { }
        public bool BringToForeground { get { throw null; } set { } }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> CommandLine { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public delegate void StartupNextInstanceEventHandler(object sender, Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs e);
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class UnhandledExceptionEventArgs : System.Threading.ThreadExceptionEventArgs
    {
        public UnhandledExceptionEventArgs(bool exitApplication, System.Exception exception) : base (default(System.Exception)) { }
        public bool ExitApplication { get { throw null; } set { } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public delegate void UnhandledExceptionEventHandler(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e);
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class User
    {
        public User() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Security.Principal.IPrincipal CurrentPrincipal { get { throw null; } set { } }
        protected virtual System.Security.Principal.IPrincipal InternalPrincipal { get { throw null; } set { } }
        public bool IsAuthenticated { get { throw null; } }
        public string Name { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public void InitializeWithWindowsUser() { }
        public bool IsInRole(Microsoft.VisualBasic.ApplicationServices.BuiltInRole role) { throw null; }
        public bool IsInRole(string role) { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class WebUser : Microsoft.VisualBasic.ApplicationServices.User
    {
        public WebUser() { }
        protected override System.Security.Principal.IPrincipal InternalPrincipal { get { throw null; } set { } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class WindowsFormsApplicationBase : Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase
    {
        public WindowsFormsApplicationBase() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public WindowsFormsApplicationBase(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode authenticationMode) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Windows.Forms.ApplicationContext ApplicationContext { get { throw null; } }
        protected bool EnableVisualStyles { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected bool IsSingleInstance { get { throw null; } set { } }
        protected System.Windows.Forms.Form MainForm { get { throw null; } set { } }
        public int MinimumSplashScreenDisplayTime { get { throw null; } set { } }
        public System.Windows.Forms.FormCollection OpenForms { get { throw null; } }
        public bool SaveMySettingsOnExit { get { throw null; } set { } }
        protected internal Microsoft.VisualBasic.ApplicationServices.ShutdownMode ShutdownStyle { get { throw null; } set { } }
        public System.Windows.Forms.Form SplashScreen { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected static bool UseCompatibleTextRendering { get { throw null; } }
        public event Microsoft.VisualBasic.Devices.NetworkAvailableEventHandler NetworkAvailabilityChanged { add { } remove { } }
        public event Microsoft.VisualBasic.ApplicationServices.ShutdownEventHandler Shutdown { add { } remove { } }
        public event Microsoft.VisualBasic.ApplicationServices.StartupEventHandler Startup { add { } remove { } }
        public event Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventHandler StartupNextInstance { add { } remove { } }
        public event Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventHandler UnhandledException { add { } remove { } }
        public void DoEvents() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void HideSplashScreen() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected virtual void OnCreateMainForm() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected virtual void OnCreateSplashScreen() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        [System.STAThreadAttribute]
        protected virtual bool OnInitialize(System.Collections.ObjectModel.ReadOnlyCollection<string> commandLineArgs) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        protected virtual void OnRun() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected virtual void OnShutdown() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected virtual bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        protected virtual void OnStartupNextInstance(Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs eventArgs) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected virtual bool OnUnhandledException(Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public void Run(string[] commandLine) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected void ShowSplashScreen() { }
    }
}
namespace Microsoft.VisualBasic.CompilerServices
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class BooleanType
    {
        internal BooleanType() { }
        public static bool FromObject(object Value) { throw null; }
        public static bool FromString(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ByteType
    {
        internal ByteType() { }
        public static byte FromObject(object Value) { throw null; }
        public static byte FromString(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class CharArrayType
    {
        internal CharArrayType() { }
        public static char[] FromObject(object Value) { throw null; }
        public static char[] FromString(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class CharType
    {
        internal CharType() { }
        public static char FromObject(object Value) { throw null; }
        public static char FromString(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class Conversions
    {
        internal Conversions() { }
        public static object ChangeType(object Expression, System.Type TargetType) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static object FallbackUserDefinedConversion(object Expression, System.Type TargetType) { throw null; }
        public static string FromCharAndCount(char Value, int Count) { throw null; }
        public static string FromCharArray(char[] Value) { throw null; }
        public static string FromCharArraySubset(char[] Value, int StartIndex, int Length) { throw null; }
        public static bool ToBoolean(object Value) { throw null; }
        public static bool ToBoolean(string Value) { throw null; }
        public static byte ToByte(object Value) { throw null; }
        public static byte ToByte(string Value) { throw null; }
        public static char ToChar(object Value) { throw null; }
        public static char ToChar(string Value) { throw null; }
        public static char[] ToCharArrayRankOne(object Value) { throw null; }
        public static char[] ToCharArrayRankOne(string Value) { throw null; }
        public static System.DateTime ToDate(object Value) { throw null; }
        public static System.DateTime ToDate(string Value) { throw null; }
        public static decimal ToDecimal(bool Value) { throw null; }
        public static decimal ToDecimal(object Value) { throw null; }
        public static decimal ToDecimal(string Value) { throw null; }
        public static double ToDouble(object Value) { throw null; }
        public static double ToDouble(string Value) { throw null; }
        public static T ToGenericParameter<T>(object Value) { throw null; }
        public static int ToInteger(object Value) { throw null; }
        public static int ToInteger(string Value) { throw null; }
        public static long ToLong(object Value) { throw null; }
        public static long ToLong(string Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(object Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string Value) { throw null; }
        public static short ToShort(object Value) { throw null; }
        public static short ToShort(string Value) { throw null; }
        public static float ToSingle(object Value) { throw null; }
        public static float ToSingle(string Value) { throw null; }
        public static string ToString(bool Value) { throw null; }
        public static string ToString(byte Value) { throw null; }
        public static string ToString(char Value) { throw null; }
        public static string ToString(System.DateTime Value) { throw null; }
        public static string ToString(decimal Value) { throw null; }
        public static string ToString(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static string ToString(double Value) { throw null; }
        public static string ToString(double Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static string ToString(short Value) { throw null; }
        public static string ToString(int Value) { throw null; }
        public static string ToString(long Value) { throw null; }
        public static string ToString(object Value) { throw null; }
        public static string ToString(float Value) { throw null; }
        public static string ToString(float Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInteger(object Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInteger(string Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToULong(object Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToULong(string Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUShort(object Value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUShort(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class DateType
    {
        internal DateType() { }
        public static System.DateTime FromObject(object Value) { throw null; }
        public static System.DateTime FromString(string Value) { throw null; }
        public static System.DateTime FromString(string Value, System.Globalization.CultureInfo culture) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class DecimalType
    {
        internal DecimalType() { }
        public static decimal FromBoolean(bool Value) { throw null; }
        public static decimal FromObject(object Value) { throw null; }
        public static decimal FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static decimal FromString(string Value) { throw null; }
        public static decimal FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static decimal Parse(string Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class DesignerGeneratedAttribute : System.Attribute
    {
        public DesignerGeneratedAttribute() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class DoubleType
    {
        internal DoubleType() { }
        public static double FromObject(object Value) { throw null; }
        public static double FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static double FromString(string Value) { throw null; }
        public static double FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static double Parse(string Value) { throw null; }
        public static double Parse(string Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ExceptionUtils
    {
        internal ExceptionUtils() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class FlowControl
    {
        internal FlowControl() { }
        public static void CheckForSyncLockOnValueType(object obj) { }
        public static System.Collections.IEnumerator ForEachInArr(System.Array ary) { throw null; }
        public static System.Collections.IEnumerator ForEachInObj(object obj) { throw null; }
        public static bool ForEachNextObj(ref object obj, System.Collections.IEnumerator enumerator) { throw null; }
        public static bool ForLoopInitObj(object Counter, object Start, object Limit, object StepValue, ref object LoopForResult, ref object CounterResult) { throw null; }
        public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue) { throw null; }
        public static bool ForNextCheckObj(object Counter, object LoopObj, ref object CounterResult) { throw null; }
        public static bool ForNextCheckR4(float count, float limit, float StepValue) { throw null; }
        public static bool ForNextCheckR8(double count, double limit, double StepValue) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(2))]
    public sealed partial class HostServices
    {
        public HostServices() { }
        public static Microsoft.VisualBasic.CompilerServices.IVbHost VBHost { get { throw null; } set { } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.SerializableAttribute]
    public sealed partial class IncompleteInitialization : System.Exception
    {
        public IncompleteInitialization() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public IncompleteInitialization(string message) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public IncompleteInitialization(string message, System.Exception innerException) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class IntegerType
    {
        internal IntegerType() { }
        public static int FromObject(object Value) { throw null; }
        public static int FromString(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.SerializableAttribute]
    public sealed partial class InternalErrorException : System.Exception
    {
        public InternalErrorException() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public InternalErrorException(string message) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public InternalErrorException(string message, System.Exception innerException) { }
    }
#if false
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    public sealed partial class InternalXmlHelper
    {
        internal InternalXmlHelper() { }
        [System.Runtime.CompilerServices.IndexerName("AttributeValue")]
        public static string this[System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source, System.Xml.Linq.XName name] { get { throw null; } set { } }
        [System.Runtime.CompilerServices.IndexerName("AttributeValue")]
        public static string this[System.Xml.Linq.XElement source, System.Xml.Linq.XName name] { get { throw null; } set { } }
        [System.Runtime.CompilerServices.IndexerName("Value")]
        public static string this[System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source] { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static System.Xml.Linq.XAttribute CreateAttribute(System.Xml.Linq.XName name, object value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static System.Xml.Linq.XAttribute CreateNamespaceAttribute(System.Xml.Linq.XName name, System.Xml.Linq.XNamespace ns) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static System.Collections.IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, System.Xml.Linq.XNamespace[] inScopeNs, System.Collections.Generic.List<System.Xml.Linq.XAttribute> attributes, System.Collections.IEnumerable obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static object RemoveNamespaceAttributes(string[] inScopePrefixes, System.Xml.Linq.XNamespace[] inScopeNs, System.Collections.Generic.List<System.Xml.Linq.XAttribute> attributes, object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static System.Xml.Linq.XElement RemoveNamespaceAttributes(string[] inScopePrefixes, System.Xml.Linq.XNamespace[] inScopeNs, System.Collections.Generic.List<System.Xml.Linq.XAttribute> attributes, System.Xml.Linq.XElement e) { throw null; }
    }
#endif
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial interface IVbHost
    {
        System.Windows.Forms.IWin32Window GetParentWindow();
        string GetWindowTitle();
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class LateBinding
    {
        internal LateBinding() { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateCall(object o, System.Type objType, string name, object[] args, string[] paramnames, bool[] CopyBack) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static object LateGet(object o, System.Type objType, string name, object[] args, string[] paramnames, bool[] CopyBack) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static object LateIndexGet(object o, object[] args, string[] paramnames) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateIndexSet(object o, object[] args, string[] paramnames) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateIndexSetComplex(object o, object[] args, string[] paramnames, bool OptimisticSet, bool RValueBase) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateSet(object o, System.Type objType, string name, object[] args, string[] paramnames) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateSetComplex(object o, System.Type objType, string name, object[] args, string[] paramnames, bool OptimisticSet, bool RValueBase) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class LikeOperator
    {
        internal LikeOperator() { }
        public static object LikeObject(object Source, object Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { throw null; }
        public static bool LikeString(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class LongType
    {
        internal LongType() { }
        public static long FromObject(object Value) { throw null; }
        public static long FromString(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class NewLateBinding
    {
        internal NewLateBinding() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static object FallbackCall(object Instance, string MemberName, object[] Arguments, string[] ArgumentNames, bool IgnoreReturn) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static object FallbackGet(object Instance, string MemberName, object[] Arguments, string[] ArgumentNames) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static void FallbackIndexSet(object Instance, object[] Arguments, string[] ArgumentNames) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static void FallbackIndexSetComplex(object Instance, object[] Arguments, string[] ArgumentNames, bool OptimisticSet, bool RValueBase) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static object FallbackInvokeDefault1(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static object FallbackInvokeDefault2(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static void FallbackSet(object Instance, string MemberName, object[] Arguments) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static void FallbackSetComplex(object Instance, string MemberName, object[] Arguments, bool OptimisticSet, bool RValueBase) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static object LateCall(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool[] CopyBack, bool IgnoreReturn) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static object LateCallInvokeDefault(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static bool LateCanEvaluate(object instance, System.Type type, string memberName, object[] arguments, bool allowFunctionEvaluation, bool allowPropertyEvaluation) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static object LateGet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool[] CopyBack) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static object LateGetInvokeDefault(object Instance, object[] Arguments, string[] ArgumentNames, bool ReportErrors) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static object LateIndexGet(object Instance, object[] Arguments, string[] ArgumentNames) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateIndexSet(object Instance, object[] Arguments, string[] ArgumentNames) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateIndexSetComplex(object Instance, object[] Arguments, string[] ArgumentNames, bool OptimisticSet, bool RValueBase) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateSet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateSet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase, Microsoft.VisualBasic.CallType CallType) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static void LateSetComplex(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ObjectFlowControl
    {
        internal ObjectFlowControl() { }
        public static void CheckForSyncLockOnValueType(object Expression) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public sealed partial class ForLoopControl
        {
            internal ForLoopControl() { }
            public static bool ForLoopInitObj(object Counter, object Start, object Limit, object StepValue, ref object LoopForResult, ref object CounterResult) { throw null; }
            public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue) { throw null; }
            public static bool ForNextCheckObj(object Counter, object LoopObj, ref object CounterResult) { throw null; }
            public static bool ForNextCheckR4(float count, float limit, float StepValue) { throw null; }
            public static bool ForNextCheckR8(double count, double limit, double StepValue) { throw null; }
        }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ObjectType
    {
        public ObjectType() { }
        public static object AddObj(object o1, object o2) { throw null; }
        public static object BitAndObj(object obj1, object obj2) { throw null; }
        public static object BitOrObj(object obj1, object obj2) { throw null; }
        public static object BitXorObj(object obj1, object obj2) { throw null; }
        public static object DivObj(object o1, object o2) { throw null; }
        public static object GetObjectValuePrimitive(object o) { throw null; }
        public static object IDivObj(object o1, object o2) { throw null; }
        public static bool LikeObj(object vLeft, object vRight, Microsoft.VisualBasic.CompareMethod CompareOption) { throw null; }
        public static object ModObj(object o1, object o2) { throw null; }
        public static object MulObj(object o1, object o2) { throw null; }
        public static object NegObj(object obj) { throw null; }
        public static object NotObj(object obj) { throw null; }
        public static int ObjTst(object o1, object o2, bool TextCompare) { throw null; }
        public static object PlusObj(object obj) { throw null; }
        public static object PowObj(object obj1, object obj2) { throw null; }
        public static object ShiftLeftObj(object o1, int amount) { throw null; }
        public static object ShiftRightObj(object o1, int amount) { throw null; }
        public static object StrCatObj(object vLeft, object vRight) { throw null; }
        public static object SubObj(object o1, object o2) { throw null; }
        public static object XorObj(object obj1, object obj2) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class Operators
    {
        internal Operators() { }
        public static object AddObject(object Left, object Right) { throw null; }
        public static object AndObject(object Left, object Right) { throw null; }
        public static int CompareObject(object Left, object Right, bool TextCompare) { throw null; }
        public static object CompareObjectEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static object CompareObjectGreater(object Left, object Right, bool TextCompare) { throw null; }
        public static object CompareObjectGreaterEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static object CompareObjectLess(object Left, object Right, bool TextCompare) { throw null; }
        public static object CompareObjectLessEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static object CompareObjectNotEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static int CompareString(string Left, string Right, bool TextCompare) { throw null; }
        public static object ConcatenateObject(object Left, object Right) { throw null; }
        public static bool ConditionalCompareObjectEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static bool ConditionalCompareObjectGreater(object Left, object Right, bool TextCompare) { throw null; }
        public static bool ConditionalCompareObjectGreaterEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static bool ConditionalCompareObjectLess(object Left, object Right, bool TextCompare) { throw null; }
        public static bool ConditionalCompareObjectLessEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static bool ConditionalCompareObjectNotEqual(object Left, object Right, bool TextCompare) { throw null; }
        public static object DivideObject(object Left, object Right) { throw null; }
        public static object ExponentObject(object Left, object Right) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.ObsoleteAttribute("do not use this method", true)]
        public static object FallbackInvokeUserDefinedOperator(object vbOp, object[] Arguments) { throw null; }
        public static object IntDivideObject(object Left, object Right) { throw null; }
        public static object LeftShiftObject(object Operand, object Amount) { throw null; }
        public static object LikeObject(object Source, object Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { throw null; }
        public static bool LikeString(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { throw null; }
        public static object ModObject(object Left, object Right) { throw null; }
        public static object MultiplyObject(object Left, object Right) { throw null; }
        public static object NegateObject(object Operand) { throw null; }
        public static object NotObject(object Operand) { throw null; }
        public static object OrObject(object Left, object Right) { throw null; }
        public static object PlusObject(object Operand) { throw null; }
        public static object RightShiftObject(object Operand, object Amount) { throw null; }
        public static object SubtractObject(object Left, object Right) { throw null; }
        public static object XorObject(object Left, object Right) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false, AllowMultiple=false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class OptionCompareAttribute : System.Attribute
    {
        public OptionCompareAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class OptionTextAttribute : System.Attribute
    {
        public OptionTextAttribute() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ProjectData
    {
        internal ProjectData() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        public static void ClearProjectError() { }
        public static System.Exception CreateProjectError(int hr) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(8))]
        public static void EndApp() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        public static void SetProjectError(System.Exception ex) { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        public static void SetProjectError(System.Exception ex, int lErl) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ShortType
    {
        internal ShortType() { }
        public static short FromObject(object Value) { throw null; }
        public static short FromString(string Value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class SingleType
    {
        internal SingleType() { }
        public static float FromObject(object Value) { throw null; }
        public static float FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static float FromString(string Value) { throw null; }
        public static float FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class StandardModuleAttribute : System.Attribute
    {
        public StandardModuleAttribute() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.SerializableAttribute]
    public sealed partial class StaticLocalInitFlag
    {
        public short State;
        public StaticLocalInitFlag() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class StringType
    {
        internal StringType() { }
        public static string FromBoolean(bool Value) { throw null; }
        public static string FromByte(byte Value) { throw null; }
        public static string FromChar(char Value) { throw null; }
        public static string FromDate(System.DateTime Value) { throw null; }
        public static string FromDecimal(decimal Value) { throw null; }
        public static string FromDecimal(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static string FromDouble(double Value) { throw null; }
        public static string FromDouble(double Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static string FromInteger(int Value) { throw null; }
        public static string FromLong(long Value) { throw null; }
        public static string FromObject(object Value) { throw null; }
        public static string FromShort(short Value) { throw null; }
        public static string FromSingle(float Value) { throw null; }
        public static string FromSingle(float Value, System.Globalization.NumberFormatInfo NumberFormat) { throw null; }
        public static void MidStmtStr(ref string sDest, int StartPosition, int MaxInsertLength, string sInsert) { }
        public static int StrCmp(string sLeft, string sRight, bool TextCompare) { throw null; }
        public static bool StrLike(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { throw null; }
        public static bool StrLikeBinary(string Source, string Pattern) { throw null; }
        public static bool StrLikeText(string Source, string Pattern) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class Utils
    {
        internal Utils() { }
        public static System.Array CopyArray(System.Array arySrc, System.Array aryDest) { throw null; }
        public static string GetResourceString(string ResourceKey, params string[] Args) { throw null; }
        public static string MethodToString(System.Reflection.MethodBase Method) { throw null; }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(32))]
        public static object SetCultureInfo(System.Globalization.CultureInfo Culture) { throw null; }
        public static void ThrowException(int hr) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class Versioned
    {
        internal Versioned() { }
        public static object CallByName(object Instance, string MethodName, Microsoft.VisualBasic.CallType UseCallType, params object[] Arguments) { throw null; }
        public static bool IsNumeric(object Expression) { throw null; }
        public static string SystemTypeName(string VbName) { throw null; }
        public static string TypeName(object Expression) { throw null; }
        public static string VbTypeName(string SystemName) { throw null; }
    }
}
namespace Microsoft.VisualBasic.Devices
{
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Audio
    {
        public Audio() { }
        public void Play(byte[] data, Microsoft.VisualBasic.AudioPlayMode playMode) { }
        public void Play(System.IO.Stream stream, Microsoft.VisualBasic.AudioPlayMode playMode) { }
        public void Play(string location) { }
        public void Play(string location, Microsoft.VisualBasic.AudioPlayMode playMode) { }
        public void PlaySystemSound(System.Media.SystemSound systemSound) { }
        public void Stop() { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Clock
    {
        public Clock() { }
        public System.DateTime GmtTime { get { throw null; } }
        public System.DateTime LocalTime { get { throw null; } }
        public int TickCount { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Computer : Microsoft.VisualBasic.Devices.ServerComputer
    {
        public Computer() { }
        public Microsoft.VisualBasic.Devices.Audio Audio { get { throw null; } }
        public Microsoft.VisualBasic.MyServices.ClipboardProxy Clipboard { get { throw null; } }
        public Microsoft.VisualBasic.Devices.Keyboard Keyboard { get { throw null; } }
        public Microsoft.VisualBasic.Devices.Mouse Mouse { get { throw null; } }
        public Microsoft.VisualBasic.Devices.Ports Ports { get { throw null; } }
        public System.Windows.Forms.Screen Screen { get { throw null; } }
    }
    [System.Diagnostics.DebuggerTypeProxyAttribute("Microsoft.VisualBasic.Devices.ComputerInfo.ComputerInfoDebugView")]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class ComputerInfo
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public ComputerInfo() { }
        [System.CLSCompliantAttribute(false)]
        public ulong AvailablePhysicalMemory { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public ulong AvailableVirtualMemory { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public System.Globalization.CultureInfo InstalledUICulture { get { throw null; } }
        public string OSFullName { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public string OSPlatform { get { throw null; } }
        public string OSVersion { get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public ulong TotalPhysicalMemory { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public ulong TotalVirtualMemory { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Keyboard
    {
        public Keyboard() { }
        public bool AltKeyDown { get { throw null; } }
        public bool CapsLock { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public bool CtrlKeyDown { get { throw null; } }
        public bool NumLock { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public bool ScrollLock { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public bool ShiftKeyDown { get { throw null; } }
        public void SendKeys(string keys) { }
        public void SendKeys(string keys, bool wait) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Mouse
    {
        public Mouse() { }
        public bool ButtonsSwapped { get { throw null; } }
        public bool WheelExists { get { throw null; } }
        public int WheelScrollLines { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Network
    {
        public Network() { }
        public bool IsAvailable { get { throw null; } }
        public event Microsoft.VisualBasic.Devices.NetworkAvailableEventHandler NetworkAvailabilityChanged { add { } remove { } }
        public void DownloadFile(string address, string destinationFileName) { }
        public void DownloadFile(string address, string destinationFileName, string userName, string password) { }
        public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite) { }
        public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void DownloadFile(System.Uri address, string destinationFileName) { }
        public void DownloadFile(System.Uri address, string destinationFileName, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void DownloadFile(System.Uri address, string destinationFileName, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password) { }
        public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite) { }
        public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public bool Ping(string hostNameOrAddress) { throw null; }
        public bool Ping(string hostNameOrAddress, int timeout) { throw null; }
        public bool Ping(System.Uri address) { throw null; }
        public bool Ping(System.Uri address, int timeout) { throw null; }
        public void UploadFile(string sourceFileName, string address) { }
        public void UploadFile(string sourceFileName, string address, string userName, string password) { }
        public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout) { }
        public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void UploadFile(string sourceFileName, System.Uri address) { }
        public void UploadFile(string sourceFileName, System.Uri address, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout) { }
        public void UploadFile(string sourceFileName, System.Uri address, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void UploadFile(string sourceFileName, System.Uri address, string userName, string password) { }
        public void UploadFile(string sourceFileName, System.Uri address, string userName, string password, bool showUI, int connectionTimeout) { }
        public void UploadFile(string sourceFileName, System.Uri address, string userName, string password, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    }
    public partial class NetworkAvailableEventArgs : System.EventArgs
    {
        public NetworkAvailableEventArgs(bool networkAvailable) { }
        public bool IsNetworkAvailable { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public delegate void NetworkAvailableEventHandler(object sender, Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs e);
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Ports
    {
        public Ports() { }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> SerialPortNames { get { throw null; } }
        public System.IO.Ports.SerialPort OpenSerialPort(string portName) { throw null; }
        public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate) { throw null; }
        public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity) { throw null; }
        public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits) { throw null; }
        public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits, System.IO.Ports.StopBits stopBits) { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class ServerComputer
    {
        public ServerComputer() { }
        public Microsoft.VisualBasic.Devices.Clock Clock { get { throw null; } }
        public Microsoft.VisualBasic.MyServices.FileSystemProxy FileSystem { get { throw null; } }
        public Microsoft.VisualBasic.Devices.ComputerInfo Info { get { throw null; } }
        public string Name { get { throw null; } }
        public Microsoft.VisualBasic.Devices.Network Network { get { throw null; } }
        public Microsoft.VisualBasic.MyServices.RegistryProxy Registry { get { throw null; } }
    }
}
namespace Microsoft.VisualBasic.FileIO
{
    public enum DeleteDirectoryOption
    {
        DeleteAllContents = 5,
        ThrowIfDirectoryNonEmpty = 4,
    }
    public enum FieldType
    {
        Delimited = 0,
        FixedWidth = 1,
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class FileSystem
    {
        public FileSystem() { }
        public static string CurrentDirectory { get { throw null; } set { } }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> Drives { get { throw null; } }
        public static string CombinePath(string baseDirectory, string relativePath) { throw null; }
        public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
        public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
        public static void CopyFile(string sourceFileName, string destinationFileName) { }
        public static void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public static void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public static void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) { }
        public static void CreateDirectory(string directory) { }
        public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption onDirectoryNotEmpty) { }
        public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
        public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public static void DeleteFile(string file) { }
        public static void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
        public static void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public static bool DirectoryExists(string directory) { throw null; }
        public static bool FileExists(string file) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] fileWildcards) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetDirectories(string directory) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetDirectories(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] wildcards) { throw null; }
        public static System.IO.DirectoryInfo GetDirectoryInfo(string directory) { throw null; }
        public static System.IO.DriveInfo GetDriveInfo(string drive) { throw null; }
        public static System.IO.FileInfo GetFileInfo(string file) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetFiles(string directory) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetFiles(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] wildcards) { throw null; }
        public static string GetName(string path) { throw null; }
        public static string GetParentPath(string path) { throw null; }
        public static string GetTempFileName() { throw null; }
        public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
        public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
        public static void MoveFile(string sourceFileName, string destinationFileName) { }
        public static void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public static void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public static void MoveFile(string sourceFileName, string destinationFileName, bool overwrite) { }
        public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file) { throw null; }
        public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params int[] fieldWidths) { throw null; }
        public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params string[] delimiters) { throw null; }
        public static System.IO.StreamReader OpenTextFileReader(string file) { throw null; }
        public static System.IO.StreamReader OpenTextFileReader(string file, System.Text.Encoding encoding) { throw null; }
        public static System.IO.StreamWriter OpenTextFileWriter(string file, bool append) { throw null; }
        public static System.IO.StreamWriter OpenTextFileWriter(string file, bool append, System.Text.Encoding encoding) { throw null; }
        public static byte[] ReadAllBytes(string file) { throw null; }
        public static string ReadAllText(string file) { throw null; }
        public static string ReadAllText(string file, System.Text.Encoding encoding) { throw null; }
        public static void RenameDirectory(string directory, string newName) { }
        public static void RenameFile(string file, string newName) { }
        public static void WriteAllBytes(string file, byte[] data, bool append) { }
        public static void WriteAllText(string file, string text, bool append) { }
        public static void WriteAllText(string file, string text, bool append, System.Text.Encoding encoding) { }
    }
    [System.SerializableAttribute]
    public partial class MalformedLineException : System.Exception
    {
        public MalformedLineException() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        protected MalformedLineException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MalformedLineException(string message) { }
        public MalformedLineException(string message, System.Exception innerException) { }
        public MalformedLineException(string message, long lineNumber) { }
        public MalformedLineException(string message, long lineNumber, System.Exception innerException) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(0))]
        public long LineNumber { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        [System.Security.SecurityCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public enum RecycleOption
    {
        DeletePermanently = 2,
        SendToRecycleBin = 3,
    }
    public enum SearchOption
    {
        SearchAllSubDirectories = 3,
        SearchTopLevelOnly = 2,
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class SpecialDirectories
    {
        public SpecialDirectories() { }
        public static string AllUsersApplicationData { get { throw null; } }
        public static string CurrentUserApplicationData { get { throw null; } }
        public static string Desktop { get { throw null; } }
        public static string MyDocuments { get { throw null; } }
        public static string MyMusic { get { throw null; } }
        public static string MyPictures { get { throw null; } }
        public static string ProgramFiles { get { throw null; } }
        public static string Programs { get { throw null; } }
        public static string Temp { get { throw null; } }
    }
    public partial class TextFieldParser : System.IDisposable
    {
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(System.IO.Stream stream) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding, bool leaveOpen) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(System.IO.TextReader reader) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(string path) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(string path, System.Text.Encoding defaultEncoding) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public TextFieldParser(string path, System.Text.Encoding defaultEncoding, bool detectEncoding) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public string[] CommentTokens { get { throw null; } set { } }
        public string[] Delimiters { get { throw null; } set { } }
        public bool EndOfData { get { throw null; } }
        public string ErrorLine { get { throw null; } }
        public long ErrorLineNumber { get { throw null; } }
        public int[] FieldWidths { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public bool HasFieldsEnclosedInQuotes { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public long LineNumber { get { throw null; } }
        public Microsoft.VisualBasic.FileIO.FieldType TextFieldType { get { throw null; } set { } }
        public bool TrimWhiteSpace { get { throw null; } set { } }
        public void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~TextFieldParser() { }
        public string PeekChars(int numberOfChars) { throw null; }
        public string[] ReadFields() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public string ReadLine() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public string ReadToEnd() { throw null; }
        public void SetDelimiters(params string[] delimiters) { }
        public void SetFieldWidths(params int[] fieldWidths) { }
    }
    public enum UICancelOption
    {
        DoNothing = 2,
        ThrowException = 3,
    }
    public enum UIOption
    {
        AllDialogs = 3,
        OnlyErrorDialogs = 2,
    }
}
namespace Microsoft.VisualBasic.Logging
{
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class AspLog : Microsoft.VisualBasic.Logging.Log
    {
        public AspLog() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public AspLog(string name) { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected internal override void InitializeWithDefaultsSinceNoConfigExists() { }
    }
    public enum DiskSpaceExhaustedOption
    {
        DiscardMessages = 1,
        ThrowException = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class FileLogTraceListener : System.Diagnostics.TraceListener
    {
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public FileLogTraceListener() { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
        public FileLogTraceListener(string name) { }
        public bool Append { get { throw null; } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public bool AutoFlush { get { throw null; } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public string BaseFileName { get { throw null; } set { } }
        public string CustomLocation { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } set { } }
        public string Delimiter { get { throw null; } set { } }
        public Microsoft.VisualBasic.Logging.DiskSpaceExhaustedOption DiskSpaceExhaustedBehavior { get { throw null; } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public string FullLogFileName { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public bool IncludeHostName { get { throw null; } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public Microsoft.VisualBasic.Logging.LogFileLocation Location { get { throw null; } set { } }
        public Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption LogFileCreationSchedule { get { throw null; } set { } }
        public long MaxFileSize { get { throw null; } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public long ReserveDiskSpace { get { throw null; } [System.Security.SecuritySafeCriticalAttribute]set { } }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void Close() { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        protected override void Dispose(bool disposing) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void Flush() { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        protected override string[] GetSupportedAttributes() { throw null; }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void Write(string message) { }
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Synchronization=true)]
        public override void WriteLine(string message) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class Log
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public Log() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public Log(string name) { }
        public Microsoft.VisualBasic.Logging.FileLogTraceListener DefaultFileLogWriter { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Diagnostics.TraceSource TraceSource { get { throw null; } }
        [System.Security.SecuritySafeCriticalAttribute]
        protected internal virtual void InitializeWithDefaultsSinceNoConfigExists() { }
        public void WriteEntry(string message) { }
        public void WriteEntry(string message, System.Diagnostics.TraceEventType severity) { }
        public void WriteEntry(string message, System.Diagnostics.TraceEventType severity, int id) { }
        public void WriteException(System.Exception ex) { }
        public void WriteException(System.Exception ex, System.Diagnostics.TraceEventType severity, string additionalInfo) { }
        public void WriteException(System.Exception ex, System.Diagnostics.TraceEventType severity, string additionalInfo, int id) { }
    }
    public enum LogFileCreationScheduleOption
    {
        Daily = 1,
        None = 0,
        Weekly = 2,
    }
    public enum LogFileLocation
    {
        CommonApplicationDirectory = 2,
        Custom = 4,
        ExecutableDirectory = 3,
        LocalUserApplicationDirectory = 1,
        TempDirectory = 0,
    }
}
namespace Microsoft.VisualBasic.MyServices
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class ClipboardProxy
    {
        internal ClipboardProxy() { }
        public void Clear() { }
        public bool ContainsAudio() { throw null; }
        public bool ContainsData(string format) { throw null; }
        public bool ContainsFileDropList() { throw null; }
        public bool ContainsImage() { throw null; }
        public bool ContainsText() { throw null; }
        public bool ContainsText(System.Windows.Forms.TextDataFormat format) { throw null; }
        public System.IO.Stream GetAudioStream() { throw null; }
        public object GetData(string format) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Windows.Forms.IDataObject GetDataObject() { throw null; }
        public System.Collections.Specialized.StringCollection GetFileDropList() { throw null; }
        public System.Drawing.Image GetImage() { throw null; }
        public string GetText() { throw null; }
        public string GetText(System.Windows.Forms.TextDataFormat format) { throw null; }
        public void SetAudio(byte[] audioBytes) { }
        public void SetAudio(System.IO.Stream audioStream) { }
        public void SetData(string format, object data) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public void SetDataObject(System.Windows.Forms.DataObject data) { }
        public void SetFileDropList(System.Collections.Specialized.StringCollection filePaths) { }
        public void SetImage(System.Drawing.Image image) { }
        public void SetText(string text) { }
        public void SetText(string text, System.Windows.Forms.TextDataFormat format) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class FileSystemProxy
    {
        internal FileSystemProxy() { }
        public string CurrentDirectory { get { throw null; } set { } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> Drives { get { throw null; } }
        public Microsoft.VisualBasic.MyServices.SpecialDirectoriesProxy SpecialDirectories { get { throw null; } }
        public string CombinePath(string baseDirectory, string relativePath) { throw null; }
        public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
        public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
        public void CopyFile(string sourceFileName, string destinationFileName) { }
        public void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) { }
        public void CreateDirectory(string directory) { }
        public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption onDirectoryNotEmpty) { }
        public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
        public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void DeleteFile(string file) { }
        public void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
        public void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public bool DirectoryExists(string directory) { throw null; }
        public bool FileExists(string file) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] fileWildcards) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> GetDirectories(string directory) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> GetDirectories(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] wildcards) { throw null; }
        public System.IO.DirectoryInfo GetDirectoryInfo(string directory) { throw null; }
        public System.IO.DriveInfo GetDriveInfo(string drive) { throw null; }
        public System.IO.FileInfo GetFileInfo(string file) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> GetFiles(string directory) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> GetFiles(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params string[] wildcards) { throw null; }
        public string GetName(string path) { throw null; }
        public string GetParentPath(string path) { throw null; }
        public string GetTempFileName() { throw null; }
        public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
        public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
        public void MoveFile(string sourceFileName, string destinationFileName) { }
        public void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
        public void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
        public void MoveFile(string sourceFileName, string destinationFileName, bool overwrite) { }
        public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file) { throw null; }
        public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params int[] fieldWidths) { throw null; }
        public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params string[] delimiters) { throw null; }
        public System.IO.StreamReader OpenTextFileReader(string file) { throw null; }
        public System.IO.StreamReader OpenTextFileReader(string file, System.Text.Encoding encoding) { throw null; }
        public System.IO.StreamWriter OpenTextFileWriter(string file, bool append) { throw null; }
        public System.IO.StreamWriter OpenTextFileWriter(string file, bool append, System.Text.Encoding encoding) { throw null; }
        public byte[] ReadAllBytes(string file) { throw null; }
        public string ReadAllText(string file) { throw null; }
        public string ReadAllText(string file, System.Text.Encoding encoding) { throw null; }
        public void RenameDirectory(string directory, string newName) { }
        public void RenameFile(string file, string newName) { }
        public void WriteAllBytes(string file, byte[] data, bool append) { }
        public void WriteAllText(string file, string text, bool append) { }
        public void WriteAllText(string file, string text, bool append, System.Text.Encoding encoding) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class RegistryProxy
    {
        internal RegistryProxy() { }
        public Microsoft.Win32.RegistryKey ClassesRoot { get { throw null; } }
        public Microsoft.Win32.RegistryKey CurrentConfig { get { throw null; } }
        public Microsoft.Win32.RegistryKey CurrentUser { get { throw null; } }
        [System.ObsoleteAttribute("The DynData registry key works only on Win9x, which is not supported by this version of the .NET Framework.  Use the PerformanceData registry key instead.  This property will be removed from a future version of the framework.")]
        public Microsoft.Win32.RegistryKey DynData { get { throw null; } }
        public Microsoft.Win32.RegistryKey LocalMachine { get { throw null; } }
        public Microsoft.Win32.RegistryKey PerformanceData { get { throw null; } }
        public Microsoft.Win32.RegistryKey Users { get { throw null; } }
        public object GetValue(string keyName, string valueName, object defaultValue) { throw null; }
        public void SetValue(string keyName, string valueName, object value) { }
        public void SetValue(string keyName, string valueName, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Resources=(System.Security.Permissions.HostProtectionResource)(4))]
    public partial class SpecialDirectoriesProxy
    {
        internal SpecialDirectoriesProxy() { }
        public string AllUsersApplicationData { get { throw null; } }
        public string CurrentUserApplicationData { get { throw null; } }
        public string Desktop { get { throw null; } }
        public string MyDocuments { get { throw null; } }
        public string MyMusic { get { throw null; } }
        public string MyPictures { get { throw null; } }
        public string ProgramFiles { get { throw null; } }
        public string Programs { get { throw null; } }
        public string Temp { get { throw null; } }
    }
}
namespace Microsoft.VisualBasic.MyServices.Internal
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class ContextValue<T>
    {
        public ContextValue() { }
        public T Value { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } [System.Security.SecuritySafeCriticalAttribute]set { } }
    }
}
