// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Open Technologies, Inc.")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Retail")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Open Technologies, Inc.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Reactive Extensions Query Library used to express complex event processing queries over observable sequences.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Reactive Extensions")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reactive.Linq")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Reactive.Debugger, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Reactive.Experimental, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Reactive.PlatformServices, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System.Reactive
{
    public abstract partial class EventPatternSourceBase<TSender, TEventArgs> where TEventArgs : System.EventArgs
    {
        protected EventPatternSourceBase(System.IObservable<System.Reactive.EventPattern<TSender, TEventArgs>> source, System.Action<System.Action<TSender, TEventArgs>, System.Reactive.EventPattern<TSender, TEventArgs>> invokeHandler) { }
        protected void Add(System.Delegate handler, System.Action<TSender, TEventArgs> invoke) { }
        protected void Remove(System.Delegate handler) { }
    }
    public partial class EventPattern<TEventArgs> : System.Reactive.EventPattern<object, TEventArgs> where TEventArgs : System.EventArgs
    {
        public EventPattern(object sender, TEventArgs e) : base (default(object), default(TEventArgs)) { }
    }
    public partial class EventPattern<TSender, TEventArgs> : System.IEquatable<System.Reactive.EventPattern<TSender, TEventArgs>>, System.Reactive.IEventPattern<TSender, TEventArgs> where TEventArgs : System.EventArgs
    {
        public EventPattern(TSender sender, TEventArgs e) { }
        public TEventArgs EventArgs { get { throw null; } }
        public TSender Sender { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reactive.EventPattern<TSender, TEventArgs> other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reactive.EventPattern<TSender, TEventArgs> first, System.Reactive.EventPattern<TSender, TEventArgs> second) { throw null; }
        public static bool operator !=(System.Reactive.EventPattern<TSender, TEventArgs> first, System.Reactive.EventPattern<TSender, TEventArgs> second) { throw null; }
    }
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TimeInterval<T> : System.IEquatable<System.Reactive.TimeInterval<T>>
    {
        private readonly T _value;
        private int _dummyPrimitive;
        public TimeInterval(T value, System.TimeSpan interval) { throw null; }
        public System.TimeSpan Interval { get { throw null; } }
        public T Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reactive.TimeInterval<T> other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reactive.TimeInterval<T> first, System.Reactive.TimeInterval<T> second) { throw null; }
        public static bool operator !=(System.Reactive.TimeInterval<T> first, System.Reactive.TimeInterval<T> second) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class Timestamped
    {
        public static System.Reactive.Timestamped<T> Create<T>(T value, System.DateTimeOffset timestamp) { throw null; }
    }
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Timestamped<T> : System.IEquatable<System.Reactive.Timestamped<T>>
    {
        private readonly T _value;
        private int _dummyPrimitive;
        public Timestamped(T value, System.DateTimeOffset timestamp) { throw null; }
        public System.DateTimeOffset Timestamp { get { throw null; } }
        public T Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reactive.Timestamped<T> other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reactive.Timestamped<T> first, System.Reactive.Timestamped<T> second) { throw null; }
        public static bool operator !=(System.Reactive.Timestamped<T> first, System.Reactive.Timestamped<T> second) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Reactive.Concurrency
{
    public partial class HistoricalScheduler : System.Reactive.Concurrency.HistoricalSchedulerBase
    {
        public HistoricalScheduler() { }
        public HistoricalScheduler(System.DateTimeOffset initialClock) { }
        public HistoricalScheduler(System.DateTimeOffset initialClock, System.Collections.Generic.IComparer<System.DateTimeOffset> comparer) { }
        protected override System.Reactive.Concurrency.IScheduledItem<System.DateTimeOffset> GetNext() { throw null; }
        public override System.IDisposable ScheduleAbsolute<TState>(TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
    }
    public abstract partial class HistoricalSchedulerBase : System.Reactive.Concurrency.VirtualTimeSchedulerBase<System.DateTimeOffset, System.TimeSpan>
    {
        protected HistoricalSchedulerBase() { }
        protected HistoricalSchedulerBase(System.DateTimeOffset initialClock) { }
        protected HistoricalSchedulerBase(System.DateTimeOffset initialClock, System.Collections.Generic.IComparer<System.DateTimeOffset> comparer) { }
        protected override System.DateTimeOffset Add(System.DateTimeOffset absolute, System.TimeSpan relative) { throw null; }
        protected override System.DateTimeOffset ToDateTimeOffset(System.DateTimeOffset absolute) { throw null; }
        protected override System.TimeSpan ToRelative(System.TimeSpan timeSpan) { throw null; }
    }
    public abstract partial class VirtualTimeSchedulerBase<TAbsolute, TRelative> : System.IServiceProvider, System.Reactive.Concurrency.IScheduler, System.Reactive.Concurrency.IStopwatchProvider where TAbsolute : System.IComparable<TAbsolute>
    {
        protected VirtualTimeSchedulerBase() { }
        protected VirtualTimeSchedulerBase(TAbsolute initialClock, System.Collections.Generic.IComparer<TAbsolute> comparer) { }
        public TAbsolute Clock { get { throw null; } protected set { } }
        protected System.Collections.Generic.IComparer<TAbsolute> Comparer { get { throw null; } }
        public bool IsEnabled { get { throw null; } }
        public System.DateTimeOffset Now { get { throw null; } }
        protected abstract TAbsolute Add(TAbsolute absolute, TRelative relative);
        public void AdvanceBy(TRelative time) { }
        public void AdvanceTo(TAbsolute time) { }
        protected abstract System.Reactive.Concurrency.IScheduledItem<TAbsolute> GetNext();
        protected virtual object GetService(System.Type serviceType) { throw null; }
        public abstract System.IDisposable ScheduleAbsolute<TState>(TState state, TAbsolute dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
        public System.IDisposable ScheduleRelative<TState>(TState state, TRelative dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public System.IDisposable Schedule<TState>(TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public void Sleep(TRelative time) { }
        public void Start() { }
        public System.Reactive.Concurrency.IStopwatch StartStopwatch() { throw null; }
        public void Stop() { }
        object System.IServiceProvider.GetService(System.Type serviceType) { throw null; }
        protected abstract System.DateTimeOffset ToDateTimeOffset(TAbsolute absolute);
        protected abstract TRelative ToRelative(System.TimeSpan timeSpan);
    }
    public static partial class VirtualTimeSchedulerExtensions
    {
        public static System.IDisposable ScheduleAbsolute<TAbsolute, TRelative>(this System.Reactive.Concurrency.VirtualTimeSchedulerBase<TAbsolute, TRelative> scheduler, TAbsolute dueTime, System.Action action) where TAbsolute : System.IComparable<TAbsolute> { throw null; }
        public static System.IDisposable ScheduleRelative<TAbsolute, TRelative>(this System.Reactive.Concurrency.VirtualTimeSchedulerBase<TAbsolute, TRelative> scheduler, TRelative dueTime, System.Action action) where TAbsolute : System.IComparable<TAbsolute> { throw null; }
    }
    public abstract partial class VirtualTimeScheduler<TAbsolute, TRelative> : System.Reactive.Concurrency.VirtualTimeSchedulerBase<TAbsolute, TRelative> where TAbsolute : System.IComparable<TAbsolute>
    {
        protected VirtualTimeScheduler() { }
        protected VirtualTimeScheduler(TAbsolute initialClock, System.Collections.Generic.IComparer<TAbsolute> comparer) { }
        protected override System.Reactive.Concurrency.IScheduledItem<TAbsolute> GetNext() { throw null; }
        public override System.IDisposable ScheduleAbsolute<TState>(TState state, TAbsolute dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
    }
}
namespace System.Reactive.Joins
{
    public abstract partial class Pattern
    {
        internal Pattern() { }
    }
    public partial class Pattern<TSource1> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11> And<TSource11>(System.IObservable<TSource11> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12> And<TSource12>(System.IObservable<TSource12> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13> And<TSource13>(System.IObservable<TSource13> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14> And<TSource14>(System.IObservable<TSource14> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15> And<TSource15>(System.IObservable<TSource15> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16> And<TSource16>(System.IObservable<TSource16> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3> And<TSource3>(System.IObservable<TSource3> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4> And<TSource4>(System.IObservable<TSource4> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5> And<TSource5>(System.IObservable<TSource5> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> And<TSource6>(System.IObservable<TSource6> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> And<TSource7>(System.IObservable<TSource7> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8> And<TSource8>(System.IObservable<TSource8> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9> And<TSource9>(System.IObservable<TSource9> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult> selector) { throw null; }
    }
    public partial class Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9> : System.Reactive.Joins.Pattern
    {
        internal Pattern() { }
        public System.Reactive.Joins.Pattern<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10> And<TSource10>(System.IObservable<TSource10> other) { throw null; }
        public System.Reactive.Joins.Plan<TResult> Then<TResult>(System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult> selector) { throw null; }
    }
    public abstract partial class Plan<TResult>
    {
        internal Plan() { }
    }
}
namespace System.Reactive.Linq
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=false, AllowMultiple=false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed partial class LocalQueryMethodImplementationTypeAttribute : System.Attribute
    {
        public LocalQueryMethodImplementationTypeAttribute(System.Type targetType) { }
        public System.Type TargetType { get { throw null; } }
    }
    public static partial class Observable
    {
        public static System.IObservable<TSource> Aggregate<TSource>(this System.IObservable<TSource> source, System.Func<TSource, TSource, TSource> accumulator) { throw null; }
        public static System.IObservable<TAccumulate> Aggregate<TSource, TAccumulate>(this System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator) { throw null; }
        public static System.IObservable<TResult> Aggregate<TSource, TAccumulate, TResult>(this System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator, System.Func<TAccumulate, TResult> resultSelector) { throw null; }
        public static System.IObservable<bool> All<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> Amb<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Amb<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second) { throw null; }
        public static System.IObservable<TSource> Amb<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        public static System.Reactive.Joins.Pattern<TLeft, TRight> And<TLeft, TRight>(this System.IObservable<TLeft> left, System.IObservable<TRight> right) { throw null; }
        public static System.IObservable<bool> Any<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<bool> Any<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> AsObservable<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<decimal> Average(this System.IObservable<decimal> source) { throw null; }
        public static System.IObservable<double> Average(this System.IObservable<double> source) { throw null; }
        public static System.IObservable<double> Average(this System.IObservable<int> source) { throw null; }
        public static System.IObservable<double> Average(this System.IObservable<long> source) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Average(this System.IObservable<System.Nullable<decimal>> source) { throw null; }
        public static System.IObservable<System.Nullable<double>> Average(this System.IObservable<System.Nullable<double>> source) { throw null; }
        public static System.IObservable<System.Nullable<double>> Average(this System.IObservable<System.Nullable<int>> source) { throw null; }
        public static System.IObservable<System.Nullable<double>> Average(this System.IObservable<System.Nullable<long>> source) { throw null; }
        public static System.IObservable<System.Nullable<float>> Average(this System.IObservable<System.Nullable<float>> source) { throw null; }
        public static System.IObservable<float> Average(this System.IObservable<float> source) { throw null; }
        public static System.IObservable<decimal> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, decimal> selector) { throw null; }
        public static System.IObservable<double> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, double> selector) { throw null; }
        public static System.IObservable<double> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int> selector) { throw null; }
        public static System.IObservable<double> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, long> selector) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { throw null; }
        public static System.IObservable<System.Nullable<double>> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { throw null; }
        public static System.IObservable<System.Nullable<double>> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { throw null; }
        public static System.IObservable<System.Nullable<double>> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { throw null; }
        public static System.IObservable<System.Nullable<float>> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { throw null; }
        public static System.IObservable<float> Average<TSource>(this System.IObservable<TSource> source, System.Func<TSource, float> selector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, int count) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, int count, int skip) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, int count) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, int count, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, System.TimeSpan timeShift) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, System.TimeSpan timeShift, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource, TBufferClosing>(this System.IObservable<TSource> source, System.Func<System.IObservable<TBufferClosing>> bufferClosingSelector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource, TBufferBoundary>(this System.IObservable<TSource> source, System.IObservable<TBufferBoundary> bufferBoundaries) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Buffer<TSource, TBufferOpening, TBufferClosing>(this System.IObservable<TSource> source, System.IObservable<TBufferOpening> bufferOpenings, System.Func<TBufferOpening, System.IObservable<TBufferClosing>> bufferClosingSelector) { throw null; }
        public static System.IObservable<TResult> Case<TValue, TResult>(System.Func<TValue> selector, System.Collections.Generic.IDictionary<TValue, System.IObservable<TResult>> sources) { throw null; }
        public static System.IObservable<TResult> Case<TValue, TResult>(System.Func<TValue> selector, System.Collections.Generic.IDictionary<TValue, System.IObservable<TResult>> sources, System.IObservable<TResult> defaultSource) { throw null; }
        public static System.IObservable<TResult> Case<TValue, TResult>(System.Func<TValue> selector, System.Collections.Generic.IDictionary<TValue, System.IObservable<TResult>> sources, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Cast<TResult>(this System.IObservable<object> source) { throw null; }
        public static System.IObservable<TSource> Catch<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Catch<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second) { throw null; }
        public static System.IObservable<TSource> Catch<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        public static System.IObservable<TSource> Catch<TSource, TException>(this System.IObservable<TSource> source, System.Func<TException, System.IObservable<TSource>> handler) where TException : System.Exception { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<TSource>> Chunkify<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.Collections.Generic.IEnumerable<TResult> Collect<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TResult> newCollector, System.Func<TResult, TSource, TResult> merge) { throw null; }
        public static System.Collections.Generic.IEnumerable<TResult> Collect<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TResult> getInitialCollector, System.Func<TResult, TSource, TResult> merge, System.Func<TResult, TResult> getNewCollector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> CombineLatest<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> CombineLatest<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.IObservable<TSource14> source14, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.IObservable<TSource14> source14, System.IObservable<TSource15> source15, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.IObservable<TSource14> source14, System.IObservable<TSource15> source15, System.IObservable<TSource16> source16, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource, TResult>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, System.Func<System.Collections.Generic.IList<TSource>, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TResult>(this System.IObservable<TSource1> first, System.IObservable<TSource2> second, System.Func<TSource1, TSource2, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.Func<TSource1, TSource2, TSource3, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.Func<TSource1, TSource2, TSource3, TSource4, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult> resultSelector) { throw null; }
        public static System.IObservable<TSource> Concat<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Concat<TSource>(this System.IObservable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Concat<TSource>(this System.IObservable<System.Threading.Tasks.Task<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Concat<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second) { throw null; }
        public static System.IObservable<TSource> Concat<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        public static System.IObservable<bool> Contains<TSource>(this System.IObservable<TSource> source, TSource value) { throw null; }
        public static System.IObservable<bool> Contains<TSource>(this System.IObservable<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer) { throw null; }
        public static System.IObservable<int> Count<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<int> Count<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Action> subscribe) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.IDisposable> subscribe) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.Action>> subscribeAsync) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> subscribeAsync) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Threading.CancellationToken, System.Threading.Tasks.Task> subscribeAsync) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Threading.Tasks.Task<System.Action>> subscribeAsync) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Threading.Tasks.Task<System.IDisposable>> subscribeAsync) { throw null; }
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Threading.Tasks.Task> subscribeAsync) { throw null; }
        public static System.IObservable<TSource> DefaultIfEmpty<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> DefaultIfEmpty<TSource>(this System.IObservable<TSource> source, TSource defaultValue) { throw null; }
        public static System.IObservable<TResult> DeferAsync<TResult>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IObservable<TResult>>> observableFactoryAsync) { throw null; }
        public static System.IObservable<TResult> Defer<TResult>(System.Func<System.IObservable<TResult>> observableFactory) { throw null; }
        public static System.IObservable<TResult> Defer<TResult>(System.Func<System.Threading.Tasks.Task<System.IObservable<TResult>>> observableFactoryAsync) { throw null; }
        public static System.IObservable<TSource> DelaySubscription<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime) { throw null; }
        public static System.IObservable<TSource> DelaySubscription<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> DelaySubscription<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime) { throw null; }
        public static System.IObservable<TSource> DelaySubscription<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Delay<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime) { throw null; }
        public static System.IObservable<TSource> Delay<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Delay<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime) { throw null; }
        public static System.IObservable<TSource> Delay<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Delay<TSource, TDelay>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TDelay>> delayDurationSelector) { throw null; }
        public static System.IObservable<TSource> Delay<TSource, TDelay>(this System.IObservable<TSource> source, System.IObservable<TDelay> subscriptionDelay, System.Func<TSource, System.IObservable<TDelay>> delayDurationSelector) { throw null; }
        public static System.IObservable<TSource> Dematerialize<TSource>(this System.IObservable<System.Reactive.Notification<TSource>> source) { throw null; }
        public static System.IObservable<TSource> DistinctUntilChanged<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> DistinctUntilChanged<TSource>(this System.IObservable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { throw null; }
        public static System.IObservable<TSource> DistinctUntilChanged<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector) { throw null; }
        public static System.IObservable<TSource> DistinctUntilChanged<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<TSource> Distinct<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Distinct<TSource>(this System.IObservable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { throw null; }
        public static System.IObservable<TSource> Distinct<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector) { throw null; }
        public static System.IObservable<TSource> Distinct<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<TSource> DoWhile<TSource>(this System.IObservable<TSource> source, System.Func<bool> condition) { throw null; }
        public static System.IObservable<TSource> Do<TSource>(this System.IObservable<TSource> source, System.Action<TSource> onNext) { throw null; }
        public static System.IObservable<TSource> Do<TSource>(this System.IObservable<TSource> source, System.Action<TSource> onNext, System.Action onCompleted) { throw null; }
        public static System.IObservable<TSource> Do<TSource>(this System.IObservable<TSource> source, System.Action<TSource> onNext, System.Action<System.Exception> onError) { throw null; }
        public static System.IObservable<TSource> Do<TSource>(this System.IObservable<TSource> source, System.Action<TSource> onNext, System.Action<System.Exception> onError, System.Action onCompleted) { throw null; }
        public static System.IObservable<TSource> Do<TSource>(this System.IObservable<TSource> source, System.IObserver<TSource> observer) { throw null; }
        public static System.IObservable<TSource> ElementAtOrDefault<TSource>(this System.IObservable<TSource> source, int index) { throw null; }
        public static System.IObservable<TSource> ElementAt<TSource>(this System.IObservable<TSource> source, int index) { throw null; }
        public static System.IObservable<TResult> Empty<TResult>() { throw null; }
        public static System.IObservable<TResult> Empty<TResult>(System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Empty<TResult>(System.Reactive.Concurrency.IScheduler scheduler, TResult witness) { throw null; }
        public static System.IObservable<TResult> Empty<TResult>(TResult witness) { throw null; }
        public static System.IObservable<TSource> Finally<TSource>(this System.IObservable<TSource> source, System.Action finallyAction) { throw null; }
        public static System.IObservable<TSource> FirstAsync<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> FirstAsync<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> FirstOrDefaultAsync<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> FirstOrDefaultAsync<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource FirstOrDefault<TSource>(this System.IObservable<TSource> source) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource FirstOrDefault<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource First<TSource>(this System.IObservable<TSource> source) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource First<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.Threading.Tasks.Task ForEachAsync<TSource>(this System.IObservable<TSource> source, System.Action<TSource, int> onNext) { throw null; }
        public static System.Threading.Tasks.Task ForEachAsync<TSource>(this System.IObservable<TSource> source, System.Action<TSource, int> onNext, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task ForEachAsync<TSource>(this System.IObservable<TSource> source, System.Action<TSource> onNext) { throw null; }
        public static System.Threading.Tasks.Task ForEachAsync<TSource>(this System.IObservable<TSource> source, System.Action<TSource> onNext, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static void ForEach<TSource>(this System.IObservable<TSource> source, System.Action<TSource, int> onNext) { }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static void ForEach<TSource>(this System.IObservable<TSource> source, System.Action<TSource> onNext) { }
        public static System.IObservable<TResult> For<TSource, TResult>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, System.IObservable<TResult>> resultSelector) { throw null; }
        public static System.IObservable<System.Reactive.Unit> FromAsync(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task> actionAsync) { throw null; }
        public static System.IObservable<System.Reactive.Unit> FromAsync(System.Func<System.Threading.Tasks.Task> actionAsync) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<System.IObservable<System.Reactive.Unit>> FromAsyncPattern(System.Func<System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<System.IObservable<TResult>> FromAsyncPattern<TResult>(System.Func<System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, System.IObservable<TResult>> FromAsyncPattern<TArg1, TResult>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TResult>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TResult>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4>(System.Func<TArg1, TArg2, TArg3, TArg4, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.AsyncCallback, object, System.IAsyncResult> begin, System.Func<System.IAsyncResult, TResult> end) { throw null; }
        [System.ObsoleteAttribute("This conversion is no longer supported. Replace use of the Begin/End asynchronous method pair with a new Task-based async method, and convert the result using ToObservable. If no Task-based async method is available, use Task.Factory.FromAsync to obtain a Task object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.IObservable<System.Reactive.Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.AsyncCallback, object, System.IAsyncResult> begin, System.Action<System.IAsyncResult> end) { throw null; }
        public static System.IObservable<TResult> FromAsync<TResult>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>> functionAsync) { throw null; }
        public static System.IObservable<TResult> FromAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> functionAsync) { throw null; }
        public static System.IObservable<System.Reactive.Unit> FromEvent(System.Action<System.Action> addHandler, System.Action<System.Action> removeHandler) { throw null; }
        public static System.IObservable<System.Reactive.Unit> FromEvent(System.Action<System.Action> addHandler, System.Action<System.Action> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> FromEventPattern(System.Action<System.EventHandler> addHandler, System.Action<System.EventHandler> removeHandler) { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> FromEventPattern(System.Action<System.EventHandler> addHandler, System.Action<System.EventHandler> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> FromEventPattern(object target, string eventName) { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> FromEventPattern(object target, string eventName, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> FromEventPattern(System.Type type, string eventName) { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> FromEventPattern(System.Type type, string eventName, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(System.Action<System.EventHandler<TEventArgs>> addHandler, System.Action<System.EventHandler<TEventArgs>> removeHandler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(System.Action<System.EventHandler<TEventArgs>> addHandler, System.Action<System.EventHandler<TEventArgs>> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(object target, string eventName) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(object target, string eventName, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(System.Type type, string eventName) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(System.Type type, string eventName, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(System.Func<System.EventHandler<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(System.Func<System.EventHandler<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(object target, string eventName) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(object target, string eventName, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(System.Type type, string eventName) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(System.Type type, string eventName, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TSender, TEventArgs>> FromEventPattern<TDelegate, TSender, TEventArgs>(System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<System.Reactive.EventPattern<TSender, TEventArgs>> FromEventPattern<TDelegate, TSender, TEventArgs>(System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) where TEventArgs : System.EventArgs { throw null; }
        public static System.IObservable<TEventArgs> FromEvent<TEventArgs>(System.Action<System.Action<TEventArgs>> addHandler, System.Action<System.Action<TEventArgs>> removeHandler) { throw null; }
        public static System.IObservable<TEventArgs> FromEvent<TEventArgs>(System.Action<System.Action<TEventArgs>> addHandler, System.Action<System.Action<TEventArgs>> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler) { throw null; }
        public static System.IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(System.Func<System.Action<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler) { throw null; }
        public static System.IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(System.Func<System.Action<TEventArgs>, TDelegate> conversion, System.Action<TDelegate> addHandler, System.Action<TDelegate> removeHandler, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Generate<TState, TResult>(TState initialState, System.Func<TState, bool> condition, System.Func<TState, TState> iterate, System.Func<TState, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Generate<TState, TResult>(TState initialState, System.Func<TState, bool> condition, System.Func<TState, TState> iterate, System.Func<TState, TResult> resultSelector, System.Func<TState, System.DateTimeOffset> timeSelector) { throw null; }
        public static System.IObservable<TResult> Generate<TState, TResult>(TState initialState, System.Func<TState, bool> condition, System.Func<TState, TState> iterate, System.Func<TState, TResult> resultSelector, System.Func<TState, System.DateTimeOffset> timeSelector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Generate<TState, TResult>(TState initialState, System.Func<TState, bool> condition, System.Func<TState, TState> iterate, System.Func<TState, TResult> resultSelector, System.Func<TState, System.TimeSpan> timeSelector) { throw null; }
        public static System.IObservable<TResult> Generate<TState, TResult>(TState initialState, System.Func<TState, bool> condition, System.Func<TState, TState> iterate, System.Func<TState, TResult> resultSelector, System.Func<TState, System.TimeSpan> timeSelector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Generate<TState, TResult>(TState initialState, System.Func<TState, bool> condition, System.Func<TState, TState> iterate, System.Func<TState, TResult> resultSelector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Subjects.AsyncSubject<TSource> GetAwaiter<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.Reactive.Subjects.AsyncSubject<TSource> GetAwaiter<TSource>(this System.Reactive.Subjects.IConnectableObservable<TSource> source) { throw null; }
        public static System.Collections.Generic.IEnumerator<TSource> GetEnumerator<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupByUntil<TSource, TKey, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TSource>, System.IObservable<TDuration>> durationSelector) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupByUntil<TSource, TKey, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TSource>, System.IObservable<TDuration>> durationSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupByUntil<TSource, TKey, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TSource>, System.IObservable<TDuration>> durationSelector, int capacity) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupByUntil<TSource, TKey, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TSource>, System.IObservable<TDuration>> durationSelector, int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupByUntil<TSource, TKey, TElement, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TElement>, System.IObservable<TDuration>> durationSelector) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupByUntil<TSource, TKey, TElement, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TElement>, System.IObservable<TDuration>> durationSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupByUntil<TSource, TKey, TElement, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TElement>, System.IObservable<TDuration>> durationSelector, int capacity) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupByUntil<TSource, TKey, TElement, TDuration>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<System.Reactive.Linq.IGroupedObservable<TKey, TElement>, System.IObservable<TDuration>> durationSelector, int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, int capacity) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, int capacity) { throw null; }
        public static System.IObservable<System.Reactive.Linq.IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<TResult> GroupJoin<TLeft, TRight, TLeftDuration, TRightDuration, TResult>(this System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, System.IObservable<TLeftDuration>> leftDurationSelector, System.Func<TRight, System.IObservable<TRightDuration>> rightDurationSelector, System.Func<TLeft, System.IObservable<TRight>, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> If<TResult>(System.Func<bool> condition, System.IObservable<TResult> thenSource) { throw null; }
        public static System.IObservable<TResult> If<TResult>(System.Func<bool> condition, System.IObservable<TResult> thenSource, System.IObservable<TResult> elseSource) { throw null; }
        public static System.IObservable<TResult> If<TResult>(System.Func<bool> condition, System.IObservable<TResult> thenSource, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> IgnoreElements<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<long> Interval(System.TimeSpan period) { throw null; }
        public static System.IObservable<long> Interval(System.TimeSpan period, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<bool> IsEmpty<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TResult> Join<TLeft, TRight, TLeftDuration, TRightDuration, TResult>(this System.IObservable<TLeft> left, System.IObservable<TRight> right, System.Func<TLeft, System.IObservable<TLeftDuration>> leftDurationSelector, System.Func<TRight, System.IObservable<TRightDuration>> rightDurationSelector, System.Func<TLeft, TRight, TResult> resultSelector) { throw null; }
        public static System.IObservable<TSource> LastAsync<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> LastAsync<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> LastOrDefaultAsync<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> LastOrDefaultAsync<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource LastOrDefault<TSource>(this System.IObservable<TSource> source) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource LastOrDefault<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource Last<TSource>(this System.IObservable<TSource> source) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource Last<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.Collections.Generic.IEnumerable<TSource> Latest<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<long> LongCount<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<long> LongCount<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<System.Reactive.Notification<TSource>> Materialize<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<decimal> Max(this System.IObservable<decimal> source) { throw null; }
        public static System.IObservable<double> Max(this System.IObservable<double> source) { throw null; }
        public static System.IObservable<int> Max(this System.IObservable<int> source) { throw null; }
        public static System.IObservable<long> Max(this System.IObservable<long> source) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Max(this System.IObservable<System.Nullable<decimal>> source) { throw null; }
        public static System.IObservable<System.Nullable<double>> Max(this System.IObservable<System.Nullable<double>> source) { throw null; }
        public static System.IObservable<System.Nullable<int>> Max(this System.IObservable<System.Nullable<int>> source) { throw null; }
        public static System.IObservable<System.Nullable<long>> Max(this System.IObservable<System.Nullable<long>> source) { throw null; }
        public static System.IObservable<System.Nullable<float>> Max(this System.IObservable<System.Nullable<float>> source) { throw null; }
        public static System.IObservable<float> Max(this System.IObservable<float> source) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> MaxBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> MaxBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { throw null; }
        public static System.IObservable<TSource> Max<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Max<TSource>(this System.IObservable<TSource> source, System.Collections.Generic.IComparer<TSource> comparer) { throw null; }
        public static System.IObservable<decimal> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, decimal> selector) { throw null; }
        public static System.IObservable<double> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, double> selector) { throw null; }
        public static System.IObservable<int> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int> selector) { throw null; }
        public static System.IObservable<long> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, long> selector) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { throw null; }
        public static System.IObservable<System.Nullable<double>> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { throw null; }
        public static System.IObservable<System.Nullable<int>> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { throw null; }
        public static System.IObservable<System.Nullable<long>> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { throw null; }
        public static System.IObservable<System.Nullable<float>> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { throw null; }
        public static System.IObservable<float> Max<TSource>(this System.IObservable<TSource> source, System.Func<TSource, float> selector) { throw null; }
        public static System.IObservable<TResult> Max<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, TResult> selector) { throw null; }
        public static System.IObservable<TResult> Max<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, TResult> selector, System.Collections.Generic.IComparer<TResult> comparer) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, int maxConcurrent) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, int maxConcurrent, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.IObservable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.IObservable<System.IObservable<TSource>> sources, int maxConcurrent) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.IObservable<System.Threading.Tasks.Task<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        public static System.IObservable<TSource> Merge<TSource>(System.Reactive.Concurrency.IScheduler scheduler, params System.IObservable<TSource>[] sources) { throw null; }
        public static System.IObservable<decimal> Min(this System.IObservable<decimal> source) { throw null; }
        public static System.IObservable<double> Min(this System.IObservable<double> source) { throw null; }
        public static System.IObservable<int> Min(this System.IObservable<int> source) { throw null; }
        public static System.IObservable<long> Min(this System.IObservable<long> source) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Min(this System.IObservable<System.Nullable<decimal>> source) { throw null; }
        public static System.IObservable<System.Nullable<double>> Min(this System.IObservable<System.Nullable<double>> source) { throw null; }
        public static System.IObservable<System.Nullable<int>> Min(this System.IObservable<System.Nullable<int>> source) { throw null; }
        public static System.IObservable<System.Nullable<long>> Min(this System.IObservable<System.Nullable<long>> source) { throw null; }
        public static System.IObservable<System.Nullable<float>> Min(this System.IObservable<System.Nullable<float>> source) { throw null; }
        public static System.IObservable<float> Min(this System.IObservable<float> source) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> MinBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> MinBy<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { throw null; }
        public static System.IObservable<TSource> Min<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Min<TSource>(this System.IObservable<TSource> source, System.Collections.Generic.IComparer<TSource> comparer) { throw null; }
        public static System.IObservable<decimal> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, decimal> selector) { throw null; }
        public static System.IObservable<double> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, double> selector) { throw null; }
        public static System.IObservable<int> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int> selector) { throw null; }
        public static System.IObservable<long> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, long> selector) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { throw null; }
        public static System.IObservable<System.Nullable<double>> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { throw null; }
        public static System.IObservable<System.Nullable<int>> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { throw null; }
        public static System.IObservable<System.Nullable<long>> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { throw null; }
        public static System.IObservable<System.Nullable<float>> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { throw null; }
        public static System.IObservable<float> Min<TSource>(this System.IObservable<TSource> source, System.Func<TSource, float> selector) { throw null; }
        public static System.IObservable<TResult> Min<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, TResult> selector) { throw null; }
        public static System.IObservable<TResult> Min<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, TResult> selector, System.Collections.Generic.IComparer<TResult> comparer) { throw null; }
        public static System.Collections.Generic.IEnumerable<TSource> MostRecent<TSource>(this System.IObservable<TSource> source, TSource initialValue) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TResult> Multicast<TSource, TResult>(this System.IObservable<TSource> source, System.Reactive.Subjects.ISubject<TSource, TResult> subject) { throw null; }
        public static System.IObservable<TResult> Multicast<TSource, TIntermediate, TResult>(this System.IObservable<TSource> source, System.Func<System.Reactive.Subjects.ISubject<TSource, TIntermediate>> subjectSelector, System.Func<System.IObservable<TIntermediate>, System.IObservable<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> Never<TResult>() { throw null; }
        public static System.IObservable<TResult> Never<TResult>(TResult witness) { throw null; }
        public static System.Collections.Generic.IEnumerable<TSource> Next<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Threading.SynchronizationContext context) { throw null; }
        public static System.IObservable<TResult> OfType<TResult>(this System.IObservable<object> source) { throw null; }
        public static System.IObservable<TSource> OnErrorResumeNext<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> OnErrorResumeNext<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second) { throw null; }
        public static System.IObservable<TSource> OnErrorResumeNext<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> PublishLast<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TResult> PublishLast<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Publish<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Publish<TSource>(this System.IObservable<TSource> source, TSource initialValue) { throw null; }
        public static System.IObservable<TResult> Publish<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> Publish<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, TSource initialValue) { throw null; }
        public static System.IObservable<int> Range(int start, int count) { throw null; }
        public static System.IObservable<int> Range(int start, int count, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> RefCount<TSource>(this System.Reactive.Subjects.IConnectableObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Repeat<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Repeat<TSource>(this System.IObservable<TSource> source, int repeatCount) { throw null; }
        public static System.IObservable<TResult> Repeat<TResult>(TResult value) { throw null; }
        public static System.IObservable<TResult> Repeat<TResult>(TResult value, int repeatCount) { throw null; }
        public static System.IObservable<TResult> Repeat<TResult>(TResult value, int repeatCount, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Repeat<TResult>(TResult value, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source, int bufferSize) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source, int bufferSize, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source, int bufferSize, System.TimeSpan window) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source, int bufferSize, System.TimeSpan window, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source, System.TimeSpan window) { throw null; }
        public static System.Reactive.Subjects.IConnectableObservable<TSource> Replay<TSource>(this System.IObservable<TSource> source, System.TimeSpan window, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, int bufferSize) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, int bufferSize, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, int bufferSize, System.TimeSpan window) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, int bufferSize, System.TimeSpan window, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, System.TimeSpan window) { throw null; }
        public static System.IObservable<TResult> Replay<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector, System.TimeSpan window, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Retry<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Retry<TSource>(this System.IObservable<TSource> source, int retryCount) { throw null; }
        public static System.IObservable<TResult> Return<TResult>(TResult value) { throw null; }
        public static System.IObservable<TResult> Return<TResult>(TResult value, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Subjects.AsyncSubject<TSource> RunAsync<TSource>(this System.IObservable<TSource> source, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Reactive.Subjects.AsyncSubject<TSource> RunAsync<TSource>(this System.Reactive.Subjects.IConnectableObservable<TSource> source, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.IObservable<TSource> Sample<TSource>(this System.IObservable<TSource> source, System.TimeSpan interval) { throw null; }
        public static System.IObservable<TSource> Sample<TSource>(this System.IObservable<TSource> source, System.TimeSpan interval, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Sample<TSource, TSample>(this System.IObservable<TSource> source, System.IObservable<TSample> sampler) { throw null; }
        public static System.IObservable<TSource> Scan<TSource>(this System.IObservable<TSource> source, System.Func<TSource, TSource, TSource> accumulator) { throw null; }
        public static System.IObservable<TAccumulate> Scan<TSource, TAccumulate>(this System.IObservable<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> accumulator) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TResult>> onNext, System.Func<System.Exception, System.IObservable<TResult>> onError, System.Func<System.IObservable<TResult>> onCompleted) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.Tasks.Task<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TResult>> onNext, System.Func<System.Exception, System.IObservable<TResult>> onError, System.Func<System.IObservable<TResult>> onCompleted) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>> selector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.Tasks.Task<TResult>> selector) { throw null; }
        public static System.IObservable<TOther> SelectMany<TSource, TOther>(this System.IObservable<TSource> source, System.IObservable<TOther> other) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.CancellationToken, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, int, TTaskResult, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, int, TTaskResult, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.CancellationToken, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, TTaskResult, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> SelectMany<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, TTaskResult, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Select<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, TResult> selector) { throw null; }
        public static System.IObservable<TResult> Select<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, TResult> selector) { throw null; }
        public static System.IObservable<bool> SequenceEqual<TSource>(this System.IObservable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { throw null; }
        public static System.IObservable<bool> SequenceEqual<TSource>(this System.IObservable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { throw null; }
        public static System.IObservable<bool> SequenceEqual<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second) { throw null; }
        public static System.IObservable<bool> SequenceEqual<TSource>(this System.IObservable<TSource> first, System.IObservable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { throw null; }
        public static System.IObservable<TSource> SingleAsync<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> SingleAsync<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> SingleOrDefaultAsync<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> SingleOrDefaultAsync<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource SingleOrDefault<TSource>(this System.IObservable<TSource> source) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource SingleOrDefault<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource Single<TSource>(this System.IObservable<TSource> source) { throw null; }
        [System.ObsoleteAttribute("This blocking operation is no longer supported. Instead, use the async version in combination with C# and Visual Basic async/await support. In case you need a blocking operation, use Wait or convert the resulting observable sequence to a Task object and block. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static TSource Single<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> SkipLast<TSource>(this System.IObservable<TSource> source, int count) { throw null; }
        public static System.IObservable<TSource> SkipLast<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration) { throw null; }
        public static System.IObservable<TSource> SkipLast<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> SkipUntil<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset startTime) { throw null; }
        public static System.IObservable<TSource> SkipUntil<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset startTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> SkipUntil<TSource, TOther>(this System.IObservable<TSource> source, System.IObservable<TOther> other) { throw null; }
        public static System.IObservable<TSource> SkipWhile<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> SkipWhile<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int, bool> predicate) { throw null; }
        public static System.IObservable<TSource> Skip<TSource>(this System.IObservable<TSource> source, int count) { throw null; }
        public static System.IObservable<TSource> Skip<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration) { throw null; }
        public static System.IObservable<TSource> Skip<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Reactive.Unit> Start(System.Action action) { throw null; }
        public static System.IObservable<System.Reactive.Unit> Start(System.Action action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Reactive.Unit> StartAsync(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task> actionAsync) { throw null; }
        public static System.IObservable<System.Reactive.Unit> StartAsync(System.Func<System.Threading.Tasks.Task> actionAsync) { throw null; }
        public static System.IObservable<TResult> StartAsync<TResult>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>> functionAsync) { throw null; }
        public static System.IObservable<TResult> StartAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> functionAsync) { throw null; }
        public static System.IObservable<TSource> StartWith<TSource>(this System.IObservable<TSource> source, System.Collections.Generic.IEnumerable<TSource> values) { throw null; }
        public static System.IObservable<TSource> StartWith<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler, System.Collections.Generic.IEnumerable<TSource> values) { throw null; }
        public static System.IObservable<TSource> StartWith<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler, params TSource[] values) { throw null; }
        public static System.IObservable<TSource> StartWith<TSource>(this System.IObservable<TSource> source, params TSource[] values) { throw null; }
        public static System.IObservable<TResult> Start<TResult>(System.Func<TResult> function) { throw null; }
        public static System.IObservable<TResult> Start<TResult>(System.Func<TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Threading.SynchronizationContext context) { throw null; }
        public static System.IDisposable Subscribe<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.IObserver<TSource> observer) { throw null; }
        public static System.IDisposable Subscribe<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.IObserver<TSource> observer, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<decimal> Sum(this System.IObservable<decimal> source) { throw null; }
        public static System.IObservable<double> Sum(this System.IObservable<double> source) { throw null; }
        public static System.IObservable<int> Sum(this System.IObservable<int> source) { throw null; }
        public static System.IObservable<long> Sum(this System.IObservable<long> source) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Sum(this System.IObservable<System.Nullable<decimal>> source) { throw null; }
        public static System.IObservable<System.Nullable<double>> Sum(this System.IObservable<System.Nullable<double>> source) { throw null; }
        public static System.IObservable<System.Nullable<int>> Sum(this System.IObservable<System.Nullable<int>> source) { throw null; }
        public static System.IObservable<System.Nullable<long>> Sum(this System.IObservable<System.Nullable<long>> source) { throw null; }
        public static System.IObservable<System.Nullable<float>> Sum(this System.IObservable<System.Nullable<float>> source) { throw null; }
        public static System.IObservable<float> Sum(this System.IObservable<float> source) { throw null; }
        public static System.IObservable<decimal> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, decimal> selector) { throw null; }
        public static System.IObservable<double> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, double> selector) { throw null; }
        public static System.IObservable<int> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int> selector) { throw null; }
        public static System.IObservable<long> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, long> selector) { throw null; }
        public static System.IObservable<System.Nullable<decimal>> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { throw null; }
        public static System.IObservable<System.Nullable<double>> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { throw null; }
        public static System.IObservable<System.Nullable<int>> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { throw null; }
        public static System.IObservable<System.Nullable<long>> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { throw null; }
        public static System.IObservable<System.Nullable<float>> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { throw null; }
        public static System.IObservable<float> Sum<TSource>(this System.IObservable<TSource> source, System.Func<TSource, float> selector) { throw null; }
        public static System.IObservable<TSource> Switch<TSource>(this System.IObservable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Switch<TSource>(this System.IObservable<System.Threading.Tasks.Task<TSource>> sources) { throw null; }
        public static System.IObservable<TSource> Synchronize<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Synchronize<TSource>(this System.IObservable<TSource> source, object gate) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> TakeLastBuffer<TSource>(this System.IObservable<TSource> source, int count) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> TakeLastBuffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> TakeLastBuffer<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> TakeLast<TSource>(this System.IObservable<TSource> source, int count) { throw null; }
        public static System.IObservable<TSource> TakeLast<TSource>(this System.IObservable<TSource> source, int count, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> TakeLast<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration) { throw null; }
        public static System.IObservable<TSource> TakeLast<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> TakeLast<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration, System.Reactive.Concurrency.IScheduler timerScheduler, System.Reactive.Concurrency.IScheduler loopScheduler) { throw null; }
        public static System.IObservable<TSource> TakeUntil<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset endTime) { throw null; }
        public static System.IObservable<TSource> TakeUntil<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset endTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> TakeUntil<TSource, TOther>(this System.IObservable<TSource> source, System.IObservable<TOther> other) { throw null; }
        public static System.IObservable<TSource> TakeWhile<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> TakeWhile<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int, bool> predicate) { throw null; }
        public static System.IObservable<TSource> Take<TSource>(this System.IObservable<TSource> source, int count) { throw null; }
        public static System.IObservable<TSource> Take<TSource>(this System.IObservable<TSource> source, int count, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Take<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration) { throw null; }
        public static System.IObservable<TSource> Take<TSource>(this System.IObservable<TSource> source, System.TimeSpan duration, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Joins.Plan<TResult> Then<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, TResult> selector) { throw null; }
        public static System.IObservable<TSource> Throttle<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime) { throw null; }
        public static System.IObservable<TSource> Throttle<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Throttle<TSource, TThrottle>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TThrottle>> throttleDurationSelector) { throw null; }
        public static System.IObservable<TResult> Throw<TResult>(System.Exception exception) { throw null; }
        public static System.IObservable<TResult> Throw<TResult>(System.Exception exception, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Throw<TResult>(System.Exception exception, System.Reactive.Concurrency.IScheduler scheduler, TResult witness) { throw null; }
        public static System.IObservable<TResult> Throw<TResult>(System.Exception exception, TResult witness) { throw null; }
        public static System.IObservable<System.Reactive.TimeInterval<TSource>> TimeInterval<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<System.Reactive.TimeInterval<TSource>> TimeInterval<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime, System.IObservable<TSource> other) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime, System.IObservable<TSource> other, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.DateTimeOffset dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime, System.IObservable<TSource> other) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime, System.IObservable<TSource> other, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource>(this System.IObservable<TSource> source, System.TimeSpan dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource, TTimeout>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TTimeout>> timeoutDurationSelector) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource, TTimeout>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TTimeout>> timeoutDurationSelector, System.IObservable<TSource> other) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource, TTimeout>(this System.IObservable<TSource> source, System.IObservable<TTimeout> firstTimeout, System.Func<TSource, System.IObservable<TTimeout>> timeoutDurationSelector) { throw null; }
        public static System.IObservable<TSource> Timeout<TSource, TTimeout>(this System.IObservable<TSource> source, System.IObservable<TTimeout> firstTimeout, System.Func<TSource, System.IObservable<TTimeout>> timeoutDurationSelector, System.IObservable<TSource> other) { throw null; }
        public static System.IObservable<long> Timer(System.DateTimeOffset dueTime) { throw null; }
        public static System.IObservable<long> Timer(System.DateTimeOffset dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<long> Timer(System.DateTimeOffset dueTime, System.TimeSpan period) { throw null; }
        public static System.IObservable<long> Timer(System.DateTimeOffset dueTime, System.TimeSpan period, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<long> Timer(System.TimeSpan dueTime) { throw null; }
        public static System.IObservable<long> Timer(System.TimeSpan dueTime, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<long> Timer(System.TimeSpan dueTime, System.TimeSpan period) { throw null; }
        public static System.IObservable<long> Timer(System.TimeSpan dueTime, System.TimeSpan period, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Reactive.Timestamped<TSource>> Timestamp<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<System.Reactive.Timestamped<TSource>> Timestamp<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource[]> ToArray<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.Func<System.IObservable<System.Reactive.Unit>> ToAsync(this System.Action action) { throw null; }
        public static System.Func<System.IObservable<System.Reactive.Unit>> ToAsync(this System.Action action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1>(this System.Action<TArg1> action) { throw null; }
        public static System.Func<TArg1, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1>(this System.Action<TArg1> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<System.IObservable<TResult>> ToAsync<TResult>(this System.Func<TResult> function) { throw null; }
        public static System.Func<System.IObservable<TResult>> ToAsync<TResult>(this System.Func<TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2>(this System.Action<TArg1, TArg2> action) { throw null; }
        public static System.Func<TArg1, TArg2, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2>(this System.Action<TArg1, TArg2> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, System.IObservable<TResult>> ToAsync<TArg1, TResult>(this System.Func<TArg1, TResult> function) { throw null; }
        public static System.Func<TArg1, System.IObservable<TResult>> ToAsync<TArg1, TResult>(this System.Func<TArg1, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3>(this System.Action<TArg1, TArg2, TArg3> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3>(this System.Action<TArg1, TArg2, TArg3> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TResult>(this System.Func<TArg1, TArg2, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TResult>(this System.Func<TArg1, TArg2, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4>(this System.Action<TArg1, TArg2, TArg3, TArg4> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4>(this System.Action<TArg1, TArg2, TArg3, TArg4> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TResult>(this System.Func<TArg1, TArg2, TArg3, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TResult>(this System.Func<TArg1, TArg2, TArg3, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> action) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, System.IObservable<System.Reactive.Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this System.Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> action, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function) { throw null; }
        public static System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, System.IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(this System.Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.Collections.Generic.IDictionary<TKey, TSource>> ToDictionary<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IDictionary<TKey, TSource>> ToDictionary<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Collections.Generic.IDictionary<TKey, TElement>> ToDictionary<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IDictionary<TKey, TElement>> ToDictionary<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.Collections.Generic.IEnumerable<TSource> ToEnumerable<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.Reactive.IEventSource<System.Reactive.Unit> ToEvent(this System.IObservable<System.Reactive.Unit> source) { throw null; }
        public static System.Reactive.IEventPatternSource<TEventArgs> ToEventPattern<TEventArgs>(this System.IObservable<System.Reactive.EventPattern<TEventArgs>> source) where TEventArgs : System.EventArgs { throw null; }
        public static System.Reactive.IEventSource<TSource> ToEvent<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> ToList<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<System.Linq.ILookup<TKey, TSource>> ToLookup<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector) { throw null; }
        public static System.IObservable<System.Linq.ILookup<TKey, TSource>> ToLookup<TSource, TKey>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<System.Linq.ILookup<TKey, TElement>> ToLookup<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { throw null; }
        public static System.IObservable<System.Linq.ILookup<TKey, TElement>> ToLookup<TSource, TKey, TElement>(this System.IObservable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { throw null; }
        public static System.IObservable<TSource> ToObservable<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { throw null; }
        public static System.IObservable<TSource> ToObservable<TSource>(this System.Collections.Generic.IEnumerable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TResult> Using<TResult, TResource>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<TResource>> resourceFactoryAsync, System.Func<TResource, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IObservable<TResult>>> observableFactoryAsync) where TResource : System.IDisposable { throw null; }
        public static System.IObservable<TResult> Using<TResult, TResource>(System.Func<TResource> resourceFactory, System.Func<TResource, System.IObservable<TResult>> observableFactory) where TResource : System.IDisposable { throw null; }
        public static TSource Wait<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TResult> When<TResult>(this System.Collections.Generic.IEnumerable<System.Reactive.Joins.Plan<TResult>> plans) { throw null; }
        public static System.IObservable<TResult> When<TResult>(params System.Reactive.Joins.Plan<TResult>[] plans) { throw null; }
        public static System.IObservable<TSource> Where<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { throw null; }
        public static System.IObservable<TSource> Where<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int, bool> predicate) { throw null; }
        public static System.IObservable<TSource> While<TSource>(System.Func<bool> condition, System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, int count) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, int count, int skip) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, int count) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, int count, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, System.TimeSpan timeShift) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource>(this System.IObservable<TSource> source, System.TimeSpan timeSpan, System.TimeSpan timeShift, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource, TWindowClosing>(this System.IObservable<TSource> source, System.Func<System.IObservable<TWindowClosing>> windowClosingSelector) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource, TWindowBoundary>(this System.IObservable<TSource> source, System.IObservable<TWindowBoundary> windowBoundaries) { throw null; }
        public static System.IObservable<System.IObservable<TSource>> Window<TSource, TWindowOpening, TWindowClosing>(this System.IObservable<TSource> source, System.IObservable<TWindowOpening> windowOpenings, System.Func<TWindowOpening, System.IObservable<TWindowClosing>> windowClosingSelector) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Zip<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        public static System.IObservable<System.Collections.Generic.IList<TSource>> Zip<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.IObservable<TSource14> source14, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.IObservable<TSource14> source14, System.IObservable<TSource15> source15, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.IObservable<TSource9> source9, System.IObservable<TSource10> source10, System.IObservable<TSource11> source11, System.IObservable<TSource12> source12, System.IObservable<TSource13> source13, System.IObservable<TSource14> source14, System.IObservable<TSource15> source15, System.IObservable<TSource16> source16, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource, TResult>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources, System.Func<System.Collections.Generic.IList<TSource>, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TResult>(this System.IObservable<TSource1> first, System.Collections.Generic.IEnumerable<TSource2> second, System.Func<TSource1, TSource2, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TResult>(this System.IObservable<TSource1> first, System.IObservable<TSource2> second, System.Func<TSource1, TSource2, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.Func<TSource1, TSource2, TSource3, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.Func<TSource1, TSource2, TSource3, TSource4, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult> resultSelector) { throw null; }
        public static System.IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>(this System.IObservable<TSource1> source1, System.IObservable<TSource2> source2, System.IObservable<TSource3> source3, System.IObservable<TSource4> source4, System.IObservable<TSource5> source5, System.IObservable<TSource6> source6, System.IObservable<TSource7> source7, System.IObservable<TSource8> source8, System.Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult> resultSelector) { throw null; }
    }
}
namespace System.Reactive.Subjects
{
    public sealed partial class AsyncSubject<T> : System.IDisposable, System.IObservable<T>, System.IObserver<T>, System.Reactive.Subjects.ISubject<T, T>, System.Reactive.Subjects.ISubject<T>, System.Runtime.CompilerServices.INotifyCompletion
    {
        public AsyncSubject() { }
        public bool HasObservers { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
        public void Dispose() { }
        public System.Reactive.Subjects.AsyncSubject<T> GetAwaiter() { throw null; }
        public T GetResult() { throw null; }
        public void OnCompleted() { }
        public void OnCompleted(System.Action continuation) { }
        public void OnError(System.Exception error) { }
        public void OnNext(T value) { }
        public System.IDisposable Subscribe(System.IObserver<T> observer) { throw null; }
    }
    public sealed partial class BehaviorSubject<T> : System.IDisposable, System.IObservable<T>, System.IObserver<T>, System.Reactive.Subjects.ISubject<T, T>, System.Reactive.Subjects.ISubject<T>
    {
        public BehaviorSubject(T value) { }
        public bool HasObservers { get { throw null; } }
        public T Value { get { throw null; } }
        public void Dispose() { }
        public void OnCompleted() { }
        public void OnError(System.Exception error) { }
        public void OnNext(T value) { }
        public System.IDisposable Subscribe(System.IObserver<T> observer) { throw null; }
    }
    public sealed partial class ReplaySubject<T> : System.IDisposable, System.IObservable<T>, System.IObserver<T>, System.Reactive.Subjects.ISubject<T, T>, System.Reactive.Subjects.ISubject<T>
    {
        public ReplaySubject() { }
        public ReplaySubject(int bufferSize) { }
        public ReplaySubject(int bufferSize, System.Reactive.Concurrency.IScheduler scheduler) { }
        public ReplaySubject(int bufferSize, System.TimeSpan window) { }
        public ReplaySubject(int bufferSize, System.TimeSpan window, System.Reactive.Concurrency.IScheduler scheduler) { }
        public ReplaySubject(System.Reactive.Concurrency.IScheduler scheduler) { }
        public ReplaySubject(System.TimeSpan window) { }
        public ReplaySubject(System.TimeSpan window, System.Reactive.Concurrency.IScheduler scheduler) { }
        public bool HasObservers { get { throw null; } }
        public void Dispose() { }
        public void OnCompleted() { }
        public void OnError(System.Exception error) { }
        public void OnNext(T value) { }
        public System.IDisposable Subscribe(System.IObserver<T> observer) { throw null; }
    }
    public static partial class Subject
    {
        public static System.Reactive.Subjects.ISubject<TSource, TResult> Create<TSource, TResult>(System.IObserver<TSource> observer, System.IObservable<TResult> observable) { throw null; }
        public static System.Reactive.Subjects.ISubject<TSource, TResult> Synchronize<TSource, TResult>(System.Reactive.Subjects.ISubject<TSource, TResult> subject) { throw null; }
        public static System.Reactive.Subjects.ISubject<TSource, TResult> Synchronize<TSource, TResult>(System.Reactive.Subjects.ISubject<TSource, TResult> subject, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
    }
    public sealed partial class Subject<T> : System.IDisposable, System.IObservable<T>, System.IObserver<T>, System.Reactive.Subjects.ISubject<T, T>, System.Reactive.Subjects.ISubject<T>
    {
        public Subject() { }
        public bool HasObservers { get { throw null; } }
        public void Dispose() { }
        public void OnCompleted() { }
        public void OnError(System.Exception error) { }
        public void OnNext(T value) { }
        public System.IDisposable Subscribe(System.IObserver<T> observer) { throw null; }
    }
}
namespace System.Reactive.Threading.Tasks
{
    public static partial class TaskObservableExtensions
    {
        public static System.IObservable<System.Reactive.Unit> ToObservable(this System.Threading.Tasks.Task task) { throw null; }
        public static System.IObservable<TResult> ToObservable<TResult>(this System.Threading.Tasks.Task<TResult> task) { throw null; }
        public static System.Threading.Tasks.Task<TResult> ToTask<TResult>(this System.IObservable<TResult> observable) { throw null; }
        public static System.Threading.Tasks.Task<TResult> ToTask<TResult>(this System.IObservable<TResult> observable, object state) { throw null; }
        public static System.Threading.Tasks.Task<TResult> ToTask<TResult>(this System.IObservable<TResult> observable, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<TResult> ToTask<TResult>(this System.IObservable<TResult> observable, System.Threading.CancellationToken cancellationToken, object state) { throw null; }
    }
}
