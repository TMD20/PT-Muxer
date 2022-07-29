// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.84.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Copyright 2001-2005 Mike Krueger")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("A free C# compression library")]
[assembly:System.Reflection.AssemblyProductAttribute("#ZipLibrary")]
[assembly:System.Reflection.AssemblyTitleAttribute("ICSharpCode.SharpZipLibrary")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace ICSharpCode.SharpZipLib
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class SharpZipBaseException : System.ApplicationException
    {
        public SharpZipBaseException() { }
        public SharpZipBaseException(string msg) { }
        public SharpZipBaseException(string message, System.Exception innerException) { }
    }
}
namespace ICSharpCode.SharpZipLib.BZip2
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public sealed partial class BZip2
    {
        public BZip2() { }
        public static void Compress(System.IO.Stream instream, System.IO.Stream outstream, int blockSize) { }
        public static void Decompress(System.IO.Stream instream, System.IO.Stream outstream) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public sealed partial class BZip2Constants
    {
        internal BZip2Constants() { }
        public static readonly int baseBlockSize;
        public static readonly int G_SIZE;
        public static readonly int MAX_ALPHA_SIZE;
        public static readonly int MAX_CODE_LEN;
        public static readonly int MAX_SELECTORS;
        public static readonly int NUM_OVERSHOOT_BYTES;
        public static readonly int N_GROUPS;
        public static readonly int N_ITERS;
        public static readonly int[] rNums;
        public static readonly int RUNA;
        public static readonly int RUNB;
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class BZip2Exception : ICSharpCode.SharpZipLib.SharpZipBaseException
    {
        public BZip2Exception() { }
        public BZip2Exception(string message) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class BZip2InputStream : System.IO.Stream
    {
        public BZip2InputStream(System.IO.Stream stream) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Close() { }
        public override void Flush() { }
        public override int Read(byte[] b, int offset, int count) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long val) { }
        public override void Write(byte[] array, int offset, int count) { }
        public override void WriteByte(byte val) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class BZip2OutputStream : System.IO.Stream
    {
        public BZip2OutputStream(System.IO.Stream stream) { }
        public BZip2OutputStream(System.IO.Stream stream, int blockSize) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Close() { }
        ~BZip2OutputStream() { }
        public override void Flush() { }
        public override int Read(byte[] b, int off, int len) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long val) { }
        public override void Write(byte[] buf, int off, int len) { }
        public override void WriteByte(byte bv) { }
    }
}
namespace ICSharpCode.SharpZipLib.Checksums
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public sealed partial class Adler32 : ICSharpCode.SharpZipLib.Checksums.IChecksum
    {
        public Adler32() { }
        public long Value { get { throw null; } }
        public void Reset() { }
        public void Update(byte[] buffer) { }
        public void Update(byte[] buf, int off, int len) { }
        public void Update(int bval) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public sealed partial class Crc32 : ICSharpCode.SharpZipLib.Checksums.IChecksum
    {
        public Crc32() { }
        public long Value { get { throw null; } set { } }
        public void Reset() { }
        public void Update(byte[] buffer) { }
        public void Update(byte[] buf, int off, int len) { }
        public void Update(int bval) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial interface IChecksum
    {
        long Value { get; }
        void Reset();
        void Update(byte[] buffer);
        void Update(byte[] buf, int off, int len);
        void Update(int bval);
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class StrangeCRC : ICSharpCode.SharpZipLib.Checksums.IChecksum
    {
        public StrangeCRC() { }
        public long Value { get { throw null; } }
        public void Reset() { }
        public void Update(byte[] buf) { }
        public void Update(byte[] buf, int off, int len) { }
        public void Update(int inCh) { }
    }
}
namespace ICSharpCode.SharpZipLib.Core
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class DirectoryEventArgs : ICSharpCode.SharpZipLib.Core.ScanEventArgs
    {
        public DirectoryEventArgs(string name, bool hasMatchingFiles) : base (default(string)) { }
        public bool HasMatchingFiles { get { throw null; } }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public delegate void DirectoryFailureDelegate(object sender, ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs e);
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public delegate void FileFailureDelegate(object sender, ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs e);
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class FileSystemScanner
    {
        public ICSharpCode.SharpZipLib.Core.DirectoryFailureDelegate DirectoryFailure;
        public ICSharpCode.SharpZipLib.Core.FileFailureDelegate FileFailure;
        public ICSharpCode.SharpZipLib.Core.ProcessDirectoryDelegate ProcessDirectory;
        public ICSharpCode.SharpZipLib.Core.ProcessFileDelegate ProcessFile;
        public FileSystemScanner(ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter) { }
        public FileSystemScanner(ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter, ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter) { }
        public FileSystemScanner(string filter) { }
        public FileSystemScanner(string fileFilter, string directoryFilter) { }
        public void OnDirectoryFailure(string directory, System.Exception e) { }
        public void OnFileFailure(string file, System.Exception e) { }
        public void OnProcessDirectory(string directory, bool hasMatchingFiles) { }
        public void OnProcessFile(string file) { }
        public void Scan(string directory, bool recurse) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial interface INameTransform
    {
        string TransformDirectory(string name);
        string TransformFile(string name);
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial interface IScanFilter
    {
        bool IsMatch(string name);
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class NameAndSizeFilter : ICSharpCode.SharpZipLib.Core.PathFilter
    {
        public NameAndSizeFilter(string filter, long minSize, long maxSize) : base (default(string)) { }
        public long MaxSize { get { throw null; } set { } }
        public long MinSize { get { throw null; } set { } }
        public override bool IsMatch(string fileName) { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class NameFilter
    {
        public NameFilter(string filter) { }
        public bool IsExcluded(string testValue) { throw null; }
        public bool IsIncluded(string testValue) { throw null; }
        public bool IsMatch(string testValue) { throw null; }
        public static bool IsValidExpression(string e) { throw null; }
        public static bool IsValidFilterExpression(string toTest) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class PathFilter : ICSharpCode.SharpZipLib.Core.IScanFilter
    {
        public PathFilter(string filter) { }
        public virtual bool IsMatch(string name) { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public delegate void ProcessDirectoryDelegate(object Sender, ICSharpCode.SharpZipLib.Core.DirectoryEventArgs e);
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public delegate void ProcessFileDelegate(object sender, ICSharpCode.SharpZipLib.Core.ScanEventArgs e);
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ScanEventArgs : System.EventArgs
    {
        public ScanEventArgs(string name) { }
        public bool ContinueRunning { get { throw null; } set { } }
        public string Name { get { throw null; } }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ScanFailureEventArgs
    {
        public ScanFailureEventArgs(string name, System.Exception e) { }
        public bool ContinueRunning { get { throw null; } set { } }
        public System.Exception Exception { get { throw null; } }
        public string Name { get { throw null; } }
    }
}
namespace ICSharpCode.SharpZipLib.Encryption
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public abstract partial class PkzipClassic : System.Security.Cryptography.SymmetricAlgorithm
    {
        protected PkzipClassic() { }
        public static byte[] GenerateKeys(byte[] seed) { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public sealed partial class PkzipClassicManaged : ICSharpCode.SharpZipLib.Encryption.PkzipClassic
    {
        public PkzipClassicManaged() { }
        public override int BlockSize { get { throw null; } set { } }
        public override byte[] Key { get { throw null; } set { } }
        public override System.Security.Cryptography.KeySizes[] LegalBlockSizes { get { throw null; } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
}
namespace ICSharpCode.SharpZipLib.GZip
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class GZipConstants
    {
        internal GZipConstants() { }
        public const int FCOMMENT = 16;
        public const int FEXTRA = 4;
        public const int FHCRC = 2;
        public const int FNAME = 8;
        public const int FTEXT = 1;
        public static readonly int GZIP_MAGIC;
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class GZipException : ICSharpCode.SharpZipLib.SharpZipBaseException
    {
        public GZipException() { }
        public GZipException(string message) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class GZipInputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
    {
        protected ICSharpCode.SharpZipLib.Checksums.Crc32 crc;
        protected bool eos;
        public GZipInputStream(System.IO.Stream baseInputStream) : base (default(System.IO.Stream)) { }
        public GZipInputStream(System.IO.Stream baseInputStream, int size) : base (default(System.IO.Stream)) { }
        public override int Read(byte[] buf, int offset, int len) { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class GZipOutputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream
    {
        protected ICSharpCode.SharpZipLib.Checksums.Crc32 crc;
        public GZipOutputStream(System.IO.Stream baseOutputStream) : base (default(System.IO.Stream)) { }
        public GZipOutputStream(System.IO.Stream baseOutputStream, int size) : base (default(System.IO.Stream)) { }
        public override void Close() { }
        public override void Finish() { }
        public int GetLevel() { throw null; }
        public void SetLevel(int level) { }
        public override void Write(byte[] buf, int off, int len) { }
    }
}
namespace ICSharpCode.SharpZipLib.Tar
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class InvalidHeaderException : ICSharpCode.SharpZipLib.Tar.TarException
    {
        public InvalidHeaderException() { }
        public InvalidHeaderException(string msg) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public delegate void ProgressMessageHandler(ICSharpCode.SharpZipLib.Tar.TarArchive archive, ICSharpCode.SharpZipLib.Tar.TarEntry entry, string message);
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class TarArchive
    {
        protected TarArchive() { }
        public bool ApplyUserInfoOverrides { get { throw null; } set { } }
        public int GroupId { get { throw null; } }
        public string GroupName { get { throw null; } }
        public string PathPrefix { get { throw null; } set { } }
        public int RecordSize { get { throw null; } }
        public string RootPath { get { throw null; } set { } }
        public int UserId { get { throw null; } }
        public string UserName { get { throw null; } }
        public event ICSharpCode.SharpZipLib.Tar.ProgressMessageHandler ProgressMessageEvent { add { } remove { } }
        public void CloseArchive() { }
        public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(System.IO.Stream inputStream) { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(System.IO.Stream inputStream, int blockFactor) { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(System.IO.Stream outputStream) { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(System.IO.Stream outputStream, int blockFactor) { throw null; }
        public void ExtractContents(string destDir) { }
        public void ListContents() { }
        protected virtual void OnProgressMessageEvent(ICSharpCode.SharpZipLib.Tar.TarEntry entry, string message) { }
        public void SetAsciiTranslation(bool asciiTranslate) { }
        public void SetKeepOldFiles(bool keepOldFiles) { }
        public void SetUserInfo(int userId, string userName, int groupId, string groupName) { }
        public void WriteEntry(ICSharpCode.SharpZipLib.Tar.TarEntry sourceEntry, bool recurse) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class TarBuffer
    {
        public const int BlockSize = 512;
        public const int DefaultBlockFactor = 20;
        public const int DefaultRecordSize = 10240;
        protected TarBuffer() { }
        public int BlockFactor { get { throw null; } }
        public int RecordSize { get { throw null; } }
        public void Close() { }
        public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(System.IO.Stream inputStream) { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(System.IO.Stream inputStream, int blockFactor) { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(System.IO.Stream outputStream) { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(System.IO.Stream outputStream, int blockFactor) { throw null; }
        public int GetBlockFactor() { throw null; }
        public int GetCurrentBlockNum() { throw null; }
        public int GetCurrentRecordNum() { throw null; }
        public int GetRecordSize() { throw null; }
        public bool IsEOFBlock(byte[] block) { throw null; }
        public byte[] ReadBlock() { throw null; }
        public void SkipBlock() { }
        public void WriteBlock(byte[] block) { }
        public void WriteBlock(byte[] buf, int offset) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class TarEntry : System.ICloneable
    {
        public TarEntry(ICSharpCode.SharpZipLib.Tar.TarHeader header) { }
        public TarEntry(byte[] headerBuf) { }
        public string File { get { throw null; } }
        public int GroupId { get { throw null; } set { } }
        public string GroupName { get { throw null; } set { } }
        public bool IsDirectory { get { throw null; } }
        public System.DateTime ModTime { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public long Size { get { throw null; } set { } }
        public ICSharpCode.SharpZipLib.Tar.TarHeader TarHeader { get { throw null; } }
        public int UserId { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
        public void AdjustEntryName(byte[] outbuf, string newName) { }
        public object Clone() { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName) { throw null; }
        public static ICSharpCode.SharpZipLib.Tar.TarEntry CreateTarEntry(string name) { throw null; }
        public override bool Equals(object it) { throw null; }
        public ICSharpCode.SharpZipLib.Tar.TarEntry[] GetDirectoryEntries() { throw null; }
        public void GetFileTarHeader(ICSharpCode.SharpZipLib.Tar.TarHeader hdr, string file) { }
        public override int GetHashCode() { throw null; }
        public bool IsDescendent(ICSharpCode.SharpZipLib.Tar.TarEntry desc) { throw null; }
        public void NameTarHeader(ICSharpCode.SharpZipLib.Tar.TarHeader hdr, string name) { }
        public void SetIds(int userId, int groupId) { }
        public void SetNames(string userName, string groupName) { }
        public void WriteEntryHeader(byte[] outbuf) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class TarException : ICSharpCode.SharpZipLib.SharpZipBaseException
    {
        public TarException() { }
        public TarException(string message) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class TarHeader : System.ICloneable
    {
        public static readonly int CHKSUMLEN;
        public const int CHKSUMOFS = 148;
        public static readonly int DEVLEN;
        public static readonly int GIDLEN;
        public static readonly int GNAMELEN;
        public static readonly string GNU_TMAGIC;
        public const byte LF_ACL = (byte)65;
        public const byte LF_BLK = (byte)52;
        public const byte LF_CHR = (byte)51;
        public const byte LF_CONTIG = (byte)55;
        public const byte LF_DIR = (byte)53;
        public const byte LF_EXTATTR = (byte)69;
        public const byte LF_FIFO = (byte)54;
        public const byte LF_GHDR = (byte)103;
        public const byte LF_GNU_DUMPDIR = (byte)68;
        public const byte LF_GNU_LONGLINK = (byte)75;
        public const byte LF_GNU_LONGNAME = (byte)76;
        public const byte LF_GNU_MULTIVOL = (byte)77;
        public const byte LF_GNU_NAMES = (byte)78;
        public const byte LF_GNU_SPARSE = (byte)83;
        public const byte LF_GNU_VOLHDR = (byte)86;
        public const byte LF_LINK = (byte)49;
        public const byte LF_META = (byte)73;
        public const byte LF_NORMAL = (byte)48;
        public const byte LF_OLDNORM = (byte)0;
        public const byte LF_SYMLINK = (byte)50;
        public static readonly byte LF_XHDR;
        public static readonly int MAGICLEN;
        public static readonly int MODELEN;
        public static readonly int MODTIMELEN;
        public static readonly int NAMELEN;
        public static readonly int SIZELEN;
        public static readonly string TMAGIC;
        public static readonly int UIDLEN;
        public static readonly int UNAMELEN;
        public static readonly int VERSIONLEN;
        public TarHeader() { }
        public int Checksum { get { throw null; } }
        public int DevMajor { get { throw null; } set { } }
        public int DevMinor { get { throw null; } set { } }
        public int GroupId { get { throw null; } set { } }
        public string GroupName { get { throw null; } set { } }
        public bool IsChecksumValid { get { throw null; } }
        public string LinkName { get { throw null; } set { } }
        public string Magic { get { throw null; } set { } }
        public int Mode { get { throw null; } set { } }
        public System.DateTime ModTime { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public long Size { get { throw null; } set { } }
        public byte TypeFlag { get { throw null; } set { } }
        public int UserId { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public object Clone() { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length) { throw null; }
        public override int GetHashCode() { throw null; }
        public static int GetLongOctalBytes(long val, byte[] buf, int offset, int length) { throw null; }
        [System.ObsoleteAttribute]
        public string GetName() { throw null; }
        public static int GetNameBytes(string name, byte[] buf, int offset, int length) { throw null; }
        public static int GetNameBytes(string name, int nameOffset, byte[] buf, int bufferOffset, int length) { throw null; }
        public static int GetNameBytes(System.Text.StringBuilder name, byte[] buf, int offset, int length) { throw null; }
        public static int GetNameBytes(System.Text.StringBuilder name, int nameOffset, byte[] buf, int bufferOffset, int length) { throw null; }
        public static int GetOctalBytes(long val, byte[] buf, int offset, int length) { throw null; }
        public void ParseBuffer(byte[] header) { }
        public static System.Text.StringBuilder ParseName(byte[] header, int offset, int length) { throw null; }
        public static long ParseOctal(byte[] header, int offset, int length) { throw null; }
        public static void ResetValueDefaults() { }
        public static void SetValueDefaults(int userId, string userName, int groupId, string groupName) { }
        public void WriteHeader(byte[] outbuf) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class TarInputStream : System.IO.Stream
    {
        protected ICSharpCode.SharpZipLib.Tar.TarBuffer buffer;
        protected ICSharpCode.SharpZipLib.Tar.TarEntry currEntry;
        protected ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory eFactory;
        protected long entryOffset;
        protected long entrySize;
        protected bool hasHitEOF;
        protected byte[] readBuf;
        public TarInputStream(System.IO.Stream inputStream) { }
        public TarInputStream(System.IO.Stream inputStream, int blockFactor) { }
        public long Available { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool IsMarkSupported { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Close() { }
        public void CopyEntryContents(System.IO.Stream outputStream) { }
        public override void Flush() { }
        public ICSharpCode.SharpZipLib.Tar.TarEntry GetNextEntry() { throw null; }
        public int GetRecordSize() { throw null; }
        public void Mark(int markLimit) { }
        public override int Read(byte[] outputBuffer, int offset, int count) { throw null; }
        public override int ReadByte() { throw null; }
        public void Reset() { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public void SetEntryFactory(ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory factory) { }
        public override void SetLength(long val) { }
        public void Skip(long numToSkip) { }
        public override void Write(byte[] array, int offset, int count) { }
        public override void WriteByte(byte val) { }
        [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
        public partial class EntryFactoryAdapter : ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory
        {
            public EntryFactoryAdapter() { }
            public ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(byte[] headerBuf) { throw null; }
            public ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name) { throw null; }
            public ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName) { throw null; }
        }
        [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
        public partial interface IEntryFactory
        {
            ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(byte[] headerBuf);
            ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name);
            ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName);
        }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class TarOutputStream : System.IO.Stream
    {
        protected byte[] assemBuf;
        protected int assemLen;
        protected byte[] blockBuf;
        protected ICSharpCode.SharpZipLib.Tar.TarBuffer buffer;
        protected long currBytes;
        protected long currSize;
        protected bool debug;
        protected System.IO.Stream outputStream;
        public TarOutputStream(System.IO.Stream outputStream) { }
        public TarOutputStream(System.IO.Stream outputStream, int blockFactor) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Close() { }
        public void CloseEntry() { }
        public void Finish() { }
        public override void Flush() { }
        public int GetRecordSize() { throw null; }
        public void PutNextEntry(ICSharpCode.SharpZipLib.Tar.TarEntry entry) { }
        public override int Read(byte[] b, int off, int len) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long val) { }
        public override void Write(byte[] wBuf, int wOffset, int numToWrite) { }
        public override void WriteByte(byte b) { }
    }
}
namespace ICSharpCode.SharpZipLib.Zip
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public enum CompressionMethod
    {
        BZip2 = 11,
        Deflate64 = 9,
        Deflated = 8,
        Stored = 0,
        WinZipAES = 99,
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class FastZip
    {
        public FastZip() { }
        public FastZip(ICSharpCode.SharpZipLib.Zip.FastZipEvents events) { }
        public bool CreateEmptyDirectories { get { throw null; } set { } }
        public ICSharpCode.SharpZipLib.Zip.ZipNameTransform NameTransform { get { throw null; } set { } }
        public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter) { }
        public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter) { }
        public void ExtractZip(string zipFileName, string targetDirectory, ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite overwrite, ICSharpCode.SharpZipLib.Zip.FastZip.ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter) { }
        public void ExtractZip(string zipFileName, string targetDirectory, string fileFilter) { }
        public delegate bool ConfirmOverwriteDelegate(string fileName);
        public enum Overwrite
        {
            Always = 2,
            Never = 1,
            Prompt = 0,
        }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class FastZipEvents
    {
        public ICSharpCode.SharpZipLib.Core.DirectoryFailureDelegate DirectoryFailure;
        public ICSharpCode.SharpZipLib.Core.FileFailureDelegate FileFailure;
        public ICSharpCode.SharpZipLib.Core.ProcessDirectoryDelegate ProcessDirectory;
        public ICSharpCode.SharpZipLib.Core.ProcessFileDelegate ProcessFile;
        public FastZipEvents() { }
        public void OnDirectoryFailure(string directory, System.Exception e) { }
        public void OnFileFailure(string file, System.Exception e) { }
        public void OnProcessDirectory(string directory, bool hasMatchingFiles) { }
        public void OnProcessFile(string file) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class KeysRequiredEventArgs : System.EventArgs
    {
        public KeysRequiredEventArgs(string name) { }
        public KeysRequiredEventArgs(string name, byte[] keyValue) { }
        public string FileName { get { throw null; } }
        public byte[] Key { get { throw null; } set { } }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public sealed partial class ZipConstants
    {
        public const int CENATT = 36;
        public const int CENATX = 38;
        public const int CENCOM = 32;
        public const int CENCRC = 16;
        public const int CENDIGITALSIG = 84233040;
        public const int CENDSK = 34;
        public const int CENEXT = 30;
        public const int CENFLG = 8;
        public const int CENHDR = 46;
        public const int CENHOW = 10;
        public const int CENLEN = 24;
        public const int CENNAM = 28;
        public const int CENOFF = 42;
        public const int CENSIG = 33639248;
        public const int CENSIG64 = 101075792;
        public const int CENSIZ = 20;
        public const int CENTIM = 12;
        public const int CENVEM = 4;
        public const int CENVER = 6;
        public const int CRYPTO_HEADER_SIZE = 12;
        public const int ENDCOM = 20;
        public const int ENDDCD = 6;
        public const int ENDHDR = 22;
        public const int ENDNRD = 4;
        public const int ENDOFF = 16;
        public const int ENDSIG = 101010256;
        public const int ENDSIZ = 12;
        public const int ENDSUB = 8;
        public const int ENDTOT = 10;
        public const int EXTCRC = 4;
        public const int EXTHDR = 16;
        public const int EXTLEN = 12;
        public const int EXTSIG = 134695760;
        public const int EXTSIZ = 8;
        public const int LOCCRC = 14;
        public const int LOCEXT = 28;
        public const int LOCFLG = 6;
        public const int LOCHDR = 30;
        public const int LOCHOW = 8;
        public const int LOCLEN = 22;
        public const int LOCNAM = 26;
        public const int LOCSIG = 67324752;
        public const int LOCSIZ = 18;
        public const int LOCTIM = 10;
        public const int LOCVER = 4;
        public const int SPANNINGSIG = 134695760;
        public const int SPANTEMPSIG = 808471376;
        public const int VERSION_MADE_BY = 20;
        public const int VERSION_STRONG_ENCRYPTION = 50;
        public ZipConstants() { }
        public static int DefaultCodePage { get { throw null; } set { } }
        public static byte[] ConvertToArray(string str) { throw null; }
        public static string ConvertToString(byte[] data) { throw null; }
        public static string ConvertToString(byte[] data, int length) { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ZipEntry : System.ICloneable
    {
        public ZipEntry(ICSharpCode.SharpZipLib.Zip.ZipEntry e) { }
        public ZipEntry(string name) { }
        public string Comment { get { throw null; } set { } }
        public long CompressedSize { get { throw null; } set { } }
        public ICSharpCode.SharpZipLib.Zip.CompressionMethod CompressionMethod { get { throw null; } set { } }
        public long Crc { get { throw null; } set { } }
        public System.DateTime DateTime { get { throw null; } set { } }
        public long DosTime { get { throw null; } set { } }
        public int ExternalFileAttributes { get { throw null; } set { } }
        public byte[] ExtraData { get { throw null; } set { } }
        public int Flags { get { throw null; } set { } }
        public int HostSystem { get { throw null; } }
        public bool IsCrypted { get { throw null; } set { } }
        public bool IsDirectory { get { throw null; } }
        public bool IsFile { get { throw null; } }
        public string Name { get { throw null; } }
        public int Offset { get { throw null; } set { } }
        public bool RequiresZip64 { get { throw null; } }
        public long Size { get { throw null; } set { } }
        public int Version { get { throw null; } }
        public int VersionMadeBy { get { throw null; } }
        public int ZipFileIndex { get { throw null; } set { } }
        public static string CleanName(string name) { throw null; }
        public static string CleanName(string name, bool relativePath) { throw null; }
        public object Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ZipException : ICSharpCode.SharpZipLib.SharpZipBaseException
    {
        public ZipException() { }
        public ZipException(string msg) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ZipFile : System.Collections.IEnumerable
    {
        public ICSharpCode.SharpZipLib.Zip.ZipFile.KeysRequiredEventHandler KeysRequired;
        public ZipFile(System.IO.FileStream file) { }
        public ZipFile(System.IO.Stream baseStream) { }
        public ZipFile(string name) { }
        [System.Runtime.CompilerServices.IndexerName("EntryByIndex")]
        public ICSharpCode.SharpZipLib.Zip.ZipEntry this[int index] { get { throw null; } }
        public string Name { get { throw null; } }
        public string Password { set { } }
        public int Size { get { throw null; } }
        public string ZipFileComment { get { throw null; } }
        public void Close() { }
        public int FindEntry(string name, bool ignoreCase) { throw null; }
        public ICSharpCode.SharpZipLib.Zip.ZipEntry GetEntry(string name) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public System.IO.Stream GetInputStream(ICSharpCode.SharpZipLib.Zip.ZipEntry entry) { throw null; }
        public System.IO.Stream GetInputStream(int entryIndex) { throw null; }
        public bool TestArchive(bool testData) { throw null; }
        public delegate void KeysRequiredEventHandler(object sender, ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs e);
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ZipInputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
    {
        public ZipInputStream(System.IO.Stream baseInputStream) : base (default(System.IO.Stream)) { }
        public override int Available { get { throw null; } }
        public bool CanDecompressEntry { get { throw null; } }
        public string Password { get { throw null; } set { } }
        public int BodyRead(byte[] b, int off, int len) { throw null; }
        public override void Close() { }
        public void CloseEntry() { }
        public ICSharpCode.SharpZipLib.Zip.ZipEntry GetNextEntry() { throw null; }
        public override int Read(byte[] destination, int index, int count) { throw null; }
        public override int ReadByte() { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ZipNameTransform : ICSharpCode.SharpZipLib.Core.INameTransform
    {
        public ZipNameTransform() { }
        public ZipNameTransform(bool useRelativePaths) { }
        public ZipNameTransform(bool useRelativePaths, string trimPrefix) { }
        public string TrimPrefix { get { throw null; } set { } }
        public string TransformDirectory(string name) { throw null; }
        public string TransformFile(string name) { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class ZipOutputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream
    {
        public ZipOutputStream(System.IO.Stream baseOutputStream) : base (default(System.IO.Stream)) { }
        public bool IsFinished { get { throw null; } }
        public void CloseEntry() { }
        public override void Finish() { }
        public int GetLevel() { throw null; }
        public void PutNextEntry(ICSharpCode.SharpZipLib.Zip.ZipEntry entry) { }
        public void SetComment(string comment) { }
        public void SetLevel(int level) { }
        public override void Write(byte[] b, int off, int len) { }
    }
}
namespace ICSharpCode.SharpZipLib.Zip.Compression
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class Deflater
    {
        public static int BEST_COMPRESSION;
        public static int BEST_SPEED;
        public static int DEFAULT_COMPRESSION;
        public static int DEFLATED;
        public static int NO_COMPRESSION;
        public Deflater() { }
        public Deflater(int lvl) { }
        public Deflater(int level, bool noZlibHeaderOrFooter) { }
        public int Adler { get { throw null; } }
        public bool IsFinished { get { throw null; } }
        public bool IsNeedingInput { get { throw null; } }
        public int TotalIn { get { throw null; } }
        public long TotalOut { get { throw null; } }
        public int Deflate(byte[] output) { throw null; }
        public int Deflate(byte[] output, int offset, int length) { throw null; }
        public void Finish() { }
        public void Flush() { }
        public int GetLevel() { throw null; }
        public void Reset() { }
        public void SetDictionary(byte[] dict) { }
        public void SetDictionary(byte[] dict, int offset, int length) { }
        public void SetInput(byte[] input) { }
        public void SetInput(byte[] input, int off, int len) { }
        public void SetLevel(int lvl) { }
        public void SetStrategy(ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy strategy) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class DeflaterConstants
    {
        public static int[] COMPR_FUNC;
        public const bool DEBUGGING = false;
        public const int DEFAULT_MEM_LEVEL = 8;
        public const int DEFLATE_FAST = 1;
        public const int DEFLATE_SLOW = 2;
        public const int DEFLATE_STORED = 0;
        public const int DYN_TREES = 2;
        public static int[] GOOD_LENGTH;
        public const int HASH_BITS = 15;
        public const int HASH_MASK = 32767;
        public const int HASH_SHIFT = 5;
        public const int HASH_SIZE = 32768;
        public static int MAX_BLOCK_SIZE;
        public static int[] MAX_CHAIN;
        public const int MAX_DIST = 32506;
        public static int[] MAX_LAZY;
        public const int MAX_MATCH = 258;
        public const int MAX_WBITS = 15;
        public const int MIN_LOOKAHEAD = 262;
        public const int MIN_MATCH = 3;
        public static int[] NICE_LENGTH;
        public const int PENDING_BUF_SIZE = 65536;
        public const int PRESET_DICT = 32;
        public const int STATIC_TREES = 1;
        public const int STORED_BLOCK = 0;
        public const int WMASK = 32767;
        public const int WSIZE = 32768;
        public DeflaterConstants() { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class DeflaterEngine : ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants
    {
        public DeflaterEngine(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending) { }
        public int Adler { get { throw null; } }
        public ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy Strategy { get { throw null; } set { } }
        public int TotalIn { get { throw null; } }
        public bool Deflate(bool flush, bool finish) { throw null; }
        public void FillWindow() { }
        public bool NeedsInput() { throw null; }
        public void Reset() { }
        public void ResetAdler() { }
        public void SetDictionary(byte[] buffer, int offset, int length) { }
        public void SetInput(byte[] buf, int off, int len) { }
        public void SetLevel(int lvl) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class DeflaterHuffman
    {
        public ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;
        public DeflaterHuffman(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending) { }
        public static short BitReverse(int toReverse) { throw null; }
        public void CompressBlock() { }
        public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }
        public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }
        public bool IsFull() { throw null; }
        public void Reset() { }
        public void SendAllTrees(int blTreeCodes) { }
        public bool TallyDist(int dist, int len) { throw null; }
        public bool TallyLit(int lit) { throw null; }
        [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
        public partial class Tree
        {
            public short[] freqs;
            public byte[] length;
            public int minNumCodes;
            public int numCodes;
            public Tree(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman dh, int elems, int minCodes, int maxLength) { }
            public void BuildCodes() { }
            public void BuildTree() { }
            public void CalcBLFreq(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree) { }
            public void CheckEmpty() { }
            public int GetEncodedLength() { throw null; }
            public void Reset() { }
            public void SetStaticCodes(short[] stCodes, byte[] stLength) { }
            public void WriteSymbol(int code) { }
            public void WriteTree(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree) { }
        }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class DeflaterPending : ICSharpCode.SharpZipLib.Zip.Compression.PendingBuffer
    {
        public DeflaterPending() { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public enum DeflateStrategy
    {
        Default = 0,
        Filtered = 1,
        HuffmanOnly = 2,
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class Inflater
    {
        public Inflater() { }
        public Inflater(bool noHeader) { }
        public int Adler { get { throw null; } }
        public bool IsFinished { get { throw null; } }
        public bool IsNeedingDictionary { get { throw null; } }
        public bool IsNeedingInput { get { throw null; } }
        public int RemainingInput { get { throw null; } }
        public int TotalIn { get { throw null; } }
        public int TotalOut { get { throw null; } }
        public int Inflate(byte[] buf) { throw null; }
        public int Inflate(byte[] buf, int offset, int len) { throw null; }
        public void Reset() { }
        public void SetDictionary(byte[] buffer) { }
        public void SetDictionary(byte[] buffer, int offset, int len) { }
        public void SetInput(byte[] buf) { }
        public void SetInput(byte[] buffer, int offset, int length) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class InflaterHuffmanTree
    {
        public static ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defDistTree;
        public static ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defLitLenTree;
        public InflaterHuffmanTree(byte[] codeLengths) { }
        public int GetSymbol(ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input) { throw null; }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class PendingBuffer
    {
        protected byte[] buf;
        public PendingBuffer() { }
        public PendingBuffer(int bufsize) { }
        public int BitCount { get { throw null; } }
        public bool IsFlushed { get { throw null; } }
        public void AlignToByte() { }
        public int Flush(byte[] output, int offset, int length) { throw null; }
        public void Reset() { }
        public byte[] ToByteArray() { throw null; }
        public void WriteBits(int b, int count) { }
        public void WriteBlock(byte[] block, int offset, int len) { }
        public void WriteByte(int b) { }
        public void WriteInt(int s) { }
        public void WriteShort(int s) { }
        public void WriteShortMSB(int s) { }
    }
}
namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class DeflaterOutputStream : System.IO.Stream
    {
        protected System.IO.Stream baseOutputStream;
        protected byte[] buf;
        protected ICSharpCode.SharpZipLib.Zip.Compression.Deflater def;
        public DeflaterOutputStream(System.IO.Stream baseOutputStream) { }
        public DeflaterOutputStream(System.IO.Stream baseOutputStream, ICSharpCode.SharpZipLib.Zip.Compression.Deflater defl) { }
        public DeflaterOutputStream(System.IO.Stream baseOutputStream, ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater, int bufsize) { }
        public bool CanPatchEntries { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool IsStreamOwner { get { throw null; } set { } }
        public override long Length { get { throw null; } }
        public string Password { get { throw null; } set { } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override void Close() { }
        protected void Deflate() { }
        protected void EncryptBlock(byte[] buffer, int offset, int length) { }
        protected byte EncryptByte() { throw null; }
        public virtual void Finish() { }
        public override void Flush() { }
        protected void InitializePassword(string password) { }
        public override int Read(byte[] b, int off, int len) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long val) { }
        protected void UpdateKeys(byte ch) { }
        public override void Write(byte[] buf, int off, int len) { }
        public override void WriteByte(byte bval) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class InflaterInputBuffer
    {
        public InflaterInputBuffer(System.IO.Stream stream) { }
        public int Available { get { throw null; } set { } }
        public byte[] ClearText { get { throw null; } }
        public int ClearTextLength { get { throw null; } }
        public System.Security.Cryptography.ICryptoTransform CryptoTransform { set { } }
        public byte[] RawData { get { throw null; } }
        public int RawLength { get { throw null; } }
        public void Fill() { }
        public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length) { throw null; }
        public int ReadLeByte() { throw null; }
        public int ReadLeInt() { throw null; }
        public long ReadLeLong() { throw null; }
        public int ReadLeShort() { throw null; }
        public int ReadRawBuffer(byte[] buffer) { throw null; }
        public int ReadRawBuffer(byte[] outBuffer, int offset, int length) { throw null; }
        public void SetInflaterInput(ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class InflaterInputStream : System.IO.Stream
    {
        protected System.IO.Stream baseInputStream;
        protected long csize;
        protected ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf;
        protected ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer inputBuffer;
        public InflaterInputStream(System.IO.Stream baseInputStream) { }
        public InflaterInputStream(System.IO.Stream baseInputStream, ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf) { }
        public InflaterInputStream(System.IO.Stream baseInputStream, ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater, int bufferSize) { }
        public virtual int Available { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool IsStreamOwner { get { throw null; } set { } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override void Close() { }
        protected void Fill() { }
        public override void Flush() { }
        public override int Read(byte[] b, int off, int len) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long val) { }
        public long Skip(long n) { throw null; }
        protected void StopDecrypting() { }
        public override void Write(byte[] array, int offset, int count) { }
        public override void WriteByte(byte val) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class OutputWindow
    {
        public OutputWindow() { }
        public void CopyDict(byte[] dict, int offset, int len) { }
        public int CopyOutput(byte[] output, int offset, int len) { throw null; }
        public int CopyStored(ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input, int len) { throw null; }
        public int GetAvailable() { throw null; }
        public int GetFreeSpace() { throw null; }
        public void Repeat(int len, int dist) { }
        public void Reset() { }
        public void Write(int abyte) { }
    }
    [System.ObsoleteAttribute("This assembly has been deprecated. Please use https://www.nuget.org/packages/SharpZipLib/ instead.")]
    public partial class StreamManipulator
    {
        public StreamManipulator() { }
        public int AvailableBits { get { throw null; } }
        public int AvailableBytes { get { throw null; } }
        public bool IsNeedingInput { get { throw null; } }
        public int CopyBytes(byte[] output, int offset, int length) { throw null; }
        public void DropBits(int n) { }
        public int GetBits(int n) { throw null; }
        public int PeekBits(int n) { throw null; }
        public void Reset() { }
        public void SetInput(byte[] buf, int off, int len) { }
        public void SkipToByteBoundary() { }
    }
}
