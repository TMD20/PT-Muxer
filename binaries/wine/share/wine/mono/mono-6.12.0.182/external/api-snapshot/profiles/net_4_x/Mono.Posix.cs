// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Unix Integration Classes")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Posix.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Posix
{
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use Mono.Unix.Native.AccessModes")]
    public enum AccessMode
    {
        F_OK = 8,
        R_OK = 1,
        W_OK = 2,
        X_OK = 4,
    }
    [System.ObsoleteAttribute("Use Mono.Unix.Catalog")]
    public partial class Catalog
    {
        public Catalog() { }
        public static string GetPluralString(string s, string p, int n) { throw null; }
        public static string GetString(string s) { throw null; }
        public static void Init(string package, string localedir) { }
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions")]
    public enum FileMode
    {
        S_IRGRP = 32,
        S_IROTH = 4,
        S_IRUSR = 256,
        S_ISGID = 1024,
        S_ISUID = 2048,
        S_ISVTX = 512,
        S_IWGRP = 16,
        S_IWOTH = 2,
        S_IWUSR = 128,
        S_IXGRP = 8,
        S_IXOTH = 1,
        S_IXUSR = 64,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use Mono.Unix.Native.OpenFlags")]
    public enum OpenFlags
    {
        O_APPEND = 64,
        O_CREAT = 4,
        O_EXCL = 8,
        O_NOCTTY = 16,
        O_NONBLOCK = 128,
        O_RDONLY = 0,
        O_RDWR = 2,
        O_SYNC = 256,
        O_TRUNC = 32,
        O_WRONLY = 1,
    }
    [System.ObsoleteAttribute("Use Mono.Unix.PeerCred")]
    public partial class PeerCred
    {
        public PeerCred(System.Net.Sockets.Socket sock) { }
        public int GroupID { get { throw null; } }
        public int ProcessID { get { throw null; } }
        public int UserID { get { throw null; } }
    }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Signum")]
    public enum Signals
    {
        SIGABRT = 5,
        SIGALRM = 13,
        SIGBUS = 6,
        SIGCHLD = 15,
        SIGCONT = 16,
        SIGFPE = 7,
        SIGHUP = 0,
        SIGILL = 3,
        SIGINT = 1,
        SIGIO = 27,
        SIGKILL = 8,
        SIGPIPE = 12,
        SIGPROF = 25,
        SIGQUIT = 2,
        SIGSEGV = 10,
        SIGSTOP = 17,
        SIGSYS = 28,
        SIGTERM = 14,
        SIGTRAP = 4,
        SIGTSTP = 18,
        SIGTTIN = 19,
        SIGTTOU = 20,
        SIGURG = 21,
        SIGUSR1 = 9,
        SIGUSR2 = 11,
        SIGVTALRM = 24,
        SIGWINCH = 26,
        SIGXCPU = 22,
        SIGXFSZ = 23,
    }
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Stat
    {
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_atime")]
        public readonly System.DateTime ATime;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_blocks")]
        public readonly long Blocks;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_blksize")]
        public readonly long BlockSize;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_ctime")]
        public readonly System.DateTime CTime;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_dev")]
        public readonly int Device;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_rdev")]
        public readonly long DeviceType;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_gid")]
        public readonly int Gid;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_ino")]
        public readonly int INode;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_mode")]
        public readonly Mono.Posix.StatMode Mode;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_mtime")]
        public readonly System.DateTime MTime;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_nlink")]
        public readonly int NLinks;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_size")]
        public readonly long Size;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_uid")]
        public readonly int Uid;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.NativeConvert.LocalUnixEpoch")]
        public static readonly System.DateTime UnixEpoch;
        [System.ObsoleteAttribute("Use Mono.Unix.Native.NativeConvert.ToDateTime")]
        public static System.DateTime UnixToDateTime(long unix) { throw null; }
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions")]
    public enum StatMode
    {
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFBLK")]
        BlockDevice = 24576,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFCHR")]
        CharDevice = 8192,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFDIR")]
        Directory = 16384,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFIFO")]
        FIFO = 4096,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IXGRP")]
        GroupExecute = 8,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IRGRP")]
        GroupRead = 32,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IWGRP")]
        GroupWrite = 16,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IXOTH")]
        OthersExecute = 1,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IROTH")]
        OthersRead = 4,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IWOTH")]
        OthersWrite = 2,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IXUSR")]
        OwnerExecute = 64,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IRUSR")]
        OwnerRead = 256,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IWUSR")]
        OwnerWrite = 128,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFREG")]
        Regular = 32768,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_ISGID")]
        SGid = 1024,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFSOCK")]
        Socket = 49152,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_ISVTX")]
        Sticky = 512,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_ISUID")]
        SUid = 2048,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFLNK")]
        SymLink = 40960,
    }
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions")]
    public enum StatModeMasks
    {
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_RWXG")]
        GroupMask = 56,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_RWXO")]
        OthersMask = 7,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_RWXU")]
        OwnerMask = 448,
        [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFMT")]
        TypeMask = 61440,
    }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Syscall.")]
    public partial class Syscall
    {
        public Syscall() { }
        public static int access(string pathname, Mono.Posix.AccessMode mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint alarm(uint seconds);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int chdir(string path);
        public static int chmod(string path, Mono.Posix.FileMode mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int chown(string path, int owner, int group);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int chroot(string path);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int close(int fileDescriptor);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int closedir(System.IntPtr dir);
        public static int creat(string pathname, Mono.Posix.FileMode flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int dup(int fileDescriptor);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int dup2(int oldFileDescriptor, int newFileDescriptor);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int exit(int status);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fork();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getegid();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int geteuid();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getgid();
        public static string getgroupname(int gid) { throw null; }
        public static string GetHostName() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string gethostname() { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getpgrp();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getpid();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getppid();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getuid();
        public static string getusername(int uid) { throw null; }
        public static bool isatty(int desc) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern void kill(int pid, int sig);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int lchown(string path, int owner, int group);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int link(string oldPath, string newPath);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int lseek(int fileDescriptor, int offset, int whence);
        public static int lstat(string filename, out Mono.Posix.Stat stat) { throw null; }
        public static int mkdir(string pathname, Mono.Posix.FileMode mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int nice(int increment);
        public static int open(string pathname, Mono.Posix.OpenFlags flags) { throw null; }
        public static int open(string pathname, Mono.Posix.OpenFlags flags, Mono.Posix.FileMode mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr opendir(string path);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int pause();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public unsafe static extern System.IntPtr read(int fileDescriptor, void* buf, System.IntPtr count);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern string readdir(System.IntPtr dir);
        public static string readlink(string path) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int rename(string oldPath, string newPath);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int rmdir(string path);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setgid(int gid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setpgid(int pid, int pgid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setregid(int rgid, int egid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setreuid(int ruid, int euid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setsid();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setuid(int uid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int signal(int signum, Mono.Posix.Syscall.sighandler_t handler);
        public static int stat(string filename, out Mono.Posix.Stat stat) { throw null; }
        public static string strerror(int errnum) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int symlink(string oldpath, string newpath);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern void sync();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int umask(int umask);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int unlink(string path);
        public static int waitpid(int pid, Mono.Posix.WaitOptions options) { throw null; }
        public static int waitpid(int pid, out int status, Mono.Posix.WaitOptions options) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int WEXITSTATUS(int status);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int WIFEXITED(int status);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int WIFSIGNALED(int status);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int WIFSTOPPED(int status);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public unsafe static extern System.IntPtr write(int fileDescriptor, void* buf, System.IntPtr count);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int WSTOPSIG(int status);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int WTERMSIG(int status);
        public delegate void sighandler_t(int v);
    }
    [System.ObsoleteAttribute("Use Mono.Unix.UnixEndPoint")]
    [System.SerializableAttribute]
    public partial class UnixEndPoint : System.Net.EndPoint
    {
        public UnixEndPoint(string filename) { }
        public override System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public string Filename { get { throw null; } set { } }
        public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override System.Net.SocketAddress Serialize() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use Mono.Unix.Native.WaitOptions")]
    public enum WaitOptions
    {
        WNOHANG = 0,
        WUNTRACED = 1,
    }
}
namespace Mono.Remoting.Channels.Unix
{
    public partial class UnixChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelSender
    {
        public UnixChannel() { }
        public UnixChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
        public UnixChannel(string path) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { throw null; }
        public string[] GetUrlsForUri(string uri) { throw null; }
        public string Parse(string url, out string objectURI) { throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
    public partial class UnixClientChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender
    {
        public UnixClientChannel() { }
        public UnixClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public UnixClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { throw null; }
        public string Parse(string url, out string objectURI) { throw null; }
    }
    public partial class UnixServerChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver
    {
        public UnixServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
        public UnixServerChannel(string path) { }
        public UnixServerChannel(string name, string path) { }
        public UnixServerChannel(string name, string path, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public string GetChannelUri() { throw null; }
        public string[] GetUrlsForUri(string uri) { throw null; }
        public string Parse(string url, out string objectURI) { throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
}
namespace Mono.Unix
{
    [System.SerializableAttribute]
    public partial class AbstractUnixEndPoint : System.Net.EndPoint
    {
        public AbstractUnixEndPoint(string path) { }
        public override System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public string Path { get { throw null; } set { } }
        public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override System.Net.SocketAddress Serialize() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Catalog
    {
        internal Catalog() { }
        public static string GetPluralString(string s, string p, int n) { throw null; }
        public static string GetString(string s) { throw null; }
        public static void Init(string package, string localedir) { }
    }
    public enum FileAccessPattern
    {
        FlushCache = 4,
        NoReuse = 5,
        Normal = 0,
        PreLoad = 3,
        Random = 1,
        Sequential = 2,
    }
    [System.FlagsAttribute]
    public enum FileAccessPermissions
    {
        AllPermissions = 511,
        DefaultPermissions = 438,
        GroupExecute = 8,
        GroupRead = 32,
        GroupReadWriteExecute = 56,
        GroupWrite = 16,
        OtherExecute = 1,
        OtherRead = 4,
        OtherReadWriteExecute = 7,
        OtherWrite = 2,
        UserExecute = 64,
        UserRead = 256,
        UserReadWriteExecute = 448,
        UserWrite = 128,
    }
    public sealed partial class FileHandleOperations
    {
        internal FileHandleOperations() { }
        public static void AdviseFileAccessPattern(Mono.Unix.UnixStream stream, Mono.Unix.FileAccessPattern pattern) { }
        public static void AdviseFileAccessPattern(Mono.Unix.UnixStream stream, Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
        public static void AdviseFileAccessPattern(int fd, Mono.Unix.FileAccessPattern pattern) { }
        public static void AdviseFileAccessPattern(int fd, Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
        public static void AdviseFileAccessPattern(System.IO.FileStream file, Mono.Unix.FileAccessPattern pattern) { }
        public static void AdviseFileAccessPattern(System.IO.FileStream file, Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
    }
    [System.FlagsAttribute]
    public enum FileSpecialAttributes
    {
        SetGroupId = 1024,
        SetUserId = 2048,
        Sticky = 512,
    }
    public enum FileTypes
    {
        BlockDevice = 24576,
        CharacterDevice = 8192,
        Directory = 16384,
        Fifo = 4096,
        RegularFile = 32768,
        Socket = 49152,
        SymbolicLink = 40960,
    }
    public partial class PeerCred
    {
        public PeerCred(System.Net.Sockets.Socket sock) { }
        public int GroupID { get { throw null; } }
        public int ProcessID { get { throw null; } }
        public int UserID { get { throw null; } }
    }
    public partial class StdioFileStream : System.IO.Stream
    {
        public static readonly System.IntPtr InvalidFileStream;
        public static readonly System.IntPtr StandardError;
        public static readonly System.IntPtr StandardInput;
        public static readonly System.IntPtr StandardOutput;
        public StdioFileStream(System.IntPtr fileStream) { }
        public StdioFileStream(System.IntPtr fileStream, bool ownsHandle) { }
        public StdioFileStream(System.IntPtr fileStream, System.IO.FileAccess access) { }
        public StdioFileStream(System.IntPtr fileStream, System.IO.FileAccess access, bool ownsHandle) { }
        public StdioFileStream(string path) { }
        public StdioFileStream(string path, System.IO.FileAccess access) { }
        public StdioFileStream(string path, System.IO.FileMode mode) { }
        public StdioFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access) { }
        public StdioFileStream(string path, string mode) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Close() { }
        ~StdioFileStream() { }
        public override void Flush() { }
        public override int Read([System.Runtime.InteropServices.In][System.Runtime.InteropServices.Out]byte[] buffer, int offset, int count) { throw null; }
        public void RestoreFilePosition(Mono.Unix.Native.FilePosition pos) { }
        public void Rewind() { }
        public void SaveFilePosition(Mono.Unix.Native.FilePosition pos) { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public partial class UnixClient : System.MarshalByRefObject, System.IDisposable
    {
        public UnixClient() { }
        public UnixClient(Mono.Unix.UnixEndPoint ep) { }
        public UnixClient(string path) { }
        public System.Net.Sockets.Socket Client { get { throw null; } set { } }
        public System.Net.Sockets.LingerOption LingerState { get { throw null; } set { } }
        public Mono.Unix.PeerCred PeerCredential { get { throw null; } }
        public int ReceiveBufferSize { get { throw null; } set { } }
        public int ReceiveTimeout { get { throw null; } set { } }
        public int SendBufferSize { get { throw null; } set { } }
        public int SendTimeout { get { throw null; } set { } }
        public void Close() { }
        public void Connect(Mono.Unix.UnixEndPoint remoteEndPoint) { }
        public void Connect(string path) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~UnixClient() { }
        public System.Net.Sockets.NetworkStream GetStream() { throw null; }
    }
    public sealed partial class UnixDirectoryInfo : Mono.Unix.UnixFileSystemInfo
    {
        public UnixDirectoryInfo(string path) : base (default(string)) { }
        public override string Name { get { throw null; } }
        public Mono.Unix.UnixDirectoryInfo Parent { get { throw null; } }
        public Mono.Unix.UnixDirectoryInfo Root { get { throw null; } }
        public void Create() { }
        public void Create(Mono.Unix.FileAccessPermissions mode) { }
        [System.CLSCompliantAttribute(false)]
        public void Create(Mono.Unix.Native.FilePermissions mode) { }
        public override void Delete() { }
        public void Delete(bool recursive) { }
        public static string GetCurrentDirectory() { throw null; }
        public Mono.Unix.Native.Dirent[] GetEntries() { throw null; }
        public Mono.Unix.Native.Dirent[] GetEntries(string regex) { throw null; }
        public Mono.Unix.Native.Dirent[] GetEntries(System.Text.RegularExpressions.Regex regex) { throw null; }
        public Mono.Unix.UnixFileSystemInfo[] GetFileSystemEntries() { throw null; }
        public Mono.Unix.UnixFileSystemInfo[] GetFileSystemEntries(string regex) { throw null; }
        public Mono.Unix.UnixFileSystemInfo[] GetFileSystemEntries(System.Text.RegularExpressions.Regex regex) { throw null; }
        public static void SetCurrentDirectory(string path) { }
    }
    public sealed partial class UnixDriveInfo
    {
        public UnixDriveInfo(string mountPoint) { }
        public long AvailableFreeSpace { get { throw null; } }
        public string DriveFormat { get { throw null; } }
        public Mono.Unix.UnixDriveType DriveType { get { throw null; } }
        public bool IsReady { get { throw null; } }
        public long MaximumFilenameLength { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.Unix.UnixDirectoryInfo RootDirectory { get { throw null; } }
        public long TotalFreeSpace { get { throw null; } }
        public long TotalSize { get { throw null; } }
        public string VolumeLabel { get { throw null; } }
        public static Mono.Unix.UnixDriveInfo[] GetDrives() { throw null; }
        public static Mono.Unix.UnixDriveInfo GetForSpecialFile(string specialFile) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum UnixDriveType
    {
        CDRom = 5,
        Fixed = 3,
        Network = 4,
        NoRootDirectory = 1,
        Ram = 6,
        Removable = 2,
        Unknown = 0,
    }
    [System.SerializableAttribute]
    public partial class UnixEncoding : System.Text.Encoding
    {
        public static readonly char EscapeByte;
        public static readonly System.Text.Encoding Instance;
        public UnixEncoding() { }
        public override bool Equals(object value) { throw null; }
        public override int GetByteCount(char[] chars, int index, int count) { throw null; }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override byte[] GetBytes(string s) { throw null; }
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override int GetCharCount(byte[] bytes, int index, int count) { throw null; }
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { throw null; }
        public override System.Text.Decoder GetDecoder() { throw null; }
        public override System.Text.Encoder GetEncoder() { throw null; }
        public override int GetHashCode() { throw null; }
        public override int GetMaxByteCount(int charCount) { throw null; }
        public override int GetMaxCharCount(int byteCount) { throw null; }
        public override byte[] GetPreamble() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class UnixEndPoint : System.Net.EndPoint
    {
        public UnixEndPoint(string filename) { }
        public override System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public string Filename { get { throw null; } set { } }
        public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override System.Net.SocketAddress Serialize() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class UnixEnvironment
    {
        internal UnixEnvironment() { }
        public static string CurrentDirectory { get { throw null; } set { } }
        public static Mono.Unix.UnixGroupInfo EffectiveGroup { get { throw null; } set { } }
        public static long EffectiveGroupId { get { throw null; } set { } }
        public static Mono.Unix.UnixUserInfo EffectiveUser { get { throw null; } set { } }
        public static long EffectiveUserId { get { throw null; } set { } }
        public static string Login { get { throw null; } }
        public static string MachineName { get { throw null; } set { } }
        public static Mono.Unix.UnixGroupInfo RealGroup { get { throw null; } }
        public static long RealGroupId { get { throw null; } }
        public static Mono.Unix.UnixUserInfo RealUser { get { throw null; } }
        public static long RealUserId { get { throw null; } }
        public static string UserName { get { throw null; } }
        public static int CreateSession() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string GetConfigurationString(Mono.Unix.Native.ConfstrName name) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static long GetConfigurationValue(Mono.Unix.Native.SysconfName name) { throw null; }
        public static Mono.Unix.UnixProcess GetParentProcess() { throw null; }
        public static int GetParentProcessId() { throw null; }
        public static int GetProcessGroup() { throw null; }
        public static long[] GetSupplementaryGroupIds() { throw null; }
        public static Mono.Unix.UnixGroupInfo[] GetSupplementaryGroups() { throw null; }
        public static string[] GetUserShells() { throw null; }
        public static void SetNiceValue(int inc) { }
        public static void SetProcessGroup() { }
        public static void SetSupplementaryGroupIds(long[] list) { }
        public static void SetSupplementaryGroups(Mono.Unix.UnixGroupInfo[] groups) { }
    }
    public sealed partial class UnixFileInfo : Mono.Unix.UnixFileSystemInfo
    {
        public UnixFileInfo(string path) : base (default(string)) { }
        public Mono.Unix.UnixDirectoryInfo Directory { get { throw null; } }
        public string DirectoryName { get { throw null; } }
        public override string Name { get { throw null; } }
        public Mono.Unix.UnixStream Create() { throw null; }
        public Mono.Unix.UnixStream Create(Mono.Unix.FileAccessPermissions mode) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.UnixStream Create(Mono.Unix.Native.FilePermissions mode) { throw null; }
        public override void Delete() { }
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.UnixStream Open(Mono.Unix.Native.OpenFlags flags) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.UnixStream Open(Mono.Unix.Native.OpenFlags flags, Mono.Unix.Native.FilePermissions mode) { throw null; }
        public Mono.Unix.UnixStream Open(System.IO.FileMode mode) { throw null; }
        public Mono.Unix.UnixStream Open(System.IO.FileMode mode, System.IO.FileAccess access) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.UnixStream Open(System.IO.FileMode mode, System.IO.FileAccess access, Mono.Unix.Native.FilePermissions perms) { throw null; }
        public Mono.Unix.UnixStream OpenRead() { throw null; }
        public Mono.Unix.UnixStream OpenWrite() { throw null; }
    }
    public abstract partial class UnixFileSystemInfo
    {
        protected UnixFileSystemInfo(string path) { }
        public long BlocksAllocated { get { throw null; } }
        public long BlockSize { get { throw null; } }
        public long Device { get { throw null; } }
        public long DeviceType { get { throw null; } }
        public bool Exists { get { throw null; } }
        public Mono.Unix.FileAccessPermissions FileAccessPermissions { get { throw null; } set { } }
        public Mono.Unix.FileSpecialAttributes FileSpecialAttributes { get { throw null; } set { } }
        public Mono.Unix.FileTypes FileType { get { throw null; } }
        public virtual string FullName { get { throw null; } }
        protected string FullPath { get { throw null; } set { } }
        public long Inode { get { throw null; } }
        public bool IsBlockDevice { get { throw null; } }
        public bool IsCharacterDevice { get { throw null; } }
        public bool IsDirectory { get { throw null; } }
        public bool IsFifo { get { throw null; } }
        public bool IsRegularFile { get { throw null; } }
        public bool IsSetGroup { get { throw null; } }
        public bool IsSetUser { get { throw null; } }
        public bool IsSocket { get { throw null; } }
        public bool IsSticky { get { throw null; } }
        public bool IsSymbolicLink { get { throw null; } }
        public System.DateTime LastAccessTime { get { throw null; } }
        public System.DateTime LastAccessTimeUtc { get { throw null; } }
        public System.DateTime LastStatusChangeTime { get { throw null; } }
        public System.DateTime LastStatusChangeTimeUtc { get { throw null; } }
        public System.DateTime LastWriteTime { get { throw null; } }
        public System.DateTime LastWriteTimeUtc { get { throw null; } }
        public long Length { get { throw null; } }
        public long LinkCount { get { throw null; } }
        public abstract string Name { get; }
        protected string OriginalPath { get { throw null; } set { } }
        public Mono.Unix.UnixGroupInfo OwnerGroup { get { throw null; } }
        public long OwnerGroupId { get { throw null; } }
        public Mono.Unix.UnixUserInfo OwnerUser { get { throw null; } }
        public long OwnerUserId { get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.Native.FilePermissions Protection { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        public bool CanAccess(Mono.Unix.Native.AccessModes mode) { throw null; }
        public Mono.Unix.UnixFileSystemInfo CreateLink(string path) { throw null; }
        public Mono.Unix.UnixSymbolicLinkInfo CreateSymbolicLink(string path) { throw null; }
        public abstract void Delete();
        [System.CLSCompliantAttribute(false)]
        public long GetConfigurationValue(Mono.Unix.Native.PathconfName name) { throw null; }
        protected virtual bool GetFileStatus(string path, out Mono.Unix.Native.Stat stat) { throw null; }
        public static Mono.Unix.UnixFileSystemInfo GetFileSystemEntry(string path) { throw null; }
        public void Refresh() { }
        public void SetLength(long length) { }
        public void SetOwner(Mono.Unix.UnixUserInfo owner) { }
        public void SetOwner(Mono.Unix.UnixUserInfo owner, Mono.Unix.UnixGroupInfo group) { }
        public virtual void SetOwner(long owner, long group) { }
        public void SetOwner(string owner) { }
        public void SetOwner(string owner, string group) { }
        public Mono.Unix.Native.Stat ToStat() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryGetFileSystemEntry(string path, out Mono.Unix.UnixFileSystemInfo entry) { throw null; }
    }
    public sealed partial class UnixGroupInfo
    {
        public UnixGroupInfo(Mono.Unix.Native.Group group) { }
        public UnixGroupInfo(long group) { }
        public UnixGroupInfo(string group) { }
        public long GroupId { get { throw null; } }
        public string GroupName { get { throw null; } }
        public string Password { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Mono.Unix.UnixGroupInfo[] GetLocalGroups() { throw null; }
        public string[] GetMemberNames() { throw null; }
        public Mono.Unix.UnixUserInfo[] GetMembers() { throw null; }
        public Mono.Unix.Native.Group ToGroup() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class UnixIOException : System.IO.IOException
    {
        public UnixIOException() { }
        public UnixIOException(Mono.Unix.Native.Errno errno) { }
        public UnixIOException(Mono.Unix.Native.Errno errno, System.Exception inner) { }
        public UnixIOException(int errno) { }
        public UnixIOException(int errno, System.Exception inner) { }
        protected UnixIOException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UnixIOException(string message) { }
        public UnixIOException(string message, System.Exception inner) { }
        public Mono.Unix.Native.Errno ErrorCode { get { throw null; } }
        public int NativeErrorCode { get { throw null; } }
    }
    public partial class UnixListener : System.MarshalByRefObject, System.IDisposable
    {
        public UnixListener(Mono.Unix.UnixEndPoint localEndPoint) { }
        public UnixListener(string path) { }
        public System.Net.EndPoint LocalEndpoint { get { throw null; } }
        protected System.Net.Sockets.Socket Server { get { throw null; } }
        public System.Net.Sockets.Socket AcceptSocket() { throw null; }
        public Mono.Unix.UnixClient AcceptUnixClient() { throw null; }
        public void Dispose() { }
        protected void Dispose(bool disposing) { }
        ~UnixListener() { }
        public bool Pending() { throw null; }
        public void Start() { }
        public void Start(int backlog) { }
        public void Stop() { }
    }
    public sealed partial class UnixMarshal
    {
        internal UnixMarshal() { }
        public static System.IntPtr AllocHeap(long size) { throw null; }
        public static void FreeHeap(System.IntPtr ptr) { }
        [System.CLSCompliantAttribute(false)]
        public static string GetErrorDescription(Mono.Unix.Native.Errno errno) { throw null; }
        public static string PtrToString(System.IntPtr p) { throw null; }
        public static string PtrToString(System.IntPtr p, System.Text.Encoding encoding) { throw null; }
        public static string[] PtrToStringArray(int count, System.IntPtr stringArray) { throw null; }
        public static string[] PtrToStringArray(int count, System.IntPtr stringArray, System.Text.Encoding encoding) { throw null; }
        public static string[] PtrToStringArray(System.IntPtr stringArray) { throw null; }
        public static string[] PtrToStringArray(System.IntPtr stringArray, System.Text.Encoding encoding) { throw null; }
        public static string PtrToStringUnix(System.IntPtr p) { throw null; }
        public static System.IntPtr ReAllocHeap(System.IntPtr ptr, long size) { throw null; }
        public static bool ShouldRetrySyscall(int r) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool ShouldRetrySyscall(int r, out Mono.Unix.Native.Errno errno) { throw null; }
        public static System.IntPtr StringToHeap(string s) { throw null; }
        public static System.IntPtr StringToHeap(string s, int index, int count) { throw null; }
        public static System.IntPtr StringToHeap(string s, int index, int count, System.Text.Encoding encoding) { throw null; }
        public static System.IntPtr StringToHeap(string s, System.Text.Encoding encoding) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void ThrowExceptionForError(Mono.Unix.Native.Errno errno) { }
        [System.CLSCompliantAttribute(false)]
        public static void ThrowExceptionForErrorIf(int retval, Mono.Unix.Native.Errno errno) { }
        public static void ThrowExceptionForLastError() { }
        public static void ThrowExceptionForLastErrorIf(int retval) { }
    }
    public sealed partial class UnixPath
    {
        internal UnixPath() { }
        public static readonly char AltDirectorySeparatorChar;
        public static readonly char DirectorySeparatorChar;
        public static readonly char PathSeparator;
        public static readonly char VolumeSeparatorChar;
        public static string Combine(string path1, params string[] paths) { throw null; }
        public static string GetCanonicalPath(string path) { throw null; }
        public static string GetCompleteRealPath(string path) { throw null; }
        public static string GetDirectoryName(string path) { throw null; }
        public static string GetFileName(string path) { throw null; }
        public static string GetFullPath(string path) { throw null; }
        public static char[] GetInvalidPathChars() { throw null; }
        public static string GetPathRoot(string path) { throw null; }
        public static string GetRealPath(string path) { throw null; }
        public static bool IsPathRooted(string path) { throw null; }
        public static string ReadLink(string path) { throw null; }
        public static string ReadLinkAt(int dirfd, string path) { throw null; }
        public static string TryReadLink(string path) { throw null; }
        public static string TryReadLinkAt(int dirfd, string path) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct UnixPipes : System.IEquatable<Mono.Unix.UnixPipes>
    {
        public Mono.Unix.UnixStream Reading;
        public Mono.Unix.UnixStream Writing;
        public UnixPipes(Mono.Unix.UnixStream reading, Mono.Unix.UnixStream writing) { throw null; }
        public static Mono.Unix.UnixPipes CreatePipes() { throw null; }
        public bool Equals(Mono.Unix.UnixPipes value) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.UnixPipes lhs, Mono.Unix.UnixPipes rhs) { throw null; }
        public static bool operator !=(Mono.Unix.UnixPipes lhs, Mono.Unix.UnixPipes rhs) { throw null; }
    }
    public sealed partial class UnixProcess
    {
        internal UnixProcess() { }
        public int ExitCode { get { throw null; } }
        public bool HasExited { get { throw null; } }
        public bool HasSignaled { get { throw null; } }
        public bool HasStopped { get { throw null; } }
        public int Id { get { throw null; } }
        public int ProcessGroupId { get { throw null; } set { } }
        public int SessionId { get { throw null; } }
        public Mono.Unix.Native.Signum StopSignal { get { throw null; } }
        public Mono.Unix.Native.Signum TerminationSignal { get { throw null; } }
        public static Mono.Unix.UnixProcess GetCurrentProcess() { throw null; }
        public static int GetCurrentProcessId() { throw null; }
        public void Kill() { }
        [System.CLSCompliantAttribute(false)]
        public void Signal(Mono.Unix.Native.Signum signal) { }
        public void WaitForExit() { }
    }
    public partial class UnixSignal : System.Threading.WaitHandle
    {
        public UnixSignal(Mono.Unix.Native.RealTimeSignum rtsig) { }
        public UnixSignal(Mono.Unix.Native.Signum signum) { }
        public int Count { get { throw null; } set { } }
        public bool IsRealTimeSignal { get { throw null; } }
        public bool IsSet { get { throw null; } }
        public Mono.Unix.Native.RealTimeSignum RealTimeSignum { get { throw null; } }
        public Mono.Unix.Native.Signum Signum { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public bool Reset() { throw null; }
        public static int WaitAny(Mono.Unix.UnixSignal[] signals) { throw null; }
        public static int WaitAny(Mono.Unix.UnixSignal[] signals, int millisecondsTimeout) { throw null; }
        public static int WaitAny(Mono.Unix.UnixSignal[] signals, System.TimeSpan timeout) { throw null; }
        public override bool WaitOne() { throw null; }
        public override bool WaitOne(int millisecondsTimeout, bool exitContext) { throw null; }
        public override bool WaitOne(System.TimeSpan timeout, bool exitContext) { throw null; }
    }
    public sealed partial class UnixStream : System.IO.Stream, System.IDisposable
    {
        public const int InvalidFileDescriptor = -1;
        public const int StandardErrorFileDescriptor = 2;
        public const int StandardInputFileDescriptor = 0;
        public const int StandardOutputFileDescriptor = 1;
        public UnixStream(int fileDescriptor) { }
        public UnixStream(int fileDescriptor, bool ownsHandle) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public Mono.Unix.FileAccessPermissions FileAccessPermissions { get { throw null; } set { } }
        public Mono.Unix.FileSpecialAttributes FileSpecialAttributes { get { throw null; } set { } }
        public Mono.Unix.FileTypes FileType { get { throw null; } }
        public int Handle { get { throw null; } }
        public override long Length { get { throw null; } }
        public Mono.Unix.UnixGroupInfo OwnerGroup { get { throw null; } }
        public long OwnerGroupId { get { throw null; } }
        public Mono.Unix.UnixUserInfo OwnerUser { get { throw null; } }
        public long OwnerUserId { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.Native.FilePermissions Protection { get { throw null; } set { } }
        public void AdviseFileAccessPattern(Mono.Unix.FileAccessPattern pattern) { }
        public void AdviseFileAccessPattern(Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
        public override void Close() { }
        ~UnixStream() { }
        public override void Flush() { }
        [System.CLSCompliantAttribute(false)]
        public long GetConfigurationValue(Mono.Unix.Native.PathconfName name) { throw null; }
        public override int Read([System.Runtime.InteropServices.In][System.Runtime.InteropServices.Out]byte[] buffer, int offset, int count) { throw null; }
        public int ReadAtOffset([System.Runtime.InteropServices.In][System.Runtime.InteropServices.Out]byte[] buffer, int offset, int count, long fileOffset) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public void SendTo(Mono.Unix.UnixStream output) { }
        [System.CLSCompliantAttribute(false)]
        public void SendTo(Mono.Unix.UnixStream output, ulong count) { }
        [System.CLSCompliantAttribute(false)]
        public void SendTo(int out_fd, ulong count) { }
        public override void SetLength(long value) { }
        public void SetOwner(long user, long group) { }
        public void SetOwner(string user) { }
        public void SetOwner(string user, string group) { }
        void System.IDisposable.Dispose() { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public void WriteAtOffset(byte[] buffer, int offset, int count, long fileOffset) { }
    }
    public sealed partial class UnixSymbolicLinkInfo : Mono.Unix.UnixFileSystemInfo
    {
        public UnixSymbolicLinkInfo(string path) : base (default(string)) { }
        [System.ObsoleteAttribute("Use GetContents()")]
        public Mono.Unix.UnixFileSystemInfo Contents { get { throw null; } }
        public string ContentsPath { get { throw null; } }
        public bool HasContents { get { throw null; } }
        public override string Name { get { throw null; } }
        public void CreateSymbolicLinkTo(Mono.Unix.UnixFileSystemInfo path) { }
        public void CreateSymbolicLinkTo(string path) { }
        public override void Delete() { }
        public Mono.Unix.UnixFileSystemInfo GetContents() { throw null; }
        protected override bool GetFileStatus(string path, out Mono.Unix.Native.Stat stat) { throw null; }
        public override void SetOwner(long owner, long group) { }
    }
    public sealed partial class UnixUserInfo
    {
        public UnixUserInfo(Mono.Unix.Native.Passwd passwd) { }
        public UnixUserInfo(long user) { }
        public UnixUserInfo(string user) { }
        [System.CLSCompliantAttribute(false)]
        public UnixUserInfo(uint user) { }
        public Mono.Unix.UnixGroupInfo Group { get { throw null; } }
        public long GroupId { get { throw null; } }
        public string GroupName { get { throw null; } }
        public string HomeDirectory { get { throw null; } }
        public string Password { get { throw null; } }
        public string RealName { get { throw null; } }
        public string ShellProgram { get { throw null; } }
        public long UserId { get { throw null; } }
        public string UserName { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Mono.Unix.UnixUserInfo[] GetLocalUsers() { throw null; }
        public static string GetLoginName() { throw null; }
        public static Mono.Unix.UnixUserInfo GetRealUser() { throw null; }
        public static long GetRealUserId() { throw null; }
        public Mono.Unix.Native.Passwd ToPasswd() { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace Mono.Unix.Native
{
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum AccessModes
    {
        F_OK = 8,
        R_OK = 1,
        W_OK = 2,
        X_OK = 4,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum AtFlags
    {
        AT_EMPTY_PATH = 4096,
        AT_NO_AUTOMOUNT = 2048,
        AT_REMOVEDIR = 512,
        AT_SYMLINK_FOLLOW = 1024,
        AT_SYMLINK_NOFOLLOW = 256,
    }
    public sealed partial class CdeclFunction
    {
        public CdeclFunction(string library, string method) { }
        public CdeclFunction(string library, string method, System.Type returnType) { }
        public object Invoke(object[] parameters) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Cmsghdr
    {
        public long cmsg_len;
        public Mono.Unix.Native.UnixSocketProtocol cmsg_level;
        public Mono.Unix.Native.UnixSocketControlMessage cmsg_type;
        public static int Size { get { throw null; } }
        public static Mono.Unix.Native.Cmsghdr ReadFromBuffer(Mono.Unix.Native.Msghdr msgh, long cmsg) { throw null; }
        public void WriteToBuffer(Mono.Unix.Native.Msghdr msgh, long cmsg) { }
    }
    [System.CLSCompliantAttribute(false)]
    public enum ConfstrName
    {
        _CS_GNU_LIBC_VERSION = 2,
        _CS_GNU_LIBPTHREAD_VERSION = 3,
        _CS_LFS64_CFLAGS = 1004,
        _CS_LFS64_LDFLAGS = 1005,
        _CS_LFS64_LIBS = 1006,
        _CS_LFS64_LINTFLAGS = 1007,
        _CS_LFS_CFLAGS = 1000,
        _CS_LFS_LDFLAGS = 1001,
        _CS_LFS_LIBS = 1002,
        _CS_LFS_LINTFLAGS = 1003,
        _CS_PATH = 0,
        _CS_POSIX_V6_ILP32_OFF32_CFLAGS = 1116,
        _CS_POSIX_V6_ILP32_OFF32_LDFLAGS = 1117,
        _CS_POSIX_V6_ILP32_OFF32_LIBS = 1118,
        _CS_POSIX_V6_ILP32_OFF32_LINTFLAGS = 1119,
        _CS_POSIX_V6_ILP32_OFFBIG_CFLAGS = 1120,
        _CS_POSIX_V6_ILP32_OFFBIG_LDFLAGS = 1121,
        _CS_POSIX_V6_ILP32_OFFBIG_LIBS = 1122,
        _CS_POSIX_V6_ILP32_OFFBIG_LINTFLAGS = 1123,
        _CS_POSIX_V6_LP64_OFF64_CFLAGS = 1124,
        _CS_POSIX_V6_LP64_OFF64_LDFLAGS = 1125,
        _CS_POSIX_V6_LP64_OFF64_LIBS = 1126,
        _CS_POSIX_V6_LP64_OFF64_LINTFLAGS = 1127,
        _CS_POSIX_V6_LPBIG_OFFBIG_CFLAGS = 1128,
        _CS_POSIX_V6_LPBIG_OFFBIG_LDFLAGS = 1129,
        _CS_POSIX_V6_LPBIG_OFFBIG_LIBS = 1130,
        _CS_POSIX_V6_LPBIG_OFFBIG_LINTFLAGS = 1131,
        _CS_V6_WIDTH_RESTRICTED_ENVS = 1,
        _CS_XBS5_ILP32_OFF32_CFLAGS = 1100,
        _CS_XBS5_ILP32_OFF32_LDFLAGS = 1101,
        _CS_XBS5_ILP32_OFF32_LIBS = 1102,
        _CS_XBS5_ILP32_OFF32_LINTFLAGS = 1103,
        _CS_XBS5_ILP32_OFFBIG_CFLAGS = 1104,
        _CS_XBS5_ILP32_OFFBIG_LDFLAGS = 1105,
        _CS_XBS5_ILP32_OFFBIG_LIBS = 1106,
        _CS_XBS5_ILP32_OFFBIG_LINTFLAGS = 1107,
        _CS_XBS5_LP64_OFF64_CFLAGS = 1108,
        _CS_XBS5_LP64_OFF64_LDFLAGS = 1109,
        _CS_XBS5_LP64_OFF64_LIBS = 1110,
        _CS_XBS5_LP64_OFF64_LINTFLAGS = 1111,
        _CS_XBS5_LPBIG_OFFBIG_CFLAGS = 1112,
        _CS_XBS5_LPBIG_OFFBIG_LDFLAGS = 1113,
        _CS_XBS5_LPBIG_OFFBIG_LIBS = 1114,
        _CS_XBS5_LPBIG_OFFBIG_LINTFLAGS = 1115,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum DirectoryNotifyFlags
    {
        DN_ACCESS = 1,
        DN_ATTRIB = 32,
        DN_CREATE = 4,
        DN_DELETE = 8,
        DN_MODIFY = 2,
        DN_MULTISHOT = -2147483648,
        DN_RENAME = 16,
    }
    public sealed partial class Dirent : System.IEquatable<Mono.Unix.Native.Dirent>
    {
        [System.CLSCompliantAttribute(false)]
        public ulong d_ino;
        public string d_name;
        public long d_off;
        [System.CLSCompliantAttribute(false)]
        public ushort d_reclen;
        public byte d_type;
        public Dirent() { }
        public bool Equals(Mono.Unix.Native.Dirent value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Dirent lhs, Mono.Unix.Native.Dirent rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Dirent lhs, Mono.Unix.Native.Dirent rhs) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=12, Pack=1)]
    public partial struct EpollEvent
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Mono.Unix.Native.EpollEvents events;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public int fd;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public System.IntPtr ptr;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public uint u32;
        [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
        public ulong u64;
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum EpollEvents : uint
    {
        EPOLLERR = (uint)8,
        EPOLLET = (uint)2147483648,
        EPOLLHUP = (uint)16,
        EPOLLIN = (uint)1,
        EPOLLMSG = (uint)1024,
        EPOLLONESHOT = (uint)1073741824,
        EPOLLOUT = (uint)4,
        EPOLLPRI = (uint)2,
        EPOLLRDBAND = (uint)128,
        EPOLLRDHUP = (uint)8192,
        EPOLLRDNORM = (uint)64,
        EPOLLWRBAND = (uint)512,
        EPOLLWRNORM = (uint)256,
    }
    [System.FlagsAttribute]
    public enum EpollFlags
    {
        EPOLL_CLOEXEC = 2000000,
        EPOLL_NONBLOCK = 4000,
    }
    public enum EpollOp
    {
        EPOLL_CTL_ADD = 1,
        EPOLL_CTL_DEL = 2,
        EPOLL_CTL_MOD = 3,
    }
    public enum Errno
    {
        E2BIG = 7,
        EACCES = 13,
        EADDRINUSE = 98,
        EADDRNOTAVAIL = 99,
        EADV = 68,
        EAFNOSUPPORT = 97,
        EAGAIN = 11,
        EALREADY = 114,
        EAUTH = 1080,
        EBADARCH = 1086,
        EBADE = 52,
        EBADEXEC = 1085,
        EBADF = 9,
        EBADFD = 77,
        EBADMACHO = 1088,
        EBADMSG = 74,
        EBADR = 53,
        EBADRPC = 1072,
        EBADRQC = 56,
        EBADSLT = 57,
        EBFONT = 59,
        EBUSY = 16,
        ECANCELED = 125,
        ECHILD = 10,
        ECHRNG = 44,
        ECOMM = 70,
        ECONNABORTED = 103,
        ECONNREFUSED = 111,
        ECONNRESET = 104,
        EDEADLK = 35,
        EDEADLOCK = 35,
        EDESTADDRREQ = 89,
        EDEVERR = 1083,
        EDOM = 33,
        EDOTDOT = 73,
        EDQUOT = 122,
        EEXIST = 17,
        EFAULT = 14,
        EFBIG = 27,
        EFTYPE = 1079,
        EHOSTDOWN = 112,
        EHOSTUNREACH = 113,
        EIDRM = 43,
        EILSEQ = 84,
        EINPROGRESS = 115,
        EINTR = 4,
        EINVAL = 22,
        EIO = 5,
        EISCONN = 106,
        EISDIR = 21,
        EISNAM = 120,
        EKEYEXPIRED = 127,
        EKEYREJECTED = 129,
        EKEYREVOKED = 128,
        EL2HLT = 51,
        EL2NSYNC = 45,
        EL3HLT = 46,
        EL3RST = 47,
        ELIBACC = 79,
        ELIBBAD = 80,
        ELIBEXEC = 83,
        ELIBMAX = 82,
        ELIBSCN = 81,
        ELNRNG = 48,
        ELOOP = 40,
        EMEDIUMTYPE = 124,
        EMFILE = 24,
        EMLINK = 31,
        EMSGSIZE = 90,
        EMULTIHOP = 72,
        ENAMETOOLONG = 36,
        ENAVAIL = 119,
        ENEEDAUTH = 1081,
        ENETDOWN = 100,
        ENETRESET = 102,
        ENETUNREACH = 101,
        ENFILE = 23,
        ENOANO = 55,
        ENOATTR = 1093,
        ENOBUFS = 105,
        ENOCSI = 50,
        ENODATA = 61,
        ENODEV = 19,
        ENOENT = 2,
        ENOEXEC = 8,
        ENOKEY = 126,
        ENOLCK = 37,
        ENOLINK = 67,
        ENOMEDIUM = 123,
        ENOMEM = 12,
        ENOMSG = 42,
        ENONET = 64,
        ENOPKG = 65,
        ENOPOLICY = 1103,
        ENOPROTOOPT = 92,
        ENOSPC = 28,
        ENOSR = 63,
        ENOSTR = 60,
        ENOSYS = 38,
        ENOTBLK = 15,
        ENOTCONN = 107,
        ENOTDIR = 20,
        ENOTEMPTY = 39,
        ENOTNAM = 118,
        ENOTRECOVERABLE = 131,
        ENOTSOCK = 88,
        ENOTTY = 25,
        ENOTUNIQ = 76,
        ENXIO = 6,
        EOPNOTSUPP = 95,
        EOVERFLOW = 75,
        EOWNERDEAD = 130,
        EPERM = 1,
        EPFNOSUPPORT = 96,
        EPIPE = 32,
        EPROCLIM = 1067,
        EPROCUNAVAIL = 1076,
        EPROGMISMATCH = 1075,
        EPROGUNAVAIL = 1074,
        EPROTO = 71,
        EPROTONOSUPPORT = 93,
        EPROTOTYPE = 91,
        EPWROFF = 1082,
        ERANGE = 34,
        EREMCHG = 78,
        EREMOTE = 66,
        EREMOTEIO = 121,
        ERESTART = 85,
        EROFS = 30,
        ERPCMISMATCH = 1073,
        ESHLIBVERS = 1087,
        ESHUTDOWN = 108,
        ESOCKTNOSUPPORT = 94,
        ESPIPE = 29,
        ESRCH = 3,
        ESRMNT = 69,
        ESTALE = 116,
        ESTRPIPE = 86,
        ETIME = 62,
        ETIMEDOUT = 110,
        ETOOMANYREFS = 109,
        ETXTBSY = 26,
        EUCLEAN = 117,
        EUNATCH = 49,
        EUSERS = 87,
        EWOULDBLOCK = 11,
        EXDEV = 18,
        EXFULL = 54,
    }
    [System.CLSCompliantAttribute(false)]
    public enum FcntlCommand
    {
        F_ADD_SEALS = 1033,
        F_DUPFD = 0,
        F_GETFD = 1,
        F_GETFL = 3,
        F_GETLEASE = 1025,
        F_GETLK = 12,
        F_GETOWN = 9,
        F_GETSIG = 11,
        F_GET_SEALS = 1034,
        F_NOCACHE = 48,
        F_NOTIFY = 1026,
        F_OFD_GETLK = 36,
        F_OFD_SETLK = 37,
        F_OFD_SETLKW = 38,
        F_SETFD = 2,
        F_SETFL = 4,
        F_SETLEASE = 1024,
        F_SETLK = 13,
        F_SETLKW = 14,
        F_SETOWN = 8,
        F_SETSIG = 10,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum FilePermissions : uint
    {
        ACCESSPERMS = (uint)511,
        ALLPERMS = (uint)4095,
        DEFFILEMODE = (uint)438,
        S_IFBLK = (uint)24576,
        S_IFCHR = (uint)8192,
        S_IFDIR = (uint)16384,
        S_IFIFO = (uint)4096,
        S_IFLNK = (uint)40960,
        S_IFMT = (uint)61440,
        S_IFREG = (uint)32768,
        S_IFSOCK = (uint)49152,
        S_IRGRP = (uint)32,
        S_IROTH = (uint)4,
        S_IRUSR = (uint)256,
        S_IRWXG = (uint)56,
        S_IRWXO = (uint)7,
        S_IRWXU = (uint)448,
        S_ISGID = (uint)1024,
        S_ISUID = (uint)2048,
        S_ISVTX = (uint)512,
        S_IWGRP = (uint)16,
        S_IWOTH = (uint)2,
        S_IWUSR = (uint)128,
        S_IXGRP = (uint)8,
        S_IXOTH = (uint)1,
        S_IXUSR = (uint)64,
    }
    public sealed partial class FilePosition : System.MarshalByRefObject, System.IDisposable, System.IEquatable<Mono.Unix.Native.FilePosition>
    {
        public FilePosition() { }
        public void Dispose() { }
        public bool Equals(Mono.Unix.Native.FilePosition value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        ~FilePosition() { }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.FilePosition lhs, Mono.Unix.Native.FilePosition rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.FilePosition lhs, Mono.Unix.Native.FilePosition rhs) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Flock : System.IEquatable<Mono.Unix.Native.Flock>
    {
        public long l_len;
        public int l_pid;
        public long l_start;
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.Native.LockType l_type;
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.Native.SeekFlags l_whence;
        public bool Equals(Mono.Unix.Native.Flock value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Flock lhs, Mono.Unix.Native.Flock rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Flock lhs, Mono.Unix.Native.Flock rhs) { throw null; }
    }
    public sealed partial class Fstab : System.IEquatable<Mono.Unix.Native.Fstab>
    {
        public string fs_file;
        public int fs_freq;
        public string fs_mntops;
        public int fs_passno;
        public string fs_spec;
        public string fs_type;
        public string fs_vfstype;
        public Fstab() { }
        public bool Equals(Mono.Unix.Native.Fstab value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Fstab lhs, Mono.Unix.Native.Fstab rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Fstab lhs, Mono.Unix.Native.Fstab rhs) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class Group : System.IEquatable<Mono.Unix.Native.Group>
    {
        [System.CLSCompliantAttribute(false)]
        public uint gr_gid;
        public string[] gr_mem;
        public string gr_name;
        public string gr_passwd;
        public Group() { }
        public bool Equals(Mono.Unix.Native.Group value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Group lhs, Mono.Unix.Native.Group rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Group lhs, Mono.Unix.Native.Group rhs) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct In6Addr : System.IEquatable<Mono.Unix.Native.In6Addr>
    {
        private int _dummyPrimitive;
        public In6Addr(byte[] buffer) { throw null; }
        public byte this[int index] { get { throw null; } set { } }
        public void CopyFrom(byte[] source, int startIndex) { }
        public void CopyTo(byte[] destination, int startIndex) { }
        public bool Equals(Mono.Unix.Native.In6Addr value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct InAddr : System.IEquatable<Mono.Unix.Native.InAddr>
    {
        public uint s_addr;
        public InAddr(byte b0, byte b1, byte b2, byte b3) { throw null; }
        public InAddr(byte[] buffer) { throw null; }
        public byte this[int index] { get { throw null; } set { } }
        public void CopyFrom(byte[] source, int startIndex) { }
        public void CopyTo(byte[] destination, int startIndex) { }
        public bool Equals(Mono.Unix.Native.InAddr value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Iovec
    {
        public System.IntPtr iov_base;
        [System.CLSCompliantAttribute(false)]
        public ulong iov_len;
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Linger
    {
        public int l_linger;
        public int l_onoff;
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public enum LockfCommand
    {
        F_LOCK = 1,
        F_TEST = 3,
        F_TLOCK = 2,
        F_ULOCK = 0,
    }
    [System.CLSCompliantAttribute(false)]
    public enum LockType : short
    {
        F_RDLCK = (short)0,
        F_UNLCK = (short)2,
        F_WRLCK = (short)1,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MemfdFlags : uint
    {
        MFD_ALLOW_SEALING = (uint)2,
        MFD_CLOEXEC = (uint)1,
        MFD_HUGETLB = (uint)4,
        MFD_HUGE_16GB = (uint)2281701376,
        MFD_HUGE_16MB = (uint)1610612736,
        MFD_HUGE_1GB = (uint)2013265920,
        MFD_HUGE_1MB = (uint)1342177280,
        MFD_HUGE_256MB = (uint)1879048192,
        MFD_HUGE_2GB = (uint)2080374784,
        MFD_HUGE_2MB = (uint)1409286144,
        MFD_HUGE_32MB = (uint)1677721600,
        MFD_HUGE_512KB = (uint)1275068416,
        MFD_HUGE_512MB = (uint)1946157056,
        MFD_HUGE_64KB = (uint)1073741824,
        MFD_HUGE_8MB = (uint)1543503872,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MessageFlags
    {
        MSG_CMSG_CLOEXEC = 1073741824,
        MSG_CONFIRM = 2048,
        MSG_CTRUNC = 8,
        MSG_DONTROUTE = 4,
        MSG_DONTWAIT = 64,
        MSG_EOR = 128,
        MSG_ERRQUEUE = 8192,
        MSG_FASTOPEN = 536870912,
        MSG_FIN = 512,
        MSG_MORE = 32768,
        MSG_NOSIGNAL = 16384,
        MSG_OOB = 1,
        MSG_PEEK = 2,
        MSG_PROXY = 16,
        MSG_RST = 4096,
        MSG_SYN = 1024,
        MSG_TRUNC = 32,
        MSG_WAITALL = 256,
        MSG_WAITFORONE = 65536,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MlockallFlags
    {
        MCL_CURRENT = 1,
        MCL_FUTURE = 2,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MmapFlags
    {
        MAP_ANON = 32,
        MAP_ANONYMOUS = 32,
        MAP_DENYWRITE = 2048,
        MAP_EXECUTABLE = 4096,
        MAP_FILE = 0,
        MAP_FIXED = 16,
        MAP_GROWSDOWN = 256,
        MAP_LOCKED = 8192,
        MAP_NONBLOCK = 65536,
        MAP_NORESERVE = 16384,
        MAP_POPULATE = 32768,
        MAP_PRIVATE = 2,
        MAP_SHARED = 1,
        MAP_TYPE = 15,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MmapProts
    {
        PROT_EXEC = 4,
        PROT_GROWSDOWN = 16777216,
        PROT_GROWSUP = 33554432,
        PROT_NONE = 0,
        PROT_READ = 1,
        PROT_WRITE = 2,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MountFlags : ulong
    {
        ST_APPEND = (ulong)256,
        ST_BIND = (ulong)4096,
        ST_IMMUTABLE = (ulong)512,
        ST_MANDLOCK = (ulong)64,
        ST_NOATIME = (ulong)1024,
        ST_NODEV = (ulong)4,
        ST_NODIRATIME = (ulong)2048,
        ST_NOEXEC = (ulong)8,
        ST_NOSUID = (ulong)2,
        ST_RDONLY = (ulong)1,
        ST_REMOUNT = (ulong)32,
        ST_SYNCHRONOUS = (ulong)16,
        ST_WRITE = (ulong)128,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MremapFlags : ulong
    {
        MREMAP_MAYMOVE = (ulong)1,
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class Msghdr
    {
        public byte[] msg_control;
        public long msg_controllen;
        public Mono.Unix.Native.MessageFlags msg_flags;
        public Mono.Unix.Native.Iovec[] msg_iov;
        public int msg_iovlen;
        public Mono.Unix.Native.Sockaddr msg_name;
        public Msghdr() { }
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum MsyncFlags
    {
        MS_ASYNC = 1,
        MS_INVALIDATE = 2,
        MS_SYNC = 4,
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class NativeConvert
    {
        internal NativeConvert() { }
        public static readonly System.DateTime LocalUnixEpoch;
        public static readonly System.TimeSpan LocalUtcOffset;
        public static readonly System.DateTime UnixEpoch;
        public static int FromAccessModes(Mono.Unix.Native.AccessModes value) { throw null; }
        public static int FromAtFlags(Mono.Unix.Native.AtFlags value) { throw null; }
        public static int FromConfstrName(Mono.Unix.Native.ConfstrName value) { throw null; }
        public static long FromDateTime(System.DateTime time) { throw null; }
        public static int FromDirectoryNotifyFlags(Mono.Unix.Native.DirectoryNotifyFlags value) { throw null; }
        public static uint FromEpollEvents(Mono.Unix.Native.EpollEvents value) { throw null; }
        public static int FromEpollFlags(Mono.Unix.Native.EpollFlags value) { throw null; }
        public static int FromErrno(Mono.Unix.Native.Errno value) { throw null; }
        public static int FromFcntlCommand(Mono.Unix.Native.FcntlCommand value) { throw null; }
        public static uint FromFilePermissions(Mono.Unix.Native.FilePermissions value) { throw null; }
        public static int FromLockfCommand(Mono.Unix.Native.LockfCommand value) { throw null; }
        public static short FromLockType(Mono.Unix.Native.LockType value) { throw null; }
        public static uint FromMemfdFlags(Mono.Unix.Native.MemfdFlags value) { throw null; }
        public static int FromMessageFlags(Mono.Unix.Native.MessageFlags value) { throw null; }
        public static int FromMlockallFlags(Mono.Unix.Native.MlockallFlags value) { throw null; }
        public static int FromMmapFlags(Mono.Unix.Native.MmapFlags value) { throw null; }
        public static int FromMmapProts(Mono.Unix.Native.MmapProts value) { throw null; }
        public static ulong FromMountFlags(Mono.Unix.Native.MountFlags value) { throw null; }
        public static ulong FromMremapFlags(Mono.Unix.Native.MremapFlags value) { throw null; }
        public static int FromMsyncFlags(Mono.Unix.Native.MsyncFlags value) { throw null; }
        public static Mono.Unix.Native.FilePermissions FromOctalPermissionString(string value) { throw null; }
        public static int FromOpenFlags(Mono.Unix.Native.OpenFlags value) { throw null; }
        public static int FromPathconfName(Mono.Unix.Native.PathconfName value) { throw null; }
        public static short FromPollEvents(Mono.Unix.Native.PollEvents value) { throw null; }
        public static int FromPosixFadviseAdvice(Mono.Unix.Native.PosixFadviseAdvice value) { throw null; }
        public static int FromPosixMadviseAdvice(Mono.Unix.Native.PosixMadviseAdvice value) { throw null; }
        public static int FromRealTimeSignum(Mono.Unix.Native.RealTimeSignum sig) { throw null; }
        public static int FromSealType(Mono.Unix.Native.SealType value) { throw null; }
        public static short FromSeekFlags(Mono.Unix.Native.SeekFlags value) { throw null; }
        public static int FromShutdownOption(Mono.Unix.Native.ShutdownOption value) { throw null; }
        public static int FromSignum(Mono.Unix.Native.Signum value) { throw null; }
        public static int FromSysconfName(Mono.Unix.Native.SysconfName value) { throw null; }
        public static int FromSyslogFacility(Mono.Unix.Native.SyslogFacility value) { throw null; }
        public static int FromSyslogLevel(Mono.Unix.Native.SyslogLevel value) { throw null; }
        public static int FromSyslogOptions(Mono.Unix.Native.SyslogOptions value) { throw null; }
        public static System.DateTime FromTimeT(long time) { throw null; }
        public static int FromUnixAddressFamily(Mono.Unix.Native.UnixAddressFamily value) { throw null; }
        public static Mono.Unix.Native.FilePermissions FromUnixPermissionString(string value) { throw null; }
        public static int FromUnixSocketControlMessage(Mono.Unix.Native.UnixSocketControlMessage value) { throw null; }
        public static int FromUnixSocketFlags(Mono.Unix.Native.UnixSocketFlags value) { throw null; }
        public static int FromUnixSocketOptionName(Mono.Unix.Native.UnixSocketOptionName value) { throw null; }
        public static int FromUnixSocketProtocol(Mono.Unix.Native.UnixSocketProtocol value) { throw null; }
        public static int FromUnixSocketType(Mono.Unix.Native.UnixSocketType value) { throw null; }
        public static int FromWaitOptions(Mono.Unix.Native.WaitOptions value) { throw null; }
        public static int FromXattrFlags(Mono.Unix.Native.XattrFlags value) { throw null; }
        public static Mono.Unix.Native.AccessModes ToAccessModes(int value) { throw null; }
        public static Mono.Unix.Native.AtFlags ToAtFlags(int value) { throw null; }
        public static Mono.Unix.Native.ConfstrName ToConfstrName(int value) { throw null; }
        public static System.DateTime ToDateTime(long time) { throw null; }
        public static System.DateTime ToDateTime(long time, long nanoTime) { throw null; }
        public static Mono.Unix.Native.DirectoryNotifyFlags ToDirectoryNotifyFlags(int value) { throw null; }
        public static Mono.Unix.Native.EpollEvents ToEpollEvents(uint value) { throw null; }
        public static Mono.Unix.Native.EpollFlags ToEpollFlags(int value) { throw null; }
        public static Mono.Unix.Native.Errno ToErrno(int value) { throw null; }
        public static Mono.Unix.Native.FcntlCommand ToFcntlCommand(int value) { throw null; }
        public static Mono.Unix.Native.FilePermissions ToFilePermissions(uint value) { throw null; }
        public static string ToFopenMode(System.IO.FileAccess access) { throw null; }
        public static string ToFopenMode(System.IO.FileMode mode) { throw null; }
        public static string ToFopenMode(System.IO.FileMode mode, System.IO.FileAccess access) { throw null; }
        public static Mono.Unix.Native.In6Addr ToIn6Addr(System.Net.IPAddress address) { throw null; }
        public static Mono.Unix.Native.InAddr ToInAddr(System.Net.IPAddress address) { throw null; }
        public static System.Net.IPAddress ToIPAddress(Mono.Unix.Native.In6Addr address) { throw null; }
        public static System.Net.IPAddress ToIPAddress(Mono.Unix.Native.InAddr address) { throw null; }
        public static Mono.Unix.Native.LockfCommand ToLockfCommand(int value) { throw null; }
        public static Mono.Unix.Native.LockType ToLockType(short value) { throw null; }
        public static Mono.Unix.Native.MemfdFlags ToMemfdFlags(uint value) { throw null; }
        public static Mono.Unix.Native.MessageFlags ToMessageFlags(int value) { throw null; }
        public static Mono.Unix.Native.MlockallFlags ToMlockallFlags(int value) { throw null; }
        public static Mono.Unix.Native.MmapFlags ToMmapFlags(int value) { throw null; }
        public static Mono.Unix.Native.MmapProts ToMmapProts(int value) { throw null; }
        public static Mono.Unix.Native.MountFlags ToMountFlags(ulong value) { throw null; }
        public static Mono.Unix.Native.MremapFlags ToMremapFlags(ulong value) { throw null; }
        public static Mono.Unix.Native.MsyncFlags ToMsyncFlags(int value) { throw null; }
        public static string ToOctalPermissionString(Mono.Unix.Native.FilePermissions value) { throw null; }
        public static Mono.Unix.Native.OpenFlags ToOpenFlags(int value) { throw null; }
        public static Mono.Unix.Native.OpenFlags ToOpenFlags(System.IO.FileMode mode, System.IO.FileAccess access) { throw null; }
        public static Mono.Unix.Native.PathconfName ToPathconfName(int value) { throw null; }
        public static Mono.Unix.Native.PollEvents ToPollEvents(short value) { throw null; }
        public static Mono.Unix.Native.PosixFadviseAdvice ToPosixFadviseAdvice(int value) { throw null; }
        public static Mono.Unix.Native.PosixMadviseAdvice ToPosixMadviseAdvice(int value) { throw null; }
        public static Mono.Unix.Native.RealTimeSignum ToRealTimeSignum(int offset) { throw null; }
        public static Mono.Unix.Native.SealType ToSealType(int value) { throw null; }
        public static Mono.Unix.Native.SeekFlags ToSeekFlags(short value) { throw null; }
        public static Mono.Unix.Native.ShutdownOption ToShutdownOption(int value) { throw null; }
        public static Mono.Unix.Native.Signum ToSignum(int value) { throw null; }
        public static Mono.Unix.Native.SysconfName ToSysconfName(int value) { throw null; }
        public static Mono.Unix.Native.SyslogFacility ToSyslogFacility(int value) { throw null; }
        public static Mono.Unix.Native.SyslogLevel ToSyslogLevel(int value) { throw null; }
        public static Mono.Unix.Native.SyslogOptions ToSyslogOptions(int value) { throw null; }
        public static long ToTimeT(System.DateTime time) { throw null; }
        public static Mono.Unix.Native.UnixAddressFamily ToUnixAddressFamily(int value) { throw null; }
        public static string ToUnixPermissionString(Mono.Unix.Native.FilePermissions value) { throw null; }
        public static Mono.Unix.Native.UnixSocketControlMessage ToUnixSocketControlMessage(int value) { throw null; }
        public static Mono.Unix.Native.UnixSocketFlags ToUnixSocketFlags(int value) { throw null; }
        public static Mono.Unix.Native.UnixSocketOptionName ToUnixSocketOptionName(int value) { throw null; }
        public static Mono.Unix.Native.UnixSocketProtocol ToUnixSocketProtocol(int value) { throw null; }
        public static Mono.Unix.Native.UnixSocketType ToUnixSocketType(int value) { throw null; }
        public static Mono.Unix.Native.WaitOptions ToWaitOptions(int value) { throw null; }
        public static Mono.Unix.Native.XattrFlags ToXattrFlags(int value) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Cmsghdr source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Flock source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.In6Addr source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.InAddr source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Iovec source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Linger source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Pollfd source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(Mono.Unix.Native.Sockaddr source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(Mono.Unix.Native.SockaddrIn source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(Mono.Unix.Native.SockaddrIn6 source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Stat source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Statvfs source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Timespec source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Timeval source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Timezone source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(ref Mono.Unix.Native.Utimbuf source, System.IntPtr destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Cmsghdr destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Flock destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.In6Addr destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.InAddr destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Iovec destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Linger destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Pollfd destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, Mono.Unix.Native.SockaddrIn destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, Mono.Unix.Native.SockaddrIn6 destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Stat destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Statvfs destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Timespec destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Timeval destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Timezone destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Utimbuf destination) { throw null; }
        public static bool TryCopy(System.IntPtr source, long size, Mono.Unix.Native.Sockaddr destination) { throw null; }
        public static bool TryFromAccessModes(Mono.Unix.Native.AccessModes value, out int rval) { throw null; }
        public static bool TryFromAtFlags(Mono.Unix.Native.AtFlags value, out int rval) { throw null; }
        public static bool TryFromConfstrName(Mono.Unix.Native.ConfstrName value, out int rval) { throw null; }
        public static bool TryFromDirectoryNotifyFlags(Mono.Unix.Native.DirectoryNotifyFlags value, out int rval) { throw null; }
        public static bool TryFromEpollEvents(Mono.Unix.Native.EpollEvents value, out uint rval) { throw null; }
        public static bool TryFromEpollFlags(Mono.Unix.Native.EpollFlags value, out int rval) { throw null; }
        public static bool TryFromErrno(Mono.Unix.Native.Errno value, out int rval) { throw null; }
        public static bool TryFromFcntlCommand(Mono.Unix.Native.FcntlCommand value, out int rval) { throw null; }
        public static bool TryFromFilePermissions(Mono.Unix.Native.FilePermissions value, out uint rval) { throw null; }
        public static bool TryFromLockfCommand(Mono.Unix.Native.LockfCommand value, out int rval) { throw null; }
        public static bool TryFromLockType(Mono.Unix.Native.LockType value, out short rval) { throw null; }
        public static bool TryFromMemfdFlags(Mono.Unix.Native.MemfdFlags value, out uint rval) { throw null; }
        public static bool TryFromMessageFlags(Mono.Unix.Native.MessageFlags value, out int rval) { throw null; }
        public static bool TryFromMlockallFlags(Mono.Unix.Native.MlockallFlags value, out int rval) { throw null; }
        public static bool TryFromMmapFlags(Mono.Unix.Native.MmapFlags value, out int rval) { throw null; }
        public static bool TryFromMmapProts(Mono.Unix.Native.MmapProts value, out int rval) { throw null; }
        public static bool TryFromMountFlags(Mono.Unix.Native.MountFlags value, out ulong rval) { throw null; }
        public static bool TryFromMremapFlags(Mono.Unix.Native.MremapFlags value, out ulong rval) { throw null; }
        public static bool TryFromMsyncFlags(Mono.Unix.Native.MsyncFlags value, out int rval) { throw null; }
        public static bool TryFromOpenFlags(Mono.Unix.Native.OpenFlags value, out int rval) { throw null; }
        public static bool TryFromPathconfName(Mono.Unix.Native.PathconfName value, out int rval) { throw null; }
        public static bool TryFromPollEvents(Mono.Unix.Native.PollEvents value, out short rval) { throw null; }
        public static bool TryFromPosixFadviseAdvice(Mono.Unix.Native.PosixFadviseAdvice value, out int rval) { throw null; }
        public static bool TryFromPosixMadviseAdvice(Mono.Unix.Native.PosixMadviseAdvice value, out int rval) { throw null; }
        public static bool TryFromSealType(Mono.Unix.Native.SealType value, out int rval) { throw null; }
        public static bool TryFromSeekFlags(Mono.Unix.Native.SeekFlags value, out short rval) { throw null; }
        public static bool TryFromShutdownOption(Mono.Unix.Native.ShutdownOption value, out int rval) { throw null; }
        public static bool TryFromSignum(Mono.Unix.Native.Signum value, out int rval) { throw null; }
        public static bool TryFromSysconfName(Mono.Unix.Native.SysconfName value, out int rval) { throw null; }
        public static bool TryFromSyslogFacility(Mono.Unix.Native.SyslogFacility value, out int rval) { throw null; }
        public static bool TryFromSyslogLevel(Mono.Unix.Native.SyslogLevel value, out int rval) { throw null; }
        public static bool TryFromSyslogOptions(Mono.Unix.Native.SyslogOptions value, out int rval) { throw null; }
        public static bool TryFromUnixAddressFamily(Mono.Unix.Native.UnixAddressFamily value, out int rval) { throw null; }
        public static bool TryFromUnixSocketControlMessage(Mono.Unix.Native.UnixSocketControlMessage value, out int rval) { throw null; }
        public static bool TryFromUnixSocketFlags(Mono.Unix.Native.UnixSocketFlags value, out int rval) { throw null; }
        public static bool TryFromUnixSocketOptionName(Mono.Unix.Native.UnixSocketOptionName value, out int rval) { throw null; }
        public static bool TryFromUnixSocketProtocol(Mono.Unix.Native.UnixSocketProtocol value, out int rval) { throw null; }
        public static bool TryFromUnixSocketType(Mono.Unix.Native.UnixSocketType value, out int rval) { throw null; }
        public static bool TryFromWaitOptions(Mono.Unix.Native.WaitOptions value, out int rval) { throw null; }
        public static bool TryFromXattrFlags(Mono.Unix.Native.XattrFlags value, out int rval) { throw null; }
        public static bool TryToAccessModes(int value, out Mono.Unix.Native.AccessModes rval) { throw null; }
        public static bool TryToAtFlags(int value, out Mono.Unix.Native.AtFlags rval) { throw null; }
        public static bool TryToConfstrName(int value, out Mono.Unix.Native.ConfstrName rval) { throw null; }
        public static bool TryToDirectoryNotifyFlags(int value, out Mono.Unix.Native.DirectoryNotifyFlags rval) { throw null; }
        public static bool TryToEpollEvents(uint value, out Mono.Unix.Native.EpollEvents rval) { throw null; }
        public static bool TryToEpollFlags(int value, out Mono.Unix.Native.EpollFlags rval) { throw null; }
        public static bool TryToErrno(int value, out Mono.Unix.Native.Errno rval) { throw null; }
        public static bool TryToFcntlCommand(int value, out Mono.Unix.Native.FcntlCommand rval) { throw null; }
        public static bool TryToFilePermissions(uint value, out Mono.Unix.Native.FilePermissions rval) { throw null; }
        public static bool TryToLockfCommand(int value, out Mono.Unix.Native.LockfCommand rval) { throw null; }
        public static bool TryToLockType(short value, out Mono.Unix.Native.LockType rval) { throw null; }
        public static bool TryToMemfdFlags(uint value, out Mono.Unix.Native.MemfdFlags rval) { throw null; }
        public static bool TryToMessageFlags(int value, out Mono.Unix.Native.MessageFlags rval) { throw null; }
        public static bool TryToMlockallFlags(int value, out Mono.Unix.Native.MlockallFlags rval) { throw null; }
        public static bool TryToMmapFlags(int value, out Mono.Unix.Native.MmapFlags rval) { throw null; }
        public static bool TryToMmapProts(int value, out Mono.Unix.Native.MmapProts rval) { throw null; }
        public static bool TryToMountFlags(ulong value, out Mono.Unix.Native.MountFlags rval) { throw null; }
        public static bool TryToMremapFlags(ulong value, out Mono.Unix.Native.MremapFlags rval) { throw null; }
        public static bool TryToMsyncFlags(int value, out Mono.Unix.Native.MsyncFlags rval) { throw null; }
        public static bool TryToOpenFlags(int value, out Mono.Unix.Native.OpenFlags rval) { throw null; }
        public static bool TryToPathconfName(int value, out Mono.Unix.Native.PathconfName rval) { throw null; }
        public static bool TryToPollEvents(short value, out Mono.Unix.Native.PollEvents rval) { throw null; }
        public static bool TryToPosixFadviseAdvice(int value, out Mono.Unix.Native.PosixFadviseAdvice rval) { throw null; }
        public static bool TryToPosixMadviseAdvice(int value, out Mono.Unix.Native.PosixMadviseAdvice rval) { throw null; }
        public static bool TryToSealType(int value, out Mono.Unix.Native.SealType rval) { throw null; }
        public static bool TryToSeekFlags(short value, out Mono.Unix.Native.SeekFlags rval) { throw null; }
        public static bool TryToShutdownOption(int value, out Mono.Unix.Native.ShutdownOption rval) { throw null; }
        public static bool TryToSignum(int value, out Mono.Unix.Native.Signum rval) { throw null; }
        public static bool TryToSysconfName(int value, out Mono.Unix.Native.SysconfName rval) { throw null; }
        public static bool TryToSyslogFacility(int value, out Mono.Unix.Native.SyslogFacility rval) { throw null; }
        public static bool TryToSyslogLevel(int value, out Mono.Unix.Native.SyslogLevel rval) { throw null; }
        public static bool TryToSyslogOptions(int value, out Mono.Unix.Native.SyslogOptions rval) { throw null; }
        public static bool TryToUnixAddressFamily(int value, out Mono.Unix.Native.UnixAddressFamily rval) { throw null; }
        public static bool TryToUnixSocketControlMessage(int value, out Mono.Unix.Native.UnixSocketControlMessage rval) { throw null; }
        public static bool TryToUnixSocketFlags(int value, out Mono.Unix.Native.UnixSocketFlags rval) { throw null; }
        public static bool TryToUnixSocketOptionName(int value, out Mono.Unix.Native.UnixSocketOptionName rval) { throw null; }
        public static bool TryToUnixSocketProtocol(int value, out Mono.Unix.Native.UnixSocketProtocol rval) { throw null; }
        public static bool TryToUnixSocketType(int value, out Mono.Unix.Native.UnixSocketType rval) { throw null; }
        public static bool TryToWaitOptions(int value, out Mono.Unix.Native.WaitOptions rval) { throw null; }
        public static bool TryToXattrFlags(int value, out Mono.Unix.Native.XattrFlags rval) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum OpenFlags
    {
        O_APPEND = 1024,
        O_ASYNC = 8192,
        O_CLOEXEC = 524288,
        O_CREAT = 64,
        O_DIRECT = 16384,
        O_DIRECTORY = 65536,
        O_EXCL = 128,
        O_LARGEFILE = 32768,
        O_NOATIME = 262144,
        O_NOCTTY = 256,
        O_NOFOLLOW = 131072,
        O_NONBLOCK = 2048,
        O_PATH = 2097152,
        O_RDONLY = 0,
        O_RDWR = 2,
        O_SYNC = 4096,
        O_TRUNC = 512,
        O_WRONLY = 1,
    }
    public sealed partial class Passwd : System.IEquatable<Mono.Unix.Native.Passwd>
    {
        public string pw_dir;
        public string pw_gecos;
        [System.CLSCompliantAttribute(false)]
        public uint pw_gid;
        public string pw_name;
        public string pw_passwd;
        public string pw_shell;
        [System.CLSCompliantAttribute(false)]
        public uint pw_uid;
        public Passwd() { }
        public bool Equals(Mono.Unix.Native.Passwd value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Passwd lhs, Mono.Unix.Native.Passwd rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Passwd lhs, Mono.Unix.Native.Passwd rhs) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public enum PathconfName
    {
        _PC_2_SYMLINKS = 20,
        _PC_ALLOC_SIZE_MIN = 18,
        _PC_ASYNC_IO = 10,
        _PC_CHOWN_RESTRICTED = 6,
        _PC_FILESIZEBITS = 13,
        _PC_LINK_MAX = 0,
        _PC_MAX_CANON = 1,
        _PC_MAX_INPUT = 2,
        _PC_NAME_MAX = 3,
        _PC_NO_TRUNC = 7,
        _PC_PATH_MAX = 4,
        _PC_PIPE_BUF = 5,
        _PC_PRIO_IO = 11,
        _PC_REC_INCR_XFER_SIZE = 14,
        _PC_REC_MAX_XFER_SIZE = 15,
        _PC_REC_MIN_XFER_SIZE = 16,
        _PC_REC_XFER_ALIGN = 17,
        _PC_SOCK_MAXBUF = 12,
        _PC_SYMLINK_MAX = 19,
        _PC_SYNC_IO = 9,
        _PC_VDISABLE = 8,
    }
    [System.FlagsAttribute]
    public enum PollEvents : short
    {
        POLLERR = (short)8,
        POLLHUP = (short)16,
        POLLIN = (short)1,
        POLLNVAL = (short)32,
        POLLOUT = (short)4,
        POLLPRI = (short)2,
        POLLRDBAND = (short)128,
        POLLRDNORM = (short)64,
        POLLWRBAND = (short)512,
        POLLWRNORM = (short)256,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Pollfd : System.IEquatable<Mono.Unix.Native.Pollfd>
    {
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.Native.PollEvents events;
        public int fd;
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.Native.PollEvents revents;
        public bool Equals(Mono.Unix.Native.Pollfd value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Pollfd lhs, Mono.Unix.Native.Pollfd rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Pollfd lhs, Mono.Unix.Native.Pollfd rhs) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public enum PosixFadviseAdvice
    {
        POSIX_FADV_DONTNEED = 4,
        POSIX_FADV_NOREUSE = 5,
        POSIX_FADV_NORMAL = 0,
        POSIX_FADV_RANDOM = 1,
        POSIX_FADV_SEQUENTIAL = 2,
        POSIX_FADV_WILLNEED = 3,
    }
    [System.CLSCompliantAttribute(false)]
    public enum PosixMadviseAdvice
    {
        POSIX_MADV_DONTNEED = 4,
        POSIX_MADV_NORMAL = 0,
        POSIX_MADV_RANDOM = 1,
        POSIX_MADV_SEQUENTIAL = 2,
        POSIX_MADV_WILLNEED = 3,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RealTimeSignum : System.IEquatable<Mono.Unix.Native.RealTimeSignum>
    {
        private int _dummyPrimitive;
        public static readonly Mono.Unix.Native.RealTimeSignum MaxValue;
        public static readonly Mono.Unix.Native.RealTimeSignum MinValue;
        public RealTimeSignum(int offset) { throw null; }
        public int Offset { get { throw null; } }
        public bool Equals(Mono.Unix.Native.RealTimeSignum value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.RealTimeSignum lhs, Mono.Unix.Native.RealTimeSignum rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.RealTimeSignum lhs, Mono.Unix.Native.RealTimeSignum rhs) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum SealType
    {
        F_SEAL_FUTURE_WRITE = 16,
        F_SEAL_GROW = 4,
        F_SEAL_SEAL = 1,
        F_SEAL_SHRINK = 2,
        F_SEAL_WRITE = 8,
    }
    [System.CLSCompliantAttribute(false)]
    public enum SeekFlags : short
    {
        L_INCR = (short)1,
        L_SET = (short)0,
        L_XTND = (short)2,
        SEEK_CUR = (short)1,
        SEEK_END = (short)2,
        SEEK_SET = (short)0,
    }
    [System.CLSCompliantAttribute(false)]
    public enum ShutdownOption
    {
        SHUT_RD = 1,
        SHUT_RDWR = 3,
        SHUT_WR = 2,
    }
    public enum SignalAction
    {
        Default = 0,
        Error = 2,
        Ignore = 1,
    }
    public delegate void SignalHandler(int signal);
    public enum Signum
    {
        SIGABRT = 6,
        SIGALRM = 14,
        SIGBUS = 7,
        SIGCHLD = 17,
        SIGCLD = 17,
        SIGCONT = 18,
        SIGFPE = 8,
        SIGHUP = 1,
        SIGILL = 4,
        SIGINT = 2,
        SIGIO = 29,
        SIGIOT = 6,
        SIGKILL = 9,
        SIGPIPE = 13,
        SIGPOLL = 29,
        SIGPROF = 27,
        SIGPWR = 30,
        SIGQUIT = 3,
        SIGSEGV = 11,
        SIGSTKFLT = 16,
        SIGSTOP = 19,
        SIGSYS = 31,
        SIGTERM = 15,
        SIGTRAP = 5,
        SIGTSTP = 20,
        SIGTTIN = 21,
        SIGTTOU = 22,
        SIGUNUSED = 31,
        SIGURG = 23,
        SIGUSR1 = 10,
        SIGUSR2 = 12,
        SIGVTALRM = 26,
        SIGWINCH = 28,
        SIGXCPU = 24,
        SIGXFSZ = 25,
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial class Sockaddr
    {
        public Sockaddr() { }
        public Mono.Unix.Native.UnixAddressFamily sa_family { get { throw null; } set { } }
        public static Mono.Unix.Native.Sockaddr FromSockaddrStorage(Mono.Unix.Native.SockaddrStorage storage) { throw null; }
        public Mono.Unix.Native.SockaddrStorage ToSockaddrStorage() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public sealed partial class SockaddrIn : Mono.Unix.Native.Sockaddr, System.IEquatable<Mono.Unix.Native.SockaddrIn>
    {
        public Mono.Unix.Native.InAddr sin_addr;
        public ushort sin_port;
        public SockaddrIn() { }
        public Mono.Unix.Native.UnixAddressFamily sin_family { get { throw null; } set { } }
        public bool Equals(Mono.Unix.Native.SockaddrIn value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new Mono.Unix.Native.SockaddrIn FromSockaddrStorage(Mono.Unix.Native.SockaddrStorage storage) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public sealed partial class SockaddrIn6 : Mono.Unix.Native.Sockaddr, System.IEquatable<Mono.Unix.Native.SockaddrIn6>
    {
        public Mono.Unix.Native.In6Addr sin6_addr;
        public uint sin6_flowinfo;
        public ushort sin6_port;
        public uint sin6_scope_id;
        public SockaddrIn6() { }
        public Mono.Unix.Native.UnixAddressFamily sin6_family { get { throw null; } set { } }
        public bool Equals(Mono.Unix.Native.SockaddrIn6 value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new Mono.Unix.Native.SockaddrIn6 FromSockaddrStorage(Mono.Unix.Native.SockaddrStorage storage) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class SockaddrStorage : Mono.Unix.Native.Sockaddr, System.IEquatable<Mono.Unix.Native.SockaddrStorage>
    {
        public SockaddrStorage() { }
        public SockaddrStorage(int size) { }
        public byte[] data { get { throw null; } set { } }
        public long data_len { get { throw null; } set { } }
        public void CopyTo(Mono.Unix.Native.Sockaddr address) { }
        public bool Equals(Mono.Unix.Native.SockaddrStorage value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public void SetTo(Mono.Unix.Native.Sockaddr address) { }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class SockaddrUn : Mono.Unix.Native.Sockaddr, System.IEquatable<Mono.Unix.Native.SockaddrUn>
    {
        public SockaddrUn() { }
        public SockaddrUn(int size) { }
        public SockaddrUn(string path, bool linuxAbstractNamespace = false) { }
        public bool IsLinuxAbstractNamespace { get { throw null; } }
        public string Path { get { throw null; } }
        public Mono.Unix.Native.UnixAddressFamily sun_family { get { throw null; } set { } }
        public byte[] sun_path { get { throw null; } set { } }
        public long sun_path_len { get { throw null; } set { } }
        public bool Equals(Mono.Unix.Native.SockaddrUn value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new Mono.Unix.Native.SockaddrUn FromSockaddrStorage(Mono.Unix.Native.SockaddrStorage storage) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Stat : System.IEquatable<Mono.Unix.Native.Stat>
    {
        private int _dummyPrimitive;
        public long st_atime;
        public long st_atime_nsec;
        public long st_blksize;
        public long st_blocks;
        public long st_ctime;
        public long st_ctime_nsec;
        [System.CLSCompliantAttribute(false)]
        public ulong st_dev;
        [System.CLSCompliantAttribute(false)]
        public uint st_gid;
        [System.CLSCompliantAttribute(false)]
        public ulong st_ino;
        [System.CLSCompliantAttribute(false)]
        public Mono.Unix.Native.FilePermissions st_mode;
        public long st_mtime;
        public long st_mtime_nsec;
        [System.CLSCompliantAttribute(false)]
        public ulong st_nlink;
        [System.CLSCompliantAttribute(false)]
        public ulong st_rdev;
        public long st_size;
        [System.CLSCompliantAttribute(false)]
        public uint st_uid;
        public Mono.Unix.Native.Timespec st_atim { get { throw null; } set { } }
        public Mono.Unix.Native.Timespec st_ctim { get { throw null; } set { } }
        public Mono.Unix.Native.Timespec st_mtim { get { throw null; } set { } }
        public bool Equals(Mono.Unix.Native.Stat value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Stat lhs, Mono.Unix.Native.Stat rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Stat lhs, Mono.Unix.Native.Stat rhs) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Statvfs : System.IEquatable<Mono.Unix.Native.Statvfs>
    {
        public ulong f_bavail;
        public ulong f_bfree;
        public ulong f_blocks;
        public ulong f_bsize;
        public ulong f_favail;
        public ulong f_ffree;
        public ulong f_files;
        public Mono.Unix.Native.MountFlags f_flag;
        public ulong f_frsize;
        public ulong f_fsid;
        public ulong f_namemax;
        public bool Equals(Mono.Unix.Native.Statvfs value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Statvfs lhs, Mono.Unix.Native.Statvfs rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Statvfs lhs, Mono.Unix.Native.Statvfs rhs) { throw null; }
    }
    public partial class Stdlib
    {
        internal Stdlib() { }
        [System.CLSCompliantAttribute(false)]
        public static readonly int BUFSIZ;
        [System.CLSCompliantAttribute(false)]
        public static readonly int EOF;
        [System.CLSCompliantAttribute(false)]
        public static readonly int EXIT_FAILURE;
        [System.CLSCompliantAttribute(false)]
        public static readonly int EXIT_SUCCESS;
        [System.CLSCompliantAttribute(false)]
        public static readonly int FILENAME_MAX;
        [System.CLSCompliantAttribute(false)]
        public static readonly int FOPEN_MAX;
        [System.CLSCompliantAttribute(false)]
        public static readonly int L_tmpnam;
        [System.CLSCompliantAttribute(false)]
        public static readonly int MB_CUR_MAX;
        [System.CLSCompliantAttribute(false)]
        public static readonly int RAND_MAX;
        [System.CLSCompliantAttribute(false)]
        public static readonly Mono.Unix.Native.SignalHandler SIG_DFL;
        [System.CLSCompliantAttribute(false)]
        public static readonly Mono.Unix.Native.SignalHandler SIG_ERR;
        [System.CLSCompliantAttribute(false)]
        public static readonly Mono.Unix.Native.SignalHandler SIG_IGN;
        public static readonly System.IntPtr stderr;
        public static readonly System.IntPtr stdin;
        public static readonly System.IntPtr stdout;
        [System.CLSCompliantAttribute(false)]
        public static readonly int TMP_MAX;
        [System.CLSCompliantAttribute(false)]
        public static readonly int _IOFBF;
        [System.CLSCompliantAttribute(false)]
        public static readonly int _IOLBF;
        [System.CLSCompliantAttribute(false)]
        public static readonly int _IONBF;
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern void abort();
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern System.IntPtr calloc(ulong nmemb, ulong size);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int clearerr(System.IntPtr stream);
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern void exit(int status);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fclose(System.IntPtr stream);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int feof(System.IntPtr stream);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int ferror(System.IntPtr stream);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fflush(System.IntPtr stream);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fgetc(System.IntPtr stream);
        public static int fgetpos(System.IntPtr stream, Mono.Unix.Native.FilePosition pos) { throw null; }
        public static System.Text.StringBuilder fgets(System.Text.StringBuilder sb, int size, System.IntPtr stream) { throw null; }
        public static System.Text.StringBuilder fgets(System.Text.StringBuilder sb, System.IntPtr stream) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr fopen([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, string mode);
        public static int fprintf(System.IntPtr stream, string message) { throw null; }
        [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse fprintf (IntPtr, string) instead.")]
        public static int fprintf(System.IntPtr stream, string format, params object[] parameters) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fputc(int c, System.IntPtr stream);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fputs(string s, System.IntPtr stream);
        [System.CLSCompliantAttribute(false)]
        public static ulong fread(byte[] ptr, System.IntPtr stream) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong fread(byte[] ptr, ulong size, ulong nmemb, System.IntPtr stream) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern ulong fread(System.IntPtr ptr, ulong size, ulong nmemb, System.IntPtr stream);
        [System.CLSCompliantAttribute(false)]
        public unsafe static ulong fread(void* ptr, ulong size, ulong nmemb, System.IntPtr stream) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern void free(System.IntPtr ptr);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr freopen([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, string mode, System.IntPtr stream);
        [System.CLSCompliantAttribute(false)]
        public static int fseek(System.IntPtr stream, long offset, Mono.Unix.Native.SeekFlags origin) { throw null; }
        public static int fsetpos(System.IntPtr stream, Mono.Unix.Native.FilePosition pos) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long ftell(System.IntPtr stream);
        [System.CLSCompliantAttribute(false)]
        public static ulong fwrite(byte[] ptr, System.IntPtr stream) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong fwrite(byte[] ptr, ulong size, ulong nmemb, System.IntPtr stream) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern ulong fwrite(System.IntPtr ptr, ulong size, ulong nmemb, System.IntPtr stream);
        [System.CLSCompliantAttribute(false)]
        public unsafe static ulong fwrite(void* ptr, ulong size, ulong nmemb, System.IntPtr stream) { throw null; }
        public static int getc(System.IntPtr stream) { throw null; }
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getchar();
        public static string getenv(string name) { throw null; }
        public static Mono.Unix.Native.Errno GetLastError() { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern System.IntPtr malloc(ulong size);
        public static int perror(string s) { throw null; }
        public static int printf(string message) { throw null; }
        [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse printf (string) instead.")]
        public static int printf(string format, params object[] parameters) { throw null; }
        public static int putc(int c, System.IntPtr stream) { throw null; }
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int putchar(int c);
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int puts(string s);
        public static int raise(Mono.Unix.Native.RealTimeSignum rts) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int raise(Mono.Unix.Native.Signum sig) { throw null; }
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int rand();
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern System.IntPtr realloc(System.IntPtr ptr, ulong size);
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int remove([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string filename);
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int rename([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string oldpath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string newpath);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int rewind(System.IntPtr stream);
        [System.CLSCompliantAttribute(false)]
        public unsafe static int setbuf(System.IntPtr stream, byte* buf) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setbuf(System.IntPtr stream, System.IntPtr buf);
        protected static void SetLastError(Mono.Unix.Native.Errno error) { }
        public static int SetSignalAction(Mono.Unix.Native.RealTimeSignum rts, Mono.Unix.Native.SignalAction action) { throw null; }
        public static int SetSignalAction(Mono.Unix.Native.Signum signal, Mono.Unix.Native.SignalAction action) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static int setvbuf(System.IntPtr stream, byte* buf, int mode, ulong size) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern int setvbuf(System.IntPtr stream, System.IntPtr buf, int mode, ulong size);
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("This is not safe; use Mono.Unix.UnixSignal for signal delivery or SetSignalAction()")]
        public static Mono.Unix.Native.SignalHandler signal(Mono.Unix.Native.Signum signum, Mono.Unix.Native.SignalHandler handler) { throw null; }
        public static int snprintf(System.Text.StringBuilder s, string message) { throw null; }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse snprintf (StringBuilder, string) instead.")]
        public static int snprintf(System.Text.StringBuilder s, string format, params object[] parameters) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int snprintf(System.Text.StringBuilder s, ulong n, string message) { throw null; }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse snprintf (StringBuilder, string) instead.")]
        public static int snprintf(System.Text.StringBuilder s, ulong n, string format, params object[] parameters) { throw null; }
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern void srand(uint seed);
        [System.CLSCompliantAttribute(false)]
        public static string strerror(Mono.Unix.Native.Errno errnum) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern ulong strlen(System.IntPtr s);
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern int system(string @string);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr tmpfile();
        [System.ObsoleteAttribute("Syscall.mkstemp() should be preferred.")]
        public static string tmpnam() { throw null; }
        [System.ObsoleteAttribute("Syscall.mkstemp() should be preferred.")]
        public static string tmpnam(System.Text.StringBuilder s) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int ungetc(int c, System.IntPtr stream);
        [System.Runtime.InteropServices.DllImport("msvcrt")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern void _Exit(int status);
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class Syscall : Mono.Unix.Native.Stdlib
    {
        internal Syscall() { }
        public static readonly int AT_FDCWD;
        public static readonly int L_ctermid;
        public static readonly int L_cuserid;
        public static readonly System.IntPtr MAP_FAILED;
        public static readonly long UTIME_NOW;
        public static readonly long UTIME_OMIT;
        public static int accept(int socket, Mono.Unix.Native.Sockaddr address) { throw null; }
        public static int accept4(int socket, Mono.Unix.Native.Sockaddr address, Mono.Unix.Native.UnixSocketFlags flags) { throw null; }
        public static int access(string pathname, Mono.Unix.Native.AccessModes mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int acct([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string filename);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint alarm(uint seconds);
        public static int bind(int socket, Mono.Unix.Native.Sockaddr address) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int brk(System.IntPtr end_data_segment);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int chdir([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path);
        public static int chmod(string path, Mono.Unix.Native.FilePermissions mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int chown([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, int owner, int group);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.ObsoleteAttribute("Use Int32 overload")]
        public static extern int chown([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, uint owner, uint group);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int chroot([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int close(int fd);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int closedir(System.IntPtr dir);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int closelog();
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern ulong CMSG_ALIGN(ulong length);
        public static long CMSG_DATA(Mono.Unix.Native.Msghdr msgh, long cmsg) { throw null; }
        public static long CMSG_FIRSTHDR(Mono.Unix.Native.Msghdr msgh) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern ulong CMSG_LEN(ulong length);
        public static long CMSG_NXTHDR(Mono.Unix.Native.Msghdr msgh, long cmsg) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern ulong CMSG_SPACE(ulong length);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern ulong confstr(Mono.Unix.Native.ConfstrName name, [System.Runtime.InteropServices.Out]System.Text.StringBuilder buf, ulong len);
        public static int connect(int socket, Mono.Unix.Native.Sockaddr address) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int creat([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string pathname, Mono.Unix.Native.FilePermissions mode);
        [System.ObsoleteAttribute("This is insecure and should not be used", true)]
        public static string crypt(string key, string salt) { throw null; }
        [System.ObsoleteAttribute("\"Nobody knows precisely what cuserid() does... DO NOT USE cuserid().\n`string' must hold L_cuserid characters.  Use getlogin_r instead.")]
        public static string cuserid(System.Text.StringBuilder @string) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int dirfd(System.IntPtr dir);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int dup(int fd);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int dup2(int fd, int fd2);
        [System.ObsoleteAttribute("This is insecure and should not be used", true)]
        public static int encrypt(byte[] block, bool decode) { throw null; }
        public static int endfsent() { throw null; }
        public static int endgrent() { throw null; }
        public static int endpwent() { throw null; }
        public static int endusershell() { throw null; }
        public static int epoll_create(Mono.Unix.Native.EpollFlags flags) { throw null; }
        public static int epoll_create(int size) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int epoll_ctl(int epfd, Mono.Unix.Native.EpollOp op, int fd, ref Mono.Unix.Native.EpollEvent ee);
        public static int epoll_ctl(int epfd, Mono.Unix.Native.EpollOp op, int fd, Mono.Unix.Native.EpollEvents events) { throw null; }
        public static int epoll_wait(int epfd, Mono.Unix.Native.EpollEvent[] events, int max_events, int timeout) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int execv([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, string[] argv);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int execve([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, string[] argv, string[] envp);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int execvp([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, string[] argv);
        public static int faccessat(int dirfd, string pathname, Mono.Unix.Native.AccessModes mode, Mono.Unix.Native.AtFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fchdir(int fd);
        public static int fchmod(int filedes, Mono.Unix.Native.FilePermissions mode) { throw null; }
        public static int fchmodat(int dirfd, string pathname, Mono.Unix.Native.FilePermissions mode, Mono.Unix.Native.AtFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fchown(int fd, int owner, int group);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.ObsoleteAttribute("Use Int32 overload")]
        public static extern int fchown(int fd, uint owner, uint group);
        public static int fchownat(int dirfd, string pathname, int owner, int group, Mono.Unix.Native.AtFlags flags) { throw null; }
        [System.ObsoleteAttribute("Use Int32 overload")]
        public static int fchownat(int dirfd, string pathname, uint owner, uint group, Mono.Unix.Native.AtFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd);
        public static int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, Mono.Unix.Native.DirectoryNotifyFlags arg) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, ref Mono.Unix.Native.Flock @lock);
        public static int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, Mono.Unix.Native.SealType arg) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, int arg);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, long arg);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, System.IntPtr ptr);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fdatasync(int fd);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr fdopendir(int fd);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fexecve(int fd, string[] argv, string[] envp);
        public static Mono.Unix.Native.Group fgetgrent(System.IntPtr stream) { throw null; }
        public static Mono.Unix.Native.Passwd fgetpwent(System.IntPtr stream) { throw null; }
        public static long fgetxattr(int fd, string name, byte[] value) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long fgetxattr(int fd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name, byte[] value, ulong size);
        public static long fgetxattr(int fd, string name, out byte[] value) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long flistxattr(int fd, byte[] list, ulong size);
        public static long flistxattr(int fd, out string[] values) { throw null; }
        public static long flistxattr(int fd, System.Text.Encoding encoding, out string[] values) { throw null; }
        public static long fpathconf(int filedes, Mono.Unix.Native.PathconfName name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long fpathconf(int filedes, Mono.Unix.Native.PathconfName name, Mono.Unix.Native.Errno defaultError);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fremovexattr(int fd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name);
        public static int fsetxattr(int fd, string name, byte[] value) { throw null; }
        public static int fsetxattr(int fd, string name, byte[] value, Mono.Unix.Native.XattrFlags flags) { throw null; }
        public static int fsetxattr(int fd, string name, byte[] value, ulong size) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fsetxattr(int fd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name, byte[] value, ulong size, Mono.Unix.Native.XattrFlags flags);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fstat(int filedes, out Mono.Unix.Native.Stat buf);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fstatat(int dirfd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string file_name, out Mono.Unix.Native.Stat buf, Mono.Unix.Native.AtFlags flags);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fstatvfs(int fd, out Mono.Unix.Native.Statvfs buf);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int fsync(int fd);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int ftruncate(int fd, long length);
        public static int futimens(int fd, Mono.Unix.Native.Timespec[] times) { throw null; }
        public static int futimes(int fd, Mono.Unix.Native.Timeval[] tvp) { throw null; }
        public static System.Text.StringBuilder getcwd(System.Text.StringBuilder buf) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr getcwd([System.Runtime.InteropServices.Out]System.Text.StringBuilder buf, ulong size);
        public static int getdomainname(System.Text.StringBuilder name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getdomainname([System.Runtime.InteropServices.Out]System.Text.StringBuilder name, ulong len);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getdtablesize();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint getegid();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint geteuid();
        public static Mono.Unix.Native.Fstab getfsent() { throw null; }
        public static Mono.Unix.Native.Fstab getfsfile(string mount_point) { throw null; }
        public static Mono.Unix.Native.Fstab getfsspec(string special_file) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint getgid();
        public static Mono.Unix.Native.Group getgrent() { throw null; }
        public static Mono.Unix.Native.Group getgrgid(uint uid) { throw null; }
        public static int getgrgid_r(uint uid, Mono.Unix.Native.Group grbuf, out Mono.Unix.Native.Group grbufp) { throw null; }
        public static Mono.Unix.Native.Group getgrnam(string name) { throw null; }
        public static int getgrnam_r(string name, Mono.Unix.Native.Group grbuf, out Mono.Unix.Native.Group grbufp) { throw null; }
        public static Mono.Unix.Native.Group[] getgrouplist(Mono.Unix.Native.Passwd user) { throw null; }
        public static Mono.Unix.Native.Group[] getgrouplist(string username) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getgroups(int size, uint[] list);
        public static int getgroups(uint[] list) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long gethostid();
        public static int gethostname(System.Text.StringBuilder name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int gethostname([System.Runtime.InteropServices.Out]System.Text.StringBuilder name, ulong len);
        public static string getlogin() { throw null; }
        public static int getlogin_r(System.Text.StringBuilder name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getlogin_r([System.Runtime.InteropServices.Out]System.Text.StringBuilder name, ulong bufsize);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.ObsoleteAttribute("Dropped in POSIX 1003.1-2001.  Use Syscall.sysconf (SysconfName._SC_PAGESIZE).")]
        public static extern int getpagesize();
        public static int getpeername(int socket, Mono.Unix.Native.Sockaddr address) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getpgid(int pid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getpgrp();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getpid();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getppid();
        public static Mono.Unix.Native.Passwd getpwent() { throw null; }
        public static Mono.Unix.Native.Passwd getpwnam(string name) { throw null; }
        public static int getpwnam_r(string name, Mono.Unix.Native.Passwd pwbuf, out Mono.Unix.Native.Passwd pwbufp) { throw null; }
        public static Mono.Unix.Native.Passwd getpwuid(uint uid) { throw null; }
        public static int getpwuid_r(uint uid, Mono.Unix.Native.Passwd pwbuf, out Mono.Unix.Native.Passwd pwbufp) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getresgid(out uint rgid, out uint egid, out uint sgid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getresuid(out uint ruid, out uint euid, out uint suid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int getsid(int pid);
        public static int getsockname(int socket, Mono.Unix.Native.Sockaddr address) { throw null; }
        public static int getsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, out Mono.Unix.Native.Linger option_value) { throw null; }
        public static int getsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, out Mono.Unix.Native.Timeval option_value) { throw null; }
        public static int getsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, byte[] option_value, ref long option_len) { throw null; }
        public static int getsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, out int option_value) { throw null; }
        public static int getsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, System.IntPtr option_value, ref long option_len) { throw null; }
        public unsafe static int getsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, void* option_value, ref long option_len) { throw null; }
        public static int gettimeofday(out Mono.Unix.Native.Timeval tv) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int gettimeofday(out Mono.Unix.Native.Timeval tv, out Mono.Unix.Native.Timezone tz);
        public static int gettimeofday(out Mono.Unix.Native.Timezone tz) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint getuid();
        public static string getusershell() { throw null; }
        public static long getxattr(string path, string name, byte[] value) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long getxattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name, byte[] value, ulong size);
        public static long getxattr(string path, string name, out byte[] value) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint htonl(uint hostlong);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern ushort htons(ushort hostshort);
        public static bool isatty(int fd) { throw null; }
        public static int kill(int pid, Mono.Unix.Native.Signum sig) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int lchown([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, int owner, int group);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.ObsoleteAttribute("Use Int32 overload")]
        public static extern int lchown([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, uint owner, uint group);
        public static long lgetxattr(string path, string name, byte[] value) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long lgetxattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name, byte[] value, ulong size);
        public static long lgetxattr(string path, string name, out byte[] value) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int link([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string oldpath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string newpath);
        public static int linkat(int olddirfd, string oldpath, int newdirfd, string newpath, Mono.Unix.Native.AtFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int listen(int socket, int backlog);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long listxattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, byte[] list, ulong size);
        public static long listxattr(string path, out string[] values) { throw null; }
        public static long listxattr(string path, System.Text.Encoding encoding, out string[] values) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long llistxattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, byte[] list, ulong size);
        public static long llistxattr(string path, out string[] values) { throw null; }
        public static long llistxattr(string path, System.Text.Encoding encoding, out string[] values) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int lockf(int fd, Mono.Unix.Native.LockfCommand cmd, long len);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int lremovexattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name);
        public static long lseek(int fd, long offset, Mono.Unix.Native.SeekFlags whence) { throw null; }
        public static int lsetxattr(string path, string name, byte[] value) { throw null; }
        public static int lsetxattr(string path, string name, byte[] value, Mono.Unix.Native.XattrFlags flags) { throw null; }
        public static int lsetxattr(string path, string name, byte[] value, ulong size) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int lsetxattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name, byte[] value, ulong size, Mono.Unix.Native.XattrFlags flags);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int lstat([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string file_name, out Mono.Unix.Native.Stat buf);
        public static int lutimes(string filename, Mono.Unix.Native.Timeval[] tvp) { throw null; }
        public static int memfd_create(string name, Mono.Unix.Native.MemfdFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int mincore(System.IntPtr start, ulong length, byte[] vec);
        public static int mkdir(string oldpath, Mono.Unix.Native.FilePermissions mode) { throw null; }
        public static int mkdirat(int dirfd, string oldpath, Mono.Unix.Native.FilePermissions mode) { throw null; }
        public static System.Text.StringBuilder mkdtemp(System.Text.StringBuilder template) { throw null; }
        public static int mkfifo(string pathname, Mono.Unix.Native.FilePermissions mode) { throw null; }
        public static int mkfifoat(int dirfd, string pathname, Mono.Unix.Native.FilePermissions mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int mknod([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string pathname, Mono.Unix.Native.FilePermissions mode, ulong dev);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int mknodat(int dirfd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string pathname, Mono.Unix.Native.FilePermissions mode, ulong dev);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int mkstemp(System.Text.StringBuilder template);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int mlock(System.IntPtr start, ulong len);
        public static int mlockall(Mono.Unix.Native.MlockallFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr mmap(System.IntPtr start, ulong length, Mono.Unix.Native.MmapProts prot, Mono.Unix.Native.MmapFlags flags, int fd, long offset);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int mprotect(System.IntPtr start, ulong len, Mono.Unix.Native.MmapProts prot);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr mremap(System.IntPtr old_address, ulong old_size, ulong new_size, Mono.Unix.Native.MremapFlags flags);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int msync(System.IntPtr start, ulong len, Mono.Unix.Native.MsyncFlags flags);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int munlock(System.IntPtr start, ulong len);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int munlockall();
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int munmap(System.IntPtr start, ulong length);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int nanosleep(ref Mono.Unix.Native.Timespec req, ref Mono.Unix.Native.Timespec rem);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int nice(int inc);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint ntohl(uint netlong);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern ushort ntohs(ushort netshort);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int open([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string pathname, Mono.Unix.Native.OpenFlags flags);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int open([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string pathname, Mono.Unix.Native.OpenFlags flags, Mono.Unix.Native.FilePermissions mode);
        public static int openat(int dirfd, string pathname, Mono.Unix.Native.OpenFlags flags) { throw null; }
        public static int openat(int dirfd, string pathname, Mono.Unix.Native.OpenFlags flags, Mono.Unix.Native.FilePermissions mode) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr opendir([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name);
        public static int openlog(System.IntPtr ident, Mono.Unix.Native.SyslogOptions option, Mono.Unix.Native.SyslogFacility defaultFacility) { throw null; }
        public static long pathconf(string path, Mono.Unix.Native.PathconfName name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long pathconf([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, Mono.Unix.Native.PathconfName name, Mono.Unix.Native.Errno defaultError);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int pause();
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int pipe(out int reading, out int writing);
        public static int pipe(int[] filedes) { throw null; }
        public static int poll(Mono.Unix.Native.Pollfd[] fds, int timeout) { throw null; }
        public static int poll(Mono.Unix.Native.Pollfd[] fds, uint nfds, int timeout) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int posix_fadvise(int fd, long offset, long len, Mono.Unix.Native.PosixFadviseAdvice advice);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int posix_fallocate(int fd, long offset, ulong len);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int posix_madvise(System.IntPtr addr, ulong len, Mono.Unix.Native.PosixMadviseAdvice advice);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long pread(int fd, System.IntPtr buf, ulong count, long offset);
        public unsafe static long pread(int fd, void* buf, ulong count, long offset) { throw null; }
        public static long preadv(int fd, Mono.Unix.Native.Iovec[] iov, long offset) { throw null; }
        public static int psignal(Mono.Unix.Native.Signum sig, string s) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long pwrite(int fd, System.IntPtr buf, ulong count, long offset);
        public unsafe static long pwrite(int fd, void* buf, ulong count, long offset) { throw null; }
        public static long pwritev(int fd, Mono.Unix.Native.Iovec[] iov, long offset) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long read(int fd, System.IntPtr buf, ulong count);
        public unsafe static long read(int fd, void* buf, ulong count) { throw null; }
        public static Mono.Unix.Native.Dirent readdir(System.IntPtr dir) { throw null; }
        public static int readdir_r(System.IntPtr dirp, Mono.Unix.Native.Dirent entry, out System.IntPtr result) { throw null; }
        public static long readlink(string path, byte[] buf) { throw null; }
        public static int readlink(string path, [System.Runtime.InteropServices.Out]System.Text.StringBuilder buf) { throw null; }
        public static int readlink(string path, [System.Runtime.InteropServices.Out]System.Text.StringBuilder buf, ulong bufsiz) { throw null; }
        public static long readlinkat(int dirfd, string pathname, byte[] buf) { throw null; }
        public static int readlinkat(int dirfd, string pathname, [System.Runtime.InteropServices.Out]System.Text.StringBuilder buf) { throw null; }
        public static int readlinkat(int dirfd, string pathname, [System.Runtime.InteropServices.Out]System.Text.StringBuilder buf, ulong bufsiz) { throw null; }
        public static long readv(int fd, Mono.Unix.Native.Iovec[] iov) { throw null; }
        public static long recv(int socket, byte[] buffer, ulong length, Mono.Unix.Native.MessageFlags flags) { throw null; }
        public static long recv(int socket, System.IntPtr buffer, ulong length, Mono.Unix.Native.MessageFlags flags) { throw null; }
        public unsafe static long recv(int socket, void* buffer, ulong length, Mono.Unix.Native.MessageFlags flags) { throw null; }
        public static long recvfrom(int socket, byte[] buffer, ulong length, Mono.Unix.Native.MessageFlags flags, Mono.Unix.Native.Sockaddr address) { throw null; }
        public static long recvfrom(int socket, System.IntPtr buffer, ulong length, Mono.Unix.Native.MessageFlags flags, Mono.Unix.Native.Sockaddr address) { throw null; }
        public unsafe static long recvfrom(int socket, void* buffer, ulong length, Mono.Unix.Native.MessageFlags flags, Mono.Unix.Native.Sockaddr address) { throw null; }
        public static long recvmsg(int socket, Mono.Unix.Native.Msghdr message, Mono.Unix.Native.MessageFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int remap_file_pages(System.IntPtr start, ulong size, Mono.Unix.Native.MmapProts prot, long pgoff, Mono.Unix.Native.MmapFlags flags);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int removexattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int renameat(int olddirfd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string oldpath, int newdirfd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string newpath);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int revoke([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string file);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int rewinddir(System.IntPtr dir);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int rmdir([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string pathname);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern System.IntPtr sbrk(System.IntPtr increment);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int seekdir(System.IntPtr dir, long offset);
        public static long send(int socket, byte[] message, ulong length, Mono.Unix.Native.MessageFlags flags) { throw null; }
        public static long send(int socket, System.IntPtr message, ulong length, Mono.Unix.Native.MessageFlags flags) { throw null; }
        public unsafe static long send(int socket, void* message, ulong length, Mono.Unix.Native.MessageFlags flags) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long sendfile(int out_fd, int in_fd, ref long offset, ulong count);
        public static long sendmsg(int socket, Mono.Unix.Native.Msghdr message, Mono.Unix.Native.MessageFlags flags) { throw null; }
        public static long sendto(int socket, byte[] message, ulong length, Mono.Unix.Native.MessageFlags flags, Mono.Unix.Native.Sockaddr address) { throw null; }
        public static long sendto(int socket, System.IntPtr message, ulong length, Mono.Unix.Native.MessageFlags flags, Mono.Unix.Native.Sockaddr address) { throw null; }
        public unsafe static long sendto(int socket, void* message, ulong length, Mono.Unix.Native.MessageFlags flags, Mono.Unix.Native.Sockaddr address) { throw null; }
        public static int setdomainname(string name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setdomainname(string name, ulong len);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setegid(uint uid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int seteuid(uint euid);
        public static int setfsent() { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setgid(uint gid);
        public static int setgrent() { throw null; }
        public static int setgroups(uint[] list) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setgroups(ulong size, uint[] list);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int sethostid(long hostid);
        public static int sethostname(string name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int sethostname(string name, ulong len);
        [System.ObsoleteAttribute("This is insecure and should not be used", true)]
        public static int setkey(string key) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setlogin(string name);
        public static int setlogmask(Mono.Unix.Native.SyslogLevel mask) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setpgid(int pid, int pgid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setpgrp();
        public static int setpwent() { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setregid(uint rgid, uint egid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setresgid(uint rgid, uint egid, uint sgid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setresuid(uint ruid, uint euid, uint suid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setreuid(uint ruid, uint euid);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setsid();
        public static int setsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, Mono.Unix.Native.Linger option_value) { throw null; }
        public static int setsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, Mono.Unix.Native.Timeval option_value) { throw null; }
        public static int setsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, byte[] option_value, long option_len) { throw null; }
        public static int setsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, int option_value) { throw null; }
        public static int setsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, System.IntPtr option_value, long option_len) { throw null; }
        public unsafe static int setsockopt(int socket, Mono.Unix.Native.UnixSocketProtocol level, Mono.Unix.Native.UnixSocketOptionName option_name, void* option_value, long option_len) { throw null; }
        public static int settimeofday(ref Mono.Unix.Native.Timeval tv) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int settimeofday(ref Mono.Unix.Native.Timeval tv, ref Mono.Unix.Native.Timezone tz);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setuid(uint uid);
        public static int setusershell() { throw null; }
        public static int setxattr(string path, string name, byte[] value) { throw null; }
        public static int setxattr(string path, string name, byte[] value, Mono.Unix.Native.XattrFlags flags) { throw null; }
        public static int setxattr(string path, string name, byte[] value, ulong size) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int setxattr([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string name, byte[] value, ulong size, Mono.Unix.Native.XattrFlags flags);
        public static int shutdown(int socket, Mono.Unix.Native.ShutdownOption how) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint sleep(uint seconds);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int sockatmark(int socket);
        public static int socket(Mono.Unix.Native.UnixAddressFamily domain, Mono.Unix.Native.UnixSocketType type, Mono.Unix.Native.UnixSocketFlags flags, Mono.Unix.Native.UnixSocketProtocol protocol) { throw null; }
        public static int socket(Mono.Unix.Native.UnixAddressFamily domain, Mono.Unix.Native.UnixSocketType type, Mono.Unix.Native.UnixSocketProtocol protocol) { throw null; }
        public static int socketpair(Mono.Unix.Native.UnixAddressFamily domain, Mono.Unix.Native.UnixSocketType type, Mono.Unix.Native.UnixSocketFlags flags, Mono.Unix.Native.UnixSocketProtocol protocol, out int socket1, out int socket2) { throw null; }
        public static int socketpair(Mono.Unix.Native.UnixAddressFamily domain, Mono.Unix.Native.UnixSocketType type, Mono.Unix.Native.UnixSocketProtocol protocol, out int socket1, out int socket2) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int stat([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string file_name, out Mono.Unix.Native.Stat buf);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int statvfs([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, out Mono.Unix.Native.Statvfs buf);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int stime(ref long t);
        public static int strerror_r(Mono.Unix.Native.Errno errnum, System.Text.StringBuilder buf) { throw null; }
        public static int strerror_r(Mono.Unix.Native.Errno errnum, System.Text.StringBuilder buf, ulong n) { throw null; }
        public static string strsignal(Mono.Unix.Native.Signum sig) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int swab(System.IntPtr from, System.IntPtr to, long n);
        public unsafe static void swab(void* from, void* to, long n) { }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int symlink([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string oldpath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string newpath);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int symlinkat([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string oldpath, int dirfd, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string newpath);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int sync();
        public static long sysconf(Mono.Unix.Native.SysconfName name) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long sysconf(Mono.Unix.Native.SysconfName name, Mono.Unix.Native.Errno defaultError);
        public static int syslog(Mono.Unix.Native.SyslogFacility facility, Mono.Unix.Native.SyslogLevel level, string message) { throw null; }
        [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse syslog(SyslogFacility, SyslogLevel, string) instead.")]
        public static int syslog(Mono.Unix.Native.SyslogFacility facility, Mono.Unix.Native.SyslogLevel level, string format, params object[] parameters) { throw null; }
        public static int syslog(Mono.Unix.Native.SyslogLevel level, string message) { throw null; }
        [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse syslog(SyslogLevel, string) instead.")]
        public static int syslog(Mono.Unix.Native.SyslogLevel level, string format, params object[] parameters) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int tcgetpgrp(int fd);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int tcsetpgrp(int fd, int pgrp);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long telldir(System.IntPtr dir);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long time(out long t);
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int truncate([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string path, long length);
        public static string ttyname(int fd) { throw null; }
        public static int ttyname_r(int fd, System.Text.StringBuilder buf) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int ttyname_r(int fd, [System.Runtime.InteropServices.Out]System.Text.StringBuilder buf, ulong buflen);
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int ttyslot();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern uint ualarm(uint usecs, uint interval);
        public static Mono.Unix.Native.FilePermissions umask(Mono.Unix.Native.FilePermissions mask) { throw null; }
        public static int uname(out Mono.Unix.Native.Utsname buf) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int unlink([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalType = "Mono.Unix.Native.FileNameMarshaler")]string pathname);
        public static int unlinkat(int dirfd, string pathname, Mono.Unix.Native.AtFlags flags) { throw null; }
        public static int utime(string filename) { throw null; }
        public static int utime(string filename, ref Mono.Unix.Native.Utimbuf buf) { throw null; }
        public static int utimensat(int dirfd, string pathname, Mono.Unix.Native.Timespec[] times, Mono.Unix.Native.AtFlags flags) { throw null; }
        public static int utimes(string filename, Mono.Unix.Native.Timeval[] tvp) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int vhangup();
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int wait(out int status);
        public static int waitpid(int pid, out int status, Mono.Unix.Native.WaitOptions options) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern int WEXITSTATUS(int status);
        public static bool WIFEXITED(int status) { throw null; }
        public static bool WIFSIGNALED(int status) { throw null; }
        public static bool WIFSTOPPED(int status) { throw null; }
        [System.Runtime.InteropServices.DllImport("MonoPosixHelper")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]public static extern long write(int fd, System.IntPtr buf, ulong count);
        public unsafe static long write(int fd, void* buf, ulong count) { throw null; }
        public static long writev(int fd, Mono.Unix.Native.Iovec[] iov) { throw null; }
        public static Mono.Unix.Native.Signum WSTOPSIG(int status) { throw null; }
        public static Mono.Unix.Native.Signum WTERMSIG(int status) { throw null; }
        [System.Runtime.InteropServices.DllImport("libc")][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)][System.CLSCompliantAttribute(false)]
        public static extern int _exit(int status);
    }
    [System.CLSCompliantAttribute(false)]
    public enum SysconfName
    {
        _SC_2_CHAR_TERM = 95,
        _SC_2_C_BIND = 47,
        _SC_2_C_DEV = 48,
        _SC_2_C_VERSION = 96,
        _SC_2_FORT_DEV = 49,
        _SC_2_FORT_RUN = 50,
        _SC_2_LOCALEDEF = 52,
        _SC_2_PBS = 168,
        _SC_2_PBS_ACCOUNTING = 169,
        _SC_2_PBS_CHECKPOINT = 175,
        _SC_2_PBS_LOCATE = 170,
        _SC_2_PBS_MESSAGE = 171,
        _SC_2_PBS_TRACK = 172,
        _SC_2_SW_DEV = 51,
        _SC_2_UPE = 97,
        _SC_2_VERSION = 46,
        _SC_ADVISORY_INFO = 132,
        _SC_AIO_LISTIO_MAX = 23,
        _SC_AIO_MAX = 24,
        _SC_AIO_PRIO_DELTA_MAX = 25,
        _SC_ARG_MAX = 0,
        _SC_ASYNCHRONOUS_IO = 12,
        _SC_ATEXIT_MAX = 87,
        _SC_AVPHYS_PAGES = 86,
        _SC_BARRIERS = 133,
        _SC_BASE = 134,
        _SC_BC_BASE_MAX = 36,
        _SC_BC_DIM_MAX = 37,
        _SC_BC_SCALE_MAX = 38,
        _SC_BC_STRING_MAX = 39,
        _SC_CHARCLASS_NAME_MAX = 45,
        _SC_CHAR_BIT = 101,
        _SC_CHAR_MAX = 102,
        _SC_CHAR_MIN = 103,
        _SC_CHILD_MAX = 1,
        _SC_CLK_TCK = 2,
        _SC_CLOCK_SELECTION = 137,
        _SC_COLL_WEIGHTS_MAX = 40,
        _SC_CPUTIME = 138,
        _SC_C_LANG_SUPPORT = 135,
        _SC_C_LANG_SUPPORT_R = 136,
        _SC_DELAYTIMER_MAX = 26,
        _SC_DEVICE_IO = 140,
        _SC_DEVICE_SPECIFIC = 141,
        _SC_DEVICE_SPECIFIC_R = 142,
        _SC_EQUIV_CLASS_MAX = 41,
        _SC_EXPR_NEST_MAX = 42,
        _SC_FD_MGMT = 143,
        _SC_FIFO = 144,
        _SC_FILE_ATTRIBUTES = 146,
        _SC_FILE_LOCKING = 147,
        _SC_FILE_SYSTEM = 148,
        _SC_FSYNC = 15,
        _SC_GETGR_R_SIZE_MAX = 69,
        _SC_GETPW_R_SIZE_MAX = 70,
        _SC_HOST_NAME_MAX = 180,
        _SC_INT_MAX = 104,
        _SC_INT_MIN = 105,
        _SC_IOV_MAX = 60,
        _SC_JOB_CONTROL = 7,
        _SC_LEVEL1_DCACHE_ASSOC = 189,
        _SC_LEVEL1_DCACHE_LINESIZE = 190,
        _SC_LEVEL1_DCACHE_SIZE = 188,
        _SC_LEVEL1_ICACHE_ASSOC = 186,
        _SC_LEVEL1_ICACHE_LINESIZE = 187,
        _SC_LEVEL1_ICACHE_SIZE = 185,
        _SC_LEVEL2_CACHE_ASSOC = 192,
        _SC_LEVEL2_CACHE_LINESIZE = 193,
        _SC_LEVEL2_CACHE_SIZE = 191,
        _SC_LEVEL3_CACHE_ASSOC = 195,
        _SC_LEVEL3_CACHE_LINESIZE = 196,
        _SC_LEVEL3_CACHE_SIZE = 194,
        _SC_LEVEL4_CACHE_ASSOC = 198,
        _SC_LEVEL4_CACHE_LINESIZE = 199,
        _SC_LEVEL4_CACHE_SIZE = 197,
        _SC_LINE_MAX = 43,
        _SC_LOGIN_NAME_MAX = 71,
        _SC_LONG_BIT = 106,
        _SC_MAPPED_FILES = 16,
        _SC_MB_LEN_MAX = 108,
        _SC_MEMLOCK = 17,
        _SC_MEMLOCK_RANGE = 18,
        _SC_MEMORY_PROTECTION = 19,
        _SC_MESSAGE_PASSING = 20,
        _SC_MONOTONIC_CLOCK = 149,
        _SC_MQ_OPEN_MAX = 27,
        _SC_MQ_PRIO_MAX = 28,
        _SC_MULTI_PROCESS = 150,
        _SC_NETWORKING = 152,
        _SC_NGROUPS_MAX = 3,
        _SC_NL_ARGMAX = 119,
        _SC_NL_LANGMAX = 120,
        _SC_NL_MSGMAX = 121,
        _SC_NL_NMAX = 122,
        _SC_NL_SETMAX = 123,
        _SC_NL_TEXTMAX = 124,
        _SC_NPROCESSORS_CONF = 83,
        _SC_NPROCESSORS_ONLN = 84,
        _SC_NZERO = 109,
        _SC_OPEN_MAX = 4,
        _SC_PAGESIZE = 30,
        _SC_PASS_MAX = 88,
        _SC_PHYS_PAGES = 85,
        _SC_PII = 53,
        _SC_PII_INTERNET = 56,
        _SC_PII_INTERNET_DGRAM = 62,
        _SC_PII_INTERNET_STREAM = 61,
        _SC_PII_OSI = 57,
        _SC_PII_OSI_CLTS = 64,
        _SC_PII_OSI_COTS = 63,
        _SC_PII_OSI_M = 65,
        _SC_PII_SOCKET = 55,
        _SC_PII_XTI = 54,
        _SC_PIPE = 145,
        _SC_POLL = 58,
        _SC_PRIORITIZED_IO = 13,
        _SC_PRIORITY_SCHEDULING = 10,
        _SC_READER_WRITER_LOCKS = 153,
        _SC_REALTIME_SIGNALS = 9,
        _SC_REGEXP = 155,
        _SC_REGEX_VERSION = 156,
        _SC_RE_DUP_MAX = 44,
        _SC_RTSIG_MAX = 31,
        _SC_SAVED_IDS = 8,
        _SC_SCHAR_MAX = 111,
        _SC_SCHAR_MIN = 112,
        _SC_SELECT = 59,
        _SC_SEMAPHORES = 21,
        _SC_SEM_NSEMS_MAX = 32,
        _SC_SEM_VALUE_MAX = 33,
        _SC_SHARED_MEMORY_OBJECTS = 22,
        _SC_SHELL = 157,
        _SC_SHRT_MAX = 113,
        _SC_SHRT_MIN = 114,
        _SC_SIGNALS = 158,
        _SC_SIGQUEUE_MAX = 34,
        _SC_SINGLE_PROCESS = 151,
        _SC_SPAWN = 159,
        _SC_SPIN_LOCKS = 154,
        _SC_SPORADIC_SERVER = 160,
        _SC_SSIZE_MAX = 110,
        _SC_STREAMS = 174,
        _SC_STREAM_MAX = 5,
        _SC_SYMLOOP_MAX = 173,
        _SC_SYNCHRONIZED_IO = 14,
        _SC_SYSTEM_DATABASE = 162,
        _SC_SYSTEM_DATABASE_R = 163,
        _SC_THREADS = 67,
        _SC_THREAD_ATTR_STACKADDR = 77,
        _SC_THREAD_ATTR_STACKSIZE = 78,
        _SC_THREAD_CPUTIME = 139,
        _SC_THREAD_DESTRUCTOR_ITERATIONS = 73,
        _SC_THREAD_KEYS_MAX = 74,
        _SC_THREAD_PRIORITY_SCHEDULING = 79,
        _SC_THREAD_PRIO_INHERIT = 80,
        _SC_THREAD_PRIO_PROTECT = 81,
        _SC_THREAD_PROCESS_SHARED = 82,
        _SC_THREAD_SAFE_FUNCTIONS = 68,
        _SC_THREAD_SPORADIC_SERVER = 161,
        _SC_THREAD_STACK_MIN = 75,
        _SC_THREAD_THREADS_MAX = 76,
        _SC_TIMEOUTS = 164,
        _SC_TIMERS = 11,
        _SC_TIMER_MAX = 35,
        _SC_TRACE = 181,
        _SC_TRACE_EVENT_FILTER = 182,
        _SC_TRACE_INHERIT = 183,
        _SC_TRACE_LOG = 184,
        _SC_TTY_NAME_MAX = 72,
        _SC_TYPED_MEMORY_OBJECTS = 165,
        _SC_TZNAME_MAX = 6,
        _SC_T_IOV_MAX = 66,
        _SC_UCHAR_MAX = 115,
        _SC_UINT_MAX = 116,
        _SC_UIO_MAXIOV = 60,
        _SC_ULONG_MAX = 117,
        _SC_USER_GROUPS = 166,
        _SC_USER_GROUPS_R = 167,
        _SC_USHRT_MAX = 118,
        _SC_V6_ILP32_OFF32 = 176,
        _SC_V6_ILP32_OFFBIG = 177,
        _SC_V6_LP64_OFF64 = 178,
        _SC_V6_LPBIG_OFFBIG = 179,
        _SC_VERSION = 29,
        _SC_WORD_BIT = 107,
        _SC_XBS5_ILP32_OFF32 = 125,
        _SC_XBS5_ILP32_OFFBIG = 126,
        _SC_XBS5_LP64_OFF64 = 127,
        _SC_XBS5_LPBIG_OFFBIG = 128,
        _SC_XOPEN_CRYPT = 92,
        _SC_XOPEN_ENH_I18N = 93,
        _SC_XOPEN_LEGACY = 129,
        _SC_XOPEN_REALTIME = 130,
        _SC_XOPEN_REALTIME_THREADS = 131,
        _SC_XOPEN_SHM = 94,
        _SC_XOPEN_UNIX = 91,
        _SC_XOPEN_VERSION = 89,
        _SC_XOPEN_XCU_VERSION = 90,
        _SC_XOPEN_XPG2 = 98,
        _SC_XOPEN_XPG3 = 99,
        _SC_XOPEN_XPG4 = 100,
    }
    [System.CLSCompliantAttribute(false)]
    public enum SyslogFacility
    {
        LOG_AUTH = 32,
        LOG_AUTHPRIV = 80,
        LOG_CRON = 72,
        LOG_DAEMON = 24,
        LOG_FTP = 88,
        LOG_KERN = 0,
        LOG_LOCAL0 = 128,
        LOG_LOCAL1 = 136,
        LOG_LOCAL2 = 144,
        LOG_LOCAL3 = 152,
        LOG_LOCAL4 = 160,
        LOG_LOCAL5 = 168,
        LOG_LOCAL6 = 176,
        LOG_LOCAL7 = 184,
        LOG_LPR = 48,
        LOG_MAIL = 16,
        LOG_NEWS = 56,
        LOG_SYSLOG = 40,
        LOG_USER = 8,
        LOG_UUCP = 64,
    }
    [System.CLSCompliantAttribute(false)]
    public enum SyslogLevel
    {
        LOG_ALERT = 1,
        LOG_CRIT = 2,
        LOG_DEBUG = 7,
        LOG_EMERG = 0,
        LOG_ERR = 3,
        LOG_INFO = 6,
        LOG_NOTICE = 5,
        LOG_WARNING = 4,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum SyslogOptions
    {
        LOG_CONS = 2,
        LOG_NDELAY = 8,
        LOG_NOWAIT = 16,
        LOG_ODELAY = 4,
        LOG_PERROR = 32,
        LOG_PID = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Timespec : System.IEquatable<Mono.Unix.Native.Timespec>
    {
        public long tv_nsec;
        public long tv_sec;
        public bool Equals(Mono.Unix.Native.Timespec value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Timespec lhs, Mono.Unix.Native.Timespec rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Timespec lhs, Mono.Unix.Native.Timespec rhs) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Timeval : System.IEquatable<Mono.Unix.Native.Timeval>
    {
        public long tv_sec;
        public long tv_usec;
        public bool Equals(Mono.Unix.Native.Timeval value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Timeval lhs, Mono.Unix.Native.Timeval rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Timeval lhs, Mono.Unix.Native.Timeval rhs) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Timezone : System.IEquatable<Mono.Unix.Native.Timezone>
    {
        private int _dummyPrimitive;
        public int tz_minuteswest;
        public bool Equals(Mono.Unix.Native.Timezone value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Timezone lhs, Mono.Unix.Native.Timezone rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Timezone lhs, Mono.Unix.Native.Timezone rhs) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public enum UnixAddressFamily
    {
        AF_ALG = 38,
        AF_APPLETALK = 5,
        AF_ASH = 18,
        AF_ATMPVC = 8,
        AF_ATMSVC = 20,
        AF_AX25 = 3,
        AF_BLUETOOTH = 31,
        AF_BRIDGE = 7,
        AF_CAIF = 37,
        AF_CAN = 29,
        AF_DECnet = 12,
        AF_ECONET = 19,
        AF_IEEE802154 = 36,
        AF_INET = 2,
        AF_INET6 = 10,
        AF_IPX = 4,
        AF_IRDA = 23,
        AF_ISDN = 34,
        AF_IUCV = 32,
        AF_KEY = 15,
        AF_LLC = 26,
        AF_NETBEUI = 13,
        AF_NETLINK = 16,
        AF_NETROM = 6,
        AF_NFC = 39,
        AF_PACKET = 17,
        AF_PHONET = 35,
        AF_PPPOX = 24,
        AF_RDS = 21,
        AF_ROSE = 11,
        AF_RXRPC = 33,
        AF_SECURITY = 14,
        AF_SNA = 22,
        AF_TIPC = 30,
        AF_UNIX = 1,
        AF_UNSPEC = 0,
        AF_VSOCK = 40,
        AF_WANPIPE = 25,
        AF_X25 = 9,
        Unknown = 65536,
    }
    [System.CLSCompliantAttribute(false)]
    public enum UnixSocketControlMessage
    {
        SCM_CREDENTIALS = 2,
        SCM_RIGHTS = 1,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum UnixSocketFlags
    {
        SOCK_CLOEXEC = 524288,
        SOCK_NONBLOCK = 2048,
    }
    [System.CLSCompliantAttribute(false)]
    public enum UnixSocketOptionName
    {
        SO_ACCEPTCONN = 30,
        SO_ATTACH_FILTER = 26,
        SO_BINDTODEVICE = 25,
        SO_BROADCAST = 6,
        SO_BSDCOMPAT = 14,
        SO_BUSY_POLL = 46,
        SO_DEBUG = 1,
        SO_DETACH_FILTER = 27,
        SO_DOMAIN = 39,
        SO_DONTROUTE = 5,
        SO_ERROR = 4,
        SO_KEEPALIVE = 9,
        SO_LINGER = 13,
        SO_LOCK_FILTER = 44,
        SO_MARK = 36,
        SO_MAX_PACING_RATE = 47,
        SO_NOFCS = 43,
        SO_NO_CHECK = 11,
        SO_OOBINLINE = 10,
        SO_PASSCRED = 16,
        SO_PASSSEC = 34,
        SO_PEEK_OFF = 42,
        SO_PEERCRED = 17,
        SO_PEERNAME = 28,
        SO_PEERSEC = 31,
        SO_PRIORITY = 12,
        SO_PROTOCOL = 38,
        SO_RCVBUF = 8,
        SO_RCVBUFFORCE = 33,
        SO_RCVLOWAT = 18,
        SO_RCVTIMEO = 20,
        SO_REUSEADDR = 2,
        SO_REUSEPORT = 15,
        SO_RXQ_OVFL = 40,
        SO_SECURITY_AUTHENTICATION = 22,
        SO_SECURITY_ENCRYPTION_NETWORK = 24,
        SO_SECURITY_ENCRYPTION_TRANSPORT = 23,
        SO_SELECT_ERR_QUEUE = 45,
        SO_SNDBUF = 7,
        SO_SNDBUFFORCE = 32,
        SO_SNDLOWAT = 19,
        SO_SNDTIMEO = 21,
        SO_TIMESTAMP = 29,
        SO_TIMESTAMPING = 37,
        SO_TIMESTAMPNS = 35,
        SO_TYPE = 3,
        SO_WIFI_STATUS = 41,
    }
    [System.CLSCompliantAttribute(false)]
    public enum UnixSocketProtocol
    {
        IPPROTO_AH = 51,
        IPPROTO_BEETPH = 94,
        IPPROTO_COMP = 108,
        IPPROTO_DCCP = 33,
        IPPROTO_EGP = 8,
        IPPROTO_ENCAP = 98,
        IPPROTO_ESP = 50,
        IPPROTO_GRE = 47,
        IPPROTO_ICMP = 1,
        IPPROTO_IDP = 22,
        IPPROTO_IGMP = 2,
        IPPROTO_IP = 1024,
        IPPROTO_IPIP = 4,
        IPPROTO_IPV6 = 41,
        IPPROTO_MTP = 92,
        IPPROTO_PIM = 103,
        IPPROTO_PUP = 12,
        IPPROTO_RAW = 255,
        IPPROTO_RSVP = 46,
        IPPROTO_SCTP = 132,
        IPPROTO_TCP = 6,
        IPPROTO_TP = 29,
        IPPROTO_UDP = 17,
        IPPROTO_UDPLITE = 136,
        SOL_SOCKET = 2048,
    }
    [System.CLSCompliantAttribute(false)]
    public enum UnixSocketType
    {
        SOCK_DCCP = 6,
        SOCK_DGRAM = 2,
        SOCK_PACKET = 10,
        SOCK_RAW = 3,
        SOCK_RDM = 4,
        SOCK_SEQPACKET = 5,
        SOCK_STREAM = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Utimbuf : System.IEquatable<Mono.Unix.Native.Utimbuf>
    {
        public long actime;
        public long modtime;
        public bool Equals(Mono.Unix.Native.Utimbuf value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Utimbuf lhs, Mono.Unix.Native.Utimbuf rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Utimbuf lhs, Mono.Unix.Native.Utimbuf rhs) { throw null; }
    }
    public sealed partial class Utsname : System.IEquatable<Mono.Unix.Native.Utsname>
    {
        public string domainname;
        public string machine;
        public string nodename;
        public string release;
        public string sysname;
        public string version;
        public Utsname() { }
        public bool Equals(Mono.Unix.Native.Utsname value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Unix.Native.Utsname lhs, Mono.Unix.Native.Utsname rhs) { throw null; }
        public static bool operator !=(Mono.Unix.Native.Utsname lhs, Mono.Unix.Native.Utsname rhs) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum WaitOptions
    {
        WNOHANG = 1,
        WUNTRACED = 2,
    }
    [System.CLSCompliantAttribute(false)]
    [System.FlagsAttribute]
    public enum XattrFlags
    {
        XATTR_AUTO = 0,
        XATTR_CREATE = 1,
        XATTR_REPLACE = 2,
    }
}
