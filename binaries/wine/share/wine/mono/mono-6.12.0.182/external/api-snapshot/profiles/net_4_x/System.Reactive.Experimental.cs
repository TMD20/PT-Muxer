// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reactive.ExperimentalAttribute]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Open Technologies, Inc.")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Retail")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Open Technologies, Inc.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Reactive Extensions Experimental Library containing unstable and infrequently used functionality.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Reactive Extensions")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reactive.Experimental")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Reactive.Debugger, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System.Reactive
{
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    [System.Reactive.ExperimentalAttribute]
    public sealed partial class ExperimentalAttribute : System.Attribute
    {
        public ExperimentalAttribute() { }
    }
    [System.Reactive.ExperimentalAttribute]
    public partial class ListObservable<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable, System.IObservable<object>
    {
        public ListObservable(System.IObservable<T> source) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        public T Value { get { throw null; } }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { throw null; }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public int IndexOf(T item) { throw null; }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { throw null; }
        public void RemoveAt(int index) { }
        public System.IDisposable Subscribe(System.IObserver<object> observer) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
}
namespace System.Reactive.Linq
{
    public static partial class ObservableEx
    {
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<System.Reactive.Unit> Create(System.Func<System.Collections.Generic.IEnumerable<System.IObservable<object>>> iteratorMethod) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Collections.Generic.IEnumerable<System.IObservable<object>>> iteratorMethod) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TSource> Expand<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TSource>> selector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TSource> Expand<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TSource>> selector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TSource[]> ForkJoin<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TSource[]> ForkJoin<TSource>(params System.IObservable<TSource>[] sources) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TResult> ForkJoin<TSource1, TSource2, TResult>(this System.IObservable<TSource1> first, System.IObservable<TSource2> second, System.Func<TSource1, TSource2, TResult> resultSelector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TResult> Let<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TResult> ManySelect<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, TResult> selector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.IObservable<TResult> ManySelect<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, TResult> selector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.ListObservable<TSource> ToListObservable<TSource>(this System.IObservable<TSource> source) { throw null; }
    }
    [System.Reactive.Linq.LocalQueryMethodImplementationTypeAttribute(typeof(System.Reactive.Linq.ObservableEx))]
    public static partial class QbservableEx
    {
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<System.Reactive.Unit> Create(this System.Reactive.Linq.IQbservableProvider provider, System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.IObservable<object>>>> iteratorMethod) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TResult> Create<TResult>(this System.Reactive.Linq.IQbservableProvider provider, System.Linq.Expressions.Expression<System.Func<System.IObserver<TResult>, System.Collections.Generic.IEnumerable<System.IObservable<object>>>> iteratorMethod) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TSource> Expand<TSource>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.IObservable<TSource>>> selector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TSource> Expand<TSource>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.IObservable<TSource>>> selector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TSource[]> ForkJoin<TSource>(this System.Reactive.Linq.IQbservableProvider provider, System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TSource[]> ForkJoin<TSource>(this System.Reactive.Linq.IQbservableProvider provider, params System.IObservable<TSource>[] sources) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TResult> ForkJoin<TSource1, TSource2, TResult>(this System.Reactive.Linq.IQbservable<TSource1> first, System.IObservable<TSource2> second, System.Linq.Expressions.Expression<System.Func<TSource1, TSource2, TResult>> resultSelector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TResult> Let<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<System.IObservable<TSource>, System.IObservable<TResult>>> selector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TResult> ManySelect<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<System.IObservable<TSource>, TResult>> selector) { throw null; }
        [System.Reactive.ExperimentalAttribute]
        public static System.Reactive.Linq.IQbservable<TResult> ManySelect<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<System.IObservable<TSource>, TResult>> selector, System.Reactive.Concurrency.IScheduler scheduler) { throw null; }
    }
}
