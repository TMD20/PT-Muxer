// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace Mono.Collections.Concurrent
{
    public partial class ConcurrentOrderedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        public ConcurrentOrderedList() { }
        public ConcurrentOrderedList(System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public System.Collections.Generic.IEqualityComparer<T> Comparer { get { throw null; } }
        public int Count { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        public void Clear() { }
        public bool Contains(T data) { throw null; }
        public bool ContainsHash(int key) { throw null; }
        public void CopyTo(T[] array, int startIndex) { }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        bool System.Collections.Generic.ICollection<T>.Remove(T item) { throw null; }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryAdd(T data) { throw null; }
        public bool TryGetFromHash(int key, out T data) { throw null; }
        public bool TryPop(out T data) { throw null; }
        public bool TryRemove(T data) { throw null; }
        public bool TryRemoveHash(int key, out T data) { throw null; }
    }
    public partial class ConcurrentSkipList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        public ConcurrentSkipList() { }
        public ConcurrentSkipList(System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public int Count { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        public void Clear() { }
        public bool Contains(T value) { throw null; }
        public bool ContainsHash(int hash) { throw null; }
        public void CopyTo(T[] array, int startIndex) { }
        public bool Remove(T value) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public T[] ToArray() { throw null; }
        public bool TryAdd(T value) { throw null; }
        public bool TryGetFromHash(int hash, out T value) { throw null; }
    }
}
namespace Mono.Threading
{
    public partial class AtomicBoolean
    {
        public AtomicBoolean() { }
        public bool Value { get { throw null; } set { } }
        public bool CompareAndExchange(bool expected, bool newVal) { throw null; }
        public bool Equals(Mono.Threading.AtomicBoolean rhs) { throw null; }
        public override bool Equals(object rhs) { throw null; }
        public bool Exchange(bool newVal) { throw null; }
        public static Mono.Threading.AtomicBoolean FromValue(bool value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static explicit operator bool (Mono.Threading.AtomicBoolean rhs) { throw null; }
        public static implicit operator Mono.Threading.AtomicBoolean (bool rhs) { throw null; }
        public bool TryRelaxedSet() { throw null; }
        public bool TrySet() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AtomicBooleanValue
    {
        private int _dummyPrimitive;
        public bool Value { get { throw null; } set { } }
        public bool CompareAndExchange(bool expected, bool newVal) { throw null; }
        public bool Equals(Mono.Threading.AtomicBooleanValue rhs) { throw null; }
        public override bool Equals(object rhs) { throw null; }
        public bool Exchange(bool newVal) { throw null; }
        public static Mono.Threading.AtomicBooleanValue FromValue(bool value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static explicit operator bool (Mono.Threading.AtomicBooleanValue rhs) { throw null; }
        public static implicit operator Mono.Threading.AtomicBooleanValue (bool rhs) { throw null; }
        public bool TryRelaxedSet() { throw null; }
        public bool TrySet() { throw null; }
    }
    public partial class CSnzi
    {
        public CSnzi() { }
        public Mono.Threading.CSnziNode Arrive() { throw null; }
        public bool Close() { throw null; }
        public bool Depart(Mono.Threading.CSnziNode node) { throw null; }
        public void Open() { }
        public System.Tuple<bool, Mono.Threading.CSnziState> Query() { throw null; }
    }
    public abstract partial class CSnziNode
    {
        protected CSnziNode() { }
    }
    public enum CSnziState
    {
        Closed = 1,
        Open = 0,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ReaderWriterLockSlimmer
    {
        private int _dummyPrimitive;
        public void EnterReadLock(ref bool taken) { }
        public void EnterWriteLock(ref bool taken) { }
        public void ExitReadLock() { }
        public void ExitWriteLock() { }
        public void TryEnterReadLock(ref bool taken) { }
        public void TryEnterWriteLock(ref bool taken) { }
    }
    public partial class Snzi
    {
        public Snzi() { }
        public bool IsSet { get { throw null; } }
        public void Decrement() { }
        public void Increment() { }
        public void Reset() { }
    }
    public partial class SpinLockWrapper
    {
        public System.Threading.SpinLock Lock;
        public SpinLockWrapper() { }
        public SpinLockWrapper(bool enableTracking) { }
    }
}
namespace Mono.Threading.Tasks
{
    public partial class CyclicDeque<T> : Mono.Threading.Tasks.IConcurrentDeque<T>
    {
        public CyclicDeque() { }
        public bool IsEmpty { get { throw null; } }
        public System.Collections.Generic.IEnumerable<T> GetEnumerable() { throw null; }
        public bool PeekBottom(out T obj) { throw null; }
        public Mono.Threading.Tasks.PopResult PopBottom(out T obj) { throw null; }
        public Mono.Threading.Tasks.PopResult PopTop(out T obj) { throw null; }
        public void PushBottom(T obj) { }
    }
    public partial interface IConcurrentDeque<T>
    {
        System.Collections.Generic.IEnumerable<T> GetEnumerable();
        Mono.Threading.Tasks.PopResult PopBottom(out T obj);
        Mono.Threading.Tasks.PopResult PopTop(out T obj);
        void PushBottom(T obj);
    }
    public enum PopResult
    {
        Abort = 2,
        Empty = 1,
        Succeed = 0,
    }
}
