// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("1.1.1.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003-2010 Niels Kokholm and Peter Sestoft")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("This is a build of release 1.1.1")]
[assembly:System.Reflection.AssemblyProductAttribute("")]
[assembly:System.Reflection.AssemblyTitleAttribute("C5: Copenhagen Comprehensive Collection Classes for CLI")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace C5
{
    public delegate void Act();
    public delegate void Act<A1>(A1 x1);
    public delegate void Act<A1, A2>(A1 x1, A2 x2);
    public delegate void Act<A1, A2, A3>(A1 x1, A2 x2, A3 x3);
    public delegate void Act<A1, A2, A3, A4>(A1 x1, A2 x2, A3 x3, A4 x4);
    [System.SerializableAttribute]
    public abstract partial class ArrayBase<T> : C5.SequencedBase<T>
    {
        protected T[] array;
        protected int offset;
        protected ArrayBase(int capacity, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public virtual C5.IDirectedCollectionValue<T> this[int start, int count] { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public override C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Check() { throw null; }
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public virtual void Clear() { }
        protected virtual void expand() { }
        protected virtual void expand(int newcapacity, int newsize) { }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        protected virtual void insert(int i, T item) { }
        [C5.TestedAttribute]
        public override T[] ToArray() { throw null; }
        protected partial class Range : C5.DirectedCollectionValueBase<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
        {
            internal Range() { }
            [C5.TestedAttribute]
            public override int Count { [C5.TestedAttribute]get { throw null; } }
            public override C5.Speed CountSpeed { get { throw null; } }
            [C5.TestedAttribute]
            public override C5.EnumerationDirection Direction { [C5.TestedAttribute]get { throw null; } }
            public override bool IsEmpty { get { throw null; } }
            [C5.TestedAttribute]
            public override C5.IDirectedCollectionValue<T> Backwards() { throw null; }
            C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
            public override T Choose() { throw null; }
            [C5.TestedAttribute]
            public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        }
    }
    [System.SerializableAttribute]
    public partial class ArrayList<T> : C5.ArrayBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IList<T>, C5.IQueue<T>, C5.ISequenced<T>, C5.IShowable, C5.IStack<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public ArrayList() : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public ArrayList(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public ArrayList(int capacity) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public ArrayList(int capacity, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public virtual bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public override int Count { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool FIFO { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public virtual T First { [C5.TestedAttribute]get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsValid { get { throw null; } }
        [C5.TestedAttribute]
        public virtual T this[int index] { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public virtual T Last { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public virtual int Offset { [C5.TestedAttribute]get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        [System.ObsoleteAttribute]
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Underlying { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        [C5.TestedAttribute]
        public override bool Check() { throw null; }
        [C5.TestedAttribute]
        public override void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public virtual int ContainsCount(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual T Dequeue() { throw null; }
        public virtual void Dispose() { }
        [C5.TestedAttribute]
        public virtual void Enqueue(T item) { }
        protected override void expand() { }
        protected override void expand(int newcapacity, int newsize) { }
        [C5.TestedAttribute]
        public virtual bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public virtual bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public override int GetUnsequencedHashCode() { throw null; }
        [C5.TestedAttribute]
        public virtual int IndexOf(T item) { throw null; }
        public void Insert(C5.IList<T> pointer, T item) { }
        protected override void insert(int i, T item) { }
        [C5.TestedAttribute]
        public virtual void Insert(int index, T item) { }
        [C5.TestedAttribute]
        public virtual void InsertAll<U>(int index, System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void InsertFirst(T item) { }
        [C5.TestedAttribute]
        public virtual void InsertLast(T item) { }
        [C5.TestedAttribute]
        public bool IsSorted() { throw null; }
        [C5.TestedAttribute]
        public virtual bool IsSorted(System.Collections.Generic.IComparer<T> c) { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public virtual int LastIndexOf(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> LastViewOf(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<V> Map<V>(C5.Fun<T, V> mapper) { throw null; }
        public virtual C5.IList<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IEqualityComparer<V> itemequalityComparer) { throw null; }
        protected override void modifycheck(int stamp) { }
        [C5.TestedAttribute]
        public virtual T Pop() { throw null; }
        [C5.TestedAttribute]
        public virtual void Push(T item) { }
        [C5.TestedAttribute]
        public virtual T Remove() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public virtual void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual T RemoveAt(int index) { throw null; }
        [C5.TestedAttribute]
        public virtual T RemoveFirst() { throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveInterval(int start, int count) { }
        [C5.TestedAttribute]
        public virtual T RemoveLast() { throw null; }
        [C5.TestedAttribute]
        public virtual void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void Reverse() { }
        public virtual void Shuffle() { }
        public virtual void Shuffle(System.Random rnd) { }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Slide(int offset) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Slide(int offset, int size) { throw null; }
        public virtual void Sort() { }
        [C5.TestedAttribute]
        public virtual void Sort(System.Collections.Generic.IComparer<T> comparer) { }
        public virtual C5.IList<T> Span(C5.IList<T> otherView) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
        int System.Collections.IList.Add(object o) { throw null; }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
        [C5.TestedAttribute]
        public virtual bool TrySlide(int offset) { throw null; }
        [C5.TestedAttribute]
        public virtual bool TrySlide(int offset, int size) { throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public override bool UnsequencedEquals(C5.ICollection<T> that) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Update(T item) { throw null; }
        public virtual bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        protected override void updatecheck() { }
        [C5.TestedAttribute]
        public virtual bool UpdateOrAdd(T item) { throw null; }
        public virtual bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> View(int start, int count) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> ViewOf(T item) { throw null; }
    }
    public partial class ByteEqualityComparer : System.Collections.Generic.IEqualityComparer<byte>
    {
        internal ByteEqualityComparer() { }
        public static C5.ByteEqualityComparer Default { get { throw null; } }
        public bool Equals(byte item1, byte item2) { throw null; }
        public int GetHashCode(byte item) { throw null; }
    }
    public partial class C5Random : System.Random
    {
        public C5Random() { }
        public C5Random(long seed) { }
        [System.CLSCompliantAttribute(false)]
        public C5Random(uint[] Q) { }
        public override int Next() { throw null; }
        public override int Next(int max) { throw null; }
        public override int Next(int min, int max) { throw null; }
        public override void NextBytes(byte[] buffer) { }
        public override double NextDouble() { throw null; }
        protected override double Sample() { throw null; }
    }
    public partial class CharEqualityComparer : System.Collections.Generic.IEqualityComparer<char>
    {
        internal CharEqualityComparer() { }
        public static C5.CharEqualityComparer Default { get { throw null; } }
        public bool Equals(char item1, char item2) { throw null; }
        public int GetHashCode(char item) { throw null; }
    }
    public partial class CircularQueue<T> : C5.SequencedBase<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IQueue<T>, C5.IShowable, C5.IStack<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        public CircularQueue() : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public CircularQueue(int capacity) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public virtual bool AllowsDuplicates { get { throw null; } }
        public virtual T this[int i] { get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        public override C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public virtual bool Check() { throw null; }
        [C5.TestedAttribute]
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public virtual T Dequeue() { throw null; }
        [C5.TestedAttribute]
        public virtual void Enqueue(T item) { }
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public T Pop() { throw null; }
        public void Push(T item) { }
    }
    public partial class ClearedEventArgs : System.EventArgs
    {
        public readonly int Count;
        public readonly bool Full;
        public ClearedEventArgs(bool full, int count) { }
        public override string ToString() { throw null; }
    }
    public partial class ClearedRangeEventArgs : C5.ClearedEventArgs
    {
        public readonly System.Nullable<int> Start;
        public ClearedRangeEventArgs(bool full, int count, System.Nullable<int> start) : base (default(bool), default(int)) { }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public abstract partial class CollectionBase<T> : C5.CollectionValueBase<T>
    {
        protected bool isReadOnlyBase;
        protected readonly System.Collections.Generic.IEqualityComparer<T> itemequalityComparer;
        protected int size;
        protected int stamp;
        protected CollectionBase(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) { }
        [C5.TestedAttribute]
        public override int Count { [C5.TestedAttribute]get { throw null; } }
        public override C5.Speed CountSpeed { get { throw null; } }
        public virtual System.Collections.Generic.IEqualityComparer<T> EqualityComparer { get { throw null; } }
        [C5.TestedAttribute]
        public override bool IsEmpty { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool IsReadOnly { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        protected void checkRange(int start, int count) { }
        [C5.TestedAttribute]
        public static int ComputeHashCode(C5.ICollectionValue<T> items, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) { throw null; }
        public abstract override System.Collections.Generic.IEnumerator<T> GetEnumerator();
        public virtual int GetUnsequencedHashCode() { throw null; }
        protected virtual void modifycheck(int thestamp) { }
        [C5.TestedAttribute]
        public static bool StaticEquals(C5.ICollection<T> collection1, C5.ICollection<T> collection2, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) { throw null; }
        public virtual bool UnsequencedEquals(C5.ICollection<T> otherCollection) { throw null; }
        protected virtual void updatecheck() { }
    }
    public delegate void CollectionChangedHandler<T>(object sender);
    public delegate void CollectionClearedHandler<T>(object sender, C5.ClearedEventArgs eventArgs);
    [System.SerializableAttribute]
    public partial class CollectionModifiedException : System.Exception
    {
        public CollectionModifiedException() { }
        public CollectionModifiedException(string message) { }
    }
    [System.SerializableAttribute]
    public abstract partial class CollectionValueBase<T> : C5.EnumerableBase<T>, C5.ICollectionValue<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        protected CollectionValueBase() { }
        public virtual C5.EventTypeEnum ActiveEvents { get { throw null; } }
        public abstract int Count { get; }
        public abstract C5.Speed CountSpeed { get; }
        public abstract bool IsEmpty { get; }
        public virtual C5.EventTypeEnum ListenableEvents { get { throw null; } }
        public virtual event C5.CollectionChangedHandler<T> CollectionChanged { add { } remove { } }
        public virtual event C5.CollectionClearedHandler<T> CollectionCleared { add { } remove { } }
        public virtual event C5.ItemInsertedHandler<T> ItemInserted { add { } remove { } }
        public virtual event C5.ItemRemovedAtHandler<T> ItemRemovedAt { add { } remove { } }
        public virtual event C5.ItemsAddedHandler<T> ItemsAdded { add { } remove { } }
        public virtual event C5.ItemsRemovedHandler<T> ItemsRemoved { add { } remove { } }
        [C5.TestedAttribute]
        public virtual bool All(C5.Fun<T, bool> predicate) { throw null; }
        [C5.TestedAttribute]
        public virtual void Apply(C5.Act<T> action) { }
        public abstract T Choose();
        [C5.TestedAttribute]
        public virtual void CopyTo(T[] array, int index) { }
        [C5.TestedAttribute]
        public virtual bool Exists(C5.Fun<T, bool> predicate) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<T> Filter(C5.Fun<T, bool> predicate) { throw null; }
        public virtual bool Find(C5.Fun<T, bool> predicate, out T item) { item = default(T); throw null; }
        public abstract override System.Collections.Generic.IEnumerator<T> GetEnumerator();
        protected virtual void raiseCollectionChanged() { }
        protected virtual void raiseCollectionCleared(bool full, int count) { }
        protected virtual void raiseCollectionCleared(bool full, int count, System.Nullable<int> offset) { }
        protected virtual void raiseForAdd(T item) { }
        protected virtual void raiseForInsert(int i, T item) { }
        protected void raiseForRemove(T item) { }
        protected void raiseForRemove(T item, int count) { }
        protected virtual void raiseForRemoveAll(C5.ICollectionValue<T> wasRemoved) { }
        protected void raiseForRemoveAt(int index, T item) { }
        protected virtual void raiseForSetThis(int index, T value, T item) { }
        protected virtual void raiseForUpdate(T newitem, T olditem) { }
        protected virtual void raiseForUpdate(T newitem, T olditem, int count) { }
        protected virtual void raiseItemInserted(T item, int index) { }
        protected virtual void raiseItemRemovedAt(T item, int index) { }
        protected virtual void raiseItemsAdded(T item, int count) { }
        protected virtual void raiseItemsRemoved(T item, int count) { }
        public virtual bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public virtual T[] ToArray() { throw null; }
        public override string ToString() { throw null; }
        public virtual string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
        protected partial class RaiseForRemoveAllHandler
        {
            public readonly bool MustFire;
            public RaiseForRemoveAllHandler(C5.CollectionValueBase<T> collection) { }
            public void Raise() { }
            public void Remove(T item) { }
        }
    }
    [System.SerializableAttribute]
    public partial class ComparerZeroHashCodeEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>
    {
        public ComparerZeroHashCodeEqualityComparer(System.Collections.Generic.IComparer<T> comparer) { }
        public bool Equals(T item1, T item2) { throw null; }
        public int GetHashCode(T item) { throw null; }
    }
    public static partial class Comparer<T>
    {
        [C5.TestedAttribute]
        public static System.Collections.Generic.IComparer<T> Default { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class DecimalEqualityComparer : System.Collections.Generic.IEqualityComparer<decimal>
    {
        internal DecimalEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.DecimalEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(decimal item1, decimal item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(decimal item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class DelegateComparer<T> : System.Collections.Generic.IComparer<T>
    {
        public DelegateComparer(System.Comparison<T> comparison) { }
        public int Compare(T item1, T item2) { throw null; }
    }
    [System.SerializableAttribute]
    public abstract partial class DictionaryBase<K, V> : C5.CollectionValueBase<C5.KeyValuePair<K, V>>, C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IDictionary<K, V>, C5.IShowable, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        protected C5.ICollection<C5.KeyValuePair<K, V>> pairs;
        protected DictionaryBase(System.Collections.Generic.IEqualityComparer<K> keyequalityComparer) { }
        public override C5.EventTypeEnum ActiveEvents { get { throw null; } }
        public virtual C5.Speed ContainsSpeed { get { throw null; } }
        [C5.TestedAttribute]
        public override int Count { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public override C5.Speed CountSpeed { [C5.TestedAttribute]get { throw null; } }
        public virtual System.Collections.Generic.IEqualityComparer<K> EqualityComparer { get { throw null; } }
        public virtual C5.Fun<K, V> Fun { get { throw null; } }
        public override bool IsEmpty { get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool IsReadOnly { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual V this[K key] { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public virtual C5.ICollectionValue<K> Keys { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public virtual C5.ICollectionValue<V> Values { [C5.TestedAttribute]get { throw null; } }
        public override event C5.CollectionChangedHandler<C5.KeyValuePair<K, V>> CollectionChanged { add { } remove { } }
        public override event C5.CollectionClearedHandler<C5.KeyValuePair<K, V>> CollectionCleared { add { } remove { } }
        public override event C5.ItemsAddedHandler<C5.KeyValuePair<K, V>> ItemsAdded { add { } remove { } }
        public override event C5.ItemsRemovedHandler<C5.KeyValuePair<K, V>> ItemsRemoved { add { } remove { } }
        [C5.TestedAttribute]
        public virtual void Add(K key, V value) { }
        public virtual void AddAll<L, W>(System.Collections.Generic.IEnumerable<C5.KeyValuePair<L, W>> entries) where L : K where W : V { }
        [C5.TestedAttribute]
        public virtual bool Check() { throw null; }
        public override C5.KeyValuePair<K, V> Choose() { throw null; }
        [C5.TestedAttribute]
        public virtual void Clear() { }
        public abstract object Clone();
        [C5.TestedAttribute]
        public virtual bool Contains(K key) { throw null; }
        public virtual bool ContainsAll<H>(System.Collections.Generic.IEnumerable<H> keys) where H : K { throw null; }
        [C5.TestedAttribute]
        public virtual bool Find(K key, out V value) { value = default(V); throw null; }
        public virtual bool Find(ref K key, out V value) { value = default(V); throw null; }
        [C5.TestedAttribute]
        public virtual bool FindOrAdd(K key, ref V value) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<C5.KeyValuePair<K, V>> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(K key) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(K key, out V value) { value = default(V); throw null; }
        public override bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Update(K key, V value) { throw null; }
        public virtual bool Update(K key, V value, out V oldvalue) { oldvalue = default(V); throw null; }
        [C5.TestedAttribute]
        public virtual bool UpdateOrAdd(K key, V value) { throw null; }
        public virtual bool UpdateOrAdd(K key, V value, out V oldvalue) { oldvalue = default(V); throw null; }
    }
    [System.SerializableAttribute]
    public abstract partial class DirectedCollectionBase<T> : C5.CollectionBase<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        protected DirectedCollectionBase(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public virtual C5.EnumerationDirection Direction { [C5.TestedAttribute]get { throw null; } }
        public abstract C5.IDirectedCollectionValue<T> Backwards();
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public virtual bool FindLast(C5.Fun<T, bool> predicate, out T item) { item = default(T); throw null; }
    }
    public abstract partial class DirectedCollectionValueBase<T> : C5.CollectionValueBase<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        protected DirectedCollectionValueBase() { }
        public virtual C5.EnumerationDirection Direction { [C5.TestedAttribute]get { throw null; } }
        public abstract C5.IDirectedCollectionValue<T> Backwards();
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public virtual bool FindLast(C5.Fun<T, bool> predicate, out T item) { item = default(T); throw null; }
    }
    public partial class DoubleEqualityComparer : System.Collections.Generic.IEqualityComparer<double>
    {
        internal DoubleEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.DoubleEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(double item1, double item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(double item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class DuplicateNotAllowedException : System.Exception
    {
        public DuplicateNotAllowedException() { }
        public DuplicateNotAllowedException(string message) { }
    }
    [System.SerializableAttribute]
    public abstract partial class EnumerableBase<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        protected EnumerableBase() { }
        [C5.TestedAttribute]
        protected static int countItems(System.Collections.Generic.IEnumerable<T> items) { throw null; }
        public abstract System.Collections.Generic.IEnumerator<T> GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public enum EnumerationDirection
    {
        Backwards = 1,
        Forwards = 0,
    }
    public static partial class EqualityComparer<T>
    {
        public static System.Collections.Generic.IEqualityComparer<T> Default { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class EquatableEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T> where T : System.IEquatable<T>
    {
        internal EquatableEqualityComparer() { }
        public static C5.EquatableEqualityComparer<T> Default { get { throw null; } }
        public bool Equals(T item1, T item2) { throw null; }
        public int GetHashCode(T item) { throw null; }
    }
    [System.FlagsAttribute]
    public enum EventTypeEnum
    {
        Added = 4,
        All = 63,
        Basic = 15,
        Changed = 1,
        Cleared = 2,
        Inserted = 16,
        None = 0,
        Removed = 8,
        RemovedAt = 32,
    }
    [System.SerializableAttribute]
    public partial class FixedSizeCollectionException : System.Exception
    {
        public FixedSizeCollectionException() { }
        public FixedSizeCollectionException(string message) { }
    }
    public partial class FloatEqualityComparer : System.Collections.Generic.IEqualityComparer<float>
    {
        internal FloatEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.FloatEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(float item1, float item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(float item) { throw null; }
    }
    public delegate R Fun<R>();
    public delegate R Fun<A1, R>(A1 x1);
    public delegate R Fun<A1, A2, R>(A1 x1, A2 x2);
    public delegate R Fun<A1, A2, A3, R>(A1 x1, A2 x2, A3 x3);
    public delegate R Fun<A1, A2, A3, A4, R>(A1 x1, A2 x2, A3 x3, A4 x4);
    public partial class GuardedCollectionValue<T> : C5.GuardedEnumerable<T>, C5.ICollectionValue<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        public GuardedCollectionValue(C5.ICollectionValue<T> collectionvalue) : base (default(System.Collections.Generic.IEnumerable<T>)) { }
        public virtual C5.EventTypeEnum ActiveEvents { get { throw null; } }
        public virtual int Count { get { throw null; } }
        public virtual C5.Speed CountSpeed { get { throw null; } }
        public virtual bool IsEmpty { get { throw null; } }
        public virtual C5.EventTypeEnum ListenableEvents { get { throw null; } }
        public event C5.CollectionChangedHandler<T> CollectionChanged { add { } remove { } }
        public event C5.CollectionClearedHandler<T> CollectionCleared { add { } remove { } }
        public event C5.ItemInsertedHandler<T> ItemInserted { add { } remove { } }
        public event C5.ItemRemovedAtHandler<T> ItemRemovedAt { add { } remove { } }
        public event C5.ItemsAddedHandler<T> ItemsAdded { add { } remove { } }
        public event C5.ItemsRemovedHandler<T> ItemsRemoved { add { } remove { } }
        public virtual bool All(C5.Fun<T, bool> filter) { throw null; }
        public virtual void Apply(C5.Act<T> a) { }
        public virtual T Choose() { throw null; }
        public virtual void CopyTo(T[] a, int i) { }
        public virtual bool Exists(C5.Fun<T, bool> filter) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<T> Filter(C5.Fun<T, bool> filter) { throw null; }
        public virtual bool Find(C5.Fun<T, bool> filter, out T item) { item = default(T); throw null; }
        public bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public virtual T[] ToArray() { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
    public partial class GuardedCollection<T> : C5.GuardedCollectionValue<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IExtensible<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public GuardedCollection(C5.ICollection<T> collection) : base (default(C5.ICollectionValue<T>)) { }
        public virtual bool AllowsDuplicates { get { throw null; } }
        public virtual C5.Speed ContainsSpeed { get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        public virtual System.Collections.Generic.IEqualityComparer<T> EqualityComparer { get { throw null; } }
        public override bool IsEmpty { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool Add(T item) { throw null; }
        public virtual void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        public virtual bool Check() { throw null; }
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        public virtual bool Contains(T item) { throw null; }
        public virtual bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        public virtual int ContainsCount(T item) { throw null; }
        public virtual bool Find(ref T item) { throw null; }
        public virtual bool FindOrAdd(ref T item) { throw null; }
        public virtual int GetUnsequencedHashCode() { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        public virtual bool Remove(T item) { throw null; }
        public virtual bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        public virtual void RemoveAllCopies(T item) { }
        public virtual void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        public virtual void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        public virtual bool UnsequencedEquals(C5.ICollection<T> that) { throw null; }
        public virtual bool Update(T item) { throw null; }
        public virtual bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        public virtual bool UpdateOrAdd(T item) { throw null; }
        public virtual bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
    }
    public partial class GuardedDictionary<K, V> : C5.GuardedCollectionValue<C5.KeyValuePair<K, V>>, C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IDictionary<K, V>, C5.IShowable, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public GuardedDictionary(C5.IDictionary<K, V> dict) : base (default(C5.ICollectionValue<C5.KeyValuePair<K, V>>)) { }
        public C5.Speed ContainsSpeed { get { throw null; } }
        public System.Collections.Generic.IEqualityComparer<K> EqualityComparer { get { throw null; } }
        public virtual C5.Fun<K, V> Fun { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public V this[K key] { get { throw null; } set { } }
        public C5.ICollectionValue<K> Keys { get { throw null; } }
        public C5.ICollectionValue<V> Values { get { throw null; } }
        public void Add(K key, V val) { }
        public void AddAll<L, W>(System.Collections.Generic.IEnumerable<C5.KeyValuePair<L, W>> items) where L : K where W : V { }
        public bool Check() { throw null; }
        public void Clear() { }
        public virtual object Clone() { throw null; }
        public bool Contains(K key) { throw null; }
        public bool ContainsAll<H>(System.Collections.Generic.IEnumerable<H> keys) where H : K { throw null; }
        public bool Find(K key, out V val) { val = default(V); throw null; }
        public bool Find(ref K key, out V val) { val = default(V); throw null; }
        public bool FindOrAdd(K key, ref V val) { throw null; }
        public bool Remove(K key) { throw null; }
        public bool Remove(K key, out V val) { val = default(V); throw null; }
        public bool Update(K key, V val) { throw null; }
        public bool Update(K key, V val, out V oldval) { oldval = default(V); throw null; }
        public bool UpdateOrAdd(K key, V val) { throw null; }
        public bool UpdateOrAdd(K key, V val, out V oldval) { oldval = default(V); throw null; }
    }
    public partial class GuardedDirectedCollectionValue<T> : C5.GuardedCollectionValue<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        public GuardedDirectedCollectionValue(C5.IDirectedCollectionValue<T> directedcollection) : base (default(C5.ICollectionValue<T>)) { }
        public C5.EnumerationDirection Direction { get { throw null; } }
        public virtual C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public virtual bool FindLast(C5.Fun<T, bool> predicate, out T item) { item = default(T); throw null; }
    }
    public partial class GuardedDirectedEnumerable<T> : C5.GuardedEnumerable<T>, C5.IDirectedEnumerable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        public GuardedDirectedEnumerable(C5.IDirectedEnumerable<T> directedenumerable) : base (default(System.Collections.Generic.IEnumerable<T>)) { }
        public C5.EnumerationDirection Direction { get { throw null; } }
        public C5.IDirectedEnumerable<T> Backwards() { throw null; }
    }
    public partial class GuardedEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        public GuardedEnumerable(System.Collections.Generic.IEnumerable<T> enumerable) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class GuardedEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
    {
        public GuardedEnumerator(System.Collections.Generic.IEnumerator<T> enumerator) { }
        public T Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public void Dispose() { }
        public bool MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public partial class GuardedIndexedSorted<T> : C5.GuardedSorted<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IIndexedSorted<T>, C5.ISequenced<T>, C5.IShowable, C5.ISorted<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public GuardedIndexedSorted(C5.IIndexedSorted<T> list) : base (default(C5.ISorted<T>)) { }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        public T this[int i] { get { throw null; } }
        public C5.IDirectedCollectionValue<T> this[int start, int end] { get { throw null; } }
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public override object Clone() { throw null; }
        public int CountFrom(T bot) { throw null; }
        public int CountFromTo(T bot, T top) { throw null; }
        public int CountTo(T top) { throw null; }
        public C5.IIndexedSorted<T> FindAll(C5.Fun<T, bool> f) { throw null; }
        public int IndexOf(T item) { throw null; }
        public int LastIndexOf(T item) { throw null; }
        public C5.IIndexedSorted<V> Map<V>(C5.Fun<T, V> m, System.Collections.Generic.IComparer<V> c) { throw null; }
        public new C5.IDirectedCollectionValue<T> RangeFrom(T bot) { throw null; }
        public new C5.IDirectedCollectionValue<T> RangeFromTo(T bot, T top) { throw null; }
        public new C5.IDirectedCollectionValue<T> RangeTo(T top) { throw null; }
        public T RemoveAt(int i) { throw null; }
        public void RemoveInterval(int start, int count) { }
    }
    public partial class GuardedList<T> : C5.GuardedSequenced<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IList<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public GuardedList(C5.IList<T> list) : base (default(C5.ISequenced<T>)) { }
        public bool FIFO { get { throw null; } set { } }
        public T First { get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsValid { get { throw null; } }
        public T this[int i] { get { throw null; } set { } }
        public C5.IDirectedCollectionValue<T> this[int start, int end] { get { throw null; } }
        public T Last { get { throw null; } }
        public int Offset { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        [System.ObsoleteAttribute]
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public C5.IList<T> Underlying { get { throw null; } }
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public override object Clone() { throw null; }
        public T Dequeue() { throw null; }
        public void Dispose() { }
        public void Enqueue(T item) { }
        public C5.IList<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        public int IndexOf(T item) { throw null; }
        public void Insert(C5.IList<T> pointer, T item) { }
        public void Insert(int index, T item) { }
        public void InsertAfter(T item, T target) { }
        public void InsertAll<U>(int i, System.Collections.Generic.IEnumerable<U> items) where U : T { }
        public void InsertBefore(T item, T target) { }
        public void InsertFirst(T item) { }
        public void InsertLast(T item) { }
        public bool IsSorted() { throw null; }
        public bool IsSorted(System.Collections.Generic.IComparer<T> c) { throw null; }
        public int LastIndexOf(T item) { throw null; }
        public C5.IList<T> LastViewOf(T item) { throw null; }
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper) { throw null; }
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IEqualityComparer<V> itemequalityComparer) { throw null; }
        public T Pop() { throw null; }
        public void Push(T item) { }
        public T Remove() { throw null; }
        public T RemoveAt(int i) { throw null; }
        public T RemoveFirst() { throw null; }
        public void RemoveInterval(int start, int count) { }
        public T RemoveLast() { throw null; }
        public void Reverse() { }
        public void Reverse(int start, int count) { }
        public void Shuffle() { }
        public void Shuffle(System.Random rnd) { }
        public C5.IList<T> Slide(int offset) { throw null; }
        public C5.IList<T> Slide(int offset, int size) { throw null; }
        public void Sort() { }
        public void Sort(System.Collections.Generic.IComparer<T> c) { }
        public C5.IList<T> Span(C5.IList<T> otherView) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
        int System.Collections.IList.Add(object o) { throw null; }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
        public bool TrySlide(int offset) { throw null; }
        public bool TrySlide(int offset, int size) { throw null; }
        public C5.IList<T> View(int start, int count) { throw null; }
        public C5.IList<T> ViewOf(T item) { throw null; }
    }
    public partial class GuardedQueue<T> : C5.GuardedDirectedCollectionValue<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IQueue<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        public GuardedQueue(C5.IQueue<T> queue) : base (default(C5.IDirectedCollectionValue<T>)) { }
        public bool AllowsDuplicates { get { throw null; } }
        public T this[int i] { get { throw null; } }
        public T Dequeue() { throw null; }
        public void Enqueue(T item) { }
    }
    public partial class GuardedSequenced<T> : C5.GuardedCollection<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public GuardedSequenced(C5.ISequenced<T> sorted) : base (default(C5.ICollection<T>)) { }
        public C5.EnumerationDirection Direction { get { throw null; } }
        public virtual C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public override object Clone() { throw null; }
        public int FindIndex(C5.Fun<T, bool> predicate) { throw null; }
        public virtual bool FindLast(C5.Fun<T, bool> predicate, out T item) { item = default(T); throw null; }
        public int FindLastIndex(C5.Fun<T, bool> predicate) { throw null; }
        public int GetSequencedHashCode() { throw null; }
        public bool SequencedEquals(C5.ISequenced<T> that) { throw null; }
    }
    public partial class GuardedSortedDictionary<K, V> : C5.GuardedDictionary<K, V>, C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IDictionary<K, V>, C5.IShowable, C5.ISortedDictionary<K, V>, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public GuardedSortedDictionary(C5.ISortedDictionary<K, V> sorteddict) : base (default(C5.IDictionary<K, V>)) { }
        public System.Collections.Generic.IComparer<K> Comparer { get { throw null; } }
        public new C5.ISorted<K> Keys { get { throw null; } }
        public void AddSorted(System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>> items) { }
        public bool Cut(System.IComparable<K> c, out C5.KeyValuePair<K, V> lowEntry, out bool lowIsValid, out C5.KeyValuePair<K, V> highEntry, out bool highIsValid) { lowEntry = default(C5.KeyValuePair<K, V>); lowIsValid = default(bool); highEntry = default(C5.KeyValuePair<K, V>); highIsValid = default(bool); throw null; }
        public C5.KeyValuePair<K, V> DeleteMax() { throw null; }
        public C5.KeyValuePair<K, V> DeleteMin() { throw null; }
        public C5.KeyValuePair<K, V> FindMax() { throw null; }
        public C5.KeyValuePair<K, V> FindMin() { throw null; }
        public C5.KeyValuePair<K, V> Predecessor(K key) { throw null; }
        public C5.IDirectedCollectionValue<C5.KeyValuePair<K, V>> RangeAll() { throw null; }
        public C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeFrom(K bot) { throw null; }
        public C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeFromTo(K bot, K top) { throw null; }
        public C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeTo(K top) { throw null; }
        public void RemoveRangeFrom(K low) { }
        public void RemoveRangeFromTo(K low, K hi) { }
        public void RemoveRangeTo(K hi) { }
        public C5.KeyValuePair<K, V> Successor(K key) { throw null; }
        public bool TryPredecessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        public bool TrySuccessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        public bool TryWeakPredecessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        public bool TryWeakSuccessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        public C5.KeyValuePair<K, V> WeakPredecessor(K key) { throw null; }
        public C5.KeyValuePair<K, V> WeakSuccessor(K key) { throw null; }
    }
    public partial class GuardedSorted<T> : C5.GuardedSequenced<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.ISequenced<T>, C5.IShowable, C5.ISorted<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public GuardedSorted(C5.ISorted<T> sorted) : base (default(C5.ISequenced<T>)) { }
        public System.Collections.Generic.IComparer<T> Comparer { get { throw null; } }
        public void AddSorted<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public override object Clone() { throw null; }
        public bool Cut(System.IComparable<T> c, out T low, out bool lval, out T high, out bool hval) { low = default(T); lval = default(bool); high = default(T); hval = default(bool); throw null; }
        public T DeleteMax() { throw null; }
        public T DeleteMin() { throw null; }
        public T FindMax() { throw null; }
        public T FindMin() { throw null; }
        public T Predecessor(T item) { throw null; }
        public C5.IDirectedCollectionValue<T> RangeAll() { throw null; }
        public C5.IDirectedEnumerable<T> RangeFrom(T bot) { throw null; }
        public C5.IDirectedEnumerable<T> RangeFromTo(T bot, T top) { throw null; }
        public C5.IDirectedEnumerable<T> RangeTo(T top) { throw null; }
        public void RemoveRangeFrom(T low) { }
        public void RemoveRangeFromTo(T low, T hi) { }
        public void RemoveRangeTo(T hi) { }
        public T Successor(T item) { throw null; }
        public bool TryPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TrySuccessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakSuccessor(T item, out T res) { res = default(T); throw null; }
        public T WeakPredecessor(T item) { throw null; }
        public T WeakSuccessor(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class HashBag<T> : C5.CollectionBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IExtensible<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public HashBag() : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashBag(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashBag(int capacity, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashBag(int capacity, double fill, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public virtual bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool Add(T item) { throw null; }
        public virtual void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual bool Check() { throw null; }
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public virtual int ContainsCount(T item) { throw null; }
        [C5.TestedAttribute]
        public override void CopyTo(T[] array, int index) { }
        [C5.TestedAttribute]
        public virtual bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public virtual void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        [C5.TestedAttribute]
        public override T[] ToArray() { throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Update(T item) { throw null; }
        public virtual bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual bool UpdateOrAdd(T item) { throw null; }
        public virtual bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
    }
    [System.SerializableAttribute]
    public partial class HashDictionary<K, V> : C5.DictionaryBase<K, V>, C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IDictionary<K, V>, C5.IShowable, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public HashDictionary() : base (default(System.Collections.Generic.IEqualityComparer<K>)) { }
        public HashDictionary(System.Collections.Generic.IEqualityComparer<K> keyequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<K>)) { }
        public HashDictionary(int capacity, double fill, System.Collections.Generic.IEqualityComparer<K> keyequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<K>)) { }
        public override object Clone() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class HashedArrayList<T> : C5.ArrayBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IList<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public HashedArrayList() : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashedArrayList(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashedArrayList(int capacity) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashedArrayList(int capacity, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public virtual bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public override int Count { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool FIFO { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public virtual T First { [C5.TestedAttribute]get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsValid { get { throw null; } }
        [C5.TestedAttribute]
        public virtual T this[int index] { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public virtual T Last { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public virtual int Offset { [C5.TestedAttribute]get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        [System.ObsoleteAttribute]
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Underlying { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        [C5.TestedAttribute]
        public override bool Check() { throw null; }
        [C5.TestedAttribute]
        public override void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public virtual int ContainsCount(T item) { throw null; }
        public virtual void Dispose() { }
        protected override void expand() { }
        protected override void expand(int newcapacity, int newsize) { }
        [C5.TestedAttribute]
        public virtual bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public virtual bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public override int GetUnsequencedHashCode() { throw null; }
        [C5.TestedAttribute]
        public virtual int IndexOf(T item) { throw null; }
        public void Insert(C5.IList<T> pointer, T item) { }
        protected override void insert(int i, T item) { }
        [C5.TestedAttribute]
        public virtual void Insert(int index, T item) { }
        [C5.TestedAttribute]
        public virtual void InsertAll<U>(int index, System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void InsertFirst(T item) { }
        [C5.TestedAttribute]
        public virtual void InsertLast(T item) { }
        [C5.TestedAttribute]
        public bool IsSorted() { throw null; }
        [C5.TestedAttribute]
        public virtual bool IsSorted(System.Collections.Generic.IComparer<T> c) { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public virtual int LastIndexOf(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> LastViewOf(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<V> Map<V>(C5.Fun<T, V> mapper) { throw null; }
        public virtual C5.IList<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IEqualityComparer<V> itemequalityComparer) { throw null; }
        protected override void modifycheck(int stamp) { }
        [C5.TestedAttribute]
        public virtual T Remove() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public virtual void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual T RemoveAt(int index) { throw null; }
        [C5.TestedAttribute]
        public virtual T RemoveFirst() { throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveInterval(int start, int count) { }
        [C5.TestedAttribute]
        public virtual T RemoveLast() { throw null; }
        [C5.TestedAttribute]
        public virtual void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void Reverse() { }
        public virtual void Shuffle() { }
        public virtual void Shuffle(System.Random rnd) { }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Slide(int offset) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Slide(int offset, int size) { throw null; }
        public virtual void Sort() { }
        [C5.TestedAttribute]
        public virtual void Sort(System.Collections.Generic.IComparer<T> comparer) { }
        public virtual C5.IList<T> Span(C5.IList<T> otherView) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
        int System.Collections.IList.Add(object o) { throw null; }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
        [C5.TestedAttribute]
        public virtual bool TrySlide(int offset) { throw null; }
        [C5.TestedAttribute]
        public virtual bool TrySlide(int offset, int size) { throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public override bool UnsequencedEquals(C5.ICollection<T> that) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Update(T item) { throw null; }
        public virtual bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        protected override void updatecheck() { }
        [C5.TestedAttribute]
        public virtual bool UpdateOrAdd(T item) { throw null; }
        public virtual bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> View(int start, int count) { throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> ViewOf(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class HashedLinkedList<T> : C5.SequencedBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IList<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public HashedLinkedList() : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashedLinkedList(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public virtual bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public override int Count { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool FIFO { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public virtual T First { [C5.TestedAttribute]get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsValid { get { throw null; } }
        [C5.TestedAttribute]
        public virtual T this[int index] { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> this[int start, int count] { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual T Last { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public virtual int Offset { [C5.TestedAttribute]get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        [System.ObsoleteAttribute]
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Underlying { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public override C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Check() { throw null; }
        [C5.TestedAttribute]
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public virtual int ContainsCount(T item) { throw null; }
        public virtual void Dispose() { }
        public override System.Collections.Generic.IEnumerable<T> Filter(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IList<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public virtual bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public override int GetSequencedHashCode() { throw null; }
        [C5.TestedAttribute]
        public override int GetUnsequencedHashCode() { throw null; }
        [C5.TestedAttribute]
        public virtual int IndexOf(T item) { throw null; }
        public void Insert(C5.IList<T> pointer, T item) { }
        [C5.TestedAttribute]
        public virtual void Insert(int i, T item) { }
        [C5.TestedAttribute]
        public virtual void InsertAll<U>(int i, System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void InsertFirst(T item) { }
        [C5.TestedAttribute]
        public virtual void InsertLast(T item) { }
        public bool IsSorted() { throw null; }
        [C5.TestedAttribute]
        public virtual bool IsSorted(System.Collections.Generic.IComparer<T> c) { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public virtual int LastIndexOf(T item) { throw null; }
        public virtual C5.IList<T> LastViewOf(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper) { throw null; }
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IEqualityComparer<V> equalityComparer) { throw null; }
        protected override void modifycheck(int stamp) { }
        [C5.TestedAttribute]
        public virtual T Remove() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public virtual void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual T RemoveAt(int i) { throw null; }
        [C5.TestedAttribute]
        public virtual T RemoveFirst() { throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveInterval(int start, int count) { }
        [C5.TestedAttribute]
        public virtual T RemoveLast() { throw null; }
        [C5.TestedAttribute]
        public virtual void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void Reverse() { }
        [C5.TestedAttribute]
        public override bool SequencedEquals(C5.ISequenced<T> that) { throw null; }
        public virtual void Shuffle() { }
        public virtual void Shuffle(System.Random rnd) { }
        [C5.TestedAttribute]
        public C5.IList<T> Slide(int offset) { throw null; }
        public C5.IList<T> Slide(int offset, int size) { throw null; }
        public virtual void Sort() { }
        [C5.TestedAttribute]
        public virtual void Sort(System.Collections.Generic.IComparer<T> c) { }
        public virtual C5.IList<T> Span(C5.IList<T> otherView) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
        int System.Collections.IList.Add(object o) { throw null; }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
        public virtual bool TrySlide(int offset) { throw null; }
        public virtual bool TrySlide(int offset, int size) { throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public override bool UnsequencedEquals(C5.ICollection<T> that) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Update(T item) { throw null; }
        public virtual bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        protected override void updatecheck() { }
        [C5.TestedAttribute]
        public virtual bool UpdateOrAdd(T item) { throw null; }
        public virtual bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> View(int start, int count) { throw null; }
        public virtual C5.IList<T> ViewOf(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class HashSet<T> : C5.CollectionBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IExtensible<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public HashSet() : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashSet(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashSet(int capacity, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public HashSet(int capacity, double fill, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public virtual bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        public static C5.HashSet<T>.Feature Features { get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute(via="Manually")]
        public C5.ISortedDictionary<int, int> BucketCostDistribution() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Check() { throw null; }
        [C5.TestedAttribute]
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public virtual int ContainsCount(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public virtual void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        [C5.TestedAttribute]
        public override T[] ToArray() { throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Update(T item) { throw null; }
        public virtual bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual bool UpdateOrAdd(T item) { throw null; }
        public virtual bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [System.FlagsAttribute]
        public enum Feature : short
        {
            Chaining = (short)16,
            Dummy = (short)0,
            InterHashing = (short)32,
            LinearProbing = (short)4,
            RandomInterHashing = (short)64,
            RefTypeBucket = (short)1,
            ShrinkTable = (short)8,
            ValueTypeBucket = (short)2,
        }
    }
    public partial interface ICollectionValue<T> : C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        C5.EventTypeEnum ActiveEvents { get; }
        int Count { get; }
        C5.Speed CountSpeed { get; }
        bool IsEmpty { get; }
        C5.EventTypeEnum ListenableEvents { get; }
        event C5.CollectionChangedHandler<T> CollectionChanged;
        event C5.CollectionClearedHandler<T> CollectionCleared;
        event C5.ItemInsertedHandler<T> ItemInserted;
        event C5.ItemRemovedAtHandler<T> ItemRemovedAt;
        event C5.ItemsAddedHandler<T> ItemsAdded;
        event C5.ItemsRemovedHandler<T> ItemsRemoved;
        bool All(C5.Fun<T, bool> predicate);
        void Apply(C5.Act<T> action);
        T Choose();
        void CopyTo(T[] array, int index);
        bool Exists(C5.Fun<T, bool> predicate);
        System.Collections.Generic.IEnumerable<T> Filter(C5.Fun<T, bool> filter);
        bool Find(C5.Fun<T, bool> predicate, out T item);
        T[] ToArray();
    }
    public partial interface ICollection<T> : C5.ICollectionValue<T>, C5.IExtensible<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        C5.Speed ContainsSpeed { get; }
        new int Count { get; }
        new bool IsReadOnly { get; }
        new bool Add(T item);
        new void Clear();
        new bool Contains(T item);
        bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T;
        int ContainsCount(T item);
        new void CopyTo(T[] array, int index);
        bool Find(ref T item);
        bool FindOrAdd(ref T item);
        int GetUnsequencedHashCode();
        C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities();
        new bool Remove(T item);
        bool Remove(T item, out T removeditem);
        void RemoveAllCopies(T item);
        void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T;
        void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T;
        C5.ICollectionValue<T> UniqueItems();
        bool UnsequencedEquals(C5.ICollection<T> otherCollection);
        bool Update(T item);
        bool Update(T item, out T olditem);
        bool UpdateOrAdd(T item);
        bool UpdateOrAdd(T item, out T olditem);
    }
    public partial interface IDictionary<K, V> : C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IShowable, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        C5.Speed ContainsSpeed { get; }
        System.Collections.Generic.IEqualityComparer<K> EqualityComparer { get; }
        C5.Fun<K, V> Fun { get; }
        bool IsReadOnly { get; }
        V this[K key] { get; set; }
        C5.ICollectionValue<K> Keys { get; }
        C5.ICollectionValue<V> Values { get; }
        void Add(K key, V val);
        void AddAll<U, W>(System.Collections.Generic.IEnumerable<C5.KeyValuePair<U, W>> entries) where U : K where W : V;
        bool Check();
        void Clear();
        bool Contains(K key);
        bool ContainsAll<H>(System.Collections.Generic.IEnumerable<H> items) where H : K;
        bool Find(K key, out V val);
        bool Find(ref K key, out V val);
        bool FindOrAdd(K key, ref V val);
        bool Remove(K key);
        bool Remove(K key, out V val);
        bool Update(K key, V val);
        bool Update(K key, V val, out V oldval);
        bool UpdateOrAdd(K key, V val);
        bool UpdateOrAdd(K key, V val, out V oldval);
    }
    public partial interface IDirectedCollectionValue<T> : C5.ICollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        new C5.IDirectedCollectionValue<T> Backwards();
        bool FindLast(C5.Fun<T, bool> predicate, out T item);
    }
    public partial interface IDirectedEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        C5.EnumerationDirection Direction { get; }
        C5.IDirectedEnumerable<T> Backwards();
    }
    public partial interface IExtensible<T> : C5.ICollectionValue<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        bool AllowsDuplicates { get; }
        bool DuplicatesByCounting { get; }
        System.Collections.Generic.IEqualityComparer<T> EqualityComparer { get; }
        bool IsReadOnly { get; }
        bool Add(T item);
        void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T;
        bool Check();
    }
    public partial interface IIndexedSorted<T> : C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.ISequenced<T>, C5.IShowable, C5.ISorted<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        int CountFrom(T bot);
        int CountFromTo(T bot, T top);
        int CountTo(T top);
        C5.IIndexedSorted<T> FindAll(C5.Fun<T, bool> predicate);
        C5.IIndexedSorted<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IComparer<V> comparer);
        new C5.IDirectedCollectionValue<T> RangeFrom(T bot);
        new C5.IDirectedCollectionValue<T> RangeFromTo(T bot, T top);
        new C5.IDirectedCollectionValue<T> RangeTo(T top);
    }
    public partial interface IIndexed<T> : C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        C5.Speed IndexingSpeed { get; }
        T this[int index] { get; }
        C5.IDirectedCollectionValue<T> this[int start, int count] { get; }
        int FindIndex(C5.Fun<T, bool> predicate);
        int FindLastIndex(C5.Fun<T, bool> predicate);
        int IndexOf(T item);
        int LastIndexOf(T item);
        T RemoveAt(int index);
        void RemoveInterval(int start, int count);
    }
    public partial interface IList<T> : C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable, System.IDisposable, System.IFormattable
    {
        new int Count { get; }
        bool FIFO { get; set; }
        T First { get; }
        new bool IsFixedSize { get; }
        new bool IsReadOnly { get; }
        bool IsValid { get; }
        new T this[int index] { get; set; }
        T Last { get; }
        int Offset { get; }
        C5.IList<T> Underlying { get; }
        new bool Add(T item);
        new void Clear();
        new bool Contains(T item);
        new void CopyTo(T[] array, int index);
        C5.IList<T> FindAll(C5.Fun<T, bool> filter);
        new int IndexOf(T item);
        void Insert(C5.IList<T> pointer, T item);
        void InsertAll<U>(int index, System.Collections.Generic.IEnumerable<U> items) where U : T;
        void InsertFirst(T item);
        void InsertLast(T item);
        bool IsSorted();
        bool IsSorted(System.Collections.Generic.IComparer<T> comparer);
        C5.IList<T> LastViewOf(T item);
        C5.IList<V> Map<V>(C5.Fun<T, V> mapper);
        C5.IList<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IEqualityComparer<V> equalityComparer);
        T Remove();
        new bool Remove(T item);
        new T RemoveAt(int index);
        T RemoveFirst();
        T RemoveLast();
        void Reverse();
        void Shuffle();
        void Shuffle(System.Random rnd);
        C5.IList<T> Slide(int offset);
        C5.IList<T> Slide(int offset, int size);
        void Sort();
        void Sort(System.Collections.Generic.IComparer<T> comparer);
        C5.IList<T> Span(C5.IList<T> otherView);
        bool TrySlide(int offset);
        bool TrySlide(int offset, int size);
        C5.IList<T> View(int start, int count);
        C5.IList<T> ViewOf(T item);
    }
    [System.SerializableAttribute]
    public partial class IncompatibleViewException : System.Exception
    {
        public IncompatibleViewException() { }
        public IncompatibleViewException(string message) { }
    }
    [System.SerializableAttribute]
    public partial class IntEqualityComparer : System.Collections.Generic.IEqualityComparer<int>
    {
        internal IntEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.IntEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(int item1, int item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(int item) { throw null; }
    }
    public partial class InternalException : System.Exception
    {
        internal InternalException() { }
    }
    [System.SerializableAttribute]
    public partial class IntervalHeap<T> : C5.CollectionValueBase<T>, C5.ICollectionValue<T>, C5.IExtensible<T>, C5.IPriorityQueue<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public IntervalHeap() { }
        public IntervalHeap(System.Collections.Generic.IComparer<T> comparer) { }
        public IntervalHeap(int capacity) { }
        public IntervalHeap(int capacity, System.Collections.Generic.IComparer<T> comparer) { }
        [C5.TestedAttribute]
        public bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        public System.Collections.Generic.IComparer<T> Comparer { get { throw null; } }
        [C5.TestedAttribute]
        public override int Count { [C5.TestedAttribute]get { throw null; } }
        public override C5.Speed CountSpeed { get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        public virtual System.Collections.Generic.IEqualityComparer<T> EqualityComparer { get { throw null; } }
        [C5.TestedAttribute]
        public override bool IsEmpty { [C5.TestedAttribute]get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        [C5.TestedAttribute]
        public T this[C5.IPriorityQueueHandle<T> handle] { get { throw null; } set { } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public bool Add(ref C5.IPriorityQueueHandle<T> handle, T item) { throw null; }
        [C5.TestedAttribute]
        public bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public bool Check() { throw null; }
        public override T Choose() { throw null; }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public T Delete(C5.IPriorityQueueHandle<T> handle) { throw null; }
        [C5.TestedAttribute]
        public T DeleteMax() { throw null; }
        public T DeleteMax(out C5.IPriorityQueueHandle<T> handle) { handle = default(C5.IPriorityQueueHandle<T>); throw null; }
        [C5.TestedAttribute]
        public T DeleteMin() { throw null; }
        public T DeleteMin(out C5.IPriorityQueueHandle<T> handle) { handle = default(C5.IPriorityQueueHandle<T>); throw null; }
        public bool Find(C5.IPriorityQueueHandle<T> handle, out T item) { item = default(T); throw null; }
        [C5.TestedAttribute]
        public T FindMax() { throw null; }
        public T FindMax(out C5.IPriorityQueueHandle<T> handle) { handle = default(C5.IPriorityQueueHandle<T>); throw null; }
        [C5.TestedAttribute]
        public T FindMin() { throw null; }
        public T FindMin(out C5.IPriorityQueueHandle<T> handle) { handle = default(C5.IPriorityQueueHandle<T>); throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public T Replace(C5.IPriorityQueueHandle<T> handle, T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class InvalidPriorityQueueHandleException : System.Exception
    {
        public InvalidPriorityQueueHandleException() { }
        public InvalidPriorityQueueHandleException(string message) { }
    }
    public partial interface IPersistentSorted<T> : C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.ISequenced<T>, C5.IShowable, C5.ISorted<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IDisposable, System.IFormattable
    {
        C5.ISorted<T> Snapshot();
    }
    public partial interface IPriorityQueueHandle<T>
    {
    }
    public partial interface IPriorityQueue<T> : C5.ICollectionValue<T>, C5.IExtensible<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        System.Collections.Generic.IComparer<T> Comparer { get; }
        T this[C5.IPriorityQueueHandle<T> handle] { get; set; }
        bool Add(ref C5.IPriorityQueueHandle<T> handle, T item);
        T Delete(C5.IPriorityQueueHandle<T> handle);
        T DeleteMax();
        T DeleteMax(out C5.IPriorityQueueHandle<T> handle);
        T DeleteMin();
        T DeleteMin(out C5.IPriorityQueueHandle<T> handle);
        bool Find(C5.IPriorityQueueHandle<T> handle, out T item);
        T FindMax();
        T FindMax(out C5.IPriorityQueueHandle<T> handle);
        T FindMin();
        T FindMin(out C5.IPriorityQueueHandle<T> handle);
        T Replace(C5.IPriorityQueueHandle<T> handle, T item);
    }
    public partial interface IQueue<T> : C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        bool AllowsDuplicates { get; }
        T this[int index] { get; }
        T Dequeue();
        void Enqueue(T item);
    }
    public partial interface ISequenced<T> : C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        int GetSequencedHashCode();
        bool SequencedEquals(C5.ISequenced<T> otherCollection);
    }
    public partial interface IShowable : System.IFormattable
    {
        bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider);
    }
    public partial interface ISortedDictionary<K, V> : C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IDictionary<K, V>, C5.IShowable, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        System.Collections.Generic.IComparer<K> Comparer { get; }
        new C5.ISorted<K> Keys { get; }
        void AddSorted(System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>> items);
        bool Cut(System.IComparable<K> cutFunction, out C5.KeyValuePair<K, V> lowEntry, out bool lowIsValid, out C5.KeyValuePair<K, V> highEntry, out bool highIsValid);
        C5.KeyValuePair<K, V> DeleteMax();
        C5.KeyValuePair<K, V> DeleteMin();
        C5.KeyValuePair<K, V> FindMax();
        C5.KeyValuePair<K, V> FindMin();
        C5.KeyValuePair<K, V> Predecessor(K key);
        C5.IDirectedCollectionValue<C5.KeyValuePair<K, V>> RangeAll();
        C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeFrom(K bot);
        C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeFromTo(K lowerBound, K upperBound);
        C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeTo(K top);
        void RemoveRangeFrom(K low);
        void RemoveRangeFromTo(K low, K hi);
        void RemoveRangeTo(K hi);
        C5.KeyValuePair<K, V> Successor(K key);
        bool TryPredecessor(K key, out C5.KeyValuePair<K, V> res);
        bool TrySuccessor(K key, out C5.KeyValuePair<K, V> res);
        bool TryWeakPredecessor(K key, out C5.KeyValuePair<K, V> res);
        bool TryWeakSuccessor(K key, out C5.KeyValuePair<K, V> res);
        C5.KeyValuePair<K, V> WeakPredecessor(K key);
        C5.KeyValuePair<K, V> WeakSuccessor(K key);
    }
    public partial interface ISorted<T> : C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        System.Collections.Generic.IComparer<T> Comparer { get; }
        void AddSorted<U>(System.Collections.Generic.IEnumerable<U> items) where U : T;
        bool Cut(System.IComparable<T> cutFunction, out T low, out bool lowIsValid, out T high, out bool highIsValid);
        T DeleteMax();
        T DeleteMin();
        T FindMax();
        T FindMin();
        T Predecessor(T item);
        C5.IDirectedCollectionValue<T> RangeAll();
        C5.IDirectedEnumerable<T> RangeFrom(T bot);
        C5.IDirectedEnumerable<T> RangeFromTo(T bot, T top);
        C5.IDirectedEnumerable<T> RangeTo(T top);
        void RemoveRangeFrom(T low);
        void RemoveRangeFromTo(T low, T hi);
        void RemoveRangeTo(T hi);
        T Successor(T item);
        bool TryPredecessor(T item, out T res);
        bool TrySuccessor(T item, out T res);
        bool TryWeakPredecessor(T item, out T res);
        bool TryWeakSuccessor(T item, out T res);
        T WeakPredecessor(T item);
        T WeakSuccessor(T item);
    }
    public partial interface IStack<T> : C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        bool AllowsDuplicates { get; }
        T this[int index] { get; }
        T Pop();
        void Push(T item);
    }
    public partial class ItemAtEventArgs<T> : System.EventArgs
    {
        public readonly int Index;
        public readonly T Item;
        public ItemAtEventArgs(T item, int index) { }
        public override string ToString() { throw null; }
    }
    public partial class ItemCountEventArgs<T> : System.EventArgs
    {
        public readonly int Count;
        public readonly T Item;
        public ItemCountEventArgs(T item, int count) { }
        public override string ToString() { throw null; }
    }
    public delegate void ItemInsertedHandler<T>(object sender, C5.ItemAtEventArgs<T> eventArgs);
    public delegate void ItemRemovedAtHandler<T>(object sender, C5.ItemAtEventArgs<T> eventArgs);
    public delegate void ItemsAddedHandler<T>(object sender, C5.ItemCountEventArgs<T> eventArgs);
    public delegate void ItemsRemovedHandler<T>(object sender, C5.ItemCountEventArgs<T> eventArgs);
    [System.SerializableAttribute]
    public partial class KeyValuePairComparer<K, V> : System.Collections.Generic.IComparer<C5.KeyValuePair<K, V>>
    {
        public KeyValuePairComparer(System.Collections.Generic.IComparer<K> comparer) { }
        [C5.TestedAttribute]
        public int Compare(C5.KeyValuePair<K, V> entry1, C5.KeyValuePair<K, V> entry2) { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class KeyValuePairEqualityComparer<K, V> : System.Collections.Generic.IEqualityComparer<C5.KeyValuePair<K, V>>
    {
        public KeyValuePairEqualityComparer() { }
        public KeyValuePairEqualityComparer(System.Collections.Generic.IEqualityComparer<K> keyequalityComparer) { }
        [C5.TestedAttribute]
        public bool Equals(C5.KeyValuePair<K, V> entry1, C5.KeyValuePair<K, V> entry2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(C5.KeyValuePair<K, V> entry) { throw null; }
    }
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct KeyValuePair<K, V> : C5.IShowable, System.IEquatable<C5.KeyValuePair<K, V>>, System.IFormattable
    {
        public K Key;
        public V Value;
        public KeyValuePair(K key) { throw null;}
        public KeyValuePair(K key, V value) { throw null;}
        public bool Equals(C5.KeyValuePair<K, V> other) { throw null; }
        [C5.TestedAttribute]
        public override bool Equals(object obj) { throw null; }
        [C5.TestedAttribute]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(C5.KeyValuePair<K, V> pair1, C5.KeyValuePair<K, V> pair2) { throw null; }
        public static bool operator !=(C5.KeyValuePair<K, V> pair1, C5.KeyValuePair<K, V> pair2) { throw null; }
        public bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        [C5.TestedAttribute]
        public override string ToString() { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class LinkedList<T> : C5.SequencedBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IList<T>, C5.IQueue<T>, C5.ISequenced<T>, C5.IShowable, C5.IStack<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public LinkedList() : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public LinkedList(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public virtual bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public override int Count { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool FIFO { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public virtual T First { [C5.TestedAttribute]get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsValid { get { throw null; } }
        [C5.TestedAttribute]
        public virtual T this[int index] { [C5.TestedAttribute]get { throw null; } [C5.TestedAttribute]set { } }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> this[int start, int count] { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual T Last { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public virtual int Offset { [C5.TestedAttribute]get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        [System.ObsoleteAttribute]
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        [C5.TestedAttribute]
        public virtual C5.IList<T> Underlying { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public virtual bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public override C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Check() { throw null; }
        [C5.TestedAttribute]
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public virtual void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public virtual int ContainsCount(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual T Dequeue() { throw null; }
        public virtual void Dispose() { }
        [C5.TestedAttribute]
        public virtual void Enqueue(T item) { }
        public override System.Collections.Generic.IEnumerable<T> Filter(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IList<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public virtual bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public override int GetSequencedHashCode() { throw null; }
        [C5.TestedAttribute]
        public override int GetUnsequencedHashCode() { throw null; }
        [C5.TestedAttribute]
        public virtual int IndexOf(T item) { throw null; }
        public void Insert(C5.IList<T> pointer, T item) { }
        [C5.TestedAttribute]
        public virtual void Insert(int i, T item) { }
        [C5.TestedAttribute]
        public virtual void InsertAll<U>(int i, System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void InsertFirst(T item) { }
        [C5.TestedAttribute]
        public virtual void InsertLast(T item) { }
        public bool IsSorted() { throw null; }
        [C5.TestedAttribute]
        public virtual bool IsSorted(System.Collections.Generic.IComparer<T> c) { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public virtual int LastIndexOf(T item) { throw null; }
        public virtual C5.IList<T> LastViewOf(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper) { throw null; }
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IEqualityComparer<V> equalityComparer) { throw null; }
        protected override void modifycheck(int stamp) { }
        [C5.TestedAttribute]
        public T Pop() { throw null; }
        [C5.TestedAttribute]
        public void Push(T item) { }
        [C5.TestedAttribute]
        public virtual T Remove() { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public virtual void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual T RemoveAt(int i) { throw null; }
        [C5.TestedAttribute]
        public virtual T RemoveFirst() { throw null; }
        [C5.TestedAttribute]
        public virtual void RemoveInterval(int start, int count) { }
        [C5.TestedAttribute]
        public virtual T RemoveLast() { throw null; }
        [C5.TestedAttribute]
        public virtual void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public virtual void Reverse() { }
        [C5.TestedAttribute]
        public override bool SequencedEquals(C5.ISequenced<T> that) { throw null; }
        public virtual void Shuffle() { }
        public virtual void Shuffle(System.Random rnd) { }
        [C5.TestedAttribute]
        public C5.IList<T> Slide(int offset) { throw null; }
        public C5.IList<T> Slide(int offset, int size) { throw null; }
        public virtual void Sort() { }
        [C5.TestedAttribute]
        public virtual void Sort(System.Collections.Generic.IComparer<T> c) { }
        public virtual C5.IList<T> Span(C5.IList<T> otherView) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
        int System.Collections.IList.Add(object o) { throw null; }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
        public virtual bool TrySlide(int offset) { throw null; }
        public virtual bool TrySlide(int offset, int size) { throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public override bool UnsequencedEquals(C5.ICollection<T> that) { throw null; }
        [C5.TestedAttribute]
        public virtual bool Update(T item) { throw null; }
        public virtual bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        protected override void updatecheck() { }
        [C5.TestedAttribute]
        public virtual bool UpdateOrAdd(T item) { throw null; }
        public virtual bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public virtual C5.IList<T> View(int start, int count) { throw null; }
        public virtual C5.IList<T> ViewOf(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class LongEqualityComparer : System.Collections.Generic.IEqualityComparer<long>
    {
        internal LongEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.LongEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(long item1, long item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(long item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class NaturalComparerO<T> : System.Collections.Generic.IComparer<T> where T : System.IComparable
    {
        public NaturalComparerO() { }
        [C5.TestedAttribute]
        public int Compare(T item1, T item2) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class NaturalComparer<T> : System.Collections.Generic.IComparer<T> where T : System.IComparable<T>
    {
        public NaturalComparer() { }
        [C5.TestedAttribute]
        public int Compare(T item1, T item2) { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class NaturalEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>
    {
        internal NaturalEqualityComparer() { }
        public static C5.NaturalEqualityComparer<T> Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(T item1, T item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class NoSuchItemException : System.Exception
    {
        public NoSuchItemException() { }
        public NoSuchItemException(string message) { }
    }
    [System.SerializableAttribute]
    public partial class NotAViewException : System.Exception
    {
        public NotAViewException() { }
        public NotAViewException(string message) { }
    }
    [System.SerializableAttribute]
    public partial class NotComparableException : System.Exception
    {
        public NotComparableException() { }
        public NotComparableException(string message) { }
    }
    [System.SerializableAttribute]
    public partial class ReadOnlyCollectionException : System.Exception
    {
        public ReadOnlyCollectionException() { }
        public ReadOnlyCollectionException(string message) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Rec<T1, T2> : C5.IShowable, System.IEquatable<C5.Rec<T1, T2>>, System.IFormattable
    {
        public readonly T1 X1;
        public readonly T2 X2;
        [C5.TestedAttribute]
        public Rec(T1 x1, T2 x2) { throw null;}
        [C5.TestedAttribute]
        public bool Equals(C5.Rec<T1, T2> other) { throw null; }
        [C5.TestedAttribute]
        public override bool Equals(object obj) { throw null; }
        [C5.TestedAttribute]
        public override int GetHashCode() { throw null; }
        [C5.TestedAttribute]
        public static bool operator ==(C5.Rec<T1, T2> record1, C5.Rec<T1, T2> record2) { throw null; }
        [C5.TestedAttribute]
        public static bool operator !=(C5.Rec<T1, T2> record1, C5.Rec<T1, T2> record2) { throw null; }
        public bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Rec<T1, T2, T3> : C5.IShowable, System.IEquatable<C5.Rec<T1, T2, T3>>, System.IFormattable
    {
        public readonly T1 X1;
        public readonly T2 X2;
        public readonly T3 X3;
        [C5.TestedAttribute]
        public Rec(T1 x1, T2 x2, T3 x3) { throw null;}
        [C5.TestedAttribute]
        public bool Equals(C5.Rec<T1, T2, T3> other) { throw null; }
        [C5.TestedAttribute]
        public override bool Equals(object obj) { throw null; }
        [C5.TestedAttribute]
        public override int GetHashCode() { throw null; }
        [C5.TestedAttribute]
        public static bool operator ==(C5.Rec<T1, T2, T3> record1, C5.Rec<T1, T2, T3> record2) { throw null; }
        [C5.TestedAttribute]
        public static bool operator !=(C5.Rec<T1, T2, T3> record1, C5.Rec<T1, T2, T3> record2) { throw null; }
        public bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Rec<T1, T2, T3, T4> : C5.IShowable, System.IEquatable<C5.Rec<T1, T2, T3, T4>>, System.IFormattable
    {
        public readonly T1 X1;
        public readonly T2 X2;
        public readonly T3 X3;
        public readonly T4 X4;
        [C5.TestedAttribute]
        public Rec(T1 x1, T2 x2, T3 x3, T4 x4) { throw null;}
        [C5.TestedAttribute]
        public bool Equals(C5.Rec<T1, T2, T3, T4> other) { throw null; }
        [C5.TestedAttribute]
        public override bool Equals(object obj) { throw null; }
        [C5.TestedAttribute]
        public override int GetHashCode() { throw null; }
        [C5.TestedAttribute]
        public static bool operator ==(C5.Rec<T1, T2, T3, T4> record1, C5.Rec<T1, T2, T3, T4> record2) { throw null; }
        [C5.TestedAttribute]
        public static bool operator !=(C5.Rec<T1, T2, T3, T4> record1, C5.Rec<T1, T2, T3, T4> record2) { throw null; }
        public bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ReferenceEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T> where T : class
    {
        internal ReferenceEqualityComparer() { }
        public static C5.ReferenceEqualityComparer<T> Default { get { throw null; } }
        public bool Equals(T i1, T i2) { throw null; }
        public int GetHashCode(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class SByteEqualityComparer : System.Collections.Generic.IEqualityComparer<sbyte>
    {
        internal SByteEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.SByteEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(sbyte item1, sbyte item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(sbyte item) { throw null; }
    }
    [System.SerializableAttribute]
    public abstract partial class SequencedBase<T> : C5.DirectedCollectionBase<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IShowable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IFormattable
    {
        protected SequencedBase(System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public override C5.EnumerationDirection Direction { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public static int ComputeHashCode(C5.ISequenced<T> items, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) { throw null; }
        public int FindIndex(C5.Fun<T, bool> predicate) { throw null; }
        public int FindLastIndex(C5.Fun<T, bool> predicate) { throw null; }
        public abstract override System.Collections.Generic.IEnumerator<T> GetEnumerator();
        public virtual int GetSequencedHashCode() { throw null; }
        public virtual bool SequencedEquals(C5.ISequenced<T> otherCollection) { throw null; }
        [C5.TestedAttribute]
        public static bool StaticEquals(C5.ISequenced<T> collection1, C5.ISequenced<T> collection2, System.Collections.Generic.IEqualityComparer<T> itemequalityComparer) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class SequencedCollectionEqualityComparer<T, W> : System.Collections.Generic.IEqualityComparer<T> where T : C5.ISequenced<W>
    {
        internal SequencedCollectionEqualityComparer() { }
        public static C5.SequencedCollectionEqualityComparer<T, W> Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(T collection1, T collection2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(T collection) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ShortEqualityComparer : System.Collections.Generic.IEqualityComparer<short>
    {
        internal ShortEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.ShortEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(short item1, short item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(short item) { throw null; }
    }
    public static partial class Showing
    {
        public static bool Show(object obj, System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public static bool ShowCollectionValue<T>(C5.ICollectionValue<T> items, System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public static bool ShowDictionary<K, V>(C5.IDictionary<K, V> dictionary, System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public static string ShowString(C5.IShowable showable, string format, System.IFormatProvider formatProvider) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class SortedArray<T> : C5.ArrayBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IIndexedSorted<T>, C5.ISequenced<T>, C5.IShowable, C5.ISorted<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public SortedArray() : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public SortedArray(System.Collections.Generic.IComparer<T> comparer) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public SortedArray(int capacity) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public SortedArray(int capacity, System.Collections.Generic.IComparer<T> comparer) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public SortedArray(int capacity, System.Collections.Generic.IComparer<T> comparer, System.Collections.Generic.IEqualityComparer<T> equalityComparer) : base (default(int), default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        public System.Collections.Generic.IComparer<T> Comparer { get { throw null; } }
        [C5.TestedAttribute]
        public C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        public static C5.SortedArray<T>.Feature Features { get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        [C5.TestedAttribute]
        public T this[int i] { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public void AddSorted<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeFrom(T bot) { throw null; }
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeFromTo(T bot, T top) { throw null; }
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeTo(T top) { throw null; }
        [C5.TestedAttribute]
        public override bool Check() { throw null; }
        [C5.TestedAttribute]
        public override void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public int ContainsCount(T item) { throw null; }
        [C5.TestedAttribute]
        public int CountFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        public int CountFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        public int CountTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Cut(System.IComparable<T> c, out T low, out bool lowIsValid, out T high, out bool highIsValid) { low = default(T); lowIsValid = default(bool); high = default(T); highIsValid = default(bool); throw null; }
        [C5.TestedAttribute]
        public T DeleteMax() { throw null; }
        [C5.TestedAttribute]
        public T DeleteMin() { throw null; }
        [C5.TestedAttribute]
        public bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IIndexedSorted<T> FindAll(C5.Fun<T, bool> f) { throw null; }
        [C5.TestedAttribute]
        public T FindMax() { throw null; }
        [C5.TestedAttribute]
        public T FindMin() { throw null; }
        [C5.TestedAttribute]
        public bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public int IndexOf(T item) { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public int LastIndexOf(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IIndexedSorted<V> Map<V>(C5.Fun<T, V> m, System.Collections.Generic.IComparer<V> c) { throw null; }
        [C5.TestedAttribute]
        public T Predecessor(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeAll() { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public T RemoveAt(int i) { throw null; }
        [C5.TestedAttribute]
        public void RemoveInterval(int start, int count) { }
        [C5.TestedAttribute]
        public void RemoveRangeFrom(T low) { }
        [C5.TestedAttribute]
        public void RemoveRangeFromTo(T low, T hi) { }
        [C5.TestedAttribute]
        public void RemoveRangeTo(T hi) { }
        [C5.TestedAttribute]
        public void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public T Successor(T item) { throw null; }
        [C5.TestedAttribute]
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        public bool TryPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TrySuccessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakSuccessor(T item, out T res) { res = default(T); throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public bool Update(T item) { throw null; }
        public bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public bool UpdateOrAdd(T item) { throw null; }
        public bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public T WeakPredecessor(T item) { throw null; }
        [C5.TestedAttribute]
        public T WeakSuccessor(T item) { throw null; }
        [System.FlagsAttribute]
        public enum Feature : short
        {
            Standard = (short)0,
        }
    }
    [System.SerializableAttribute]
    public abstract partial class SortedDictionaryBase<K, V> : C5.DictionaryBase<K, V>, C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IDictionary<K, V>, C5.IShowable, C5.ISortedDictionary<K, V>, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        protected C5.ISorted<C5.KeyValuePair<K, V>> sortedpairs;
        protected SortedDictionaryBase(System.Collections.Generic.IComparer<K> keycomparer, System.Collections.Generic.IEqualityComparer<K> keyequalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<K>)) { }
        public System.Collections.Generic.IComparer<K> Comparer { get { throw null; } }
        public new C5.ISorted<K> Keys { get { throw null; } }
        public void AddSorted(System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>> items) { }
        public bool Cut(System.IComparable<K> cutter, out C5.KeyValuePair<K, V> lowEntry, out bool lowIsValid, out C5.KeyValuePair<K, V> highEntry, out bool highIsValid) { lowEntry = default(C5.KeyValuePair<K, V>); lowIsValid = default(bool); highEntry = default(C5.KeyValuePair<K, V>); highIsValid = default(bool); throw null; }
        public C5.KeyValuePair<K, V> DeleteMax() { throw null; }
        public C5.KeyValuePair<K, V> DeleteMin() { throw null; }
        public C5.KeyValuePair<K, V> FindMax() { throw null; }
        public C5.KeyValuePair<K, V> FindMin() { throw null; }
        [C5.TestedAttribute]
        public C5.KeyValuePair<K, V> Predecessor(K key) { throw null; }
        public C5.IDirectedCollectionValue<C5.KeyValuePair<K, V>> RangeAll() { throw null; }
        public C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeFrom(K bot) { throw null; }
        public C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeFromTo(K bot, K top) { throw null; }
        public C5.IDirectedEnumerable<C5.KeyValuePair<K, V>> RangeTo(K top) { throw null; }
        public void RemoveRangeFrom(K lowKey) { }
        public void RemoveRangeFromTo(K lowKey, K highKey) { }
        public void RemoveRangeTo(K highKey) { }
        public override bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        [C5.TestedAttribute]
        public C5.KeyValuePair<K, V> Successor(K key) { throw null; }
        [C5.TestedAttribute]
        public bool TryPredecessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        [C5.TestedAttribute]
        public bool TrySuccessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        [C5.TestedAttribute]
        public bool TryWeakPredecessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        [C5.TestedAttribute]
        public bool TryWeakSuccessor(K key, out C5.KeyValuePair<K, V> res) { res = default(C5.KeyValuePair<K, V>); throw null; }
        [C5.TestedAttribute]
        public C5.KeyValuePair<K, V> WeakPredecessor(K key) { throw null; }
        [C5.TestedAttribute]
        public C5.KeyValuePair<K, V> WeakSuccessor(K key) { throw null; }
    }
    public partial class Sorting
    {
        internal Sorting() { }
        [C5.TestedAttribute]
        public static void HeapSort<T>(T[] array, int start, int count, System.Collections.Generic.IComparer<T> comparer) { }
        [C5.TestedAttribute]
        public static void InsertionSort<T>(T[] array, int start, int count, System.Collections.Generic.IComparer<T> comparer) { }
        [C5.TestedAttribute]
        public static void IntroSort<T>(T[] array) { }
        [C5.TestedAttribute]
        public static void IntroSort<T>(T[] array, int start, int count, System.Collections.Generic.IComparer<T> comparer) { }
    }
    public enum Speed : short
    {
        Constant = (short)4,
        Linear = (short)2,
        Log = (short)3,
        PotentiallyInfinite = (short)1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    public sealed partial class TestedAttribute : System.Attribute
    {
        [C5.TestedAttribute]
        public string via;
        public TestedAttribute() { }
        [C5.TestedAttribute]
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class TreeBag<T> : C5.SequencedBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IIndexedSorted<T>, C5.IPersistentSorted<T>, C5.ISequenced<T>, C5.IShowable, C5.ISorted<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public TreeBag() : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public TreeBag(System.Collections.Generic.IComparer<T> comparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public TreeBag(System.Collections.Generic.IComparer<T> comparer, System.Collections.Generic.IEqualityComparer<T> equalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        public System.Collections.Generic.IComparer<T> Comparer { get { throw null; } }
        [C5.TestedAttribute]
        public C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        [C5.TestedAttribute]
        public T this[int i] { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> this[int start, int count] { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public void AddSorted<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public override C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Check() { throw null; }
        [C5.TestedAttribute(via="Sawtooth")]
        public bool Check(string name) { throw null; }
        [C5.TestedAttribute]
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public int ContainsCount(T item) { throw null; }
        [C5.TestedAttribute]
        public int CountFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        public int CountFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        public int CountTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Cut(System.IComparable<T> c, out T low, out bool lowIsValid, out T high, out bool highIsValid) { low = default(T); lowIsValid = default(bool); high = default(T); highIsValid = default(bool); throw null; }
        [C5.TestedAttribute]
        public T DeleteMax() { throw null; }
        [C5.TestedAttribute]
        public T DeleteMin() { throw null; }
        [C5.TestedAttribute]
        public void Dispose() { }
        [C5.TestedAttribute(via="Sawtooth")]
        public void dump() { }
        [C5.TestedAttribute(via="Sawtooth")]
        public void dump(string msg) { }
        [C5.TestedAttribute]
        public bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IIndexedSorted<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public T FindMax() { throw null; }
        [C5.TestedAttribute]
        public T FindMin() { throw null; }
        [C5.TestedAttribute]
        public bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public int IndexOf(T item) { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public int LastIndexOf(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IIndexedSorted<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IComparer<V> c) { throw null; }
        [C5.TestedAttribute]
        public T Predecessor(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeAll() { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public T RemoveAt(int i) { throw null; }
        [C5.TestedAttribute]
        public void RemoveInterval(int start, int count) { }
        [C5.TestedAttribute]
        public void RemoveRangeFrom(T low) { }
        [C5.TestedAttribute]
        public void RemoveRangeFromTo(T low, T hi) { }
        [C5.TestedAttribute]
        public void RemoveRangeTo(T hi) { }
        [C5.TestedAttribute]
        public void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public C5.ISorted<T> Snapshot() { throw null; }
        [C5.TestedAttribute]
        public T Successor(T item) { throw null; }
        [C5.TestedAttribute]
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        public bool TryPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TrySuccessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakSuccessor(T item, out T res) { res = default(T); throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public bool Update(T item) { throw null; }
        public bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public bool UpdateOrAdd(T item) { throw null; }
        public bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public T WeakPredecessor(T item) { throw null; }
        [C5.TestedAttribute]
        public T WeakSuccessor(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class TreeDictionary<K, V> : C5.SortedDictionaryBase<K, V>, C5.ICollectionValue<C5.KeyValuePair<K, V>>, C5.IDictionary<K, V>, C5.IShowable, C5.ISortedDictionary<K, V>, System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>>, System.Collections.IEnumerable, System.ICloneable, System.IFormattable
    {
        public TreeDictionary() : base (default(System.Collections.Generic.IComparer<K>), default(System.Collections.Generic.IEqualityComparer<K>)) { }
        public TreeDictionary(System.Collections.Generic.IComparer<K> comparer) : base (default(System.Collections.Generic.IComparer<K>), default(System.Collections.Generic.IEqualityComparer<K>)) { }
        public override object Clone() { throw null; }
        [C5.TestedAttribute]
        public System.Collections.Generic.IEnumerable<C5.KeyValuePair<K, V>> Snapshot() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class TreeSet<T> : C5.SequencedBase<T>, C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IIndexedSorted<T>, C5.IPersistentSorted<T>, C5.ISequenced<T>, C5.IShowable, C5.ISorted<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public TreeSet() : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public TreeSet(System.Collections.Generic.IComparer<T> comparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        public TreeSet(System.Collections.Generic.IComparer<T> comparer, System.Collections.Generic.IEqualityComparer<T> equalityComparer) : base (default(System.Collections.Generic.IEqualityComparer<T>)) { }
        [C5.TestedAttribute]
        public bool AllowsDuplicates { [C5.TestedAttribute]get { throw null; } }
        public System.Collections.Generic.IComparer<T> Comparer { get { throw null; } }
        [C5.TestedAttribute]
        public C5.Speed ContainsSpeed { [C5.TestedAttribute]get { throw null; } }
        public virtual bool DuplicatesByCounting { get { throw null; } }
        public virtual C5.Speed IndexingSpeed { get { throw null; } }
        [C5.TestedAttribute]
        public T this[int i] { [C5.TestedAttribute]get { throw null; } }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> this[int start, int count] { [C5.TestedAttribute]get { throw null; } }
        public override C5.EventTypeEnum ListenableEvents { get { throw null; } }
        [C5.TestedAttribute]
        public bool Add(T item) { throw null; }
        [C5.TestedAttribute]
        public void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public void AddSorted<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public override C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        C5.IDirectedEnumerable<T> C5.ISorted<T>.RangeTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Check() { throw null; }
        [C5.TestedAttribute(via="Sawtooth")]
        public bool Check(string name) { throw null; }
        [C5.TestedAttribute]
        public override T Choose() { throw null; }
        [C5.TestedAttribute]
        public void Clear() { }
        public virtual object Clone() { throw null; }
        [C5.TestedAttribute]
        public bool Contains(T item) { throw null; }
        [C5.TestedAttribute]
        public bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        [C5.TestedAttribute]
        public int ContainsCount(T item) { throw null; }
        [C5.TestedAttribute]
        public int CountFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        public int CountFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        public int CountTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Cut(System.IComparable<T> c, out T low, out bool lowIsValid, out T high, out bool highIsValid) { low = default(T); lowIsValid = default(bool); high = default(T); highIsValid = default(bool); throw null; }
        [C5.TestedAttribute]
        public T DeleteMax() { throw null; }
        [C5.TestedAttribute]
        public T DeleteMin() { throw null; }
        [C5.TestedAttribute]
        public void Dispose() { }
        [C5.TestedAttribute(via="Sawtooth")]
        public void dump() { }
        [C5.TestedAttribute(via="Sawtooth")]
        public void dump(string msg) { }
        [C5.TestedAttribute]
        public bool Find(ref T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IIndexedSorted<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        [C5.TestedAttribute]
        public T FindMax() { throw null; }
        [C5.TestedAttribute]
        public T FindMin() { throw null; }
        [C5.TestedAttribute]
        public bool FindOrAdd(ref T item) { throw null; }
        [C5.TestedAttribute]
        public override System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        [C5.TestedAttribute]
        public int IndexOf(T item) { throw null; }
        public virtual C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        [C5.TestedAttribute]
        public int LastIndexOf(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IIndexedSorted<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IComparer<V> c) { throw null; }
        [C5.TestedAttribute]
        public T Predecessor(T item) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeAll() { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeFrom(T bot) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeFromTo(T bot, T top) { throw null; }
        [C5.TestedAttribute]
        public C5.IDirectedCollectionValue<T> RangeTo(T top) { throw null; }
        [C5.TestedAttribute]
        public bool Remove(T item) { throw null; }
        [C5.TestedAttribute]
        public bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        [C5.TestedAttribute]
        public void RemoveAllCopies(T item) { }
        [C5.TestedAttribute]
        public void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public T RemoveAt(int i) { throw null; }
        [C5.TestedAttribute]
        public void RemoveInterval(int start, int count) { }
        [C5.TestedAttribute]
        public void RemoveRangeFrom(T low) { }
        [C5.TestedAttribute]
        public void RemoveRangeFromTo(T low, T hi) { }
        [C5.TestedAttribute]
        public void RemoveRangeTo(T hi) { }
        [C5.TestedAttribute]
        public void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        [C5.TestedAttribute]
        public C5.ISorted<T> Snapshot() { throw null; }
        [C5.TestedAttribute]
        public T Successor(T item) { throw null; }
        [C5.TestedAttribute]
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        public bool TryPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TrySuccessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakPredecessor(T item, out T res) { res = default(T); throw null; }
        public bool TryWeakSuccessor(T item, out T res) { res = default(T); throw null; }
        public virtual C5.ICollectionValue<T> UniqueItems() { throw null; }
        [C5.TestedAttribute]
        public bool Update(T item) { throw null; }
        public bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public bool UpdateOrAdd(T item) { throw null; }
        public bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        [C5.TestedAttribute]
        public T WeakPredecessor(T item) { throw null; }
        [C5.TestedAttribute]
        public T WeakSuccessor(T item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class UIntEqualityComparer : System.Collections.Generic.IEqualityComparer<uint>
    {
        internal UIntEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.UIntEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(uint item1, uint item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(uint item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ULongEqualityComparer : System.Collections.Generic.IEqualityComparer<ulong>
    {
        internal ULongEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.ULongEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(ulong item1, ulong item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(ulong item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class UnlistenableEventException : System.Exception
    {
        public UnlistenableEventException() { }
        public UnlistenableEventException(string message) { }
    }
    [System.SerializableAttribute]
    public partial class UnsequencedCollectionEqualityComparer<T, W> : System.Collections.Generic.IEqualityComparer<T> where T : C5.ICollection<W>
    {
        internal UnsequencedCollectionEqualityComparer() { }
        public static C5.UnsequencedCollectionEqualityComparer<T, W> Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(T collection1, T collection2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(T collection) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class UShortEqualityComparer : System.Collections.Generic.IEqualityComparer<ushort>
    {
        internal UShortEqualityComparer() { }
        [C5.TestedAttribute]
        public static C5.UShortEqualityComparer Default { get { throw null; } }
        [C5.TestedAttribute]
        public bool Equals(ushort item1, ushort item2) { throw null; }
        [C5.TestedAttribute]
        public int GetHashCode(ushort item) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ViewDisposedException : System.Exception
    {
        public ViewDisposedException() { }
        public ViewDisposedException(string message) { }
    }
    public partial class WrappedArray<T> : C5.ICollection<T>, C5.ICollectionValue<T>, C5.IDirectedCollectionValue<T>, C5.IDirectedEnumerable<T>, C5.IExtensible<T>, C5.IIndexed<T>, C5.IList<T>, C5.ISequenced<T>, C5.IShowable, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ICloneable, System.IDisposable, System.IFormattable
    {
        public WrappedArray(T[] wrappedarray) { }
        public virtual C5.EventTypeEnum ActiveEvents { get { throw null; } }
        public bool AllowsDuplicates { get { throw null; } }
        public C5.Speed ContainsSpeed { get { throw null; } }
        public int Count { get { throw null; } }
        public C5.Speed CountSpeed { get { throw null; } }
        public C5.EnumerationDirection Direction { get { throw null; } }
        public bool DuplicatesByCounting { get { throw null; } }
        public System.Collections.Generic.IEqualityComparer<T> EqualityComparer { get { throw null; } }
        public bool FIFO { get { throw null; } set { } }
        public T First { get { throw null; } }
        public C5.Speed IndexingSpeed { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        public C5.IDirectedCollectionValue<T> this[int start, int count] { get { throw null; } }
        public T Last { get { throw null; } }
        public virtual C5.EventTypeEnum ListenableEvents { get { throw null; } }
        public int Offset { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        [System.ObsoleteAttribute]
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public C5.IList<T> Underlying { get { throw null; } }
        public event C5.CollectionChangedHandler<T> CollectionChanged { add { } remove { } }
        public event C5.CollectionClearedHandler<T> CollectionCleared { add { } remove { } }
        public event C5.ItemInsertedHandler<T> ItemInserted { add { } remove { } }
        public event C5.ItemRemovedAtHandler<T> ItemRemovedAt { add { } remove { } }
        public event C5.ItemsAddedHandler<T> ItemsAdded { add { } remove { } }
        public event C5.ItemsRemovedHandler<T> ItemsRemoved { add { } remove { } }
        public bool Add(T item) { throw null; }
        public void AddAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        public bool All(C5.Fun<T, bool> predicate) { throw null; }
        public void Apply(C5.Act<T> action) { }
        public C5.IDirectedCollectionValue<T> Backwards() { throw null; }
        C5.IDirectedEnumerable<T> C5.IDirectedEnumerable<T>.Backwards() { throw null; }
        public bool Check() { throw null; }
        public T Choose() { throw null; }
        public void Clear() { }
        public virtual object Clone() { throw null; }
        public bool Contains(T item) { throw null; }
        public bool ContainsAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { throw null; }
        public int ContainsCount(T item) { throw null; }
        public void CopyTo(T[] array, int index) { }
        public void Dispose() { }
        public bool Exists(C5.Fun<T, bool> predicate) { throw null; }
        public System.Collections.Generic.IEnumerable<T> Filter(C5.Fun<T, bool> filter) { throw null; }
        public bool Find(C5.Fun<T, bool> predicate, out T item) { item = default(T); throw null; }
        public bool Find(ref T item) { throw null; }
        public C5.IList<T> FindAll(C5.Fun<T, bool> filter) { throw null; }
        public int FindIndex(C5.Fun<T, bool> predicate) { throw null; }
        public bool FindLast(C5.Fun<T, bool> predicate, out T item) { item = default(T); throw null; }
        public int FindLastIndex(C5.Fun<T, bool> predicate) { throw null; }
        public bool FindOrAdd(ref T item) { throw null; }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public int GetSequencedHashCode() { throw null; }
        public int GetUnsequencedHashCode() { throw null; }
        public int IndexOf(T item) { throw null; }
        public void Insert(C5.IList<T> pointer, T item) { }
        public void Insert(int index, T item) { }
        public void InsertAll<U>(int i, System.Collections.Generic.IEnumerable<U> items) where U : T { }
        public void InsertFirst(T item) { }
        public void InsertLast(T item) { }
        public bool IsSorted() { throw null; }
        public bool IsSorted(System.Collections.Generic.IComparer<T> comparer) { throw null; }
        public C5.ICollectionValue<C5.KeyValuePair<T, int>> ItemMultiplicities() { throw null; }
        public int LastIndexOf(T item) { throw null; }
        public C5.IList<T> LastViewOf(T item) { throw null; }
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper) { throw null; }
        public C5.IList<V> Map<V>(C5.Fun<T, V> mapper, System.Collections.Generic.IEqualityComparer<V> equalityComparer) { throw null; }
        public T Remove() { throw null; }
        public bool Remove(T item) { throw null; }
        public bool Remove(T item, out T removeditem) { removeditem = default(T); throw null; }
        public void RemoveAllCopies(T item) { }
        public void RemoveAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        public T RemoveAt(int i) { throw null; }
        public T RemoveFirst() { throw null; }
        public void RemoveInterval(int start, int count) { }
        public T RemoveLast() { throw null; }
        public void RetainAll<U>(System.Collections.Generic.IEnumerable<U> items) where U : T { }
        public void Reverse() { }
        public bool SequencedEquals(C5.ISequenced<T> that) { throw null; }
        public bool Show(System.Text.StringBuilder stringbuilder, ref int rest, System.IFormatProvider formatProvider) { throw null; }
        public void Shuffle() { }
        public void Shuffle(System.Random rnd) { }
        public C5.IList<T> Slide(int offset) { throw null; }
        public C5.IList<T> Slide(int offset, int size) { throw null; }
        public void Sort() { }
        public void Sort(System.Collections.Generic.IComparer<T> comparer) { }
        public C5.IList<T> Span(C5.IList<T> otherView) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object o) { throw null; }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
        public T[] ToArray() { throw null; }
        public override string ToString() { throw null; }
        public virtual string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
        public bool TrySlide(int offset) { throw null; }
        public bool TrySlide(int offset, int size) { throw null; }
        public C5.ICollectionValue<T> UniqueItems() { throw null; }
        public bool UnsequencedEquals(C5.ICollection<T> that) { throw null; }
        public bool Update(T item) { throw null; }
        public bool Update(T item, out T olditem) { olditem = default(T); throw null; }
        public bool UpdateOrAdd(T item) { throw null; }
        public bool UpdateOrAdd(T item, out T olditem) { olditem = default(T); throw null; }
        public C5.IList<T> View(int start, int count) { throw null; }
        public C5.IList<T> ViewOf(T item) { throw null; }
    }
}
