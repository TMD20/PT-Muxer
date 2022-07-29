// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Mono.Configuration.Crypto.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono configuration encryption utilities.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Configuration.Crypto.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.DefaultDependencyAttribute(System.Runtime.CompilerServices.LoadHint.Always)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace Mono.Configuration.Crypto
{
    public partial class ConfigSection
    {
        public ConfigSection() { }
        public void Decrypt(string configFile, string configSection, string containerName, bool useMachineStore) { }
        public void Encrypt(string configFile, string configSection, string containerName, bool useMachineStore) { }
    }
    public partial class Key
    {
        public Key(string file, bool machineStore) { }
        public Key(string containerName, string keyValue, bool machineStore) { }
        public Key(string containerName, uint keySize, bool machineStore) { }
        public string ContainerName { get { throw null; } set { } }
        public bool IsValid { get { throw null; } }
        public string KeyValue { get { throw null; } set { } }
        public bool Local { get { throw null; } }
        public int ProviderType { get { throw null; } set { } }
        public void Save() { }
    }
    public partial class KeyContainer : System.Collections.Generic.IEnumerable<Mono.Configuration.Crypto.Key>, System.Collections.IEnumerable
    {
        public KeyContainer(string name, bool machineStore) { }
        public int Count { get { throw null; } }
        public Mono.Configuration.Crypto.Key this[int index] { get { throw null; } }
        public bool Local { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public void Add(Mono.Configuration.Crypto.Key key) { }
        public System.Collections.Generic.IEnumerator<Mono.Configuration.Crypto.Key> GetEnumerator() { throw null; }
        public static void RemoveFromDisk(string containerName, bool machineStore) { }
        System.Collections.Generic.IEnumerator<Mono.Configuration.Crypto.Key> System.Collections.Generic.IEnumerable<Mono.Configuration.Crypto.Key>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class KeyContainerCollection : System.Collections.Generic.ICollection<Mono.Configuration.Crypto.KeyContainer>, System.Collections.Generic.IEnumerable<Mono.Configuration.Crypto.KeyContainer>, System.Collections.IEnumerable
    {
        public KeyContainerCollection(bool machineStore) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public Mono.Configuration.Crypto.KeyContainer this[string name] { get { throw null; } }
        public void Add(Mono.Configuration.Crypto.KeyContainer item) { }
        public void Clear() { }
        public bool Contains(Mono.Configuration.Crypto.KeyContainer item) { throw null; }
        public bool Contains(string name) { throw null; }
        public void CopyTo(Mono.Configuration.Crypto.KeyContainer[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<Mono.Configuration.Crypto.KeyContainer> GetEnumerator() { throw null; }
        public bool Remove(Mono.Configuration.Crypto.KeyContainer item) { throw null; }
        System.Collections.Generic.IEnumerator<Mono.Configuration.Crypto.KeyContainer> System.Collections.Generic.IEnumerable<Mono.Configuration.Crypto.KeyContainer>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
}
