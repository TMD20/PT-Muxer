// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Open Technologies, Inc.")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Retail")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Open Technologies, Inc.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Windows Presentation Foundation extensions library for Rx. Contains scheduler functionality for the WPF Dispatcher.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Reactive Extensions")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reactive.Windows.Threading")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System.Reactive.Concurrency
{
    public partial class DispatcherScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerPeriodic
    {
        public DispatcherScheduler(System.Windows.Threading.Dispatcher dispatcher) { }
        public static System.Reactive.Concurrency.DispatcherScheduler Current { get { throw null; } }
        public System.Windows.Threading.Dispatcher Dispatcher { get { throw null; } }
        [System.ObsoleteAttribute("Use the Current property to retrieve the DispatcherScheduler instance for the current thread's Dispatcher object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
        public static System.Reactive.Concurrency.DispatcherScheduler Instance { get { throw null; } }
        public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
    }
}
namespace System.Reactive.Linq
{
    public static partial class DispatcherObservable
    {
        public static System.IObservable<TSource> ObserveOnDispatcher<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.DispatcherScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.Dispatcher dispatcher) { throw null; }
        public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.DispatcherObject dispatcherObject) { throw null; }
        public static System.IObservable<TSource> SubscribeOnDispatcher<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.DispatcherScheduler scheduler) { throw null; }
        public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.Dispatcher dispatcher) { throw null; }
        public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.DispatcherObject dispatcherObject) { throw null; }
    }
}
