// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono Soft Debugger API library")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Debugger.Soft.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Debugger.Soft
{
    public partial class AbsentInformationException : System.Exception
    {
        public AbsentInformationException() { }
    }
    public partial class AppDomainCreateEvent : Mono.Debugger.Soft.Event
    {
        internal AppDomainCreateEvent() { }
        public Mono.Debugger.Soft.AppDomainMirror Domain { get { throw null; } }
    }
    public partial class AppDomainMirror : Mono.Debugger.Soft.Mirror
    {
        internal AppDomainMirror() { }
        public Mono.Debugger.Soft.AssemblyMirror Corlib { get { throw null; } }
        public string FriendlyName { get { throw null; } }
        public Mono.Debugger.Soft.ObjectMirror CreateBoxedValue(Mono.Debugger.Soft.Value value) { throw null; }
        public Mono.Debugger.Soft.StringMirror CreateString(string s) { throw null; }
        public Mono.Debugger.Soft.AssemblyMirror[] GetAssemblies() { throw null; }
        public Mono.Debugger.Soft.TypeMirror GetCorrespondingType(System.Type t) { throw null; }
        public Mono.Debugger.Soft.AssemblyMirror GetEntryAssembly() { throw null; }
    }
    public partial class AppDomainUnloadEvent : Mono.Debugger.Soft.Event
    {
        internal AppDomainUnloadEvent() { }
        public Mono.Debugger.Soft.AppDomainMirror Domain { get { throw null; } }
    }
    public partial class ArrayMirror : Mono.Debugger.Soft.ObjectMirror, System.Collections.IEnumerable
    {
        internal ArrayMirror() { }
        public int[] lengths;
        public int[] lower_bounds;
        public int rank;
        public Mono.Debugger.Soft.Value this[int index] { get { throw null; } set { } }
        public int Length { get { throw null; } }
        public int Rank { get { throw null; } }
        public int GetLength(int dimension) { throw null; }
        public int GetLowerBound(int dimension) { throw null; }
        public System.Collections.Generic.IList<Mono.Debugger.Soft.Value> GetValues(int index, int length) { throw null; }
        public void SetValues(int index, Mono.Debugger.Soft.Value[] values) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AssemblyLoadEvent : Mono.Debugger.Soft.Event
    {
        internal AssemblyLoadEvent() { }
        public Mono.Debugger.Soft.AssemblyMirror Assembly { get { throw null; } }
    }
    public sealed partial class AssemblyLoadEventRequest : Mono.Debugger.Soft.EventRequest
    {
        internal AssemblyLoadEventRequest() { }
    }
    public partial class AssemblyMirror : Mono.Debugger.Soft.Mirror
    {
        internal AssemblyMirror() { }
        public Mono.Debugger.Soft.AppDomainMirror Domain { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror EntryPoint { get { throw null; } }
        public string Location { get { throw null; } }
        public Mono.Debugger.Soft.ModuleMirror ManifestModule { get { throw null; } }
        public Mono.Cecil.AssemblyDefinition Metadata { get { throw null; } set { } }
        public Mono.Debugger.Soft.ObjectMirror GetAssemblyObject() { throw null; }
        public virtual System.Reflection.AssemblyName GetName() { throw null; }
        public Mono.Debugger.Soft.TypeMirror GetType(string name) { throw null; }
        public Mono.Debugger.Soft.TypeMirror GetType(string name, bool throwOnError) { throw null; }
        public Mono.Debugger.Soft.TypeMirror GetType(string name, bool throwOnError, bool ignoreCase) { throw null; }
    }
    public partial class AssemblyUnloadEvent : Mono.Debugger.Soft.Event
    {
        internal AssemblyUnloadEvent() { }
        public Mono.Debugger.Soft.AssemblyMirror Assembly { get { throw null; } }
    }
    public partial class BreakpointEvent : Mono.Debugger.Soft.Event
    {
        internal BreakpointEvent() { }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
    }
    public sealed partial class BreakpointEventRequest : Mono.Debugger.Soft.EventRequest
    {
        internal BreakpointEventRequest() { }
        public override void Enable() { }
    }
    public partial class CommandException : System.Exception
    {
        internal CommandException() { }
        public Mono.Debugger.Soft.ErrorCode ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public abstract partial class Connection
    {
        protected Connection() { }
        public void ForceDisconnect() { }
        public void StartBuffering() { }
        public void StopBuffering() { }
        protected abstract void TransportClose();
        protected abstract int TransportReceive(byte[] buf, int buf_offset, int len);
        protected abstract int TransportSend(byte[] buf, int buf_offset, int len);
        protected abstract void TransportSetTimeouts(int send_timeout, int receive_timeout);
        public long[] Type_GetMethodsByNameFlags(long id, string name, int flags, bool ignoreCase) { throw null; }
    }
    public sealed partial class CustomAttributeDataMirror
    {
        internal CustomAttributeDataMirror() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public Mono.Debugger.Soft.MethodMirror Constructor { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Collections.Generic.IList<Mono.Debugger.Soft.CustomAttributeTypedArgumentMirror> ConstructorArguments { get { throw null; } }
        public System.Collections.Generic.IList<Mono.Debugger.Soft.CustomAttributeNamedArgumentMirror> NamedArguments { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CustomAttributeNamedArgumentMirror
    {
        public Mono.Debugger.Soft.FieldInfoMirror Field { get { throw null; } }
        public Mono.Debugger.Soft.PropertyInfoMirror Property { get { throw null; } }
        public Mono.Debugger.Soft.CustomAttributeTypedArgumentMirror TypedValue { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CustomAttributeTypedArgumentMirror
    {
        public System.Type ArgumentType { get { throw null; } }
        public object Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class EnumMirror : Mono.Debugger.Soft.StructMirror
    {
        internal EnumMirror() { }
        public string StringValue { get { throw null; } }
        public object Value { get { throw null; } set { } }
    }
    public enum ErrorCode
    {
        ABSENT_INFORMATION = 105,
        ERR_NO_INVOCATION = 104,
        ERR_UNLOADED = 103,
        INVALID_ARGUMENT = 102,
        INVALID_FIELDID = 25,
        INVALID_FRAMEID = 30,
        INVALID_OBJECT = 20,
        INVOKE_ABORTED = 107,
        NONE = 0,
        NOT_IMPLEMENTED = 100,
        NOT_SUSPENDED = 101,
        NO_SEQ_POINT_AT_IL_OFFSET = 106,
    }
    public partial class ErrorHandlerEventArgs : System.EventArgs
    {
        public ErrorHandlerEventArgs() { }
        public Mono.Debugger.Soft.ErrorCode ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public abstract partial class Event
    {
        internal Event() { }
        protected Mono.Debugger.Soft.VirtualMachine vm;
        public Mono.Debugger.Soft.EventType EventType { get { throw null; } }
        public Mono.Debugger.Soft.EventRequest Request { get { throw null; } }
        public Mono.Debugger.Soft.ThreadMirror Thread { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class EventRequest
    {
        internal EventRequest() { }
        protected System.Collections.Generic.IList<Mono.Debugger.Soft.AssemblyMirror> assembly_filter;
        protected int count;
        protected bool enabled;
        protected Mono.Debugger.Soft.EventType etype;
        protected int id;
        protected Mono.Debugger.Soft.SuspendPolicy suspend;
        protected Mono.Debugger.Soft.ThreadMirror thread;
        protected Mono.Debugger.Soft.VirtualMachine vm;
        public System.Collections.Generic.IList<Mono.Debugger.Soft.AssemblyMirror> AssemblyFilter { get { throw null; } set { } }
        public int Count { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public Mono.Debugger.Soft.EventType EventType { get { throw null; } }
        public Mono.Debugger.Soft.ThreadMirror Thread { get { throw null; } set { } }
        protected void CheckDisabled() { }
        protected void CheckMirror(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.Mirror m) { }
        public void Disable() { }
        public virtual void Enable() { }
        protected void SetEnabled(int id) { }
    }
    public partial class EventSet
    {
        internal EventSet() { }
        protected Mono.Debugger.Soft.VirtualMachine vm;
        public Mono.Debugger.Soft.Event[] Events { get { throw null; } }
        public Mono.Debugger.Soft.Event this[int index] { get { throw null; } }
        public Mono.Debugger.Soft.SuspendPolicy SuspendPolicy { get { throw null; } }
    }
    public enum EventType
    {
        AppDomainCreate = 4,
        AppDomainUnload = 5,
        AssemblyLoad = 8,
        AssemblyUnload = 9,
        Breakpoint = 10,
        Exception = 13,
        KeepAlive = 14,
        MethodEntry = 6,
        MethodExit = 7,
        Step = 11,
        ThreadDeath = 3,
        ThreadStart = 2,
        TypeLoad = 12,
        UserBreak = 15,
        UserLog = 16,
        VMDeath = 1,
        VMDisconnect = 99,
        VMStart = 0,
    }
    public partial class ExceptionEvent : Mono.Debugger.Soft.Event
    {
        internal ExceptionEvent() { }
        public Mono.Debugger.Soft.ObjectMirror Exception { get { throw null; } }
    }
    public sealed partial class ExceptionEventRequest : Mono.Debugger.Soft.EventRequest
    {
        internal ExceptionEventRequest() { }
        public Mono.Debugger.Soft.TypeMirror ExceptionType { get { throw null; } }
        public bool IncludeSubclasses { get { throw null; } set { } }
        public override void Enable() { }
    }
    public partial class FieldInfoMirror : Mono.Debugger.Soft.Mirror
    {
        public FieldInfoMirror(Mono.Debugger.Soft.TypeMirror parent, long id, string name, Mono.Debugger.Soft.TypeMirror type, System.Reflection.FieldAttributes attrs) { }
        public FieldInfoMirror(Mono.Debugger.Soft.VirtualMachine vm, long id) { }
        public System.Reflection.FieldAttributes Attributes { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror DeclaringType { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror FieldType { get { throw null; } }
        public string FullName { get { throw null; } }
        public bool IsAssembly { get { throw null; } }
        public bool IsFamily { get { throw null; } }
        public bool IsFamilyAndAssembly { get { throw null; } }
        public bool IsFamilyOrAssembly { get { throw null; } }
        public bool IsInitOnly { get { throw null; } }
        public bool IsLiteral { get { throw null; } }
        public bool IsNotSerialized { get { throw null; } }
        public bool IsPinvokeImpl { get { throw null; } }
        public bool IsPrivate { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public Mono.Cecil.FieldDefinition Metadata { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { throw null; }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { throw null; }
    }
    public partial interface IInvokeAsyncResult : System.IAsyncResult
    {
        void Abort();
    }
    public partial class ILExceptionHandler
    {
        internal ILExceptionHandler() { }
        public Mono.Debugger.Soft.TypeMirror CatchType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int FilterOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int HandlerLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int HandlerOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.Debugger.Soft.ILExceptionHandlerType HandlerType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int TryLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int TryOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum ILExceptionHandlerType
    {
        Catch = 0,
        Fault = 4,
        Filter = 1,
        Finally = 2,
    }
    public partial class ILInstruction
    {
        internal ILInstruction() { }
        public Mono.Debugger.Soft.ILInstruction Next { get { throw null; } set { } }
        public int Offset { get { throw null; } }
        public Mono.Cecil.Cil.OpCode OpCode { get { throw null; } }
        public object Operand { get { throw null; } set { } }
        public Mono.Debugger.Soft.ILInstruction Previous { get { throw null; } set { } }
    }
    public partial interface IMirror
    {
        Mono.Debugger.Soft.VirtualMachine VirtualMachine { get; }
    }
    public partial class InterfaceMappingMirror : Mono.Debugger.Soft.Mirror
    {
        internal InterfaceMappingMirror() { }
        public Mono.Debugger.Soft.MethodMirror[] InterfaceMethods;
        public Mono.Debugger.Soft.TypeMirror InterfaceType;
        public Mono.Debugger.Soft.MethodMirror[] TargetMethods;
        public Mono.Debugger.Soft.TypeMirror TargetType;
    }
    public partial class InvalidStackFrameException : System.Exception
    {
        public InvalidStackFrameException() { }
    }
    public partial class InvocationException : System.Exception
    {
        public InvocationException(Mono.Debugger.Soft.ObjectMirror exception) { }
        public Mono.Debugger.Soft.ObjectMirror Exception { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum InvokeOptions
    {
        DisableBreakpoints = 1,
        None = 0,
        ReturnOutArgs = 8,
        ReturnOutThis = 4,
        SingleThreaded = 2,
        Virtual = 16,
    }
    public partial class InvokeResult
    {
        public InvokeResult() { }
        public Mono.Debugger.Soft.Value[] OutArgs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.Debugger.Soft.Value OutThis { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.Debugger.Soft.Value Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial interface ITargetProcess
    {
        bool HasExited { get; }
        int Id { get; }
        string ProcessName { get; }
        System.IO.StreamReader StandardError { get; }
        System.IO.StreamReader StandardOutput { get; }
        event System.EventHandler Exited;
        void Kill();
    }
    public partial class LaunchOptions
    {
        public LaunchOptions() { }
        public string AgentArgs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.Debugger.Soft.LaunchOptions.ProcessLauncher CustomProcessLauncher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.Debugger.Soft.LaunchOptions.TargetProcessLauncher CustomTargetProcessLauncher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Valgrind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public delegate System.Diagnostics.Process ProcessLauncher(System.Diagnostics.ProcessStartInfo info);
        public delegate Mono.Debugger.Soft.ITargetProcess TargetProcessLauncher(System.Diagnostics.ProcessStartInfo info);
    }
    public partial class LocalScope : Mono.Debugger.Soft.Mirror
    {
        internal LocalScope() { }
        public int LiveRangeEnd { get { throw null; } }
        public int LiveRangeStart { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
    }
    public partial class LocalVariable : Mono.Debugger.Soft.Mirror
    {
        internal LocalVariable() { }
        public int Index { get { throw null; } }
        public bool IsArg { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror Type { get { throw null; } }
    }
    public partial class Location : Mono.Debugger.Soft.Mirror
    {
        internal Location() { }
        public int ColumnNumber { get { throw null; } }
        public int EndColumnNumber { get { throw null; } }
        public int EndLineNumber { get { throw null; } }
        public int ILOffset { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
        public string SourceFile { get { throw null; } }
        public byte[] SourceFileHash { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class MethodBodyMirror : Mono.Debugger.Soft.Mirror
    {
        internal MethodBodyMirror() { }
        public System.Collections.Generic.List<Mono.Debugger.Soft.ILExceptionHandler> ExceptionHandlers { get { throw null; } }
        public System.Collections.Generic.List<Mono.Debugger.Soft.ILInstruction> Instructions { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
        public byte[] GetILAsByteArray() { throw null; }
    }
    public partial class MethodEntryEvent : Mono.Debugger.Soft.Event
    {
        internal MethodEntryEvent() { }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
    }
    public sealed partial class MethodEntryEventRequest : Mono.Debugger.Soft.EventRequest
    {
        internal MethodEntryEventRequest() { }
    }
    public partial class MethodExitEvent : Mono.Debugger.Soft.Event
    {
        internal MethodExitEvent() { }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
    }
    public sealed partial class MethodExitEventRequest : Mono.Debugger.Soft.EventRequest
    {
        internal MethodExitEventRequest() { }
    }
    public partial class MethodMirror : Mono.Debugger.Soft.Mirror
    {
        internal MethodMirror() { }
        public System.Reflection.MethodAttributes Attributes { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror DeclaringType { get { throw null; } }
        public string FullName { get { throw null; } }
        public System.Collections.Generic.IList<int> ILOffsets { get { throw null; } }
        public bool IsAbstract { get { throw null; } }
        public bool IsAssembly { get { throw null; } }
        public bool IsConstructor { get { throw null; } }
        public bool IsFamily { get { throw null; } }
        public bool IsFamilyAndAssembly { get { throw null; } }
        public bool IsFamilyOrAssembly { get { throw null; } }
        public bool IsFinal { get { throw null; } }
        public bool IsGenericMethod { get { throw null; } }
        public bool IsGenericMethodDefinition { get { throw null; } }
        public bool IsHideBySig { get { throw null; } }
        public bool IsPrivate { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public bool IsVirtual { get { throw null; } }
        public System.Collections.Generic.IList<int> LineNumbers { get { throw null; } }
        public System.Collections.Generic.IList<Mono.Debugger.Soft.Location> Locations { get { throw null; } }
        public Mono.Cecil.MethodDefinition Metadata { get { throw null; } }
        public int MetadataToken { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.Debugger.Soft.ParameterInfoMirror ReturnParameter { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror ReturnType { get { throw null; } }
        public string SourceFile { get { throw null; } }
        public Mono.Debugger.Soft.Value Evaluate(Mono.Debugger.Soft.Value this_val, Mono.Debugger.Soft.Value[] args) { throw null; }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { throw null; }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { throw null; }
        public Mono.Debugger.Soft.TypeMirror[] GetGenericArguments() { throw null; }
        public Mono.Debugger.Soft.MethodMirror GetGenericMethodDefinition() { throw null; }
        public Mono.Debugger.Soft.LocalVariable GetLocal(string name) { throw null; }
        public Mono.Debugger.Soft.LocalVariable[] GetLocals() { throw null; }
        public Mono.Debugger.Soft.MethodBodyMirror GetMethodBody() { throw null; }
        public System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { throw null; }
        public Mono.Debugger.Soft.ParameterInfoMirror[] GetParameters() { throw null; }
        public Mono.Debugger.Soft.LocalScope[] GetScopes() { throw null; }
        public Mono.Debugger.Soft.Location LocationAtILOffset(int il_offset) { throw null; }
        public Mono.Debugger.Soft.MethodMirror MakeGenericMethod(Mono.Debugger.Soft.TypeMirror[] args) { throw null; }
    }
    public abstract partial class Mirror : Mono.Debugger.Soft.IMirror
    {
        internal Mirror() { }
        protected long id;
        protected Mono.Debugger.Soft.VirtualMachine vm;
        public Mono.Debugger.Soft.VirtualMachine VirtualMachine { get { throw null; } }
        protected void CheckMirror(Mono.Debugger.Soft.Mirror m) { }
        protected void SetVirtualMachine(Mono.Debugger.Soft.VirtualMachine vm) { }
    }
    public partial class ModuleMirror : Mono.Debugger.Soft.Mirror
    {
        internal ModuleMirror() { }
        public Mono.Debugger.Soft.AssemblyMirror Assembly { get { throw null; } }
        public string FullyQualifiedName { get { throw null; } }
        public System.Guid ModuleVersionId { get { throw null; } }
        public string Name { get { throw null; } }
        public string ScopeName { get { throw null; } }
    }
    public partial class ObjectCollectedException : System.Exception
    {
        public ObjectCollectedException() { }
    }
    public partial class ObjectMirror : Mono.Debugger.Soft.Value
    {
        internal ObjectMirror() { }
        public long Address { get { throw null; } }
        public Mono.Debugger.Soft.AppDomainMirror Domain { get { throw null; } }
        public bool IsCollected { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror Type { get { throw null; } }
        public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        [System.ObsoleteAttribute("Use the overload without the 'vm' argument")]
        public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginInvokeMultiple(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror[] methods, System.Collections.Generic.IList<System.Collections.Generic.IList<Mono.Debugger.Soft.Value>> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { throw null; }
        public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { throw null; }
        public void EndInvokeMultiple(System.IAsyncResult asyncResult) { }
        public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.FieldInfoMirror field) { throw null; }
        public Mono.Debugger.Soft.Value[] GetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields) { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { throw null; }
        public System.Threading.Tasks.Task<Mono.Debugger.Soft.Value> InvokeMethodAsync(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options=(Mono.Debugger.Soft.InvokeOptions)(0)) { throw null; }
        public System.Threading.Tasks.Task<Mono.Debugger.Soft.InvokeResult> InvokeMethodAsyncWithResult(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options=(Mono.Debugger.Soft.InvokeOptions)(0)) { throw null; }
        public void SetValue(Mono.Debugger.Soft.FieldInfoMirror field, Mono.Debugger.Soft.Value value) { }
        public void SetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields, Mono.Debugger.Soft.Value[] values) { }
    }
    public partial class ParameterInfoMirror : Mono.Debugger.Soft.Mirror
    {
        internal ParameterInfoMirror() { }
        public System.Reflection.ParameterAttributes Attributes { get { throw null; } }
        public bool IsRetval { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror ParameterType { get { throw null; } }
        public int Position { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class PointerValue : Mono.Debugger.Soft.Value
    {
        public PointerValue(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.TypeMirror type, long addr) { }
        public long Address { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror Type { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PrimitiveValue : Mono.Debugger.Soft.Value
    {
        public PrimitiveValue(Mono.Debugger.Soft.VirtualMachine vm, object value) { }
        public object Value { get { throw null; } }
        public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { throw null; }
        public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PropertyInfoMirror : Mono.Debugger.Soft.Mirror
    {
        public PropertyInfoMirror(Mono.Debugger.Soft.TypeMirror parent, long id, string name, Mono.Debugger.Soft.MethodMirror get_method, Mono.Debugger.Soft.MethodMirror set_method, System.Reflection.PropertyAttributes attrs) { }
        public System.Reflection.PropertyAttributes Attributes { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror DeclaringType { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public Mono.Cecil.PropertyDefinition Metadata { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror PropertyType { get { throw null; } }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { throw null; }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { throw null; }
        public Mono.Debugger.Soft.MethodMirror GetGetMethod() { throw null; }
        public Mono.Debugger.Soft.MethodMirror GetGetMethod(bool nonPublic) { throw null; }
        public Mono.Debugger.Soft.ParameterInfoMirror[] GetIndexParameters() { throw null; }
        public Mono.Debugger.Soft.MethodMirror GetSetMethod() { throw null; }
        public Mono.Debugger.Soft.MethodMirror GetSetMethod(bool nonPublic) { throw null; }
    }
    public partial class StackFrame : Mono.Debugger.Soft.Mirror
    {
        internal StackFrame() { }
        public int ColumnNumber { get { throw null; } }
        public Mono.Debugger.Soft.AppDomainMirror Domain { get { throw null; } }
        public int EndColumnNumber { get { throw null; } }
        public int EndLineNumber { get { throw null; } }
        public string FileName { get { throw null; } }
        public int ILOffset { get { throw null; } }
        public bool IsDebuggerInvoke { get { throw null; } }
        public bool IsNativeTransition { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public Mono.Debugger.Soft.Location Location { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
        public Mono.Debugger.Soft.ThreadMirror Thread { get { throw null; } }
        public Mono.Debugger.Soft.Value GetArgument(int pos) { throw null; }
        public Mono.Debugger.Soft.Value GetThis() { throw null; }
        public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.LocalVariable var) { throw null; }
        public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.ParameterInfoMirror param) { throw null; }
        public Mono.Debugger.Soft.Value[] GetValues(Mono.Debugger.Soft.LocalVariable[] vars) { throw null; }
        public Mono.Debugger.Soft.LocalVariable GetVisibleVariableByName(string name) { throw null; }
        public System.Collections.Generic.IList<Mono.Debugger.Soft.LocalVariable> GetVisibleVariables() { throw null; }
        public void SetThis(Mono.Debugger.Soft.Value value) { }
        public void SetValue(Mono.Debugger.Soft.LocalVariable var, Mono.Debugger.Soft.Value value) { }
        public void SetValue(Mono.Debugger.Soft.ParameterInfoMirror param, Mono.Debugger.Soft.Value value) { }
    }
    public enum StepDepth
    {
        Into = 0,
        Out = 2,
        Over = 1,
    }
    public partial class StepEvent : Mono.Debugger.Soft.Event
    {
        internal StepEvent() { }
        public long Location { get { throw null; } }
        public Mono.Debugger.Soft.MethodMirror Method { get { throw null; } }
    }
    public sealed partial class StepEventRequest : Mono.Debugger.Soft.EventRequest
    {
        internal StepEventRequest() { }
        public Mono.Debugger.Soft.StepDepth Depth { get { throw null; } set { } }
        public Mono.Debugger.Soft.StepFilter Filter { get { throw null; } set { } }
        public Mono.Debugger.Soft.StepSize Size { get { throw null; } set { } }
        public new Mono.Debugger.Soft.ThreadMirror Thread { get { throw null; } }
        public override void Enable() { }
    }
    [System.FlagsAttribute]
    public enum StepFilter
    {
        DebuggerHidden = 2,
        DebuggerNonUserCode = 8,
        DebuggerStepThrough = 4,
        None = 0,
        StaticCtor = 1,
    }
    public enum StepSize
    {
        Line = 1,
        Min = 0,
    }
    public partial class StringMirror : Mono.Debugger.Soft.ObjectMirror
    {
        internal StringMirror() { }
        public int Length { get { throw null; } }
        public string Value { get { throw null; } }
        public char[] GetChars(int index, int length) { throw null; }
    }
    public partial class StructMirror : Mono.Debugger.Soft.Value
    {
        internal StructMirror() { }
        public Mono.Debugger.Soft.Value[] Fields { get { throw null; } }
        public Mono.Debugger.Soft.Value this[string field] { get { throw null; } set { } }
        public Mono.Debugger.Soft.TypeMirror Type { get { throw null; } }
        public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        [System.ObsoleteAttribute("Use the overload without the 'vm' argument")]
        public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { throw null; }
        public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { throw null; }
        public System.Threading.Tasks.Task<Mono.Debugger.Soft.Value> InvokeMethodAsync(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options=(Mono.Debugger.Soft.InvokeOptions)(0)) { throw null; }
        public System.Threading.Tasks.Task<Mono.Debugger.Soft.InvokeResult> InvokeMethodAsyncWithResult(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options=(Mono.Debugger.Soft.InvokeOptions)(0)) { throw null; }
    }
    public enum SuspendPolicy
    {
        All = 2,
        EventThread = 1,
        None = 0,
    }
    public partial class ThreadDeathEvent : Mono.Debugger.Soft.Event
    {
        internal ThreadDeathEvent() { }
    }
    public partial class ThreadMirror : Mono.Debugger.Soft.ObjectMirror
    {
        internal ThreadMirror() { }
        public long Id { get { throw null; } }
        public bool IsThreadPoolThread { get { throw null; } }
        public string Name { get { throw null; } }
        public static bool NativeTransitions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public long ThreadId { get { throw null; } }
        public System.Threading.ThreadState ThreadState { get { throw null; } }
        public long TID { get { throw null; } }
        public static void FetchFrames(System.Collections.Generic.IList<Mono.Debugger.Soft.ThreadMirror> threads) { }
        public Mono.Debugger.Soft.StackFrame[] GetFrames() { throw null; }
        public void SetIP(Mono.Debugger.Soft.Location loc) { }
    }
    public partial class ThreadStartEvent : Mono.Debugger.Soft.Event
    {
        internal ThreadStartEvent() { }
    }
    public partial class TypeLoadEvent : Mono.Debugger.Soft.Event
    {
        internal TypeLoadEvent() { }
        public Mono.Debugger.Soft.TypeMirror Type { get { throw null; } }
    }
    public sealed partial class TypeLoadEventRequest : Mono.Debugger.Soft.EventRequest
    {
        internal TypeLoadEventRequest() { }
        public string[] SourceFileFilter { get { throw null; } set { } }
        public string[] TypeNameFilter { get { throw null; } set { } }
        public override void Enable() { }
    }
    public partial class TypeMirror : Mono.Debugger.Soft.Mirror
    {
        internal TypeMirror() { }
        public Mono.Debugger.Soft.AssemblyMirror Assembly { get { throw null; } }
        public System.Reflection.TypeAttributes Attributes { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror BaseType { get { throw null; } }
        public string CSharpName { get { throw null; } }
        public Mono.Debugger.Soft.TypeMirror EnumUnderlyingType { get { throw null; } }
        public string FullName { get { throw null; } }
        public bool HasElementType { get { throw null; } }
        public bool IsAbstract { get { throw null; } }
        public bool IsAnsiClass { get { throw null; } }
        public bool IsArray { get { throw null; } }
        public bool IsAutoClass { get { throw null; } }
        public bool IsAutoLayout { get { throw null; } }
        public bool IsByRef { get { throw null; } }
        public bool IsClass { get { throw null; } }
        public bool IsCOMObject { get { throw null; } }
        public bool IsContextful { get { throw null; } }
        public bool IsEnum { get { throw null; } }
        public bool IsExplicitLayout { get { throw null; } }
        public bool IsGenericType { get { throw null; } }
        public bool IsGenericTypeDefinition { get { throw null; } }
        public bool IsImport { get { throw null; } }
        public bool IsInitialized { get { throw null; } }
        public bool IsInterface { get { throw null; } }
        public bool IsLayoutSequential { get { throw null; } }
        public bool IsMarshalByRef { get { throw null; } }
        public bool IsNested { get { throw null; } }
        public bool IsNestedAssembly { get { throw null; } }
        public bool IsNestedFamANDAssem { get { throw null; } }
        public bool IsNestedFamily { get { throw null; } }
        public bool IsNestedFamORAssem { get { throw null; } }
        public bool IsNestedPrivate { get { throw null; } }
        public bool IsNestedPublic { get { throw null; } }
        public bool IsNotPublic { get { throw null; } }
        public bool IsPointer { get { throw null; } }
        public bool IsPrimitive { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public bool IsSealed { get { throw null; } }
        public bool IsSerializable { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public bool IsUnicodeClass { get { throw null; } }
        public bool IsValueType { get { throw null; } }
        public Mono.Cecil.TypeDefinition Metadata { get { throw null; } }
        public int MetadataToken { get { throw null; } }
        public Mono.Debugger.Soft.ModuleMirror Module { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        [System.ObsoleteAttribute("Use the overload without the 'vm' argument")]
        public System.IAsyncResult BeginInvokeMethod(Mono.Debugger.Soft.VirtualMachine vm, Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options, System.AsyncCallback callback, object state) { throw null; }
        public Mono.Debugger.Soft.Value EndInvokeMethod(System.IAsyncResult asyncResult) { throw null; }
        public Mono.Debugger.Soft.InvokeResult EndInvokeMethodWithResult(System.IAsyncResult asyncResult) { throw null; }
        public int GetArrayRank() { throw null; }
        protected virtual System.Reflection.TypeAttributes GetAttributeFlagsImpl() { throw null; }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(Mono.Debugger.Soft.TypeMirror attributeType, bool inherit) { throw null; }
        public Mono.Debugger.Soft.CustomAttributeDataMirror[] GetCustomAttributes(bool inherit) { throw null; }
        public Mono.Debugger.Soft.TypeMirror GetElementType() { throw null; }
        public Mono.Debugger.Soft.FieldInfoMirror GetField(string name) { throw null; }
        public Mono.Debugger.Soft.FieldInfoMirror[] GetFields() { throw null; }
        public Mono.Debugger.Soft.TypeMirror[] GetGenericArguments() { throw null; }
        public Mono.Debugger.Soft.TypeMirror GetGenericTypeDefinition() { throw null; }
        public Mono.Debugger.Soft.InterfaceMappingMirror GetInterfaceMap(Mono.Debugger.Soft.TypeMirror interfaceType) { throw null; }
        public Mono.Debugger.Soft.TypeMirror[] GetInterfaces() { throw null; }
        public Mono.Debugger.Soft.MethodMirror GetMethod(string name) { throw null; }
        public Mono.Debugger.Soft.MethodMirror[] GetMethods() { throw null; }
        public Mono.Debugger.Soft.MethodMirror[] GetMethodsByNameFlags(string name, System.Reflection.BindingFlags flags, bool ignoreCase) { throw null; }
        public Mono.Debugger.Soft.TypeMirror[] GetNestedTypes() { throw null; }
        public Mono.Debugger.Soft.TypeMirror[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public Mono.Debugger.Soft.PropertyInfoMirror[] GetProperties() { throw null; }
        public Mono.Debugger.Soft.PropertyInfoMirror[] GetProperties(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public Mono.Debugger.Soft.PropertyInfoMirror GetProperty(string name) { throw null; }
        public string[] GetSourceFiles() { throw null; }
        public string[] GetSourceFiles(bool returnFullPaths) { throw null; }
        public Mono.Debugger.Soft.ObjectMirror GetTypeObject() { throw null; }
        public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.FieldInfoMirror field) { throw null; }
        public Mono.Debugger.Soft.Value GetValue(Mono.Debugger.Soft.FieldInfoMirror field, Mono.Debugger.Soft.ThreadMirror thread) { throw null; }
        public Mono.Debugger.Soft.Value[] GetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields) { throw null; }
        public Mono.Debugger.Soft.Value[] GetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields, Mono.Debugger.Soft.ThreadMirror thread) { throw null; }
        protected virtual bool HasElementTypeImpl() { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { throw null; }
        public Mono.Debugger.Soft.Value InvokeMethod(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { throw null; }
        public System.Threading.Tasks.Task<Mono.Debugger.Soft.Value> InvokeMethodAsync(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options=(Mono.Debugger.Soft.InvokeOptions)(0)) { throw null; }
        protected virtual bool IsArrayImpl() { throw null; }
        public virtual bool IsAssignableFrom(Mono.Debugger.Soft.TypeMirror c) { throw null; }
        protected virtual bool IsByRefImpl() { throw null; }
        protected virtual bool IsCOMObjectImpl() { throw null; }
        protected virtual bool IsContextfulImpl() { throw null; }
        protected virtual bool IsMarshalByRefImpl() { throw null; }
        protected virtual bool IsPointerImpl() { throw null; }
        protected virtual bool IsPrimitiveImpl() { throw null; }
        protected virtual bool IsValueTypeImpl() { throw null; }
        public Mono.Debugger.Soft.Value NewInstance() { throw null; }
        public Mono.Debugger.Soft.Value NewInstance(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments) { throw null; }
        public Mono.Debugger.Soft.Value NewInstance(Mono.Debugger.Soft.ThreadMirror thread, Mono.Debugger.Soft.MethodMirror method, System.Collections.Generic.IList<Mono.Debugger.Soft.Value> arguments, Mono.Debugger.Soft.InvokeOptions options) { throw null; }
        public void SetValue(Mono.Debugger.Soft.FieldInfoMirror field, Mono.Debugger.Soft.Value value) { }
        public void SetValues(System.Collections.Generic.IList<Mono.Debugger.Soft.FieldInfoMirror> fields, Mono.Debugger.Soft.Value[] values) { }
    }
    public partial class UserBreakEvent : Mono.Debugger.Soft.Event
    {
        internal UserBreakEvent() { }
    }
    public partial class UserLogEvent : Mono.Debugger.Soft.Event
    {
        internal UserLogEvent() { }
        public string Category { get { throw null; } }
        public int Level { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public abstract partial class Value : Mono.Debugger.Soft.Mirror
    {
        internal Value() { }
    }
    public partial class VersionInfo
    {
        public VersionInfo() { }
        public int MajorVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MinorVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string VMVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool AtLeast(int major, int minor) { throw null; }
    }
    public partial class VirtualMachine : Mono.Debugger.Soft.Mirror
    {
        internal VirtualMachine() { }
        public System.Net.EndPoint EndPoint { get { throw null; } }
        public System.Diagnostics.Process Process { get { throw null; } }
        public Mono.Debugger.Soft.AppDomainMirror RootDomain { get { throw null; } }
        public System.IO.StreamReader StandardError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.IO.StreamReader StandardOutput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.Debugger.Soft.ITargetProcess TargetProcess { get { throw null; } }
        public Mono.Debugger.Soft.VersionInfo Version { get { throw null; } }
        public void ClearAllBreakpoints() { }
        public Mono.Debugger.Soft.AssemblyLoadEventRequest CreateAssemblyLoadRequest() { throw null; }
        public Mono.Debugger.Soft.BreakpointEventRequest CreateBreakpointRequest(Mono.Debugger.Soft.Location loc) { throw null; }
        public Mono.Debugger.Soft.BreakpointEventRequest CreateBreakpointRequest(Mono.Debugger.Soft.MethodMirror method, long il_offset) { throw null; }
        public Mono.Debugger.Soft.EnumMirror CreateEnumMirror(Mono.Debugger.Soft.TypeMirror type, Mono.Debugger.Soft.PrimitiveValue value) { throw null; }
        public Mono.Debugger.Soft.ExceptionEventRequest CreateExceptionRequest(Mono.Debugger.Soft.TypeMirror exc_type) { throw null; }
        public Mono.Debugger.Soft.ExceptionEventRequest CreateExceptionRequest(Mono.Debugger.Soft.TypeMirror exc_type, bool caught, bool uncaught) { throw null; }
        public Mono.Debugger.Soft.MethodEntryEventRequest CreateMethodEntryRequest() { throw null; }
        public Mono.Debugger.Soft.MethodExitEventRequest CreateMethodExitRequest() { throw null; }
        public Mono.Debugger.Soft.StepEventRequest CreateStepRequest(Mono.Debugger.Soft.ThreadMirror thread) { throw null; }
        public Mono.Debugger.Soft.TypeLoadEventRequest CreateTypeLoadRequest() { throw null; }
        public Mono.Debugger.Soft.PrimitiveValue CreateValue(object value) { throw null; }
        public void Detach() { }
        public void Disconnect() { }
        [System.ObsoleteAttribute("This method was poorly named; use the Detach() method instead")]
        public void Dispose() { }
        public void EnableEvents(params Mono.Debugger.Soft.EventType[] events) { }
        public void EnableEvents(Mono.Debugger.Soft.EventType[] events, Mono.Debugger.Soft.SuspendPolicy suspendPolicy) { }
        public void Exit(int exitCode) { }
        public void ForceDisconnect() { }
        [System.ObsoleteAttribute("Use GetNextEventSet () instead")]
        public Mono.Debugger.Soft.Event GetNextEvent() { throw null; }
        public Mono.Debugger.Soft.Event GetNextEvent(int timeout) { throw null; }
        public Mono.Debugger.Soft.EventSet GetNextEventSet() { throw null; }
        [System.ObsoleteAttribute("Use GetNextEventSet () instead")]
        public T GetNextEvent<T>() where T : Mono.Debugger.Soft.Event { throw null; }
        public System.Collections.Generic.IList<Mono.Debugger.Soft.ThreadMirror> GetThreads() { throw null; }
        public System.Collections.Generic.IList<Mono.Debugger.Soft.TypeMirror> GetTypes(string name, bool ignoreCase) { throw null; }
        public System.Collections.Generic.IList<Mono.Debugger.Soft.TypeMirror> GetTypesForSourceFile(string fname, bool ignoreCase) { throw null; }
        public void Resume() { }
        public Mono.Debugger.Soft.BreakpointEventRequest SetBreakpoint(Mono.Debugger.Soft.MethodMirror method, long il_offset) { throw null; }
        public void SetSocketTimeouts(int send_timeout, int receive_timeout, int keepalive_interval) { }
        public void Suspend() { }
    }
    public partial class VirtualMachineManager
    {
        internal VirtualMachineManager() { }
        public static System.IAsyncResult BeginConnect(System.Net.IPEndPoint dbg_ep, System.AsyncCallback callback) { throw null; }
        public static System.IAsyncResult BeginConnect(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep, System.AsyncCallback callback) { throw null; }
        public static System.IAsyncResult BeginLaunch(System.Diagnostics.ProcessStartInfo info, System.AsyncCallback callback) { throw null; }
        public static System.IAsyncResult BeginLaunch(System.Diagnostics.ProcessStartInfo info, System.AsyncCallback callback, Mono.Debugger.Soft.LaunchOptions options) { throw null; }
        public static System.IAsyncResult BeginListen(System.Net.IPEndPoint dbg_ep, System.AsyncCallback callback) { throw null; }
        public static System.IAsyncResult BeginListen(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep, System.AsyncCallback callback) { throw null; }
        public static System.IAsyncResult BeginListen(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep, System.AsyncCallback callback, out int dbg_port, out int con_port) { dbg_port = default(int); con_port = default(int); throw null; }
        public static void CancelConnection(System.IAsyncResult asyncResult) { }
        public static Mono.Debugger.Soft.VirtualMachine Connect(Mono.Debugger.Soft.Connection transport, System.IO.StreamReader standardOutput, System.IO.StreamReader standardError) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Connect(System.Net.IPEndPoint endpoint) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Connect(System.Net.IPEndPoint endpoint, System.Net.IPEndPoint consoleEndpoint) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine ConnectInternal(System.Net.Sockets.Socket dbg_sock, System.Net.Sockets.Socket con_sock, System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine EndConnect(System.IAsyncResult asyncResult) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine EndLaunch(System.IAsyncResult asyncResult) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine EndListen(System.IAsyncResult asyncResult) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Launch(System.Diagnostics.ProcessStartInfo info) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Launch(System.Diagnostics.ProcessStartInfo info, Mono.Debugger.Soft.LaunchOptions options) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Launch(string[] args) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Launch(string[] args, Mono.Debugger.Soft.LaunchOptions options) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine LaunchInternal(Mono.Debugger.Soft.ITargetProcess p, System.Diagnostics.ProcessStartInfo info, System.Net.Sockets.Socket socket) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine LaunchInternal(System.Diagnostics.Process p, System.Diagnostics.ProcessStartInfo info, System.Net.Sockets.Socket socket) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Listen(System.Net.IPEndPoint dbg_ep) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine Listen(System.Net.IPEndPoint dbg_ep, System.Net.IPEndPoint con_ep) { throw null; }
        public static Mono.Debugger.Soft.VirtualMachine ListenInternal(System.Net.Sockets.Socket dbg_sock, System.Net.Sockets.Socket con_sock) { throw null; }
    }
    public partial class VMDeathEvent : Mono.Debugger.Soft.Event
    {
        public VMDeathEvent(Mono.Debugger.Soft.VirtualMachine vm, int req_id, int exit_code) { }
        public int ExitCode { get { throw null; } }
    }
    public partial class VMDisconnectedException : System.Exception
    {
        public VMDisconnectedException() { }
    }
    public partial class VMDisconnectEvent : Mono.Debugger.Soft.Event
    {
        public VMDisconnectEvent(Mono.Debugger.Soft.VirtualMachine vm, int req_id) { }
    }
    public partial class VMMismatchException : System.Exception
    {
        public VMMismatchException() { }
    }
    public partial class VMNotSuspendedException : System.InvalidOperationException
    {
        public VMNotSuspendedException() { }
    }
    public partial class VMStartEvent : Mono.Debugger.Soft.Event
    {
        public VMStartEvent(Mono.Debugger.Soft.VirtualMachine vm, int req_id, long thread_id) { }
    }
}
