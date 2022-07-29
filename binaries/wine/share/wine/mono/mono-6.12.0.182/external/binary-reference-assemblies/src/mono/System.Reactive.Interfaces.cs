// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Open Technologies, Inc.")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Retail")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Open Technologies, Inc.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Reactive Extensions Interfaces Library containing essential interfaces.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Reactive Extensions")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reactive.Interfaces")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.IObservable<>))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.IObserver<>))]
namespace System.Reactive
{
    public partial interface IEventPatternSource<TEventArgs> where TEventArgs : System.EventArgs
    {
        event System.EventHandler<TEventArgs> OnNext;
    }
    public partial interface IEventPattern<out TSender, out TEventArgs> where TEventArgs : System.EventArgs
    {
        TEventArgs EventArgs { get; }
        TSender Sender { get; }
    }
    public partial interface IEventSource<out T>
    {
        event System.Action<T> OnNext;
    }
    public partial interface IObserver<in TValue, out TResult>
    {
        TResult OnCompleted();
        TResult OnError(System.Exception exception);
        TResult OnNext(TValue value);
    }
}
namespace System.Reactive.Concurrency
{
    public partial interface IScheduledItem<TAbsolute>
    {
        TAbsolute DueTime { get; }
        void Invoke();
    }
    public partial interface IScheduler
    {
        System.DateTimeOffset Now { get; }
        System.IDisposable Schedule<TState>(TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
        System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
        System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
    }
    public partial interface ISchedulerLongRunning
    {
        System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action);
    }
    public partial interface ISchedulerPeriodic
    {
        System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action);
    }
    public partial interface IStopwatch
    {
        System.TimeSpan Elapsed { get; }
    }
    public partial interface IStopwatchProvider
    {
        System.Reactive.Concurrency.IStopwatch StartStopwatch();
    }
}
namespace System.Reactive.Disposables
{
    public partial interface ICancelable : System.IDisposable
    {
        bool IsDisposed { get; }
    }
}
namespace System.Reactive.Linq
{
    public partial interface IGroupedObservable<out TKey, out TElement> : System.IObservable<TElement>
    {
        TKey Key { get; }
    }
    public partial interface IQbservable
    {
        System.Type ElementType { get; }
        System.Linq.Expressions.Expression Expression { get; }
        System.Reactive.Linq.IQbservableProvider Provider { get; }
    }
    public partial interface IQbservableProvider
    {
        System.Reactive.Linq.IQbservable<TResult> CreateQuery<TResult>(System.Linq.Expressions.Expression expression);
    }
    public partial interface IQbservable<out T> : System.IObservable<T>, System.Reactive.Linq.IQbservable
    {
    }
}
namespace System.Reactive.Subjects
{
    public partial interface IConnectableObservable<out T> : System.IObservable<T>
    {
        System.IDisposable Connect();
    }
    public partial interface ISubject<T> : System.IObservable<T>, System.IObserver<T>, System.Reactive.Subjects.ISubject<T, T>
    {
    }
    public partial interface ISubject<in TSource, out TResult> : System.IObservable<TResult>, System.IObserver<TSource>
    {
    }
}
