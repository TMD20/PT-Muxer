// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Open Technologies, Inc.")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Retail")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Open Technologies, Inc.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Reactive Extensions Core Library containing base classes and scheduler infrastructure.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Reactive Extensions")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reactive.Core")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System
{
    public static partial class ObservableExtensions
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static System.IDisposable SubscribeSafe<T>(this System.IObservable<T> source, System.IObserver<T> observer) { throw null; }
        public static System.IDisposable Subscribe<T>(this System.IObservable<T> source) { throw null; }
        public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext) { throw null; }
        public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action onCompleted) { throw null; }
        public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action onCompleted, System.Threading.CancellationToken token) { }
        public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError) { throw null; }
        public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted) { throw null; }
        public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted, System.Threading.CancellationToken token) { }
        public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Threading.CancellationToken token) { }
        public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Threading.CancellationToken token) { }
        public static void Subscribe<T>(this System.IObservable<T> source, System.IObserver<T> observer, System.Threading.CancellationToken token) { }
        public static void Subscribe<T>(this System.IObservable<T> source, System.Threading.CancellationToken token) { }
    }
}
namespace System.Reactive
{
    public sealed partial class AnonymousObservable<T> : System.Reactive.ObservableBase<T>
    {
        public AnonymousObservable(System.Func<System.IObserver<T>, System.IDisposable> subscribe) { }
        protected override System.IDisposable SubscribeCore(System.IObserver<T> observer) { throw null; }
    }
    public sealed partial class AnonymousObserver<T> : System.Reactive.ObserverBase<T>
    {
        public AnonymousObserver(System.Action<T> onNext) { }
        public AnonymousObserver(System.Action<T> onNext, System.Action onCompleted) { }
        public AnonymousObserver(System.Action<T> onNext, System.Action<System.Exception> onError) { }
        public AnonymousObserver(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted) { }
        protected override void OnCompletedCore() { }
        protected override void OnErrorCore(System.Exception error) { }
        protected override void OnNextCore(T value) { }
    }
    public static partial class Notification
    {
        public static System.Reactive.Notification<T> CreateOnCompleted<T>() { throw null; }
        public static System.Reactive.Notification<T> CreateOnError<T>(System.Exception error) { throw null; }
        public static System.Reactive.Notification<T> CreateOnNext<T>(T value) { throw null; }
    }
    public enum NotificationKind
    {
        OnCompleted = 2,
        OnError = 1,
        OnNext = 0,
    }
    [System.SerializableAttribute]
    public abstract partial class Notification<T> : System.IEquatable<System.Reactive.Notification<T>>
    {
        protected internal Notification() { }
        public abstract System.Exception Exception { get; }
        public abstract bool HasValue { get; }
        public abstract System.Reactive.NotificationKind Kind { get; }
        public abstract T Value { get; }
        public abstract void Accept(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
        public abstract void Accept(System.IObserver<T> observer);
        public abstract TResult Accept<TResult>(System.Func<T, TResult> onNext, System.Func<System.Exception, TResult> onError, System.Func<TResult> onCompleted);
        public abstract TResult Accept<TResult>(System.Reactive.IObserver<T, TResult> observer);
        public override bool Equals(object obj) { throw null; }
        public abstract bool Equals(System.Reactive.Notification<T> other);
        public static bool operator ==(System.Reactive.Notification<T> left, System.Reactive.Notification<T> right) { throw null; }
        public static bool operator !=(System.Reactive.Notification<T> left, System.Reactive.Notification<T> right) { throw null; }
        public System.IObservable<T> ToObservable() { throw null; }
        public System.IObservable<T> ToObservable(System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
    }
    public abstract partial class ObservableBase<T> : System.IObservable<T>
    {
        protected ObservableBase() { }
        public System.IDisposable Subscribe(System.IObserver<T> observer) { throw null; }
        protected abstract System.IDisposable SubscribeCore(System.IObserver<T> observer);
    }
    public static partial class Observer
    {
        public static System.IObserver<T> AsObserver<T>(this System.IObserver<T> observer) { throw null; }
        public static System.IObserver<T> Checked<T>(this System.IObserver<T> observer) { throw null; }
        public static System.IObserver<T> Create<T>(System.Action<T> onNext) { throw null; }
        public static System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action onCompleted) { throw null; }
        public static System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action<System.Exception> onError) { throw null; }
        public static System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted) { throw null; }
        public static System.IObserver<T> NotifyOn<T>(this System.IObserver<T> observer, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObserver<T> NotifyOn<T>(this System.IObserver<T> observer, System.Threading.SynchronizationContext context) { throw null; }
        public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer) { throw null; }
        public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer, bool preventReentrancy) { throw null; }
        public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer, object gate) { throw null; }
        public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer, System.Reactive.Concurrency.AsyncLock asyncLock) { throw null; }
        public static System.Action<System.Reactive.Notification<T>> ToNotifier<T>(this System.IObserver<T> observer) { throw null; }
        public static System.IObserver<T> ToObserver<T>(this System.Action<System.Reactive.Notification<T>> handler) { throw null; }
    }
    public abstract partial class ObserverBase<T> : System.IDisposable, System.IObserver<T>
    {
        protected ObserverBase() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void OnCompleted() { }
        protected abstract void OnCompletedCore();
        public void OnError(System.Exception error) { }
        protected abstract void OnErrorCore(System.Exception error);
        public void OnNext(T value) { }
        protected abstract void OnNextCore(T value);
    }
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    public partial struct Unit : System.IEquatable<System.Reactive.Unit>
    {
        public static System.Reactive.Unit Default { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reactive.Unit other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reactive.Unit first, System.Reactive.Unit second) { throw null; }
        public static bool operator !=(System.Reactive.Unit first, System.Reactive.Unit second) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Reactive.Concurrency
{
    public sealed partial class AsyncLock : System.IDisposable
    {
        public AsyncLock() { }
        public void Dispose() { }
        public void Wait(System.Action action) { }
    }
    public sealed partial class CurrentThreadScheduler : System.Reactive.Concurrency.LocalScheduler
    {
        internal CurrentThreadScheduler() { }
        public static System.Reactive.Concurrency.CurrentThreadScheduler Instance { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static bool IsScheduleRequired { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This instance property is no longer supported. Use CurrentThreadScheduler.IsScheduleRequired instead. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public bool ScheduleRequired { get { throw null; } }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
    }
    public sealed partial class DefaultScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerPeriodic
    {
        internal DefaultScheduler() { }
        public static System.Reactive.Concurrency.DefaultScheduler Instance { get { throw null; } }
        protected override object GetService(System.Type serviceType) { throw null; }
        public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial interface IConcurrencyAbstractionLayer
    {
        bool SupportsLongRunning { get; }
        System.IDisposable QueueUserWorkItem(System.Action<object> action, object state);
        void Sleep(System.TimeSpan timeout);
        System.IDisposable StartPeriodicTimer(System.Action action, System.TimeSpan period);
        System.Reactive.Concurrency.IStopwatch StartStopwatch();
        void StartThread(System.Action<object> action, object state);
        System.IDisposable StartTimer(System.Action<object> action, object state, System.TimeSpan dueTime);
    }
    public sealed partial class ImmediateScheduler : System.Reactive.Concurrency.LocalScheduler
    {
        internal ImmediateScheduler() { }
        public static System.Reactive.Concurrency.ImmediateScheduler Instance { get { throw null; } }
        public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
    }
    public abstract partial class LocalScheduler : System.IServiceProvider, System.Reactive.Concurrency.IScheduler, System.Reactive.Concurrency.IStopwatchProvider
    {
        protected LocalScheduler() { }
        public virtual System.DateTimeOffset Now { get { throw null; } }
        protected virtual object GetService(System.Type serviceType) { throw null; }
        public virtual System.IDisposable Schedule<TState>(TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public virtual System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public abstract System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
        public virtual System.Reactive.Concurrency.IStopwatch StartStopwatch() { throw null; }
        object System.IServiceProvider.GetService(System.Type serviceType) { throw null; }
    }
    public abstract partial class ScheduledItem<TAbsolute> : System.IComparable<System.Reactive.Concurrency.ScheduledItem<TAbsolute>>, System.Reactive.Concurrency.IScheduledItem<TAbsolute> where TAbsolute : System.IComparable<TAbsolute>
    {
        protected ScheduledItem(TAbsolute dueTime, System.Collections.Generic.IComparer<TAbsolute> comparer) { }
        public TAbsolute DueTime { get { throw null; } }
        public bool IsCanceled { get { throw null; } }
        public void Cancel() { }
        public int CompareTo(System.Reactive.Concurrency.ScheduledItem<TAbsolute> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public void Invoke() { }
        protected abstract System.IDisposable InvokeCore();
        public static bool operator ==(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { throw null; }
        public static bool operator >(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { throw null; }
        public static bool operator >=(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { throw null; }
        public static bool operator !=(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { throw null; }
        public static bool operator <(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { throw null; }
        public static bool operator <=(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { throw null; }
    }
    public sealed partial class ScheduledItem<TAbsolute, TValue> : System.Reactive.Concurrency.ScheduledItem<TAbsolute> where TAbsolute : System.IComparable<TAbsolute>
    {
        public ScheduledItem(System.Reactive.Concurrency.IScheduler scheduler, TValue state, System.Func<System.Reactive.Concurrency.IScheduler, TValue, System.IDisposable> action, TAbsolute dueTime) : base (default(TAbsolute), default(System.Collections.Generic.IComparer<TAbsolute>)) { }
        public ScheduledItem(System.Reactive.Concurrency.IScheduler scheduler, TValue state, System.Func<System.Reactive.Concurrency.IScheduler, TValue, System.IDisposable> action, TAbsolute dueTime, System.Collections.Generic.IComparer<TAbsolute> comparer) : base (default(TAbsolute), default(System.Collections.Generic.IComparer<TAbsolute>)) { }
        protected override System.IDisposable InvokeCore() { throw null; }
    }
    public static partial class Scheduler
    {
        public static System.Reactive.Concurrency.CurrentThreadScheduler CurrentThread { get { throw null; } }
        public static System.Reactive.Concurrency.DefaultScheduler Default { get { throw null; } }
        public static System.Reactive.Concurrency.ImmediateScheduler Immediate { get { throw null; } }
        [System.ObsoleteAttribute("This property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Please add a reference to the System.Reactive.PlatformServices assembly for your target platform and use NewThreadScheduler.Default to obtain an instance of this scheduler type. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Reactive.Concurrency.IScheduler NewThread { get { throw null; } }
        public static System.DateTimeOffset Now { get { throw null; } }
        [System.ObsoleteAttribute("This property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Please add a reference to the System.Reactive.PlatformServices assembly for your target platform and use TaskPoolScheduler.Default to obtain an instance of this scheduler type. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Reactive.Concurrency.IScheduler TaskPool { get { throw null; } }
        [System.ObsoleteAttribute("This property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Consider using Scheduler.Default to obtain the platform's most appropriate pool-based scheduler. In order to access a specific pool-based scheduler, please add a reference to the System.Reactive.PlatformServices assembly for your target platform and use the appropriate scheduler in the System.Reactive.Concurrency namespace. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Reactive.Concurrency.IScheduler ThreadPool { get { throw null; } }
        public static System.Reactive.Concurrency.ISchedulerLongRunning AsLongRunning(this System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Concurrency.ISchedulerPeriodic AsPeriodic(this System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Concurrency.IStopwatchProvider AsStopwatchProvider(this System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Concurrency.IScheduler Catch<TException>(this System.Reactive.Concurrency.IScheduler scheduler, System.Func<TException, bool> handler) where TException : System.Exception { throw null; }
        public static System.Reactive.Concurrency.IScheduler DisableOptimizations(this System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Concurrency.IScheduler DisableOptimizations(this System.Reactive.Concurrency.IScheduler scheduler, params System.Type[] optimizationInterfaces) { throw null; }
        public static System.TimeSpan Normalize(System.TimeSpan timeSpan) { throw null; }
        public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.Action action) { throw null; }
        public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.Action<System.Action> action) { throw null; }
        public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Action action) { throw null; }
        public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Action<System.Action<System.DateTimeOffset>> action) { throw null; }
        public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Action action) { throw null; }
        public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Action<System.Action<System.TimeSpan>> action) { throw null; }
        public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { throw null; }
        public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { throw null; }
        public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { throw null; }
        public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { throw null; }
        public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { throw null; }
        public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { throw null; }
        public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { throw null; }
        public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { throw null; }
        public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { throw null; }
        public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { throw null; }
        public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { throw null; }
        public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { throw null; }
        public static System.IDisposable ScheduleLongRunning(this System.Reactive.Concurrency.ISchedulerLongRunning scheduler, System.Action<System.Reactive.Disposables.ICancelable> action) { throw null; }
        public static System.IDisposable SchedulePeriodic(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan period, System.Action action) { throw null; }
        public static System.IDisposable SchedulePeriodic<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan period, System.Action<TState> action) { throw null; }
        public static System.IDisposable SchedulePeriodic<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan period, System.Func<TState, TState> action) { throw null; }
        public static System.IDisposable Schedule<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.Action<TState, System.Action<TState>> action) { throw null; }
        public static System.IDisposable Schedule<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.DateTimeOffset dueTime, System.Action<TState, System.Action<TState, System.DateTimeOffset>> action) { throw null; }
        public static System.IDisposable Schedule<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan dueTime, System.Action<TState, System.Action<TState, System.TimeSpan>> action) { throw null; }
        public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime) { throw null; }
        public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime) { throw null; }
        public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Reactive.Concurrency.IStopwatch StartStopwatch(this System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Concurrency.SchedulerOperation Yield(this System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.Reactive.Concurrency.SchedulerOperation Yield(this System.Reactive.Concurrency.IScheduler scheduler, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class SchedulerOperation
    {
        internal SchedulerOperation() { }
        public System.Reactive.Concurrency.SchedulerOperation ConfigureAwait(bool continueOnCapturedContext) { throw null; }
        public System.Reactive.Concurrency.SchedulerOperationAwaiter GetAwaiter() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class SchedulerOperationAwaiter : System.Runtime.CompilerServices.INotifyCompletion
    {
        internal SchedulerOperationAwaiter() { }
        public bool IsCompleted { get { throw null; } }
        public void GetResult() { }
        public void OnCompleted(System.Action continuation) { }
    }
    public partial class SchedulerQueue<TAbsolute> where TAbsolute : System.IComparable<TAbsolute>
    {
        public SchedulerQueue() { }
        public SchedulerQueue(int capacity) { }
        public int Count { get { throw null; } }
        public System.Reactive.Concurrency.ScheduledItem<TAbsolute> Dequeue() { throw null; }
        public void Enqueue(System.Reactive.Concurrency.ScheduledItem<TAbsolute> scheduledItem) { }
        public System.Reactive.Concurrency.ScheduledItem<TAbsolute> Peek() { throw null; }
        public bool Remove(System.Reactive.Concurrency.ScheduledItem<TAbsolute> scheduledItem) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static partial class Synchronization
    {
        public static System.IObservable<TSource> ObserveOn<TSource>(System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> ObserveOn<TSource>(System.IObservable<TSource> source, System.Threading.SynchronizationContext context) { throw null; }
        public static System.IObservable<TSource> SubscribeOn<TSource>(System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> SubscribeOn<TSource>(System.IObservable<TSource> source, System.Threading.SynchronizationContext context) { throw null; }
        public static System.IObservable<TSource> Synchronize<TSource>(System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Synchronize<TSource>(System.IObservable<TSource> source, object gate) { throw null; }
    }
    public partial class SynchronizationContextScheduler : System.Reactive.Concurrency.LocalScheduler
    {
        public SynchronizationContextScheduler(System.Threading.SynchronizationContext context) { }
        public SynchronizationContextScheduler(System.Threading.SynchronizationContext context, bool alwaysPost) { }
        public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
    }
}
namespace System.Reactive.Disposables
{
    public sealed partial class BooleanDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public BooleanDisposable() { }
        public bool IsDisposed { get { throw null; } }
        public void Dispose() { }
    }
    public sealed partial class CancellationDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public CancellationDisposable() { }
        public CancellationDisposable(System.Threading.CancellationTokenSource cts) { }
        public bool IsDisposed { get { throw null; } }
        public System.Threading.CancellationToken Token { get { throw null; } }
        public void Dispose() { }
    }
    public sealed partial class CompositeDisposable : System.Collections.Generic.ICollection<System.IDisposable>, System.Collections.Generic.IEnumerable<System.IDisposable>, System.Collections.IEnumerable, System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public CompositeDisposable() { }
        public CompositeDisposable(System.Collections.Generic.IEnumerable<System.IDisposable> disposables) { }
        public CompositeDisposable(params System.IDisposable[] disposables) { }
        public CompositeDisposable(int capacity) { }
        public int Count { get { throw null; } }
        public bool IsDisposed { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public void Add(System.IDisposable item) { }
        public void Clear() { }
        public bool Contains(System.IDisposable item) { throw null; }
        public void CopyTo(System.IDisposable[] array, int arrayIndex) { }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerator<System.IDisposable> GetEnumerator() { throw null; }
        public bool Remove(System.IDisposable item) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class ContextDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public ContextDisposable(System.Threading.SynchronizationContext context, System.IDisposable disposable) { }
        public System.Threading.SynchronizationContext Context { get { throw null; } }
        public bool IsDisposed { get { throw null; } }
        public void Dispose() { }
    }
    public static partial class Disposable
    {
        public static System.IDisposable Empty { get { throw null; } }
        public static System.IDisposable Create(System.Action dispose) { throw null; }
    }
    public sealed partial class MultipleAssignmentDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public MultipleAssignmentDisposable() { }
        public System.IDisposable Disposable { get { throw null; } set { } }
        public bool IsDisposed { get { throw null; } }
        public void Dispose() { }
    }
    public sealed partial class RefCountDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public RefCountDisposable(System.IDisposable disposable) { }
        public bool IsDisposed { get { throw null; } }
        public void Dispose() { }
        public System.IDisposable GetDisposable() { throw null; }
    }
    public sealed partial class ScheduledDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public ScheduledDisposable(System.Reactive.Concurrency.IScheduler scheduler, System.IDisposable disposable) { }
        public System.IDisposable Disposable { get { throw null; } }
        public bool IsDisposed { get { throw null; } }
        public System.Reactive.Concurrency.IScheduler Scheduler { get { throw null; } }
        public void Dispose() { }
    }
    public sealed partial class SerialDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public SerialDisposable() { }
        public System.IDisposable Disposable { get { throw null; } set { } }
        public bool IsDisposed { get { throw null; } }
        public void Dispose() { }
    }
    public sealed partial class SingleAssignmentDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable
    {
        public SingleAssignmentDisposable() { }
        public System.IDisposable Disposable { get { throw null; } set { } }
        public bool IsDisposed { get { throw null; } }
        public void Dispose() { }
    }
}
namespace System.Reactive.PlatformServices
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class DefaultSystemClock : System.Reactive.PlatformServices.ISystemClock
    {
        public DefaultSystemClock() { }
        public System.DateTimeOffset UtcNow { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class HostLifecycleService
    {
        public static event System.EventHandler<System.Reactive.PlatformServices.HostResumingEventArgs> Resuming { add { } remove { } }
        public static event System.EventHandler<System.Reactive.PlatformServices.HostSuspendingEventArgs> Suspending { add { } remove { } }
        public static void AddRef() { }
        public static void Release() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class HostResumingEventArgs : System.EventArgs
    {
        public HostResumingEventArgs() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class HostSuspendingEventArgs : System.EventArgs
    {
        public HostSuspendingEventArgs() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial interface IExceptionServices
    {
        void Rethrow(System.Exception exception);
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial interface IHostLifecycleNotifications
    {
        event System.EventHandler<System.Reactive.PlatformServices.HostResumingEventArgs> Resuming;
        event System.EventHandler<System.Reactive.PlatformServices.HostSuspendingEventArgs> Suspending;
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial interface INotifySystemClockChanged
    {
        event System.EventHandler<System.Reactive.PlatformServices.SystemClockChangedEventArgs> SystemClockChanged;
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial interface IPlatformEnlightenmentProvider
    {
        T GetService<T>(params object[] args) where T : class;
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial interface ISystemClock
    {
        System.DateTimeOffset UtcNow { get; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class PeriodicTimerSystemClockMonitor : System.Reactive.PlatformServices.INotifySystemClockChanged
    {
        public PeriodicTimerSystemClockMonitor(System.TimeSpan period) { }
        public event System.EventHandler<System.Reactive.PlatformServices.SystemClockChangedEventArgs> SystemClockChanged { add { } remove { } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class PlatformEnlightenmentProvider
    {
        public static System.Reactive.PlatformServices.IPlatformEnlightenmentProvider Current { get { throw null; } set { } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class SystemClock
    {
        public static System.DateTimeOffset UtcNow { get { throw null; } }
        public static event System.EventHandler<System.Reactive.PlatformServices.SystemClockChangedEventArgs> SystemClockChanged { add { } remove { } }
        public static void AddRef() { }
        public static void Release() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class SystemClockChangedEventArgs : System.EventArgs
    {
        public SystemClockChangedEventArgs() { }
        public SystemClockChangedEventArgs(System.DateTimeOffset oldTime, System.DateTimeOffset newTime) { }
        public System.DateTimeOffset NewTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.DateTimeOffset OldTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
