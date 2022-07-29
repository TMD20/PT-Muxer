// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Open Technologies, Inc.")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Retail")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Open Technologies, Inc.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Reactive Extensions Platform Services Library used to access platform-specific functionality and enlightenment services.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Reactive Extensions")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reactive.PlatformServices")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System.Reactive.Concurrency
{
    public sealed partial class EventLoopScheduler : System.Reactive.Concurrency.LocalScheduler, System.IDisposable, System.Reactive.Concurrency.ISchedulerPeriodic
    {
        public EventLoopScheduler() { }
        public EventLoopScheduler(System.Func<System.Threading.ThreadStart, System.Threading.Thread> threadFactory) { }
        public void Dispose() { }
        public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { throw null; }
    }
    public sealed partial class NewThreadScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerLongRunning, System.Reactive.Concurrency.ISchedulerPeriodic
    {
        public NewThreadScheduler() { }
        public NewThreadScheduler(System.Func<System.Threading.ThreadStart, System.Threading.Thread> threadFactory) { }
        public static System.Reactive.Concurrency.NewThreadScheduler Default { get { throw null; } }
        public System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action) { throw null; }
        public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { throw null; }
    }
    public sealed partial class TaskPoolScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerLongRunning, System.Reactive.Concurrency.ISchedulerPeriodic
    {
        public TaskPoolScheduler(System.Threading.Tasks.TaskFactory taskFactory) { }
        public static System.Reactive.Concurrency.TaskPoolScheduler Default { get { throw null; } }
        public System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action) { throw null; }
        public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { throw null; }
    }
    public sealed partial class ThreadPoolScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerLongRunning, System.Reactive.Concurrency.ISchedulerPeriodic
    {
        internal ThreadPoolScheduler() { }
        public static System.Reactive.Concurrency.ThreadPoolScheduler Instance { get { throw null; } }
        public System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action) { throw null; }
        public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { throw null; }
        public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { throw null; }
    }
}
namespace System.Reactive.PlatformServices
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class CurrentPlatformEnlightenmentProvider : System.Reactive.PlatformServices.IPlatformEnlightenmentProvider
    {
        public CurrentPlatformEnlightenmentProvider() { }
        public virtual T GetService<T>(object[] args) where T : class { throw null; }
    }
    public static partial class EnlightenmentProvider
    {
        public static bool EnsureLoaded() { throw null; }
    }
}
