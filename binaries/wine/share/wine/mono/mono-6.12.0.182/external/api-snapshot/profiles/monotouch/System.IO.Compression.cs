// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.IO.Compression.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.IO.Compression.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.IO.Compression.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.IO.Compression.CompressionLevel))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.IO.Compression.CompressionMode))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.IO.Compression.DeflateStream))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.IO.Compression.GZipStream))]
namespace System.IO.Compression
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BrotliDecoder : System.IDisposable
    {
        private object _dummy;
        private int _dummyPrimitive;
        public System.Buffers.OperationStatus Decompress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, out int bytesConsumed, out int bytesWritten) { throw null; }
        public void Dispose() { }
        public static bool TryDecompress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, out int bytesWritten) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BrotliEncoder : System.IDisposable
    {
        private object _dummy;
        private int _dummyPrimitive;
        public BrotliEncoder(int quality, int window) { throw null; }
        public System.Buffers.OperationStatus Compress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) { throw null; }
        public void Dispose() { }
        public System.Buffers.OperationStatus Flush(System.Span<byte> destination, out int bytesWritten) { throw null; }
        public static int GetMaxCompressedLength(int length) { throw null; }
        public static bool TryCompress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, out int bytesWritten) { throw null; }
        public static bool TryCompress(System.ReadOnlySpan<byte> source, System.Span<byte> destination, out int bytesWritten, int quality, int window) { throw null; }
    }
    public sealed partial class BrotliStream : System.IO.Stream
    {
        public BrotliStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
        public BrotliStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen) { }
        public BrotliStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
        public BrotliStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
        public System.IO.Stream BaseStream { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override int Read(System.Span<byte> buffer) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void Write(System.ReadOnlySpan<byte> buffer) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ZipArchive : System.IDisposable
    {
        public ZipArchive(System.IO.Stream stream) { }
        public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode) { }
        public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen) { }
        public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get { throw null; } }
        public System.IO.Compression.ZipArchiveMode Mode { get { throw null; } }
        public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName) { throw null; }
        public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName, System.IO.Compression.CompressionLevel compressionLevel) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.IO.Compression.ZipArchiveEntry GetEntry(string entryName) { throw null; }
    }
    public partial class ZipArchiveEntry
    {
        internal ZipArchiveEntry() { }
        public System.IO.Compression.ZipArchive Archive { get { throw null; } }
        public long CompressedLength { get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public uint Crc32 { get { throw null; } }
        public int ExternalAttributes { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public System.DateTimeOffset LastWriteTime { get { throw null; } set { } }
        public long Length { get { throw null; } }
        public string Name { get { throw null; } }
        public void Delete() { }
        public System.IO.Stream Open() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ZipArchiveMode
    {
        Create = 1,
        Read = 0,
        Update = 2,
    }
}
