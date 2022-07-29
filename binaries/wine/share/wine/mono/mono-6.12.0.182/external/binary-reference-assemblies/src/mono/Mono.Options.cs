// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("0.2.3.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Command Line Parsing Utilities")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Options.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Mono.Options
{
    public abstract partial class ArgumentSource
    {
        protected ArgumentSource() { }
        public abstract string Description { get; }
        public static System.Collections.Generic.IEnumerable<string> GetArguments(System.IO.TextReader reader) { throw null; }
        public abstract bool GetArguments(string value, out System.Collections.Generic.IEnumerable<string> replacement);
        public static System.Collections.Generic.IEnumerable<string> GetArgumentsFromFile(string file) { throw null; }
        public abstract string[] GetNames();
    }
    public partial class Command
    {
        public Command(string name, string help=null) { }
        public Mono.Options.CommandSet CommandSet { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Help { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.Options.OptionSet Options { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Action<System.Collections.Generic.IEnumerable<string>> Run { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int Invoke(System.Collections.Generic.IEnumerable<string> arguments) { throw null; }
    }
    public partial class CommandSet : System.Collections.ObjectModel.KeyedCollection<string, Mono.Options.Command>
    {
        public CommandSet(string suite, System.Converter<string, string> localizer=null) { }
        public CommandSet(string suite, System.IO.TextWriter output, System.IO.TextWriter error, System.Converter<string, string> localizer=null) { }
        public System.IO.TextWriter Error { get { throw null; } }
        public System.Converter<string, string> MessageLocalizer { get { throw null; } }
        public System.IO.TextWriter Out { get { throw null; } }
        public string Suite { get { throw null; } }
        public Mono.Options.CommandSet Add(Mono.Options.ArgumentSource source) { throw null; }
        public new Mono.Options.CommandSet Add(Mono.Options.Command value) { throw null; }
        public Mono.Options.CommandSet Add(Mono.Options.Option option) { throw null; }
        public Mono.Options.CommandSet Add(string header) { throw null; }
        public Mono.Options.CommandSet Add(string prototype, Mono.Options.OptionAction<string, string> action) { throw null; }
        public Mono.Options.CommandSet Add(string prototype, System.Action<string> action) { throw null; }
        public Mono.Options.CommandSet Add(string prototype, string description, Mono.Options.OptionAction<string, string> action) { throw null; }
        public Mono.Options.CommandSet Add(string prototype, string description, Mono.Options.OptionAction<string, string> action, bool hidden) { throw null; }
        public Mono.Options.CommandSet Add(string prototype, string description, System.Action<string> action) { throw null; }
        public Mono.Options.CommandSet Add(string prototype, string description, System.Action<string> action, bool hidden) { throw null; }
        public Mono.Options.CommandSet Add<T>(string prototype, System.Action<T> action) { throw null; }
        public Mono.Options.CommandSet Add<T>(string prototype, string description, System.Action<T> action) { throw null; }
        public Mono.Options.CommandSet Add<TKey, TValue>(string prototype, Mono.Options.OptionAction<TKey, TValue> action) { throw null; }
        public Mono.Options.CommandSet Add<TKey, TValue>(string prototype, string description, Mono.Options.OptionAction<TKey, TValue> action) { throw null; }
        protected override string GetKeyForItem(Mono.Options.Command item) { throw null; }
        public int Run(System.Collections.Generic.IEnumerable<string> arguments) { throw null; }
    }
    public partial class HelpCommand : Mono.Options.Command
    {
        public HelpCommand() : base (default(string), default(string)) { }
        public override int Invoke(System.Collections.Generic.IEnumerable<string> arguments) { throw null; }
    }
    public abstract partial class Option
    {
        protected Option(string prototype, string description) { }
        protected Option(string prototype, string description, int maxValueCount) { }
        protected Option(string prototype, string description, int maxValueCount, bool hidden) { }
        public string Description { get { throw null; } }
        public bool Hidden { get { throw null; } }
        public int MaxValueCount { get { throw null; } }
        public Mono.Options.OptionValueType OptionValueType { get { throw null; } }
        public string Prototype { get { throw null; } }
        public string[] GetNames() { throw null; }
        public string[] GetValueSeparators() { throw null; }
        public void Invoke(Mono.Options.OptionContext c) { }
        protected abstract void OnParseComplete(Mono.Options.OptionContext c);
        protected static T Parse<T>(string value, Mono.Options.OptionContext c) { throw null; }
        public override string ToString() { throw null; }
    }
    public delegate void OptionAction<TKey, TValue>(TKey key, TValue value);
    public partial class OptionContext
    {
        public OptionContext(Mono.Options.OptionSet @set) { }
        public Mono.Options.Option Option { get { throw null; } set { } }
        public int OptionIndex { get { throw null; } set { } }
        public string OptionName { get { throw null; } set { } }
        public Mono.Options.OptionSet OptionSet { get { throw null; } }
        public Mono.Options.OptionValueCollection OptionValues { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class OptionException : System.Exception
    {
        public OptionException() { }
        protected OptionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public OptionException(string message, string optionName) { }
        public OptionException(string message, string optionName, System.Exception innerException) { }
        public string OptionName { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class OptionSet : System.Collections.ObjectModel.KeyedCollection<string, Mono.Options.Option>
    {
        public OptionSet() { }
        public OptionSet(System.Converter<string, string> localizer) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<Mono.Options.ArgumentSource> ArgumentSources { get { throw null; } }
        public System.Converter<string, string> MessageLocalizer { get { throw null; } }
        public Mono.Options.OptionSet Add(Mono.Options.ArgumentSource source) { throw null; }
        public new Mono.Options.OptionSet Add(Mono.Options.Option option) { throw null; }
        public Mono.Options.OptionSet Add(string header) { throw null; }
        public Mono.Options.OptionSet Add(string prototype, Mono.Options.OptionAction<string, string> action) { throw null; }
        public Mono.Options.OptionSet Add(string prototype, System.Action<string> action) { throw null; }
        public Mono.Options.OptionSet Add(string prototype, string description, Mono.Options.OptionAction<string, string> action) { throw null; }
        public Mono.Options.OptionSet Add(string prototype, string description, Mono.Options.OptionAction<string, string> action, bool hidden) { throw null; }
        public Mono.Options.OptionSet Add(string prototype, string description, System.Action<string> action) { throw null; }
        public Mono.Options.OptionSet Add(string prototype, string description, System.Action<string> action, bool hidden) { throw null; }
        public Mono.Options.OptionSet Add<T>(string prototype, System.Action<T> action) { throw null; }
        public Mono.Options.OptionSet Add<T>(string prototype, string description, System.Action<T> action) { throw null; }
        public Mono.Options.OptionSet Add<TKey, TValue>(string prototype, Mono.Options.OptionAction<TKey, TValue> action) { throw null; }
        public Mono.Options.OptionSet Add<TKey, TValue>(string prototype, string description, Mono.Options.OptionAction<TKey, TValue> action) { throw null; }
        protected virtual Mono.Options.OptionContext CreateOptionContext() { throw null; }
        protected override string GetKeyForItem(Mono.Options.Option item) { throw null; }
        [System.ObsoleteAttribute("Use KeyedCollection.this[string]")]
        protected Mono.Options.Option GetOptionForName(string option) { throw null; }
        protected bool GetOptionParts(string argument, out string flag, out string name, out string sep, out string value) { flag = default(string); name = default(string); sep = default(string); value = default(string); throw null; }
        protected override void InsertItem(int index, Mono.Options.Option item) { }
        public System.Collections.Generic.List<string> Parse(System.Collections.Generic.IEnumerable<string> arguments) { throw null; }
        protected virtual bool Parse(string argument, Mono.Options.OptionContext c) { throw null; }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, Mono.Options.Option item) { }
        public void WriteOptionDescriptions(System.IO.TextWriter o) { }
    }
    public partial class OptionValueCollection : System.Collections.Generic.ICollection<string>, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IList<string>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        internal OptionValueCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public string this[int index] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void Add(string item) { }
        public void Clear() { }
        public bool Contains(string item) { throw null; }
        public void CopyTo(string[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<string> GetEnumerator() { throw null; }
        public int IndexOf(string item) { throw null; }
        public void Insert(int index, string item) { }
        public bool Remove(string item) { throw null; }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        public string[] ToArray() { throw null; }
        public System.Collections.Generic.List<string> ToList() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum OptionValueType
    {
        None = 0,
        Optional = 1,
        Required = 2,
    }
    public partial class ResponseFileSource : Mono.Options.ArgumentSource
    {
        public ResponseFileSource() { }
        public override string Description { get { throw null; } }
        public override bool GetArguments(string value, out System.Collections.Generic.IEnumerable<string> replacement) { replacement = default(System.Collections.Generic.IEnumerable<string>); throw null; }
        public override string[] GetNames() { throw null; }
    }
}
