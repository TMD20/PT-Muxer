// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Reflection.AssemblyVersionAttribute("0.0.0.0")]
[assembly:System.CLSCompliantAttribute(false)]

namespace CoreFoundation
{
    public partial class CFException : System.Exception
    {
        public CFException(string description, Foundation.NSString domain, System.nint code, string failureReason, string recoverySuggestion) { }
        public System.nint Code { get { throw null; } }
        public Foundation.NSString Domain { get { throw null; } }
        public string FailureReason { get { throw null; } }
        public string RecoverySuggestion { get { throw null; } }
        public static CoreFoundation.CFException FromCFError(System.IntPtr cfErrorHandle) { throw null; }
        public static CoreFoundation.CFException FromCFError(System.IntPtr cfErrorHandle, bool release) { throw null; }
    }
    public static partial class CFNetwork
    {
        public static Foundation.NSString ErrorDomain { get { throw null; } }
        public static System.Net.IWebProxy GetDefaultProxy() { throw null; }
        public static CoreFoundation.CFProxySettings GetSystemProxySettings() { throw null; }
    }
    public enum CFNetworkErrors
    {
        AppTransportSecurityRequiresSecureConnection = -1022,
        BackgroundSessionInUseByAnotherProcess = -996,
        BackgroundSessionWasDisconnected = -997,
        BadServerResponse = -1011,
        BadURL = -1000,
        CallIsActive = -1019,
        Cancelled = -999,
        CannotCloseFile = -3002,
        CannotConnectToHost = -1004,
        CannotCreateFile = -3000,
        CannotDecodeContentData = -1016,
        CannotDecodeRawData = -1015,
        CannotFindHost = -1003,
        CannotLoadFromNetwork = -2000,
        CannotMoveFile = -3005,
        CannotOpenFile = -3001,
        CannotParseCookieFile = -4000,
        CannotParseResponse = -1017,
        CannotRemoveFile = -3004,
        CannotWriteToFile = -3003,
        ClientCertificateRejected = -1205,
        ClientCertificateRequired = -1206,
        DataLengthExceedsMaximum = -1103,
        DataNotAllowed = -1020,
        DNSLookupFailed = -1006,
        DownloadDecodingFailedMidStream = -3006,
        DownloadDecodingFailedToComplete = -3007,
        FileDoesNotExist = -1100,
        FileIsDirectory = -1101,
        FileOutsideSafeArea = -1104,
        FtpUnexpectedStatusCode = 200,
        HostNotFound = 1,
        HostUnknown = 2,
        HttpAuthenticationTypeUnsupported = 300,
        HttpBadCredentials = 301,
        HttpBadProxyCredentials = 307,
        HttpBadURL = 305,
        HttpConnectionLost = 302,
        HttpParseFailure = 303,
        HttpProxyConnectionFailure = 306,
        HttpRedirectionLoopDetected = 304,
        HttpsProxyConnectionFailure = 310,
        HttpsProxyFailureUnexpectedResponseToConnectMethod = 311,
        HTTPTooManyRedirects = -1007,
        InternationalRoamingOff = -1018,
        NetServiceBadArgument = -72004,
        NetServiceCancel = -72005,
        NetServiceCollision = -72001,
        NetServiceDnsServiceFailure = -73000,
        NetServiceInProgress = -72003,
        NetServiceInvalid = -72006,
        NetServiceNotFound = -72002,
        NetServiceTimeout = -72007,
        NetServiceUnknown = -72000,
        NetworkConnectionLost = -1005,
        NoPermissionsToReadFile = -1102,
        NotConnectedToInternet = -1009,
        PacFileAuth = 309,
        PacFileError = 308,
        RedirectToNonExistentLocation = -1010,
        RequestBodyStreamExhausted = -1021,
        ResourceUnavailable = -1008,
        SecureConnectionFailed = -1200,
        ServerCertificateHasBadDate = -1201,
        ServerCertificateHasUnknownRoot = -1203,
        ServerCertificateNotYetValid = -1204,
        ServerCertificateUntrusted = -1202,
        Socks4IdConflict = 112,
        Socks4IdentdFailed = 111,
        Socks4RequestFailed = 110,
        Socks4UnknownStatusCode = 113,
        Socks5BadCredentials = 122,
        Socks5BadResponseAddr = 121,
        Socks5BadState = 120,
        Socks5NoAcceptableMethod = 124,
        Socks5UnsupportedNegotiationMethod = 123,
        SocksUnknownClientVersion = 100,
        SocksUnsupportedServerVersion = 101,
        TimedOut = -1001,
        Unknown = -998,
        UnsupportedURL = -1002,
        UserAuthenticationRequired = -1013,
        UserCancelledAuthentication = -1012,
        ZeroByteResource = -1014,
    }
    public partial class CFProxySettings
    {
        internal CFProxySettings() { }
        public Foundation.NSDictionary Dictionary { get { throw null; } }
        public bool HTTPEnable { get { throw null; } }
        public int HTTPPort { get { throw null; } }
        public string HTTPProxy { get { throw null; } }
        public bool ProxyAutoConfigEnable { get { throw null; } }
        public string ProxyAutoConfigJavaScript { get { throw null; } }
        public string ProxyAutoConfigURLString { get { throw null; } }
    }
    public partial class CFReadStream : CoreFoundation.CFStream
    {
        public CFReadStream(System.IntPtr handle) : base (default(System.IntPtr)) { }
        protected override void DoClose() { }
        protected override System.IntPtr DoGetProperty(Foundation.NSString name) { throw null; }
        protected override bool DoOpen() { throw null; }
        protected override bool DoSetProperty(Foundation.NSString name, ObjCRuntime.INativeObject value) { throw null; }
        public override CoreFoundation.CFException GetError() { throw null; }
        public bool HasBytesAvailable() { throw null; }
        public System.nint Read(byte[] buffer) { throw null; }
        public System.nint Read(byte[] buffer, int offset, int count) { throw null; }
        protected override void ScheduleWithRunLoop(CoreFoundation.CFRunLoop loop, Foundation.NSString mode) { }
        protected override void UnscheduleFromRunLoop(CoreFoundation.CFRunLoop loop, Foundation.NSString mode) { }
    }
    public partial class CFRunLoop : ObjCRuntime.INativeObject, System.IDisposable
    {
        internal CFRunLoop() { }
        public static CoreFoundation.CFRunLoop Current { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public bool IsWaiting { get { throw null; } }
        public static CoreFoundation.CFRunLoop Main { get { throw null; } }
        public static Foundation.NSString ModeCommon { get { throw null; } }
        public static Foundation.NSString ModeDefault { get { throw null; } }
        public void AddSource(CoreFoundation.CFRunLoopSource source, Foundation.NSString mode) { }
        public bool ContainsSource(CoreFoundation.CFRunLoopSource source, Foundation.NSString mode) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public override bool Equals(object other) { throw null; }
        ~CFRunLoop() { }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(CoreFoundation.CFRunLoop a, CoreFoundation.CFRunLoop b) { throw null; }
        public static bool operator !=(CoreFoundation.CFRunLoop a, CoreFoundation.CFRunLoop b) { throw null; }
        public void RemoveSource(CoreFoundation.CFRunLoopSource source, Foundation.NSString mode) { }
        public void Run() { }
        public void Stop() { }
        public void WakeUp() { }
    }
    public partial class CFRunLoopSource : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CFRunLoopSource(System.IntPtr handle) { }
        public CFRunLoopSource(System.IntPtr handle, bool ownsHandle) { }
        public System.IntPtr Handle { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public System.nint Order { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CFRunLoopSource() { }
        public void Invalidate() { }
        public void Signal() { }
    }
    public abstract partial class CFStream : ObjCRuntime.INativeObject, System.IDisposable
    {
        protected CFStream(System.IntPtr handle) { }
        public System.IntPtr Handle { get { throw null; } }
        public event System.EventHandler<CoreFoundation.CFStream.StreamEventArgs> CanAcceptBytesEvent { add { } remove { } }
        public event System.EventHandler<CoreFoundation.CFStream.StreamEventArgs> ClosedEvent { add { } remove { } }
        public event System.EventHandler<CoreFoundation.CFStream.StreamEventArgs> ErrorEvent { add { } remove { } }
        public event System.EventHandler<CoreFoundation.CFStream.StreamEventArgs> HasBytesAvailableEvent { add { } remove { } }
        public event System.EventHandler<CoreFoundation.CFStream.StreamEventArgs> OpenCompletedEvent { add { } remove { } }
        protected void CheckError() { }
        protected void CheckHandle() { }
        public void Close() { }
        public static CoreServices.CFHTTPStream CreateForHTTPRequest(CoreServices.CFHTTPMessage request) { throw null; }
        public static CoreServices.CFHTTPStream CreateForStreamedHTTPRequest(CoreServices.CFHTTPMessage request, CoreFoundation.CFReadStream body) { throw null; }
        public static CoreServices.CFHTTPStream CreateForStreamedHTTPRequest(CoreServices.CFHTTPMessage request, Foundation.NSInputStream body) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected abstract void DoClose();
        protected abstract System.IntPtr DoGetProperty(Foundation.NSString name);
        protected abstract bool DoOpen();
        protected abstract bool DoSetProperty(Foundation.NSString name, ObjCRuntime.INativeObject value);
        public void EnableEvents(CoreFoundation.CFRunLoop runLoop, Foundation.NSString runLoopMode) { }
        ~CFStream() { }
        public abstract CoreFoundation.CFException GetError();
        protected virtual void OnCallback(CoreFoundation.CFStreamEventType type) { }
        protected virtual void OnCanAcceptBytesEvent(CoreFoundation.CFStream.StreamEventArgs args) { }
        protected virtual void OnClosedEvent(CoreFoundation.CFStream.StreamEventArgs args) { }
        protected virtual void OnErrorEvent(CoreFoundation.CFStream.StreamEventArgs args) { }
        protected virtual void OnHasBytesAvailableEvent(CoreFoundation.CFStream.StreamEventArgs args) { }
        protected virtual void OnOpenCompleted(CoreFoundation.CFStream.StreamEventArgs args) { }
        public void Open() { }
        protected abstract void ScheduleWithRunLoop(CoreFoundation.CFRunLoop loop, Foundation.NSString mode);
        protected abstract void UnscheduleFromRunLoop(CoreFoundation.CFRunLoop loop, Foundation.NSString mode);
        public partial class StreamEventArgs : System.EventArgs
        {
            public StreamEventArgs(CoreFoundation.CFStreamEventType type) { }
            public CoreFoundation.CFStreamEventType EventType { get { throw null; } }
            public override string ToString() { throw null; }
        }
    }
    public enum CFStreamEventType : ulong
    {
        CanAcceptBytes = (ulong)4,
        EndEncountered = (ulong)16,
        ErrorOccurred = (ulong)8,
        HasBytesAvailable = (ulong)2,
        None = (ulong)0,
        OpenCompleted = (ulong)1,
    }
}
namespace CoreGraphics
{
    public partial struct CGAffineTransform
    {
        public System.nfloat x0;
        public System.nfloat xx;
        public System.nfloat xy;
        public System.nfloat y0;
        public System.nfloat yx;
        public System.nfloat yy;
        public CGAffineTransform(System.nfloat xx, System.nfloat yx, System.nfloat xy, System.nfloat yy, System.nfloat x0, System.nfloat y0) { throw null; }
        public bool IsIdentity { get { throw null; } }
        public static CoreGraphics.CGAffineTransform CGAffineTransformInvert(CoreGraphics.CGAffineTransform t) { throw null; }
        public static CoreGraphics.CGRect CGRectApplyAffineTransform(CoreGraphics.CGRect rect, CoreGraphics.CGAffineTransform t) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public CoreGraphics.CGAffineTransform Invert() { throw null; }
        public static CoreGraphics.CGAffineTransform MakeIdentity() { throw null; }
        public static CoreGraphics.CGAffineTransform MakeRotation(System.nfloat angle) { throw null; }
        public static CoreGraphics.CGAffineTransform MakeScale(System.nfloat sx, System.nfloat sy) { throw null; }
        public static CoreGraphics.CGAffineTransform MakeTranslation(System.nfloat tx, System.nfloat ty) { throw null; }
        public void Multiply(CoreGraphics.CGAffineTransform b) { }
        public static CoreGraphics.CGAffineTransform Multiply(CoreGraphics.CGAffineTransform a, CoreGraphics.CGAffineTransform b) { throw null; }
        public static bool operator ==(CoreGraphics.CGAffineTransform lhs, CoreGraphics.CGAffineTransform rhs) { throw null; }
        public static bool operator !=(CoreGraphics.CGAffineTransform lhs, CoreGraphics.CGAffineTransform rhs) { throw null; }
        public static CoreGraphics.CGAffineTransform operator *(CoreGraphics.CGAffineTransform a, CoreGraphics.CGAffineTransform b) { throw null; }
        public static CoreGraphics.CGAffineTransform Rotate(CoreGraphics.CGAffineTransform transform, System.nfloat angle) { throw null; }
        public void Rotate(System.nfloat angle) { }
        public static CoreGraphics.CGAffineTransform Scale(CoreGraphics.CGAffineTransform transform, System.nfloat sx, System.nfloat sy) { throw null; }
        public void Scale(System.nfloat sx, System.nfloat sy) { }
        public override string ToString() { throw null; }
        public CoreGraphics.CGPoint TransformPoint(CoreGraphics.CGPoint point) { throw null; }
        public CoreGraphics.CGRect TransformRect(CoreGraphics.CGRect rect) { throw null; }
        public CoreGraphics.CGSize TransformSize(CoreGraphics.CGSize size) { throw null; }
        public static CoreGraphics.CGAffineTransform Translate(CoreGraphics.CGAffineTransform transform, System.nfloat tx, System.nfloat ty) { throw null; }
        public void Translate(System.nfloat tx, System.nfloat ty) { }
    }
    public partial class CGBitmapContext : CoreGraphics.CGContext
    {
        public CGBitmapContext(byte[] data, System.nint width, System.nint height, System.nint bitsPerComponent, System.nint bytesPerRow, CoreGraphics.CGColorSpace colorSpace, CoreGraphics.CGBitmapFlags bitmapInfo) : base (default(System.IntPtr)) { }
        public CGBitmapContext(byte[] data, System.nint width, System.nint height, System.nint bitsPerComponent, System.nint bytesPerRow, CoreGraphics.CGColorSpace colorSpace, CoreGraphics.CGImageAlphaInfo bitmapInfo) : base (default(System.IntPtr)) { }
        public CGBitmapContext(System.IntPtr data, System.nint width, System.nint height, System.nint bitsPerComponent, System.nint bytesPerRow, CoreGraphics.CGColorSpace colorSpace, CoreGraphics.CGBitmapFlags bitmapInfo) : base (default(System.IntPtr)) { }
        public CGBitmapContext(System.IntPtr data, System.nint width, System.nint height, System.nint bitsPerComponent, System.nint bytesPerRow, CoreGraphics.CGColorSpace colorSpace, CoreGraphics.CGImageAlphaInfo bitmapInfo) : base (default(System.IntPtr)) { }
        public CoreGraphics.CGImageAlphaInfo AlphaInfo { get { throw null; } }
        public CoreGraphics.CGBitmapFlags BitmapInfo { get { throw null; } }
        public System.nint BitsPerComponent { get { throw null; } }
        public System.nint BitsPerPixel { get { throw null; } }
        public System.nint BytesPerRow { get { throw null; } }
        public CoreGraphics.CGColorSpace ColorSpace { get { throw null; } }
        public System.IntPtr Data { get { throw null; } }
        public System.nint Height { get { throw null; } }
        public System.nint Width { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public CoreGraphics.CGImage ToImage() { throw null; }
    }
    public enum CGBitmapFlags : uint
    {
        AlphaInfoMask = (uint)31,
        ByteOrder16Big = (uint)12288,
        ByteOrder16Little = (uint)4096,
        ByteOrder32Big = (uint)16384,
        ByteOrder32Little = (uint)8192,
        ByteOrderDefault = (uint)0,
        ByteOrderMask = (uint)28672,
        First = (uint)4,
        FloatComponents = (uint)256,
        FloatInfoMask = (uint)3840,
        Last = (uint)3,
        None = (uint)0,
        NoneSkipFirst = (uint)6,
        NoneSkipLast = (uint)5,
        Only = (uint)7,
        PremultipliedFirst = (uint)2,
        PremultipliedLast = (uint)1,
    }
    public enum CGBlendMode
    {
        Clear = 16,
        Color = 14,
        ColorBurn = 7,
        ColorDodge = 6,
        Copy = 17,
        Darken = 4,
        DestinationAtop = 24,
        DestinationIn = 22,
        DestinationOut = 23,
        DestinationOver = 21,
        Difference = 10,
        Exclusion = 11,
        HardLight = 9,
        Hue = 12,
        Lighten = 5,
        Luminosity = 15,
        Multiply = 1,
        Normal = 0,
        Overlay = 3,
        PlusDarker = 26,
        PlusLighter = 27,
        Saturation = 13,
        Screen = 2,
        SoftLight = 8,
        SourceAtop = 20,
        SourceIn = 18,
        SourceOut = 19,
        XOR = 25,
    }
    public partial class CGColor : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGColor(CoreGraphics.CGColor source, System.nfloat alpha) { }
        public CGColor(CoreGraphics.CGColorSpace colorspace, CoreGraphics.CGPattern pattern, System.nfloat[] components) { }
        public CGColor(CoreGraphics.CGColorSpace colorspace, System.nfloat[] components) { }
        public CGColor(System.IntPtr handle) { }
        public CGColor(System.nfloat gray, System.nfloat alpha) { }
        public CGColor(System.nfloat red, System.nfloat green, System.nfloat blue) { }
        public CGColor(System.nfloat red, System.nfloat green, System.nfloat blue, System.nfloat alpha) { }
        public CGColor(string name) { }
        public System.nfloat Alpha { get { throw null; } }
        public CoreGraphics.CGColorSpace ColorSpace { get { throw null; } }
        public System.nfloat[] Components { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public System.nint NumberOfComponents { get { throw null; } }
        public CoreGraphics.CGPattern Pattern { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public override bool Equals(object o) { throw null; }
        ~CGColor() { }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(CoreGraphics.CGColor color1, CoreGraphics.CGColor color2) { throw null; }
        public static bool operator !=(CoreGraphics.CGColor color1, CoreGraphics.CGColor color2) { throw null; }
    }
    public enum CGColorRenderingIntent
    {
        AbsoluteColorimetric = 1,
        Default = 0,
        Perceptual = 3,
        RelativeColorimetric = 2,
        Saturation = 4,
    }
    public partial class CGColorSpace : ObjCRuntime.INativeObject, System.IDisposable
    {
        public static readonly CoreGraphics.CGColorSpace Null;
        public CGColorSpace(System.IntPtr handle) { }
        public System.nint Components { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public bool IsWideGamutRgb { get { throw null; } }
        public CoreGraphics.CGColorSpaceModel Model { get { throw null; } }
        public string Name { get { throw null; } }
        public bool SupportsOutput { get { throw null; } }
        public static CoreGraphics.CGColorSpace CreateAcesCGLinear() { throw null; }
        public static CoreGraphics.CGColorSpace CreateAdobeRgb1988() { throw null; }
        public static CoreGraphics.CGColorSpace CreateCalibratedGray(System.nfloat[] whitepoint, System.nfloat[] blackpoint, System.nfloat gamma) { throw null; }
        public static CoreGraphics.CGColorSpace CreateCalibratedRGB(System.nfloat[] whitepoint, System.nfloat[] blackpoint, System.nfloat[] gamma, System.nfloat[] matrix) { throw null; }
        public static CoreGraphics.CGColorSpace CreateDeviceCmyk() { throw null; }
        public static CoreGraphics.CGColorSpace CreateDeviceCMYK() { throw null; }
        public static CoreGraphics.CGColorSpace CreateDeviceGray() { throw null; }
        public static CoreGraphics.CGColorSpace CreateDeviceRGB() { throw null; }
        public static CoreGraphics.CGColorSpace CreateGenericCmyk() { throw null; }
        public static CoreGraphics.CGColorSpace CreateGenericGray() { throw null; }
        public static CoreGraphics.CGColorSpace CreateGenericGrayGamma2_2() { throw null; }
        public static CoreGraphics.CGColorSpace CreateGenericRgb() { throw null; }
        public static CoreGraphics.CGColorSpace CreateGenericRgbLinear() { throw null; }
        public static CoreGraphics.CGColorSpace CreateGenericXyz() { throw null; }
        public static CoreGraphics.CGColorSpace CreateIccData(CoreGraphics.CGDataProvider provider) { throw null; }
        public static CoreGraphics.CGColorSpace CreateIccData(Foundation.NSData data) { throw null; }
        public static CoreGraphics.CGColorSpace CreateICCProfile(Foundation.NSData data) { throw null; }
        public static CoreGraphics.CGColorSpace CreateICCProfile(System.nfloat[] range, CoreGraphics.CGDataProvider profile, CoreGraphics.CGColorSpace alternate) { throw null; }
        public static CoreGraphics.CGColorSpace CreateIndexed(CoreGraphics.CGColorSpace baseSpace, int lastIndex, byte[] colorTable) { throw null; }
        public static CoreGraphics.CGColorSpace CreateItuR_2020() { throw null; }
        public static CoreGraphics.CGColorSpace CreateItuR_709() { throw null; }
        public static CoreGraphics.CGColorSpace CreateLab(System.nfloat[] whitepoint, System.nfloat[] blackpoint, System.nfloat[] range) { throw null; }
        public static CoreGraphics.CGColorSpace CreatePattern(CoreGraphics.CGColorSpace baseSpace) { throw null; }
        public static CoreGraphics.CGColorSpace CreateRommRgb() { throw null; }
        public static CoreGraphics.CGColorSpace CreateSrgb() { throw null; }
        public static CoreGraphics.CGColorSpace CreateWithName(string name) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGColorSpace() { }
        public CoreGraphics.CGColorSpace GetBaseColorSpace() { throw null; }
        public byte[] GetColorTable() { throw null; }
        public Foundation.NSData GetIccData() { throw null; }
        public Foundation.NSData GetICCProfile() { throw null; }
    }
    public enum CGColorSpaceModel
    {
        CMYK = 2,
        DeviceN = 4,
        Indexed = 5,
        Lab = 3,
        Monochrome = 0,
        Pattern = 6,
        RGB = 1,
        Unknown = -1,
        Xyz = 7,
    }
    public partial class CGContext : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGContext(System.IntPtr handle) { }
        public System.IntPtr Handle { get { throw null; } }
        public CoreGraphics.CGInterpolationQuality InterpolationQuality { get { throw null; } set { } }
        public CoreGraphics.CGAffineTransform TextMatrix { get { throw null; } set { } }
        public CoreGraphics.CGPoint TextPosition { get { throw null; } set { } }
        public void AddArc(System.nfloat x, System.nfloat y, System.nfloat radius, System.nfloat startAngle, System.nfloat endAngle, bool clockwise) { }
        public void AddArcToPoint(System.nfloat x1, System.nfloat y1, System.nfloat x2, System.nfloat y2, System.nfloat radius) { }
        public void AddCurveToPoint(System.nfloat cp1x, System.nfloat cp1y, System.nfloat cp2x, System.nfloat cp2y, System.nfloat x, System.nfloat y) { }
        public void AddEllipseInRect(CoreGraphics.CGRect rect) { }
        public void AddLines(CoreGraphics.CGPoint[] points) { }
        public void AddLineToPoint(System.nfloat x, System.nfloat y) { }
        public void AddPath(CoreGraphics.CGPath path) { }
        public void AddQuadCurveToPoint(System.nfloat cpx, System.nfloat cpy, System.nfloat x, System.nfloat y) { }
        public void AddRect(CoreGraphics.CGRect rect) { }
        public void AddRects(CoreGraphics.CGRect[] rects) { }
        public CoreGraphics.CGBitmapContext AsBitmapContext() { throw null; }
        public void BeginPage(System.Nullable<CoreGraphics.CGRect> rect) { }
        public void BeginPath() { }
        public void BeginTransparencyLayer(CoreGraphics.CGRect rectangle, Foundation.NSDictionary auxiliaryInfo = null) { }
        public void BeginTransparencyLayer(Foundation.NSDictionary auxiliaryInfo = null) { }
        public void ClearRect(CoreGraphics.CGRect rect) { }
        public void Clip() { }
        public void ClipToMask(CoreGraphics.CGRect rect, CoreGraphics.CGImage mask) { }
        public void ClipToRect(CoreGraphics.CGRect rect) { }
        public void ClipToRects(CoreGraphics.CGRect[] rects) { }
        public void ClosePath() { }
        public void ConcatCTM(CoreGraphics.CGAffineTransform transform) { }
        public void ContextFillRects(CoreGraphics.CGRect[] rects) { }
        public CoreGraphics.CGPoint ConvertPointToUserSpace(CoreGraphics.CGPoint point) { throw null; }
        public CoreGraphics.CGRect ConvertRectToDeviceSpace(CoreGraphics.CGRect rect) { throw null; }
        public CoreGraphics.CGRect ConvertRectToUserSpace(CoreGraphics.CGRect rect) { throw null; }
        public CoreGraphics.CGSize ConvertSizeToDeviceSpace(CoreGraphics.CGSize size) { throw null; }
        public CoreGraphics.CGSize ConvertSizeToUserSpace(CoreGraphics.CGSize size) { throw null; }
        public CoreGraphics.CGPath CopyPath() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void DrawImage(CoreGraphics.CGRect rect, CoreGraphics.CGImage image) { }
        public void DrawPath(CoreGraphics.CGPathDrawingMode mode) { }
        public void DrawPDFPage(CoreGraphics.CGPDFPage page) { }
        public void DrawShading(CoreGraphics.CGShading shading) { }
        public void DrawTiledImage(CoreGraphics.CGRect rect, CoreGraphics.CGImage image) { }
        public void EndPage() { }
        public void EndTransparencyLayer() { }
        public void EOClip() { }
        public void EOFillPath() { }
        public void FillEllipseInRect(CoreGraphics.CGRect rect) { }
        public void FillPath() { }
        public void FillRect(CoreGraphics.CGRect rect) { }
        ~CGContext() { }
        public void Flush() { }
        public CoreGraphics.CGRect GetClipBoundingBox() { throw null; }
        public CoreGraphics.CGAffineTransform GetCTM() { throw null; }
        public CoreGraphics.CGRect GetPathBoundingBox() { throw null; }
        public CoreGraphics.CGPoint GetPathCurrentPoint() { throw null; }
        public CoreGraphics.CGAffineTransform GetUserSpaceToDeviceSpaceTransform() { throw null; }
        public bool IsPathEmpty() { throw null; }
        public void MoveTo(System.nfloat x, System.nfloat y) { }
        public bool PathContainsPoint(CoreGraphics.CGPoint point, CoreGraphics.CGPathDrawingMode mode) { throw null; }
        public CoreGraphics.CGPoint PointToDeviceSpace(CoreGraphics.CGPoint point) { throw null; }
        public void ReplacePathWithStrokedPath() { }
        public void ResetClip() { }
        public void RestoreState() { }
        public void RotateCTM(System.nfloat angle) { }
        public void SaveState() { }
        public void ScaleCTM(System.nfloat sx, System.nfloat sy) { }
        public void SetAllowsAntialiasing(bool allowsAntialiasing) { }
        public void SetAllowsFontSmoothing(bool allows) { }
        public void SetAllowsFontSubpixelQuantization(bool allows) { }
        public void SetAllowsSubpixelPositioning(bool allows) { }
        public void SetAlpha(System.nfloat alpha) { }
        public void SetBlendMode(CoreGraphics.CGBlendMode mode) { }
        public void SetCharacterSpacing(System.nfloat spacing) { }
        public void SetFillColor(CoreGraphics.CGColor color) { }
        public void SetFillColor(System.nfloat gray, System.nfloat alpha) { }
        public void SetFillColor(System.nfloat red, System.nfloat green, System.nfloat blue, System.nfloat alpha) { }
        public void SetFillColor(System.nfloat cyan, System.nfloat magenta, System.nfloat yellow, System.nfloat black, System.nfloat alpha) { }
        public void SetFillColor(System.nfloat[] components) { }
        public void SetFillColorSpace(CoreGraphics.CGColorSpace space) { }
        public void SetFillPattern(CoreGraphics.CGPattern pattern, System.nfloat[] components) { }
        public void SetFlatness(System.nfloat flatness) { }
        public void SetFont(CoreGraphics.CGFont font) { }
        public void SetFontSize(System.nfloat size) { }
        public void SetLineCap(CoreGraphics.CGLineCap cap) { }
        public void SetLineDash(System.nfloat phase, System.nfloat[] lengths) { }
        public void SetLineDash(System.nfloat phase, System.nfloat[] lengths, int n) { }
        public void SetLineWidth(System.nfloat w) { }
        public void SetMiterLimit(System.nfloat limit) { }
        public void SetPatternPhase(CoreGraphics.CGSize phase) { }
        public void SetRenderingIntent(CoreGraphics.CGColorRenderingIntent intent) { }
        public void SetShadow(CoreGraphics.CGSize offset, System.nfloat blur, CoreGraphics.CGColor color = null) { }
        public void SetShouldAntialias(bool shouldAntialias) { }
        public void SetShouldSmoothFonts(bool shouldSmoothFonts) { }
        public void SetShouldSubpixelPositionFonts(bool shouldSubpixelPositionFonts) { }
        public void SetStrokeColor(CoreGraphics.CGColor color) { }
        public void SetStrokeColor(System.nfloat gray, System.nfloat alpha) { }
        public void SetStrokeColor(System.nfloat red, System.nfloat green, System.nfloat blue, System.nfloat alpha) { }
        public void SetStrokeColor(System.nfloat cyan, System.nfloat magenta, System.nfloat yellow, System.nfloat black, System.nfloat alpha) { }
        public void SetStrokeColor(System.nfloat[] components) { }
        public void SetStrokeColorSpace(CoreGraphics.CGColorSpace space) { }
        public void SetStrokePattern(CoreGraphics.CGPattern pattern, System.nfloat[] components) { }
        public void ShouldSubpixelQuantizeFonts(bool shouldSubpixelQuantizeFonts) { }
        public void ShowGlyphs(ushort[] glyphs) { }
        public void ShowGlyphs(ushort[] glyphs, int count) { }
        public void ShowGlyphsAtPoint(System.nfloat x, System.nfloat y, ushort[] glyphs) { }
        public void ShowGlyphsAtPoint(System.nfloat x, System.nfloat y, ushort[] glyphs, int count) { }
        public void ShowGlyphsAtPositions(ushort[] glyphs, CoreGraphics.CGPoint[] positions, int count = -1) { }
        public void ShowGlyphsWithAdvances(ushort[] glyphs, CoreGraphics.CGSize[] advances, int count) { }
        public void ShowText(byte[] bytes) { }
        public void ShowText(byte[] bytes, int count) { }
        public void ShowText(string str) { }
        public void ShowText(string str, int count) { }
        public void ShowTextAtPoint(System.nfloat x, System.nfloat y, byte[] bytes) { }
        public void ShowTextAtPoint(System.nfloat x, System.nfloat y, byte[] bytes, int length) { }
        public void ShowTextAtPoint(System.nfloat x, System.nfloat y, string str) { }
        public void ShowTextAtPoint(System.nfloat x, System.nfloat y, string str, int length) { }
        public void StrokeEllipseInRect(CoreGraphics.CGRect rect) { }
        public void StrokeLineSegments(CoreGraphics.CGPoint[] points) { }
        public void StrokePath() { }
        public void StrokeRect(CoreGraphics.CGRect rect) { }
        public void StrokeRectWithWidth(CoreGraphics.CGRect rect, System.nfloat width) { }
        public void Synchronize() { }
        public void TranslateCTM(System.nfloat tx, System.nfloat ty) { }
    }
    public partial class CGContextPDF : CoreGraphics.CGContext
    {
        public CGContextPDF(CoreGraphics.CGDataConsumer dataConsumer) : base (default(System.IntPtr)) { }
        public CGContextPDF(CoreGraphics.CGDataConsumer dataConsumer, CoreGraphics.CGRect mediaBox) : base (default(System.IntPtr)) { }
        public CGContextPDF(Foundation.NSUrl url) : base (default(System.IntPtr)) { }
        public CGContextPDF(Foundation.NSUrl url, CoreGraphics.CGRect mediaBox) : base (default(System.IntPtr)) { }
        public void AddDestination(string name, CoreGraphics.CGPoint point) { }
        public void AddDocumentMetadata(Foundation.NSData data) { }
        public void BeginPage(CoreGraphics.CGPDFPageInfo info) { }
        public void Close() { }
        protected override void Dispose(bool disposing) { }
        public new void EndPage() { }
        public void SetDestination(string name, CoreGraphics.CGRect rect) { }
        public void SetUrl(Foundation.NSUrl url, CoreGraphics.CGRect region) { }
    }
    public partial class CGDataConsumer : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGDataConsumer(Foundation.NSMutableData data) { }
        public CGDataConsumer(Foundation.NSUrl url) { }
        public CGDataConsumer(System.IntPtr handle) { }
        public System.IntPtr Handle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGDataConsumer() { }
    }
    public partial class CGDataProvider : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGDataProvider(Foundation.NSData data) { }
        public CGDataProvider(Foundation.NSUrl url) { }
        public CGDataProvider(byte[] buffer) { }
        public CGDataProvider(byte[] buffer, int offset, int count) { }
        public CGDataProvider(System.IntPtr handle) { }
        public CGDataProvider(System.IntPtr memoryBlock, int size) { }
        public CGDataProvider(System.IntPtr memoryBlock, int size, System.Action<System.IntPtr> releaseMemoryBlockCallback) { }
        public CGDataProvider(System.IntPtr memoryBlock, int size, bool ownBuffer) { }
        public CGDataProvider(string file) { }
        public System.IntPtr Handle { get { throw null; } }
        public Foundation.NSData CopyData() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGDataProvider() { }
        public static CoreGraphics.CGDataProvider FromFile(string file) { throw null; }
    }
    public partial class CGFont : ObjCRuntime.INativeObject, System.IDisposable
    {
        internal CGFont() { }
        public int Ascent { get { throw null; } }
        public int CapHeight { get { throw null; } }
        public int Descent { get { throw null; } }
        public CoreGraphics.CGRect FontBBox { get { throw null; } }
        public string FullName { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public System.nfloat ItalicAngle { get { throw null; } }
        public int Leading { get { throw null; } }
        public System.nint NumberOfGlyphs { get { throw null; } }
        public string PostScriptName { get { throw null; } }
        public System.nfloat StemV { get { throw null; } }
        public int UnitsPerEm { get { throw null; } }
        public int XHeight { get { throw null; } }
        public static CoreGraphics.CGFont CreateFromProvider(CoreGraphics.CGDataProvider provider) { throw null; }
        public static CoreGraphics.CGFont CreateWithFontName(string name) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGFont() { }
        public ushort GetGlyphWithGlyphName(string s) { throw null; }
        public static System.nint GetTypeID() { throw null; }
        public string GlyphNameForGlyph(ushort glyph) { throw null; }
        public CoreText.CTFont ToCTFont(System.nfloat size) { throw null; }
        public CoreText.CTFont ToCTFont(System.nfloat size, CoreGraphics.CGAffineTransform matrix) { throw null; }
    }
    public partial class CGFunction : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGFunction(System.nfloat[] domain, System.nfloat[] range, CoreGraphics.CGFunction.CGFunctionEvaluate callback) { }
        public CoreGraphics.CGFunction.CGFunctionEvaluate EvaluateFunction { get { throw null; } set { } }
        public System.IntPtr Handle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGFunction() { }
        public unsafe delegate void CGFunctionEvaluate(System.nfloat* data, System.nfloat* outData);
    }
    public partial class CGImage : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGImage(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, CoreGraphics.CGColorSpace colorSpace, CoreGraphics.CGBitmapFlags bitmapFlags, CoreGraphics.CGDataProvider provider, System.nfloat[] decode, bool shouldInterpolate, CoreGraphics.CGColorRenderingIntent intent) { }
        public CGImage(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, CoreGraphics.CGColorSpace colorSpace, CoreGraphics.CGImageAlphaInfo alphaInfo, CoreGraphics.CGDataProvider provider, System.nfloat[] decode, bool shouldInterpolate, CoreGraphics.CGColorRenderingIntent intent) { }
        public CGImage(System.IntPtr handle) { }
        public CoreGraphics.CGImageAlphaInfo AlphaInfo { get { throw null; } }
        public CoreGraphics.CGBitmapFlags BitmapInfo { get { throw null; } }
        public System.nint BitsPerComponent { get { throw null; } }
        public System.nint BitsPerPixel { get { throw null; } }
        public System.nint BytesPerRow { get { throw null; } }
        public CoreGraphics.CGColorSpace ColorSpace { get { throw null; } }
        public CoreGraphics.CGDataProvider DataProvider { get { throw null; } }
        public unsafe System.nfloat* Decode { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public System.nint Height { get { throw null; } }
        public bool IsMask { get { throw null; } }
        public CoreGraphics.CGColorRenderingIntent RenderingIntent { get { throw null; } }
        public static CoreGraphics.CGImage ScreenImage { get { throw null; } }
        public bool ShouldInterpolate { get { throw null; } }
        public Foundation.NSString UTType { get { throw null; } }
        public System.nint Width { get { throw null; } }
        public CoreGraphics.CGImage Clone() { throw null; }
        public static CoreGraphics.CGImage CreateMask(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, CoreGraphics.CGDataProvider provider, System.nfloat[] decode, bool shouldInterpolate) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGImage() { }
        public static CoreGraphics.CGImage FromJPEG(CoreGraphics.CGDataProvider provider, System.nfloat[] decode, bool shouldInterpolate, CoreGraphics.CGColorRenderingIntent intent) { throw null; }
        public static CoreGraphics.CGImage FromPNG(CoreGraphics.CGDataProvider provider, System.nfloat[] decode, bool shouldInterpolate, CoreGraphics.CGColorRenderingIntent intent) { throw null; }
        public CoreGraphics.CGImage WithColorSpace(CoreGraphics.CGColorSpace cs) { throw null; }
        public CoreGraphics.CGImage WithImageInRect(CoreGraphics.CGRect rect) { throw null; }
        public CoreGraphics.CGImage WithMask(CoreGraphics.CGImage mask) { throw null; }
        public CoreGraphics.CGImage WithMaskingColors(System.nfloat[] components) { throw null; }
    }
    public enum CGImageAlphaInfo : uint
    {
        First = (uint)4,
        Last = (uint)3,
        None = (uint)0,
        NoneSkipFirst = (uint)6,
        NoneSkipLast = (uint)5,
        Only = (uint)7,
        PremultipliedFirst = (uint)2,
        PremultipliedLast = (uint)1,
    }
    public partial class CGImageProperties
    {
        public CGImageProperties() { }
        public CGImageProperties(Foundation.NSDictionary dictionary) { }
        public System.Nullable<bool> Alpha { get { throw null; } set { } }
        public System.Nullable<int> Depth { get { throw null; } set { } }
        public System.Nullable<float> DPIHeightF { get { throw null; } set { } }
        public System.Nullable<float> DPIWidthF { get { throw null; } set { } }
        public System.Nullable<int> FileSize { get { throw null; } set { } }
        public System.Nullable<bool> IsFloat { get { throw null; } set { } }
        public System.Nullable<bool> IsIndexed { get { throw null; } set { } }
        public System.Nullable<int> PixelHeight { get { throw null; } set { } }
        public System.Nullable<int> PixelWidth { get { throw null; } set { } }
        public string ProfileName { get { throw null; } set { } }
    }
    public enum CGInterpolationQuality
    {
        Default = 0,
        High = 3,
        Low = 2,
        Medium = 4,
        None = 1,
    }
    public enum CGLineCap
    {
        Butt = 0,
        Round = 1,
        Square = 2,
    }
    public partial class CGPath : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGPath() { }
        public CGPath(CoreGraphics.CGPath basePath) { }
        public CGPath(CoreGraphics.CGPath reference, CoreGraphics.CGAffineTransform transform) { }
        public CGPath(System.IntPtr handle) { }
        public CoreGraphics.CGRect BoundingBox { get { throw null; } }
        public CoreGraphics.CGPoint CurrentPoint { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public CoreGraphics.CGRect PathBoundingBox { get { throw null; } }
        public void AddArc(CoreGraphics.CGAffineTransform m, System.nfloat x, System.nfloat y, System.nfloat radius, System.nfloat startAngle, System.nfloat endAngle, bool clockwise) { }
        public void AddArc(System.nfloat x, System.nfloat y, System.nfloat radius, System.nfloat startAngle, System.nfloat endAngle, bool clockwise) { }
        public void AddArcToPoint(CoreGraphics.CGAffineTransform m, System.nfloat x1, System.nfloat y1, System.nfloat x2, System.nfloat y2, System.nfloat radius) { }
        public void AddArcToPoint(System.nfloat x1, System.nfloat y1, System.nfloat x2, System.nfloat y2, System.nfloat radius) { }
        public void AddCurveToPoint(CoreGraphics.CGAffineTransform transform, CoreGraphics.CGPoint cp1, CoreGraphics.CGPoint cp2, CoreGraphics.CGPoint point) { }
        public void AddCurveToPoint(CoreGraphics.CGAffineTransform transform, System.nfloat cp1x, System.nfloat cp1y, System.nfloat cp2x, System.nfloat cp2y, System.nfloat x, System.nfloat y) { }
        public void AddCurveToPoint(CoreGraphics.CGPoint cp1, CoreGraphics.CGPoint cp2, CoreGraphics.CGPoint point) { }
        public void AddCurveToPoint(System.nfloat cp1x, System.nfloat cp1y, System.nfloat cp2x, System.nfloat cp2y, System.nfloat x, System.nfloat y) { }
        public void AddEllipseInRect(CoreGraphics.CGAffineTransform m, CoreGraphics.CGRect rect) { }
        public void AddEllipseInRect(CoreGraphics.CGRect rect) { }
        public void AddLines(CoreGraphics.CGAffineTransform m, CoreGraphics.CGPoint[] points) { }
        public void AddLines(CoreGraphics.CGAffineTransform m, CoreGraphics.CGPoint[] points, int count) { }
        public void AddLines(CoreGraphics.CGPoint[] points) { }
        public void AddLines(CoreGraphics.CGPoint[] points, int count) { }
        public void AddLineToPoint(CoreGraphics.CGAffineTransform transform, CoreGraphics.CGPoint point) { }
        public void AddLineToPoint(CoreGraphics.CGAffineTransform transform, System.nfloat x, System.nfloat y) { }
        public void AddLineToPoint(CoreGraphics.CGPoint point) { }
        public void AddLineToPoint(System.nfloat x, System.nfloat y) { }
        public void AddPath(CoreGraphics.CGAffineTransform t, CoreGraphics.CGPath path2) { }
        public void AddPath(CoreGraphics.CGPath path2) { }
        public void AddQuadCurveToPoint(CoreGraphics.CGAffineTransform transform, System.nfloat cpx, System.nfloat cpy, System.nfloat x, System.nfloat y) { }
        public void AddQuadCurveToPoint(System.nfloat cpx, System.nfloat cpy, System.nfloat x, System.nfloat y) { }
        public void AddRect(CoreGraphics.CGAffineTransform transform, CoreGraphics.CGRect rect) { }
        public void AddRect(CoreGraphics.CGRect rect) { }
        public void AddRects(CoreGraphics.CGAffineTransform m, CoreGraphics.CGRect[] rects) { }
        public void AddRects(CoreGraphics.CGAffineTransform m, CoreGraphics.CGRect[] rects, int count) { }
        public void AddRects(CoreGraphics.CGRect[] rects) { }
        public void AddRects(CoreGraphics.CGRect[] rects, int count) { }
        public void AddRelativeArc(CoreGraphics.CGAffineTransform m, System.nfloat x, System.nfloat y, System.nfloat radius, System.nfloat startAngle, System.nfloat delta) { }
        public void AddRelativeArc(System.nfloat x, System.nfloat y, System.nfloat radius, System.nfloat startAngle, System.nfloat delta) { }
        public void AddRoundedRect(CoreGraphics.CGAffineTransform transform, CoreGraphics.CGRect rect, System.nfloat cornerWidth, System.nfloat cornerHeight) { }
        public void AddRoundedRect(CoreGraphics.CGRect rect, System.nfloat cornerWidth, System.nfloat cornerHeight) { }
        public void CloseSubpath() { }
        public bool ContainsPoint(CoreGraphics.CGAffineTransform m, CoreGraphics.CGPoint point, bool eoFill) { throw null; }
        public bool ContainsPoint(CoreGraphics.CGPoint point, bool eoFill) { throw null; }
        public CoreGraphics.CGPath Copy() { throw null; }
        public CoreGraphics.CGPath CopyByDashingPath(CoreGraphics.CGAffineTransform transform, System.nfloat[] lengths) { throw null; }
        public CoreGraphics.CGPath CopyByDashingPath(CoreGraphics.CGAffineTransform transform, System.nfloat[] lengths, System.nfloat phase) { throw null; }
        public CoreGraphics.CGPath CopyByDashingPath(System.nfloat[] lengths) { throw null; }
        public CoreGraphics.CGPath CopyByDashingPath(System.nfloat[] lengths, System.nfloat phase) { throw null; }
        public CoreGraphics.CGPath CopyByTransformingPath(CoreGraphics.CGAffineTransform transform) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public static CoreGraphics.CGPath EllipseFromRect(CoreGraphics.CGRect boundingRect) { throw null; }
        public static CoreGraphics.CGPath EllipseFromRect(CoreGraphics.CGRect boundingRect, CoreGraphics.CGAffineTransform transform) { throw null; }
        public override bool Equals(object o) { throw null; }
        ~CGPath() { }
        public static CoreGraphics.CGPath FromRect(CoreGraphics.CGRect rectangle) { throw null; }
        public static CoreGraphics.CGPath FromRect(CoreGraphics.CGRect rectangle, CoreGraphics.CGAffineTransform transform) { throw null; }
        public static CoreGraphics.CGPath FromRoundedRect(CoreGraphics.CGRect rectangle, System.nfloat cornerWidth, System.nfloat cornerHeight) { throw null; }
        public static CoreGraphics.CGPath FromRoundedRect(CoreGraphics.CGRect rectangle, System.nfloat cornerWidth, System.nfloat cornerHeight, CoreGraphics.CGAffineTransform transform) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool IsRect(out CoreGraphics.CGRect rect) { throw null; }
        public void MoveToPoint(CoreGraphics.CGAffineTransform transform, CoreGraphics.CGPoint point) { }
        public void MoveToPoint(CoreGraphics.CGAffineTransform transform, System.nfloat x, System.nfloat y) { }
        public void MoveToPoint(CoreGraphics.CGPoint point) { }
        public void MoveToPoint(System.nfloat x, System.nfloat y) { }
        public static bool operator ==(CoreGraphics.CGPath path1, CoreGraphics.CGPath path2) { throw null; }
        public static bool operator !=(CoreGraphics.CGPath path1, CoreGraphics.CGPath path2) { throw null; }
    }
    public enum CGPathDrawingMode
    {
        EOFill = 1,
        EOFillStroke = 4,
        Fill = 0,
        FillStroke = 3,
        Stroke = 2,
    }
    public partial struct CGPathElement
    {
        public CoreGraphics.CGPoint Point1;
        public CoreGraphics.CGPoint Point2;
        public CoreGraphics.CGPoint Point3;
        public CoreGraphics.CGPathElementType Type;
        public CGPathElement(int t) { throw null; }
    }
    public enum CGPathElementType
    {
        AddCurveToPoint = 3,
        AddLineToPoint = 1,
        AddQuadCurveToPoint = 2,
        CloseSubpath = 4,
        MoveToPoint = 0,
    }
    public partial class CGPattern : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGPattern(System.IntPtr handle) { }
        public System.IntPtr Handle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGPattern() { }
    }
    public enum CGPatternTiling
    {
        ConstantSpacing = 2,
        ConstantSpacingMinimalDistortion = 1,
        NoDistortion = 0,
    }
    public enum CGPDFBox
    {
        Art = 4,
        Bleed = 2,
        Crop = 1,
        Media = 0,
        Trim = 3,
    }
    public partial class CGPDFDocument : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGPDFDocument(CoreGraphics.CGDataProvider provider) { }
        public CGPDFDocument(System.IntPtr handle) { }
        public bool AllowsCopying { get { throw null; } }
        public bool AllowsPrinting { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public bool IsEncrypted { get { throw null; } }
        public bool IsUnlocked { get { throw null; } }
        public System.nint Pages { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGPDFDocument() { }
        public static CoreGraphics.CGPDFDocument FromFile(string str) { throw null; }
        public static CoreGraphics.CGPDFDocument FromUrl(string str) { throw null; }
        public CoreGraphics.CGPDFPage GetPage(System.nint page) { throw null; }
        public void GetVersion(out int major, out int minor) { throw null; }
        public bool Unlock(string password) { throw null; }
    }
    public partial class CGPDFPage : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGPDFPage(System.IntPtr handle) { }
        public CoreGraphics.CGPDFDocument Document { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public System.nint PageNumber { get { throw null; } }
        public int RotationAngle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGPDFPage() { }
        public CoreGraphics.CGRect GetBoxRect(CoreGraphics.CGPDFBox box) { throw null; }
        public CoreGraphics.CGAffineTransform GetDrawingTransform(CoreGraphics.CGPDFBox box, CoreGraphics.CGRect rect, int rotate, bool preserveAspectRatio) { throw null; }
    }
    public partial class CGPDFPageInfo
    {
        public CGPDFPageInfo() { }
        public System.Nullable<CoreGraphics.CGRect> ArtBox { get { throw null; } set { } }
        public System.Nullable<CoreGraphics.CGRect> BleedBox { get { throw null; } set { } }
        public System.Nullable<CoreGraphics.CGRect> CropBox { get { throw null; } set { } }
        public System.Nullable<CoreGraphics.CGRect> MediaBox { get { throw null; } set { } }
        public System.Nullable<CoreGraphics.CGRect> TrimBox { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial struct CGPoint : System.IEquatable<CoreGraphics.CGPoint>
    {
        private int _dummyPrimitive;
        public static readonly CoreGraphics.CGPoint Empty;
        public CGPoint(CoreGraphics.CGPoint point) { throw null; }
        public CGPoint(double x, double y) { throw null; }
        public CGPoint(System.nfloat x, System.nfloat y) { throw null; }
        public CGPoint(float x, float y) { throw null; }
        public bool IsEmpty { get { throw null; } }
        public System.nfloat X { get { throw null; } set { } }
        public System.nfloat Y { get { throw null; } set { } }
        public static CoreGraphics.CGPoint Add(CoreGraphics.CGPoint point, CoreGraphics.CGSize size) { throw null; }
        public bool Equals(CoreGraphics.CGPoint point) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static CoreGraphics.CGPoint operator +(CoreGraphics.CGPoint l, CoreGraphics.CGSize r) { throw null; }
        public static bool operator ==(CoreGraphics.CGPoint l, CoreGraphics.CGPoint r) { throw null; }
//        public static explicit operator System.Drawing.Point (CoreGraphics.CGPoint point) { throw null; }
//        public static explicit operator System.Drawing.PointF (CoreGraphics.CGPoint point) { throw null; }
//        public static implicit operator CoreGraphics.CGPoint (System.Drawing.Point point) { throw null; }
//        public static implicit operator CoreGraphics.CGPoint (System.Drawing.PointF point) { throw null; }
        public static bool operator !=(CoreGraphics.CGPoint l, CoreGraphics.CGPoint r) { throw null; }
        public static CoreGraphics.CGPoint operator -(CoreGraphics.CGPoint l, CoreGraphics.CGSize r) { throw null; }
        public static CoreGraphics.CGPoint Subtract(CoreGraphics.CGPoint point, CoreGraphics.CGSize size) { throw null; }
        public Foundation.NSDictionary ToDictionary() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Foundation.NSDictionary dictionaryRepresentation, out CoreGraphics.CGPoint point) { throw null; }
    }
    [System.SerializableAttribute]
    public partial struct CGRect : System.IEquatable<CoreGraphics.CGRect>
    {
        private int _dummyPrimitive;
        public static readonly CoreGraphics.CGRect Empty;
        public CGRect(CoreGraphics.CGPoint location, CoreGraphics.CGSize size) { throw null; }
        public CGRect(double x, double y, double width, double height) { throw null; }
        public CGRect(System.nfloat x, System.nfloat y, System.nfloat width, System.nfloat height) { throw null; }
        public CGRect(float x, float y, float width, float height) { throw null; }
        public System.nfloat Bottom { get { throw null; } }
        public System.nfloat Height { get { throw null; } set { } }
        public static CoreGraphics.CGRect Infinite { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public System.nfloat Left { get { throw null; } }
        public CoreGraphics.CGPoint Location { get { throw null; } set { } }
        public static CoreGraphics.CGRect Null { get { throw null; } }
        public System.nfloat Right { get { throw null; } }
        public CoreGraphics.CGSize Size { get { throw null; } set { } }
        public System.nfloat Top { get { throw null; } }
        public System.nfloat Width { get { throw null; } set { } }
        public System.nfloat X { get { throw null; } set { } }
        public System.nfloat Y { get { throw null; } set { } }
        public bool Contains(CoreGraphics.CGPoint point) { throw null; }
        public bool Contains(CoreGraphics.CGRect rect) { throw null; }
        public bool Contains(double x, double y) { throw null; }
        public bool Contains(System.nfloat x, System.nfloat y) { throw null; }
        public bool Contains(float x, float y) { throw null; }
        public bool Equals(CoreGraphics.CGRect rect) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static CoreGraphics.CGRect FromLTRB(System.nfloat left, System.nfloat top, System.nfloat right, System.nfloat bottom) { throw null; }
        public override int GetHashCode() { throw null; }
        public static CoreGraphics.CGRect Inflate(CoreGraphics.CGRect rect, System.nfloat x, System.nfloat y) { throw null; }
        public void Inflate(CoreGraphics.CGSize size) { }
        public void Inflate(double x, double y) { }
        public void Inflate(System.nfloat x, System.nfloat y) { }
        public void Inflate(float x, float y) { }
        public void Intersect(CoreGraphics.CGRect rect) { }
        public static CoreGraphics.CGRect Intersect(CoreGraphics.CGRect a, CoreGraphics.CGRect b) { throw null; }
        public bool IntersectsWith(CoreGraphics.CGRect rect) { throw null; }
        public void Offset(CoreGraphics.CGPoint pos) { }
        public void Offset(double x, double y) { }
        public void Offset(System.nfloat x, System.nfloat y) { }
        public void Offset(float x, float y) { }
        public static bool operator ==(CoreGraphics.CGRect left, CoreGraphics.CGRect right) { throw null; }
//        public static explicit operator System.Drawing.Rectangle (CoreGraphics.CGRect rect) { throw null; }
//        public static explicit operator System.Drawing.RectangleF (CoreGraphics.CGRect rect) { throw null; }
//        public static implicit operator CoreGraphics.CGRect (System.Drawing.Rectangle rect) { throw null; }
//        public static implicit operator CoreGraphics.CGRect (System.Drawing.RectangleF rect) { throw null; }
        public static bool operator !=(CoreGraphics.CGRect left, CoreGraphics.CGRect right) { throw null; }
        public Foundation.NSDictionary ToDictionary() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Foundation.NSDictionary dictionaryRepresentation, out CoreGraphics.CGRect rect) { throw null; }
        public static CoreGraphics.CGRect Union(CoreGraphics.CGRect a, CoreGraphics.CGRect b) { throw null; }
    }
    public partial class CGShading : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CGShading(System.IntPtr handle) { }
        public System.IntPtr Handle { get { throw null; } }
        public static CoreGraphics.CGShading CreateAxial(CoreGraphics.CGColorSpace colorspace, CoreGraphics.CGPoint start, CoreGraphics.CGPoint end, CoreGraphics.CGFunction function, bool extendStart, bool extendEnd) { throw null; }
        public static CoreGraphics.CGShading CreateRadial(CoreGraphics.CGColorSpace colorspace, CoreGraphics.CGPoint start, System.nfloat startRadius, CoreGraphics.CGPoint end, System.nfloat endRadius, CoreGraphics.CGFunction function, bool extendStart, bool extendEnd) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CGShading() { }
    }
    [System.SerializableAttribute]
    public partial struct CGSize : System.IEquatable<CoreGraphics.CGSize>
    {
        private int _dummyPrimitive;
        public static readonly CoreGraphics.CGSize Empty;
        public CGSize(CoreGraphics.CGPoint point) { throw null; }
        public CGSize(CoreGraphics.CGSize size) { throw null; }
        public CGSize(double width, double height) { throw null; }
        public CGSize(System.nfloat width, System.nfloat height) { throw null; }
        public CGSize(float width, float height) { throw null; }
        public System.nfloat Height { get { throw null; } set { } }
        public bool IsEmpty { get { throw null; } }
        public System.nfloat Width { get { throw null; } set { } }
        public static CoreGraphics.CGSize Add(CoreGraphics.CGSize size1, CoreGraphics.CGSize size2) { throw null; }
        public bool Equals(CoreGraphics.CGSize size) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static CoreGraphics.CGSize operator +(CoreGraphics.CGSize l, CoreGraphics.CGSize r) { throw null; }
        public static bool operator ==(CoreGraphics.CGSize l, CoreGraphics.CGSize r) { throw null; }
        public static explicit operator CoreGraphics.CGPoint (CoreGraphics.CGSize size) { throw null; }
//        public static explicit operator System.Drawing.Size (CoreGraphics.CGSize size) { throw null; }
//        public static explicit operator System.Drawing.SizeF (CoreGraphics.CGSize size) { throw null; }
//        public static implicit operator CoreGraphics.CGSize (System.Drawing.Size size) { throw null; }
//        public static implicit operator CoreGraphics.CGSize (System.Drawing.SizeF size) { throw null; }
        public static bool operator !=(CoreGraphics.CGSize l, CoreGraphics.CGSize r) { throw null; }
        public static CoreGraphics.CGSize operator -(CoreGraphics.CGSize l, CoreGraphics.CGSize r) { throw null; }
        public static CoreGraphics.CGSize Subtract(CoreGraphics.CGSize size1, CoreGraphics.CGSize size2) { throw null; }
        public CoreGraphics.CGPoint ToCGPoint() { throw null; }
        public Foundation.NSDictionary ToDictionary() { throw null; }
        public CoreGraphics.CGPoint ToPointF() { throw null; }
        public CoreGraphics.CGSize ToRoundedCGSize() { throw null; }
        public CoreGraphics.CGSize ToSize() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(Foundation.NSDictionary dictionaryRepresentation, out CoreGraphics.CGSize size) { throw null; }
    }
}
namespace CoreImage
{
    public partial class CIContext : Foundation.NSObject
    {
        public CIContext() { }
        public CIContext(CoreImage.CIContextOptions options) { }
        protected internal CIContext(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual CoreGraphics.CGSize InputImageMaximumSize { get { throw null; } }
        public virtual CoreGraphics.CGSize OutputImageMaximumSize { get { throw null; } }
        public virtual CoreGraphics.CGColorSpace WorkingColorSpace { get { throw null; } }
        public virtual void ClearCaches() { }
        public static CoreImage.CIContext Create() { throw null; }
        public virtual CoreGraphics.CGImage CreateCGImage(CoreImage.CIImage image, CoreGraphics.CGRect fromRectangle) { throw null; }
        public virtual CoreGraphics.CGImage CreateCGImage(CoreImage.CIImage image, CoreGraphics.CGRect fromRect, int ciImageFormat, CoreGraphics.CGColorSpace colorSpace) { throw null; }
        public virtual void DrawImage(CoreImage.CIImage image, CoreGraphics.CGPoint atPoint, CoreGraphics.CGRect fromRect) { }
        public virtual void DrawImage(CoreImage.CIImage image, CoreGraphics.CGRect inRectangle, CoreGraphics.CGRect fromRectangle) { }
        public static CoreImage.CIContext FromContext(CoreGraphics.CGContext ctx) { throw null; }
        public static CoreImage.CIContext FromContext(CoreGraphics.CGContext ctx, CoreImage.CIContextOptions options) { throw null; }
        public static CoreImage.CIContext FromOptions(CoreImage.CIContextOptions options) { throw null; }
        public virtual void RenderToBitmap(CoreImage.CIImage image, System.IntPtr bitmapPtr, System.nint bytesPerRow, CoreGraphics.CGRect bounds, int bitmapFormat, CoreGraphics.CGColorSpace colorSpace) { }
    }
    public partial class CIContextOptions
    {
        public CIContextOptions() { }
        public CIContextOptions(Foundation.NSDictionary dictionary) { }
        public System.Nullable<bool> CacheIntermediates { get { throw null; } set { } }
        public System.Nullable<int> CIImageFormat { get { throw null; } set { } }
        public System.Nullable<bool> HighQualityDownsample { get { throw null; } set { } }
        public CoreGraphics.CGColorSpace OutputColorSpace { get { throw null; } set { } }
        public System.Nullable<bool> OutputPremultiplied { get { throw null; } set { } }
        public System.Nullable<bool> PriorityRequestLow { get { throw null; } set { } }
        public bool UseSoftwareRenderer { get { throw null; } set { } }
        public CoreGraphics.CGColorSpace WorkingColorSpace { get { throw null; } set { } }
    }
    public partial class CIFilter : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected CIFilter() { }
        protected internal CIFilter(System.IntPtr handle) { }
        public virtual Foundation.NSDictionary Attributes { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public CoreImage.CIImage Image { get { throw null; } set { } }
        public virtual string[] InputKeys { get { throw null; } }
        public Foundation.NSObject this[Foundation.NSString key] { get { throw null; } set { } }
        public virtual string Name { get { throw null; } set { } }
        public virtual CoreImage.CIImage OutputImage { get { throw null; } }
        public virtual string[] OutputKeys { get { throw null; } }
        public static string CategoryLocalizedName(string category) { throw null; }
        public static CoreImage.CIFilter CreateRawFilter(Foundation.NSData data, Foundation.NSDictionary options) { throw null; }
        public static CoreImage.CIFilter CreateRawFilter(Foundation.NSUrl url, Foundation.NSDictionary options) { throw null; }
        public static string FilterLocalizedDescription(string filterName) { throw null; }
        public static string FilterLocalizedName(string filterName) { throw null; }
        public static Foundation.NSUrl FilterLocalizedReferenceDocumentation(string filterName) { throw null; }
        public static string[] FilterNamesInCategories(params string[] categories) { throw null; }
        public static string[] FilterNamesInCategory(string category) { throw null; }
        public static CoreImage.CIFilter FromName(string name) { throw null; }
        public static CoreImage.CIFilter[] FromSerializedXMP(Foundation.NSData xmpData, CoreGraphics.CGRect extent, out Foundation.NSError error) { throw null; }
        public static CoreImage.CIFilter GetFilter(string name, Foundation.NSDictionary inputParameters) { throw null; }
        public static void RegisterFilterName(string name, Foundation.NSObject constructorObject, Foundation.NSDictionary<Foundation.NSString, Foundation.NSObject> classAttributes) { }
        public static Foundation.NSData SerializedXMP(CoreImage.CIFilter[] filters, CoreGraphics.CGRect extent) { throw null; }
        public virtual void SetDefaults() { }
    }
    public partial class CIImage : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public CIImage(CoreGraphics.CGImage image) { }
        public CIImage(CoreGraphics.CGImage image, Foundation.NSDictionary d) { }
        public CIImage(Foundation.NSData data) { }
        public CIImage(Foundation.NSData data, Foundation.NSDictionary d) { }
        public CIImage(Foundation.NSData d, System.nint bytesPerRow, CoreGraphics.CGSize size, int pixelFormat, CoreGraphics.CGColorSpace colorSpace) { }
        public CIImage(Foundation.NSUrl url) { }
        public CIImage(Foundation.NSUrl url, Foundation.NSDictionary d) { }
        public CIImage(int glTextureName, CoreGraphics.CGSize size, bool flipped, CoreGraphics.CGColorSpace colorSpace) { }
        protected internal CIImage(System.IntPtr handle) { }
        public virtual CoreGraphics.CGImage CGImage { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual CoreGraphics.CGColorSpace ColorSpace { get { throw null; } }
        public static CoreImage.CIImage EmptyImage { get { throw null; } }
        public virtual CoreGraphics.CGRect Extent { get { throw null; } }
        public static int FormatA16 { get { throw null; } }
        public static int FormatA8 { get { throw null; } }
        public static int FormatABGR8 { get { throw null; } }
        public static int FormatAf { get { throw null; } }
        public static int FormatAh { get { throw null; } }
        public static int FormatARGB8 { get { throw null; } }
        public static int FormatBGRA8 { get { throw null; } }
        public static int FormatL16 { get { throw null; } }
        public static int FormatL8 { get { throw null; } }
        public static int FormatLA16 { get { throw null; } }
        public static int FormatLA8 { get { throw null; } }
        public static int FormatLAf { get { throw null; } }
        public static int FormatLAh { get { throw null; } }
        public static int FormatLf { get { throw null; } }
        public static int FormatLh { get { throw null; } }
        public static int FormatR16 { get { throw null; } }
        public static int FormatR8 { get { throw null; } }
        public static int FormatRf { get { throw null; } }
        public static int FormatRG16 { get { throw null; } }
        public static int FormatRG8 { get { throw null; } }
        public static int FormatRGBA16 { get { throw null; } }
        public static int FormatRGBA8 { get { throw null; } }
        public static int FormatRGBAf { get { throw null; } }
        public static int FormatRGBAh { get { throw null; } }
        public static int FormatRGf { get { throw null; } }
        public static int FormatRGh { get { throw null; } }
        public static int FormatRh { get { throw null; } }
        public CoreGraphics.CGImageProperties Properties { get { throw null; } }
        public virtual Foundation.NSUrl Url { get { throw null; } }
        public virtual CoreImage.CIImage CreateByApplyingGaussianBlur(double sigma) { throw null; }
        public virtual CoreImage.CIImage CreateByClamping(CoreGraphics.CGRect rect) { throw null; }
        public virtual CoreImage.CIImage CreateByClampingToExtent() { throw null; }
        public virtual CoreImage.CIImage CreateByColorMatchingColorSpaceToWorkingSpace(CoreGraphics.CGColorSpace colorSpace) { throw null; }
        public virtual CoreImage.CIImage CreateByColorMatchingWorkingSpaceToColorSpace(CoreGraphics.CGColorSpace colorSpace) { throw null; }
        public virtual CoreImage.CIImage CreateByCompositingOverImage(CoreImage.CIImage dest) { throw null; }
        public virtual CoreImage.CIImage CreateByFiltering(string filterName) { throw null; }
        public virtual CoreImage.CIImage CreateByFiltering(string filterName, Foundation.NSDictionary inputParameters) { throw null; }
        public virtual CoreImage.CIImage CreateByInsertingIntermediate() { throw null; }
        public virtual CoreImage.CIImage CreateByInsertingIntermediate(bool cache) { throw null; }
        public virtual CoreImage.CIImage CreateByPremultiplyingAlpha() { throw null; }
        public virtual CoreImage.CIImage CreateBySamplingLinear() { throw null; }
        public virtual CoreImage.CIImage CreateBySamplingNearest() { throw null; }
        public virtual CoreImage.CIImage CreateBySettingAlphaOne(CoreGraphics.CGRect extent) { throw null; }
        public virtual CoreImage.CIImage CreateBySettingProperties(Foundation.NSDictionary properties) { throw null; }
        public virtual CoreImage.CIImage CreateByUnpremultiplyingAlpha() { throw null; }
        public static CoreImage.CIImage FromCGImage(CoreGraphics.CGImage image) { throw null; }
        public static CoreImage.CIImage FromCGImage(CoreGraphics.CGImage image, CoreGraphics.CGColorSpace colorSpace) { throw null; }
        public static CoreImage.CIImage FromCGImage(CoreGraphics.CGImage image, Foundation.NSDictionary d) { throw null; }
        public static CoreImage.CIImage FromData(Foundation.NSData data) { throw null; }
        public static CoreImage.CIImage FromData(Foundation.NSData data, Foundation.NSDictionary d) { throw null; }
        public static CoreImage.CIImage FromUrl(Foundation.NSUrl url) { throw null; }
        public static CoreImage.CIImage FromUrl(Foundation.NSUrl url, Foundation.NSDictionary d) { throw null; }
        public CoreImage.CIFilter[] GetAutoAdjustmentFilters() { throw null; }
        public virtual CoreGraphics.CGRect GetRegionOfInterest(CoreImage.CIImage im, CoreGraphics.CGRect r) { throw null; }
        public virtual CoreImage.CIImage ImageByApplyingTransform(CoreGraphics.CGAffineTransform matrix) { throw null; }
        public virtual CoreImage.CIImage ImageByCroppingToRect(CoreGraphics.CGRect r) { throw null; }
        public static CoreImage.CIImage ImageWithTexture(uint glTextureName, CoreGraphics.CGSize size, bool flipped, CoreGraphics.CGColorSpace colorspace) { throw null; }
        public static implicit operator CoreImage.CIImage (CoreGraphics.CGImage image) { throw null; }
    }
    public partial class CIVector : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public CIVector(CoreGraphics.CGAffineTransform r) { }
        public CIVector(CoreGraphics.CGPoint p) { }
        public CIVector(CoreGraphics.CGRect r) { }
        protected internal CIVector(System.IntPtr handle) { }
        public CIVector(System.nfloat x) { }
        public CIVector(System.nfloat x, System.nfloat y) { }
        public CIVector(System.nfloat x, System.nfloat y, System.nfloat z) { }
        public CIVector(System.nfloat x, System.nfloat y, System.nfloat z, System.nfloat w) { }
        public CIVector(System.nfloat[] values) { }
        public CIVector(System.nfloat[] values, System.nint count) { }
        public CIVector(string representation) { }
        public virtual CoreGraphics.CGAffineTransform AffineTransform { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual System.nint Count { get { throw null; } }
        public virtual CoreGraphics.CGPoint Point { get { throw null; } }
        public virtual CoreGraphics.CGRect Rectangle { get { throw null; } }
        public virtual System.nfloat W { get { throw null; } }
        public virtual System.nfloat X { get { throw null; } }
        public virtual System.nfloat Y { get { throw null; } }
        public virtual System.nfloat Z { get { throw null; } }
        public static CoreImage.CIVector Create(CoreGraphics.CGAffineTransform affineTransform) { throw null; }
        public static CoreImage.CIVector Create(CoreGraphics.CGPoint point) { throw null; }
        public static CoreImage.CIVector Create(CoreGraphics.CGRect point) { throw null; }
        public static CoreImage.CIVector Create(System.nfloat x) { throw null; }
        public static CoreImage.CIVector Create(System.nfloat x, System.nfloat y) { throw null; }
        public static CoreImage.CIVector Create(System.nfloat x, System.nfloat y, System.nfloat z) { throw null; }
        public static CoreImage.CIVector Create(System.nfloat x, System.nfloat y, System.nfloat z, System.nfloat w) { throw null; }
        public static CoreImage.CIVector FromString(string representation) { throw null; }
        public static CoreImage.CIVector FromValues(System.nfloat[] values) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace CoreServices
{
    public partial class CFHTTPMessage : ObjCRuntime.INativeObject, System.IDisposable
    {
        internal CFHTTPMessage() { }
        public System.IntPtr Handle { get { throw null; } }
        public bool IsHeaderComplete { get { throw null; } }
        public bool IsRequest { get { throw null; } }
        public System.Net.HttpStatusCode ResponseStatusCode { get { throw null; } }
        public string ResponseStatusLine { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public bool AddAuthentication(CoreServices.CFHTTPMessage failureResponse, Foundation.NSString username, Foundation.NSString password, CoreServices.CFHTTPMessage.AuthenticationScheme scheme, bool forProxy) { throw null; }
        public bool AppendBytes(byte[] bytes) { throw null; }
        public bool AppendBytes(byte[] bytes, System.nint count) { throw null; }
        protected void CheckHandle() { }
        public static CoreServices.CFHTTPMessage CreateEmpty(bool request) { throw null; }
        public static CoreServices.CFHTTPMessage CreateRequest(System.Uri uri, string method) { throw null; }
        public static CoreServices.CFHTTPMessage CreateRequest(System.Uri uri, string method, System.Version version) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CFHTTPMessage() { }
        public Foundation.NSDictionary GetAllHeaderFields() { throw null; }
        public static System.nint GetTypeID() { throw null; }
        public void SetBody(byte[] buffer) { }
        public void SetHeaderFieldValue(string name, string value) { }
        public enum AuthenticationScheme
        {
            Basic = 1,
            Default = 0,
            Digest = 4,
            Negotiate = 2,
            NTLM = 3,
            OAuth1 = 5,
        }
    }
    public partial class CFHTTPStream : CoreFoundation.CFReadStream
    {
        internal CFHTTPStream() : base (default(System.IntPtr)) { }
        public bool AttemptPersistentConnection { get { throw null; } set { } }
        public System.Uri FinalURL { get { throw null; } }
        public int RequestBytesWrittenCount { get { throw null; } }
        public bool ShouldAutoredirect { get { throw null; } set { } }
        public CoreServices.CFHTTPMessage GetFinalRequest() { throw null; }
        public CoreServices.CFHTTPMessage GetResponseHeader() { throw null; }
        public void SetProxy(CoreFoundation.CFProxySettings proxySettings) { }
    }
}
namespace CoreText
{
    public partial class CTFont : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CTFont(CoreGraphics.CGFont font, System.nfloat size, CoreGraphics.CGAffineTransform transform) { }
        public CTFont(CoreGraphics.CGFont font, System.nfloat size, CoreGraphics.CGAffineTransform transform, CoreText.CTFontDescriptor descriptor) { }
        public CTFont(CoreGraphics.CGFont font, System.nfloat size, CoreText.CTFontDescriptor descriptor) { }
        public CTFont(CoreText.CTFontDescriptor descriptor, System.nfloat size) { }
        public CTFont(CoreText.CTFontDescriptor descriptor, System.nfloat size, ref CoreGraphics.CGAffineTransform matrix) { }
        public CTFont(CoreText.CTFontUIFontType uiType, System.nfloat size, string language) { }
        public CTFont(string name, System.nfloat size) { }
        public CTFont(string name, System.nfloat size, ref CoreGraphics.CGAffineTransform matrix) { }
        public System.nfloat AscentMetric { get { throw null; } }
        public CoreGraphics.CGRect BoundingBox { get { throw null; } }
        public System.nfloat CapHeightMetric { get { throw null; } }
        public System.nfloat DescentMetric { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string FamilyName { get { throw null; } }
        public string FullName { get { throw null; } }
        public System.nint GlyphCount { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public System.nfloat LeadingMetric { get { throw null; } }
        public CoreGraphics.CGAffineTransform Matrix { get { throw null; } }
        public string PostScriptName { get { throw null; } }
        public System.nfloat Size { get { throw null; } }
        public System.nfloat SlantAngle { get { throw null; } }
        public uint StringEncoding { get { throw null; } }
        public CoreText.CTFontSymbolicTraits SymbolicTraits { get { throw null; } }
        public System.nfloat UnderlinePosition { get { throw null; } }
        public System.nfloat UnderlineThickness { get { throw null; } }
        public uint UnitsPerEmMetric { get { throw null; } }
        public System.nfloat XHeightMetric { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void DrawGlyphs(CoreGraphics.CGContext context, ushort[] glyphs, CoreGraphics.CGPoint[] positions) { }
        ~CTFont() { }
        public CoreText.CTFont ForString(string value, Foundation.NSRange range) { throw null; }
        public Foundation.NSObject GetAttribute(Foundation.NSString attribute) { throw null; }
        public CoreText.CTFontDescriptor[] GetDefaultCascadeList(string[] languages) { throw null; }
        public CoreText.CTFontDescriptor GetFontDescriptor() { throw null; }
        public bool GetGlyphsForCharacters(char[] characters, ushort[] glyphs) { throw null; }
        public bool GetGlyphsForCharacters(char[] characters, ushort[] glyphs, System.nint count) { throw null; }
        public ushort GetGlyphWithName(string glyphName) { throw null; }
        public System.nint GetLigatureCaretPositions(ushort glyph, System.nfloat[] positions) { throw null; }
        public CoreGraphics.CGPath GetPathForGlyph(ushort glyph) { throw null; }
        public CoreGraphics.CGPath GetPathForGlyph(ushort glyph, ref CoreGraphics.CGAffineTransform transform) { throw null; }
        public string[] GetSupportedLanguages() { throw null; }
        public CoreText.CTFontTraits GetTraits() { throw null; }
        public static System.nint GetTypeID() { throw null; }
        public void GetVerticalTranslationsForGlyphs(ushort[] glyphs, CoreGraphics.CGSize[] translations, System.nint count) { }
        public CoreGraphics.CGFont ToCGFont() { throw null; }
        public CoreGraphics.CGFont ToCGFont(CoreText.CTFontDescriptor attributes) { throw null; }
        public override string ToString() { throw null; }
        public CoreText.CTFont WithAttributes(System.nfloat size, CoreText.CTFontDescriptor attributes) { throw null; }
        public CoreText.CTFont WithAttributes(System.nfloat size, CoreText.CTFontDescriptor attributes, ref CoreGraphics.CGAffineTransform matrix) { throw null; }
        public CoreText.CTFont WithFamily(System.nfloat size, string family) { throw null; }
        public CoreText.CTFont WithFamily(System.nfloat size, string family, ref CoreGraphics.CGAffineTransform matrix) { throw null; }
        public CoreText.CTFont WithSymbolicTraits(System.nfloat size, CoreText.CTFontSymbolicTraits symTraitValue, CoreText.CTFontSymbolicTraits symTraitMask) { throw null; }
        public CoreText.CTFont WithSymbolicTraits(System.nfloat size, CoreText.CTFontSymbolicTraits symTraitValue, CoreText.CTFontSymbolicTraits symTraitMask, ref CoreGraphics.CGAffineTransform matrix) { throw null; }
    }
    public partial class CTFontCollection : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CTFontCollection(CoreText.CTFontCollectionOptions options) { }
        public CTFontCollection(CoreText.CTFontDescriptor[] queryDescriptors, CoreText.CTFontCollectionOptions options) { }
        public System.IntPtr Handle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CTFontCollection() { }
        public CoreText.CTFontDescriptor[] GetMatchingFontDescriptors() { throw null; }
        public CoreText.CTFontDescriptor[] GetMatchingFontDescriptors(CoreText.CTFontCollectionOptions options) { throw null; }
        public CoreText.CTFontDescriptor[] GetMatchingFontDescriptors(System.Comparison<CoreText.CTFontDescriptor> comparer) { throw null; }
        public CoreText.CTFontCollection WithFontDescriptors(CoreText.CTFontDescriptor[] queryDescriptors, CoreText.CTFontCollectionOptions options) { throw null; }
    }
    public partial class CTFontCollectionOptions
    {
        public CTFontCollectionOptions() { }
        public CTFontCollectionOptions(Foundation.NSDictionary dictionary) { }
        public Foundation.NSDictionary Dictionary { get { throw null; } }
        public bool RemoveDuplicates { get { throw null; } set { } }
    }
    public partial class CTFontDescriptor : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CTFontDescriptor(CoreText.CTFontDescriptorAttributes attributes) { }
        public CTFontDescriptor(string name, System.nfloat size) { }
        public System.IntPtr Handle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CTFontDescriptor() { }
        public Foundation.NSObject GetAttribute(Foundation.NSString attribute) { throw null; }
        public CoreText.CTFontDescriptorAttributes GetAttributes() { throw null; }
        public Foundation.NSObject GetLocalizedAttribute(Foundation.NSString attribute) { throw null; }
        public Foundation.NSObject GetLocalizedAttribute(Foundation.NSString attribute, out Foundation.NSString language) { throw null; }
        public CoreText.CTFontDescriptor GetMatchingFontDescriptor() { throw null; }
        public CoreText.CTFontDescriptor GetMatchingFontDescriptor(Foundation.NSSet mandatoryAttributes) { throw null; }
        public CoreText.CTFontDescriptor GetMatchingFontDescriptor(params Foundation.NSString[] mandatoryAttributes) { throw null; }
        public CoreText.CTFontDescriptor[] GetMatchingFontDescriptors() { throw null; }
        public CoreText.CTFontDescriptor[] GetMatchingFontDescriptors(Foundation.NSSet mandatoryAttributes) { throw null; }
        public CoreText.CTFontDescriptor[] GetMatchingFontDescriptors(params Foundation.NSString[] mandatoryAttributes) { throw null; }
        public CoreText.CTFontDescriptor WithAttributes(CoreText.CTFontDescriptorAttributes attributes) { throw null; }
        public CoreText.CTFontDescriptor WithAttributes(Foundation.NSDictionary attributes) { throw null; }
        public CoreText.CTFontDescriptor WithVariation(uint variationIdentifier, System.nfloat variationValue) { throw null; }
    }
    public static partial class CTFontDescriptorAttributeKey
    {
        public static readonly Foundation.NSString BaselineAdjust;
        public static readonly Foundation.NSString CascadeList;
        public static readonly Foundation.NSString CharacterSet;
        public static readonly Foundation.NSString DisplayName;
        public static readonly Foundation.NSString Enabled;
        public static readonly Foundation.NSString FamilyName;
        public static readonly Foundation.NSString Features;
        public static readonly Foundation.NSString FeatureSettings;
        public static readonly Foundation.NSString FixedAdvance;
        public static readonly Foundation.NSString FontFormat;
        public static readonly Foundation.NSString FontOrientation;
        public static readonly Foundation.NSString Languages;
        public static readonly Foundation.NSString MacintoshEncodings;
        public static readonly Foundation.NSString Matrix;
        public static readonly Foundation.NSString Name;
        public static readonly Foundation.NSString Priority;
        public static readonly Foundation.NSString RegistrationScope;
        public static readonly Foundation.NSString Size;
        public static readonly Foundation.NSString StyleName;
        public static readonly Foundation.NSString Traits;
        public static readonly Foundation.NSString Url;
        public static readonly Foundation.NSString Variation;
    }
    public partial class CTFontDescriptorAttributes
    {
        public CTFontDescriptorAttributes() { }
        public CTFontDescriptorAttributes(Foundation.NSDictionary dictionary) { }
        public System.Nullable<float> BaselineAdjust { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<CoreText.CTFontDescriptor> CascadeList { get { throw null; } set { } }
        public Foundation.NSDictionary Dictionary { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public string FamilyName { get { throw null; } set { } }
        public System.Nullable<float> FixedAdvance { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> Languages { get { throw null; } set { } }
        public System.Nullable<float> MacintoshEncodings { get { throw null; } set { } }
        public System.Nullable<CoreGraphics.CGAffineTransform> Matrix { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Nullable<float> Size { get { throw null; } set { } }
        public string StyleName { get { throw null; } set { } }
        public CoreText.CTFontTraits Traits { get { throw null; } set { } }
        public Foundation.NSUrl Url { get { throw null; } set { } }
    }
    public partial class CTFontManager
    {
        public static readonly Foundation.NSString ErrorDomain;
        public static readonly Foundation.NSString ErrorFontUrlsKey;
        public CTFontManager() { }
        public static CoreText.CTFontDescriptor[] GetFonts(Foundation.NSUrl url) { throw null; }
        public static bool IsFontSupported(Foundation.NSUrl url) { throw null; }
        public static bool RegisterGraphicsFont(CoreGraphics.CGFont font, out Foundation.NSError error) { throw null; }
        public static bool UnregisterGraphicsFont(CoreGraphics.CGFont font, out Foundation.NSError error) { throw null; }
    }
    public enum CTFontSymbolicTraits : uint
    {
        Bold = (uint)2,
        ColorGlyphs = (uint)8192,
        Composite = (uint)16384,
        Condensed = (uint)64,
        Expanded = (uint)32,
        Italic = (uint)1,
        Mask = (uint)4026531840,
        MonoSpace = (uint)1024,
        None = (uint)0,
        UIOptimized = (uint)4096,
        Vertical = (uint)2048,
    }
    public static partial class CTFontTraitKey
    {
        public static readonly Foundation.NSString Slant;
        public static readonly Foundation.NSString Symbolic;
        public static readonly Foundation.NSString Weight;
        public static readonly Foundation.NSString Width;
    }
    public partial class CTFontTraits
    {
        public CTFontTraits() { }
        public CTFontTraits(Foundation.NSDictionary dictionary) { }
        public Foundation.NSDictionary Dictionary { get { throw null; } }
        public System.Nullable<float> Slant { get { throw null; } set { } }
        public System.Nullable<uint> Symbolic { get { throw null; } set { } }
        public System.Nullable<CoreText.CTFontSymbolicTraits> SymbolicTraits { get { throw null; } set { } }
        public System.Nullable<float> Weight { get { throw null; } set { } }
        public System.Nullable<float> Width { get { throw null; } set { } }
    }
    public enum CTFontUIFontType : uint
    {
        AlertHeader = (uint)18,
        Application = (uint)9,
        ControlContent = (uint)26,
        EmphasizedSystem = (uint)3,
        EmphasizedSystemDetail = (uint)20,
        Label = (uint)10,
        MenuItem = (uint)12,
        MenuItemCmdKey = (uint)14,
        MenuItemMark = (uint)13,
        MenuTitle = (uint)11,
        Message = (uint)23,
        MiniEmphasizedSystem = (uint)7,
        MiniSystem = (uint)6,
        None = (uint)4294967295,
        Palette = (uint)24,
        PushButton = (uint)16,
        SmallEmphasizedSystem = (uint)5,
        SmallSystem = (uint)4,
        SmallToolbar = (uint)22,
        System = (uint)2,
        SystemDetail = (uint)19,
        Toolbar = (uint)21,
        ToolTip = (uint)25,
        User = (uint)0,
        UserFixedPitch = (uint)1,
        UtilityWindowTitle = (uint)17,
        Views = (uint)8,
        WindowTitle = (uint)15,
    }
    public partial class CTLine : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CTLine(Foundation.NSAttributedString value) { }
        public System.nint GlyphCount { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public Foundation.NSRange StringRange { get { throw null; } }
        public double TrailingWhitespaceWidth { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Draw(CoreGraphics.CGContext context) { }
        ~CTLine() { }
        public CoreText.CTRun[] GetGlyphRuns() { throw null; }
        public CoreGraphics.CGRect GetImageBounds(CoreGraphics.CGContext context) { throw null; }
        public CoreText.CTLine GetJustifiedLine(System.nfloat justificationFactor, double justificationWidth) { throw null; }
        public System.nfloat GetOffsetForStringIndex(System.nint charIndex) { throw null; }
        public System.nfloat GetOffsetForStringIndex(System.nint charIndex, out System.nfloat secondaryOffset) { throw null; }
        public double GetPenOffsetForFlush(System.nfloat flushFactor, double flushWidth) { throw null; }
        public System.nint GetStringIndexForPosition(CoreGraphics.CGPoint position) { throw null; }
        public CoreText.CTLine GetTruncatedLine(double width, CoreText.CTLineTruncation truncationType, CoreText.CTLine truncationToken) { throw null; }
        public double GetTypographicBounds() { throw null; }
        public double GetTypographicBounds(out System.nfloat ascent, out System.nfloat descent, out System.nfloat leading) { throw null; }
    }
    public enum CTLineTruncation : uint
    {
        End = (uint)1,
        Middle = (uint)2,
        Start = (uint)0,
    }
    public partial class CTParagraphStyle : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CTParagraphStyle() { }
        public CTParagraphStyle(CoreText.CTParagraphStyleSettings settings) { }
        public CoreText.CTTextAlignment Alignment { get { throw null; } }
        public float DefaultTabInterval { get { throw null; } }
        public float FirstLineHeadIndent { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public float HeadIndent { get { throw null; } }
        public float LineHeightMultiple { get { throw null; } }
        public float LineSpacing { get { throw null; } }
        public float MaximumLineHeight { get { throw null; } }
        public float MinimumLineHeight { get { throw null; } }
        public float ParagraphSpacing { get { throw null; } }
        public float ParagraphSpacingBefore { get { throw null; } }
        public float TailIndent { get { throw null; } }
        public CoreText.CTParagraphStyle Clone() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CTParagraphStyle() { }
    }
    public partial class CTParagraphStyleSettings
    {
        public CTParagraphStyleSettings() { }
        public System.Nullable<CoreText.CTTextAlignment> Alignment { get { throw null; } set { } }
        public System.Nullable<System.nfloat> DefaultTabInterval { get { throw null; } set { } }
        public System.Nullable<System.nfloat> FirstLineHeadIndent { get { throw null; } set { } }
        public System.Nullable<System.nfloat> HeadIndent { get { throw null; } set { } }
        public System.Nullable<System.nfloat> LineHeightMultiple { get { throw null; } set { } }
        public System.Nullable<System.nfloat> LineSpacing { get { throw null; } set { } }
        public System.Nullable<System.nfloat> LineSpacingAdjustment { get { throw null; } set { } }
        public System.Nullable<System.nfloat> MaximumLineHeight { get { throw null; } set { } }
        public System.Nullable<System.nfloat> MaximumLineSpacing { get { throw null; } set { } }
        public System.Nullable<System.nfloat> MinimumLineHeight { get { throw null; } set { } }
        public System.Nullable<System.nfloat> MinimumLineSpacing { get { throw null; } set { } }
        public System.Nullable<System.nfloat> ParagraphSpacing { get { throw null; } set { } }
        public System.Nullable<System.nfloat> ParagraphSpacingBefore { get { throw null; } set { } }
        public System.Nullable<System.nfloat> TailIndent { get { throw null; } set { } }
    }
    public partial class CTRun : ObjCRuntime.INativeObject, System.IDisposable
    {
        internal CTRun() { }
        public System.nint GlyphCount { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public Foundation.NSRange StringRange { get { throw null; } }
        public CoreGraphics.CGAffineTransform TextMatrix { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Draw(CoreGraphics.CGContext context, Foundation.NSRange range) { }
        ~CTRun() { }
        public CoreGraphics.CGSize[] GetAdvances() { throw null; }
        public CoreGraphics.CGSize[] GetAdvances(Foundation.NSRange range) { throw null; }
        public CoreGraphics.CGSize[] GetAdvances(Foundation.NSRange range, CoreGraphics.CGSize[] buffer) { throw null; }
        public CoreText.CTStringAttributes GetAttributes() { throw null; }
        public ushort[] GetGlyphs() { throw null; }
        public ushort[] GetGlyphs(Foundation.NSRange range) { throw null; }
        public ushort[] GetGlyphs(Foundation.NSRange range, ushort[] buffer) { throw null; }
        public CoreGraphics.CGRect GetImageBounds(CoreGraphics.CGContext context, Foundation.NSRange range) { throw null; }
        public CoreGraphics.CGPoint[] GetPositions() { throw null; }
        public CoreGraphics.CGPoint[] GetPositions(Foundation.NSRange range) { throw null; }
        public CoreGraphics.CGPoint[] GetPositions(Foundation.NSRange range, CoreGraphics.CGPoint[] buffer) { throw null; }
        public System.nint[] GetStringIndices() { throw null; }
        public System.nint[] GetStringIndices(Foundation.NSRange range) { throw null; }
        public System.nint[] GetStringIndices(Foundation.NSRange range, System.nint[] buffer) { throw null; }
        public double GetTypographicBounds() { throw null; }
        public double GetTypographicBounds(Foundation.NSRange range, out System.nfloat ascent, out System.nfloat descent, out System.nfloat leading) { throw null; }
    }
    public partial class CTStringAttributes
    {
        public CTStringAttributes() { }
        public CTStringAttributes(Foundation.NSDictionary dictionary) { }
        public CoreGraphics.CGColor BackgroundColor { get { throw null; } set { } }
        public System.Nullable<float> BaselineOffset { get { throw null; } set { } }
        public System.Nullable<int> CharacterShape { get { throw null; } set { } }
        public Foundation.NSDictionary Dictionary { get { throw null; } }
        public CoreText.CTFont Font { get { throw null; } set { } }
        public CoreGraphics.CGColor ForegroundColor { get { throw null; } set { } }
        public bool ForegroundColorFromContext { get { throw null; } set { } }
        public System.Nullable<int> HorizontalInVerticalForms { get { throw null; } set { } }
        public System.Nullable<float> KerningAdjustment { get { throw null; } set { } }
        public CoreText.CTParagraphStyle ParagraphStyle { get { throw null; } set { } }
        public CoreGraphics.CGColor StrokeColor { get { throw null; } set { } }
        public System.Nullable<float> StrokeWidth { get { throw null; } set { } }
        public CoreGraphics.CGColor UnderlineColor { get { throw null; } set { } }
        public System.Nullable<CoreText.CTUnderlineStyle> UnderlineStyle { get { throw null; } set { } }
        public System.Nullable<int> UnderlineStyleValue { get { throw null; } set { } }
        public bool VerticalForms { get { throw null; } set { } }
    }
    public enum CTTextAlignment : byte
    {
        Center = (byte)2,
        Justified = (byte)3,
        Left = (byte)0,
        Natural = (byte)4,
        Right = (byte)1,
    }
    public partial class CTTypesetter : ObjCRuntime.INativeObject, System.IDisposable
    {
        public CTTypesetter(Foundation.NSAttributedString value) { }
        public System.IntPtr Handle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CTTypesetter() { }
        public CoreText.CTLine GetLine(Foundation.NSRange stringRange) { throw null; }
        public CoreText.CTLine GetLine(Foundation.NSRange stringRange, double offset) { throw null; }
        public System.nint SuggestClusterBreak(int startIndex, double width) { throw null; }
        public System.nint SuggestClusterBreak(int startIndex, double width, double offset) { throw null; }
        public System.nint SuggestLineBreak(int startIndex, double width) { throw null; }
        public System.nint SuggestLineBreak(int startIndex, double width, double offset) { throw null; }
    }
    public enum CTUnderlineStyle
    {
        Double = 9,
        None = 0,
        Single = 1,
        Thick = 2,
    }
}
namespace Foundation
{
    public partial interface INSUrlSessionDataDelegate : Foundation.INSUrlSessionDelegate, Foundation.INSUrlSessionTaskDelegate, ObjCRuntime.INativeObject, System.IDisposable
    {
    }
    public partial interface INSUrlSessionDelegate : ObjCRuntime.INativeObject, System.IDisposable
    {
    }
    public partial interface INSUrlSessionTaskDelegate : Foundation.INSUrlSessionDelegate, ObjCRuntime.INativeObject, System.IDisposable
    {
    }
    public partial class NSAttributedString : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSAttributedString() { }
        public NSAttributedString(Foundation.NSAttributedString other) { }
        public NSAttributedString(Foundation.NSData data, Foundation.NSDictionary options, out Foundation.NSDictionary resultDocumentAttributes, ref Foundation.NSError error) { throw null; }
        public NSAttributedString(Foundation.NSData data, ref Foundation.NSError error) { }
        public NSAttributedString(Foundation.NSUrl url, Foundation.NSDictionary options, out Foundation.NSDictionary resultDocumentAttributes, ref Foundation.NSError error) { throw null; }
        public NSAttributedString(Foundation.NSUrl url, ref Foundation.NSError error) { }
        protected internal NSAttributedString(System.IntPtr handle) { }
        public NSAttributedString(string str) { }
        public NSAttributedString(string str, CoreText.CTStringAttributes attributes) { }
        public NSAttributedString(string str, Foundation.NSDictionary attributes) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual System.nint Length { get { throw null; } }
        public virtual System.IntPtr LowLevelValue { get { throw null; } }
        public static string[] ReadableTypeIdentifiers { get { throw null; } }
        public virtual CoreGraphics.CGSize Size { get { throw null; } }
        public static Foundation.NSString TextLayoutSectionOrientation { get { throw null; } }
        public static Foundation.NSString TextLayoutSectionRange { get { throw null; } }
        public static Foundation.NSString TextLayoutSectionsAttribute { get { throw null; } }
        public string Value { get { throw null; } }
        public static string[] WritableTypeIdentifiers { get { throw null; } }
        public virtual string[] WritableTypeIdentifiersForItemProvider { get { throw null; } }
        public virtual bool ContainsAttachmentsInRange(Foundation.NSRange range) { throw null; }
        public virtual void DrawString(CoreGraphics.CGPoint point) { }
        public virtual void DrawString(CoreGraphics.CGRect rect) { }
        public virtual Foundation.NSObject GetAttribute(string attribute, System.nint location, out Foundation.NSRange effectiveRange) { throw null; }
        public virtual Foundation.NSObject GetAttribute(string attribute, System.nint location, out Foundation.NSRange longestEffectiveRange, Foundation.NSRange rangeLimit) { throw null; }
        public Foundation.NSDictionary GetAttributes(System.nint location, out Foundation.NSRange effectiveRange) { throw null; }
        public virtual Foundation.NSDictionary GetAttributes(System.nint location, out Foundation.NSRange longestEffectiveRange, Foundation.NSRange rangeLimit) { throw null; }
        public CoreText.CTStringAttributes GetCoreTextAttributes(System.nint location, out Foundation.NSRange effectiveRange) { throw null; }
        public CoreText.CTStringAttributes GetCoreTextAttributes(System.nint location, out Foundation.NSRange longestEffectiveRange, Foundation.NSRange rangeLimit) { throw null; }
        public virtual Foundation.NSData GetDataFromRange(Foundation.NSRange range, Foundation.NSDictionary attributes, ref Foundation.NSError error) { throw null; }
        public virtual bool IsEqual(Foundation.NSAttributedString other) { throw null; }
        public virtual System.Threading.Tasks.Task<Foundation.NSData> LoadDataAsync(string typeIdentifier) { throw null; }
        public virtual System.IntPtr LowLevelGetAttributes(System.nint location, out Foundation.NSRange effectiveRange) { throw null; }
        public Foundation.NSAttributedString Substring(System.nint start, System.nint len) { throw null; }
    }
    public partial class NSBundle : Foundation.NSObject
    {
        public NSBundle() { }
        public NSBundle(Foundation.NSUrl url) { }
        protected internal NSBundle(System.IntPtr handle) { }
        public NSBundle(string path) { }
        public static Foundation.NSBundle[] AllFrameworks { get { throw null; } }
        public virtual Foundation.NSUrl AppStoreReceiptUrl { get { throw null; } }
        public virtual string BuiltinPluginsPath { get { throw null; } }
        public virtual Foundation.NSUrl BuiltInPluginsUrl { get { throw null; } }
        public virtual string BundleIdentifier { get { throw null; } }
        public virtual string BundlePath { get { throw null; } }
        public virtual Foundation.NSUrl BundleUrl { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual string DevelopmentLocalization { get { throw null; } }
        public virtual string ExecutablePath { get { throw null; } }
        public virtual Foundation.NSUrl ExecutableUrl { get { throw null; } }
        public virtual Foundation.NSDictionary InfoDictionary { get { throw null; } }
        public virtual bool IsLoaded { get { throw null; } }
        public virtual string[] Localizations { get { throw null; } }
        public static Foundation.NSBundle MainBundle { get { throw null; } }
        public virtual string[] PreferredLocalizations { get { throw null; } }
        public virtual ObjCRuntime.Class PrincipalClass { get { throw null; } }
        public virtual string PrivateFrameworksPath { get { throw null; } }
        public virtual Foundation.NSUrl PrivateFrameworksUrl { get { throw null; } }
        public virtual string ResourcePath { get { throw null; } }
        public virtual Foundation.NSUrl ResourceUrl { get { throw null; } }
        public virtual string SharedFrameworksPath { get { throw null; } }
        public virtual Foundation.NSUrl SharedFrameworksUrl { get { throw null; } }
        public virtual string SharedSupportPath { get { throw null; } }
        public virtual Foundation.NSUrl SharedSupportUrl { get { throw null; } }
        public static Foundation.NSBundle[] _AllBundles { get { throw null; } }
        public virtual ObjCRuntime.Class ClassNamed(string className) { throw null; }
        public static Foundation.NSBundle FromClass(ObjCRuntime.Class c) { throw null; }
        public static Foundation.NSBundle FromIdentifier(string str) { throw null; }
        public static Foundation.NSBundle FromPath(string path) { throw null; }
        public static Foundation.NSBundle FromUrl(Foundation.NSUrl url) { throw null; }
        public virtual Foundation.NSString GetLocalizedString(Foundation.NSString key, Foundation.NSString value, Foundation.NSString table) { throw null; }
        public Foundation.NSString GetLocalizedString(string key, string value = null, string table = null) { throw null; }
        public static string[] GetPathsForResources(string fileExtension, string bundlePath) { throw null; }
        public virtual double GetPreservationPriority(Foundation.NSString tag) { throw null; }
        public virtual Foundation.NSUrl GetUrlForResource(string name, string fileExtension) { throw null; }
        public virtual Foundation.NSUrl GetUrlForResource(string name, string fileExtension, string subdirectory) { throw null; }
        public static Foundation.NSUrl GetUrlForResource(string name, string fileExtension, string subdirectory, Foundation.NSUrl bundleURL) { throw null; }
        public virtual Foundation.NSUrl GetUrlForResource(string name, string fileExtension, string subdirectory, string localizationName) { throw null; }
        public virtual Foundation.NSUrl[] GetUrlsForResourcesWithExtension(string fileExtension, string subdirectory) { throw null; }
        public static Foundation.NSUrl[] GetUrlsForResourcesWithExtension(string fileExtension, string subdirectory, Foundation.NSUrl bundleURL) { throw null; }
        public virtual Foundation.NSUrl[] GetUrlsForResourcesWithExtension(string fileExtension, string subdirectory, string localizationName) { throw null; }
        public virtual bool Load() { throw null; }
        public string LocalizedString(string key, string comment) { throw null; }
        public virtual string LocalizedString(string key, string value, string table) { throw null; }
        public string LocalizedString(string key, string val, string table, string comment) { throw null; }
        public virtual Foundation.NSObject ObjectForInfoDictionary(string key) { throw null; }
        public virtual string PathForAuxiliaryExecutable(string s) { throw null; }
        public virtual string PathForResource(string name, string ofType) { throw null; }
        public virtual string PathForResource(string name, string ofType, string subpath) { throw null; }
        public virtual string PathForResource(string name, string ofType, string subpath, string localizationName) { throw null; }
        public static string PathForResourceAbsolute(string name, string ofType, string bundleDirectory) { throw null; }
        public string[] PathsForResources(string fileExtension) { throw null; }
        public virtual string[] PathsForResources(string fileExtension, string subDirectory) { throw null; }
        public virtual string[] PathsForResources(string fileExtension, string subDirectory, string localizationName) { throw null; }
        public virtual void SetPreservationPriority(double priority, Foundation.NSSet<Foundation.NSString> tags) { }
        public virtual bool Unload() { throw null; }
        public virtual Foundation.NSUrl UrlForAuxiliaryExecutable(string executable) { throw null; }
    }
    public partial class NSCachedUrlResponse : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSCachedUrlResponse(Foundation.NSUrlResponse response, Foundation.NSData data) { }
        protected internal NSCachedUrlResponse(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSData Data { get { throw null; } }
        public virtual Foundation.NSUrlResponse Response { get { throw null; } }
        public virtual Foundation.NSDictionary UserInfo { get { throw null; } }
    }
    public partial class NSData : Foundation.NSObject, ObjCRuntime.INativeObject, System.Collections.Generic.IEnumerable<byte>, System.Collections.IEnumerable, System.IDisposable
    {
        public NSData() { }
        protected internal NSData(System.IntPtr handle) { }
        public NSData(System.IntPtr bytes, System.nuint length, System.Action<System.IntPtr, System.nuint> deallocator) { }
        public virtual System.IntPtr Bytes { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual byte this[System.nint idx] { get { throw null; } set { } }
        public virtual System.nuint Length { get { throw null; } set { } }
        public virtual System.IO.Stream AsStream() { throw null; }
        public static Foundation.NSData FromArray(byte[] buffer) { throw null; }
        public static Foundation.NSData FromBytes(System.IntPtr bytes, System.nuint size) { throw null; }
        public static Foundation.NSData FromBytesNoCopy(System.IntPtr bytes, System.nuint size) { throw null; }
        public static Foundation.NSData FromBytesNoCopy(System.IntPtr bytes, System.nuint size, bool freeWhenDone) { throw null; }
        public static Foundation.NSData FromData(Foundation.NSData source) { throw null; }
        public static Foundation.NSData FromFile(string path) { throw null; }
        public static Foundation.NSData FromStream(System.IO.Stream stream) { throw null; }
        public static Foundation.NSData FromString(string s) { throw null; }
        public static Foundation.NSData FromUrl(Foundation.NSUrl url) { throw null; }
        public virtual void GetBytes(System.IntPtr buffer, Foundation.NSRange range) { }
        public virtual void GetBytes(System.IntPtr buffer, System.nuint length) { }
        public static implicit operator Foundation.NSData (string s) { throw null; }
        public virtual bool Save(Foundation.NSUrl url, bool atomically) { throw null; }
        public bool Save(Foundation.NSUrl url, bool auxiliaryFile, out Foundation.NSError error) { throw null; }
        public virtual bool Save(string path, bool atomically) { throw null; }
        public bool Save(string file, bool auxiliaryFile, out Foundation.NSError error) { throw null; }
        public virtual Foundation.NSData Subdata(Foundation.NSRange range) { throw null; }
        System.Collections.Generic.IEnumerator<byte> System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public byte[] ToArray() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NSDate : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSDate() { }
        protected internal NSDate(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSDate DistantFuture { get { throw null; } }
        public static Foundation.NSDate DistantPast { get { throw null; } }
        public static Foundation.NSDate Now { get { throw null; } }
        public virtual double SecondsSinceReferenceDate { get { throw null; } }
        public virtual Foundation.NSDate AddSeconds(double seconds) { throw null; }
        public virtual string DescriptionWithLocale(Foundation.NSLocale locale) { throw null; }
        public virtual Foundation.NSDate EarlierDate(Foundation.NSDate anotherDate) { throw null; }
        public static Foundation.NSDate FromTimeIntervalSince1970(double secs) { throw null; }
        public static Foundation.NSDate FromTimeIntervalSinceNow(double secs) { throw null; }
        public static Foundation.NSDate FromTimeIntervalSinceReferenceDate(double secs) { throw null; }
        public virtual bool IsEqualToDate(Foundation.NSDate other) { throw null; }
        public virtual Foundation.NSDate LaterDate(Foundation.NSDate anotherDate) { throw null; }
        public static explicit operator System.DateTime (Foundation.NSDate d) { throw null; }
        public static explicit operator Foundation.NSDate (System.DateTime dt) { throw null; }
    }
    public partial class NSDictionary : Foundation.NSObject, ObjCRuntime.INativeObject, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>>, System.Collections.Generic.IDictionary<Foundation.NSObject, Foundation.NSObject>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.IDisposable
    {
        public NSDictionary() { }
        public NSDictionary(Foundation.NSDictionary other) { }
        public NSDictionary(Foundation.NSDictionary other, bool copyItems) { }
        public NSDictionary(Foundation.NSObject first, Foundation.NSObject second, params Foundation.NSObject[] args) { }
        public NSDictionary(Foundation.NSUrl url) { }
        public NSDictionary(Foundation.NSUrl url, out Foundation.NSError error) { throw null; }
        protected internal NSDictionary(System.IntPtr handle) { }
        public NSDictionary(object first, object second, params object[] args) { }
        public NSDictionary(string fileName) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual System.nuint Count { get { throw null; } }
        public virtual string DescriptionInStringsFileFormat { get { throw null; } }
        public virtual Foundation.NSObject this[Foundation.NSObject key] { get { throw null; } set { } }
        public virtual Foundation.NSObject this[Foundation.NSString key] { get { throw null; } set { } }
        public virtual Foundation.NSObject this[string key] { get { throw null; } set { } }
        public virtual Foundation.NSObject[] Keys { get { throw null; } }
        int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Count { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.ICollection<Foundation.NSObject> System.Collections.Generic.IDictionary<Foundation.NSObject,Foundation.NSObject>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<Foundation.NSObject> System.Collections.Generic.IDictionary<Foundation.NSObject,Foundation.NSObject>.Values { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IDictionary.IsFixedSize { get { throw null; } }
        bool System.Collections.IDictionary.IsReadOnly { get { throw null; } }
        object System.Collections.IDictionary.this[object key] { get { throw null; } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { throw null; } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { throw null; } }
        public virtual Foundation.NSObject[] Values { get { throw null; } }
        public bool ContainsKey(Foundation.NSObject key) { throw null; }
        public static Foundation.NSDictionary FromDictionary(Foundation.NSDictionary source) { throw null; }
        public static Foundation.NSDictionary FromFile(string path) { throw null; }
        public static Foundation.NSDictionary FromObjectAndKey(Foundation.NSObject obj, Foundation.NSObject key) { throw null; }
        public static Foundation.NSDictionary FromObjectsAndKeys(Foundation.NSObject[] objects, Foundation.NSObject[] keys) { throw null; }
        public static Foundation.NSDictionary FromObjectsAndKeys(Foundation.NSObject[] objects, Foundation.NSObject[] keys, System.nint count) { throw null; }
        public static Foundation.NSDictionary FromObjectsAndKeys(object[] objects, object[] keys) { throw null; }
        public static Foundation.NSDictionary FromObjectsAndKeys(object[] objects, object[] keys, System.nint count) { throw null; }
        public static Foundation.NSDictionary FromUrl(Foundation.NSUrl url) { throw null; }
        public static Foundation.NSDictionary<Foundation.NSString, Foundation.NSObject> FromUrl(Foundation.NSUrl url, out Foundation.NSError error) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>> GetEnumerator() { throw null; }
        public static Foundation.NSObject GetSharedKeySetForKeys(Foundation.NSObject[] keys) { throw null; }
        public virtual bool IsEqualToDictionary(Foundation.NSDictionary other) { throw null; }
        public virtual Foundation.NSObject[] KeysForObject(Foundation.NSObject obj) { throw null; }
        public System.IntPtr LowlevelObjectForKey(System.IntPtr key) { throw null; }
        public virtual Foundation.NSObject ObjectForKey(Foundation.NSObject key) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Add(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Contains(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject> keyValuePair) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.CopyTo(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Remove(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject> keyValuePair) { throw null; }
        void System.Collections.Generic.IDictionary<Foundation.NSObject,Foundation.NSObject>.Add(Foundation.NSObject key, Foundation.NSObject value) { }
        bool System.Collections.Generic.IDictionary<Foundation.NSObject,Foundation.NSObject>.Remove(Foundation.NSObject key) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        void System.Collections.IDictionary.Clear() { }
        bool System.Collections.IDictionary.Contains(object key) { throw null; }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { throw null; }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(Foundation.NSObject key, out Foundation.NSObject value) { throw null; }
        public virtual bool WriteToFile(string path, bool useAuxiliaryFile) { throw null; }
        public virtual bool WriteToUrl(Foundation.NSUrl url, bool atomically) { throw null; }
    }
    public sealed partial class NSDictionary<TKey, TValue> : Foundation.NSDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable where TKey : class, ObjCRuntime.INativeObject where TValue : class, ObjCRuntime.INativeObject
    {
        public NSDictionary() { }
        public NSDictionary(Foundation.NSDictionary<TKey, TValue> other) { }
        public NSDictionary(Foundation.NSUrl url) { }
        public NSDictionary(string filename) { }
        public NSDictionary(TKey key, TValue value) { }
        public NSDictionary(TKey[] keys, TValue[] values) { }
        public TValue this[TKey key] { get { throw null; } }
        public new TKey[] Keys { get { throw null; } }
        int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Count { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { throw null; } }
        TValue System.Collections.Generic.IDictionary<TKey,TValue>.this[TKey key] { get { throw null; } set { } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { throw null; } }
        public new TValue[] Values { get { throw null; } }
        public bool ContainsKey(TKey key) { throw null; }
        public static new Foundation.NSDictionary<TKey, TValue> FromObjectsAndKeys(Foundation.NSObject[] objects, Foundation.NSObject[] keys, System.nint count) { throw null; }
        public static new Foundation.NSDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys) { throw null; }
        public static new Foundation.NSDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys, System.nint count) { throw null; }
        public static Foundation.NSDictionary<TKey, TValue> FromObjectsAndKeys(TKey[] objects, TValue[] keys) { throw null; }
        public static Foundation.NSDictionary<TKey, TValue> FromObjectsAndKeys(TValue[] objects, TKey[] keys, System.nint count) { throw null; }
        public TKey[] KeysForObject(TValue obj) { throw null; }
        public TValue ObjectForKey(TKey key) { throw null; }
        public TValue[] ObjectsForKeys(TKey[] keys, TValue marker) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
        bool System.Collections.Generic.IDictionary<TKey,TValue>.ContainsKey(TKey key) { throw null; }
        bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { throw null; }
        bool System.Collections.Generic.IDictionary<TKey,TValue>.TryGetValue(TKey key, out TValue value) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(TKey key, out TValue value) { throw null; }
    }
    public partial class NSError : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSError() { }
        public NSError(Foundation.NSString domain, System.nint code) { }
        public NSError(Foundation.NSString domain, System.nint code, Foundation.NSDictionary userInfo) { }
        protected internal NSError(System.IntPtr handle) { }
        public static Foundation.NSString CFNetworkErrorDomain { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSString CocoaErrorDomain { get { throw null; } }
        public virtual System.nint Code { get { throw null; } }
        public static Foundation.NSString CoreMotionErrorDomain { get { throw null; } }
        public static Foundation.NSString DebugDescriptionErrorKey { get { throw null; } }
        public virtual string Domain { get { throw null; } }
        public static Foundation.NSString EABluetoothAccessoryPickerErrorDomain { get { throw null; } }
        public static Foundation.NSString FilePathErrorKey { get { throw null; } }
        public virtual string HelpAnchor { get { throw null; } }
        public static Foundation.NSString HelpAnchorErrorKey { get { throw null; } }
        public virtual string LocalizedDescription { get { throw null; } }
        public static Foundation.NSString LocalizedDescriptionKey { get { throw null; } }
        public static Foundation.NSString LocalizedFailureErrorKey { get { throw null; } }
        public virtual string LocalizedFailureReason { get { throw null; } }
        public static Foundation.NSString LocalizedFailureReasonErrorKey { get { throw null; } }
        public virtual string[] LocalizedRecoveryOptions { get { throw null; } }
        public static Foundation.NSString LocalizedRecoveryOptionsErrorKey { get { throw null; } }
        public virtual string LocalizedRecoverySuggestion { get { throw null; } }
        public static Foundation.NSString LocalizedRecoverySuggestionErrorKey { get { throw null; } }
        public static Foundation.NSString MachErrorDomain { get { throw null; } }
        public static Foundation.NSString NSStreamSocketSSLErrorDomain { get { throw null; } }
        public static Foundation.NSString NSStreamSOCKSErrorDomain { get { throw null; } }
        public static Foundation.NSString NSUrlErrorDomain { get { throw null; } }
        public static Foundation.NSString OsStatusErrorDomain { get { throw null; } }
        public static Foundation.NSString PosixErrorDomain { get { throw null; } }
        public static Foundation.NSString RecoveryAttempterErrorKey { get { throw null; } }
        public static Foundation.NSString StringEncodingErrorKey { get { throw null; } }
        public static Foundation.NSString UnderlyingErrorKey { get { throw null; } }
        public static Foundation.NSString UrlErrorKey { get { throw null; } }
        public virtual Foundation.NSDictionary UserInfo { get { throw null; } }
        public static Foundation.NSString WatchKitErrorDomain { get { throw null; } }
        public static Foundation.NSError FromDomain(Foundation.NSString domain, System.nint code) { throw null; }
        public static Foundation.NSError FromDomain(Foundation.NSString domain, System.nint code, Foundation.NSDictionary userInfo) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NSErrorException : System.Exception
    {
        public NSErrorException(Foundation.NSError error) { }
        public System.nint Code { get { throw null; } }
        public string Domain { get { throw null; } }
        public Foundation.NSError Error { get { throw null; } }
        public override string Message { get { throw null; } }
        public Foundation.NSDictionary UserInfo { get { throw null; } }
    }
    public partial class NSHttpCookie : Foundation.NSObject
    {
        public NSHttpCookie(Foundation.NSDictionary properties) { }
        protected internal NSHttpCookie(System.IntPtr handle) { }
        public NSHttpCookie(System.Net.Cookie cookie) { }
        public NSHttpCookie(string name, string value) { }
        public NSHttpCookie(string name, string value, string path) { }
        public NSHttpCookie(string name, string value, string path, string domain) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual string Comment { get { throw null; } }
        public virtual Foundation.NSUrl CommentUrl { get { throw null; } }
        public virtual string Domain { get { throw null; } }
        public virtual Foundation.NSDate ExpiresDate { get { throw null; } }
        public virtual bool IsHttpOnly { get { throw null; } }
        public virtual bool IsSecure { get { throw null; } }
        public virtual bool IsSessionOnly { get { throw null; } }
        public static Foundation.NSString KeyComment { get { throw null; } }
        public static Foundation.NSString KeyCommentUrl { get { throw null; } }
        public static Foundation.NSString KeyDiscard { get { throw null; } }
        public static Foundation.NSString KeyDomain { get { throw null; } }
        public static Foundation.NSString KeyExpires { get { throw null; } }
        public static Foundation.NSString KeyMaximumAge { get { throw null; } }
        public static Foundation.NSString KeyName { get { throw null; } }
        public static Foundation.NSString KeyOriginUrl { get { throw null; } }
        public static Foundation.NSString KeyPath { get { throw null; } }
        public static Foundation.NSString KeyPort { get { throw null; } }
        public static Foundation.NSString KeySecure { get { throw null; } }
        public static Foundation.NSString KeyValue { get { throw null; } }
        public static Foundation.NSString KeyVersion { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual string Path { get { throw null; } }
        public virtual Foundation.NSNumber[] PortList { get { throw null; } }
        public virtual Foundation.NSDictionary Properties { get { throw null; } }
        public virtual string Value { get { throw null; } }
        public virtual System.nuint Version { get { throw null; } }
        public static Foundation.NSHttpCookie CookieFromProperties(Foundation.NSDictionary properties) { throw null; }
        public static Foundation.NSHttpCookie[] CookiesWithResponseHeaderFields(Foundation.NSDictionary headerFields, Foundation.NSUrl url) { throw null; }
        public static Foundation.NSDictionary RequestHeaderFieldsWithCookies(Foundation.NSHttpCookie[] cookies) { throw null; }
    }
    public partial class NSHttpCookieStorage : Foundation.NSObject
    {
        protected internal NSHttpCookieStorage(System.IntPtr handle) { }
        public static Foundation.NSString AcceptPolicyChangedNotification { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSHttpCookie[] Cookies { get { throw null; } }
        public static Foundation.NSString CookiesChangedNotification { get { throw null; } }
        public static Foundation.NSHttpCookieStorage SharedStorage { get { throw null; } }
        public virtual Foundation.NSHttpCookie[] CookiesForUrl(Foundation.NSUrl url) { throw null; }
        public virtual void DeleteCookie(Foundation.NSHttpCookie cookie) { }
        public virtual void GetCookiesForTask(Foundation.NSUrlSessionTask task, System.Action<Foundation.NSHttpCookie[]> completionHandler) { }
        public virtual System.Threading.Tasks.Task<Foundation.NSHttpCookie[]> GetCookiesForTaskAsync(Foundation.NSUrlSessionTask task) { throw null; }
        public static Foundation.NSHttpCookieStorage GetSharedCookieStorage(string groupContainerIdentifier) { throw null; }
        public virtual void RemoveCookiesSinceDate(Foundation.NSDate date) { }
        public virtual void SetCookie(Foundation.NSHttpCookie cookie) { }
        public virtual void SetCookies(Foundation.NSHttpCookie[] cookies, Foundation.NSUrl forUrl, Foundation.NSUrl mainDocumentUrl) { }
        public virtual void StoreCookies(Foundation.NSHttpCookie[] cookies, Foundation.NSUrlSessionTask task) { }
    }
    public partial class NSHttpUrlResponse : Foundation.NSUrlResponse
    {
        public NSHttpUrlResponse() { }
        public NSHttpUrlResponse(Foundation.NSUrl url, System.nint statusCode, string httpVersion, Foundation.NSDictionary headerFields) { }
        public NSHttpUrlResponse(Foundation.NSUrl url, string mimetype, System.nint expectedContentLength, string textEncodingName) { }
        protected internal NSHttpUrlResponse(System.IntPtr handle) { }
        public virtual Foundation.NSDictionary AllHeaderFields { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual System.nint StatusCode { get { throw null; } }
        public static string LocalizedStringForStatusCode(System.nint statusCode) { throw null; }
    }
    public partial class NSInputStream : Foundation.NSStream
    {
        protected NSInputStream() { }
        public NSInputStream(Foundation.NSData data) { }
        public NSInputStream(Foundation.NSUrl url) { }
        protected internal NSInputStream(System.IntPtr handle) { }
        public NSInputStream(string path) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public static Foundation.NSInputStream FromData(Foundation.NSData data) { throw null; }
        public static Foundation.NSInputStream FromFile(string path) { throw null; }
        public static Foundation.NSInputStream FromUrl(Foundation.NSUrl url) { throw null; }
        protected virtual bool GetBuffer(out System.IntPtr buffer, out System.nuint len) { throw null; }
        public virtual bool HasBytesAvailable() { throw null; }
        public void Notify(CoreFoundation.CFStreamEventType eventType) { }
        public System.nint Read(byte[] buffer, int offset, System.nuint len) { throw null; }
        public System.nint Read(byte[] buffer, System.nuint len) { throw null; }
        public virtual System.nint Read(System.IntPtr buffer, System.nuint len) { throw null; }
        protected virtual bool SetCFClientFlags(CoreFoundation.CFStreamEventType inFlags, System.IntPtr inCallback, System.IntPtr inContextPtr) { throw null; }
    }
    public partial class NSLocale : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal NSLocale(System.IntPtr handle) { }
        public NSLocale(string identifier) { }
        public string AlternateQuotationBeginDelimiterKey { get { throw null; } }
        public string AlternateQuotationEndDelimiterKey { get { throw null; } }
        public static Foundation.NSLocale AutoUpdatingCurrentLocale { get { throw null; } }
        public static string[] AvailableLocaleIdentifiers { get { throw null; } }
        public virtual string CalendarIdentifier { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public string CollationIdentifier { get { throw null; } }
        public string CollatorIdentifier { get { throw null; } }
        public static string[] CommonISOCurrencyCodes { get { throw null; } }
        public string CountryCode { get { throw null; } }
        public string CurrencyCode { get { throw null; } }
        public string CurrencySymbol { get { throw null; } }
        public static Foundation.NSLocale CurrentLocale { get { throw null; } }
        public static Foundation.NSString CurrentLocaleDidChangeNotification { get { throw null; } }
        public string DecimalSeparator { get { throw null; } }
        public string GroupingSeparator { get { throw null; } }
        public string Identifier { get { throw null; } }
        public static string[] ISOCountryCodes { get { throw null; } }
        public static string[] ISOCurrencyCodes { get { throw null; } }
        public static string[] ISOLanguageCodes { get { throw null; } }
        public string LanguageCode { get { throw null; } }
        public virtual string LocaleIdentifier { get { throw null; } }
        public string MeasurementSystem { get { throw null; } }
        public static string[] PreferredLanguages { get { throw null; } }
        public string QuotationBeginDelimiterKey { get { throw null; } }
        public string QuotationEndDelimiterKey { get { throw null; } }
        public string ScriptCode { get { throw null; } }
        public static Foundation.NSLocale SystemLocale { get { throw null; } }
        public bool UsesMetricSystem { get { throw null; } }
        public string VariantCode { get { throw null; } }
        public static string CanonicalLanguageIdentifierFromString(string str) { throw null; }
        public static string CanonicalLocaleIdentifierFromString(string str) { throw null; }
        public static Foundation.NSDictionary ComponentsFromLocaleIdentifier(string identifier) { throw null; }
        public static Foundation.NSLocale FromLocaleIdentifier(string ident) { throw null; }
        public string GetCountryCodeDisplayName(string value) { throw null; }
        public string GetCurrencyCodeDisplayName(string value) { throw null; }
        public string GetIdentifierDisplayName(string value) { throw null; }
        public string GetLanguageCodeDisplayName(string value) { throw null; }
        public virtual string GetLocalizedCalendarIdentifier(string calendarIdentifier) { throw null; }
        public static string LocaleIdentifierFromComponents(Foundation.NSDictionary dict) { throw null; }
    }
    public partial class NSMutableAttributedString : Foundation.NSAttributedString
    {
        public NSMutableAttributedString() { }
        public NSMutableAttributedString(Foundation.NSAttributedString other) { }
        protected internal NSMutableAttributedString(System.IntPtr handle) { }
        public NSMutableAttributedString(string str) { }
        public NSMutableAttributedString(string str, CoreText.CTStringAttributes attributes) { }
        public NSMutableAttributedString(string str, Foundation.NSDictionary attributes) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual void AddAttribute(Foundation.NSString attributeName, Foundation.NSObject value, Foundation.NSRange range) { }
        public void AddAttributes(CoreText.CTStringAttributes attrs, Foundation.NSRange range) { }
        public virtual void AddAttributes(Foundation.NSDictionary attrs, Foundation.NSRange range) { }
        public virtual void Append(Foundation.NSAttributedString attrString) { }
        public void Append(Foundation.NSAttributedString first, params object[] rest) { }
        public virtual void BeginEditing() { }
        public virtual void DeleteRange(Foundation.NSRange range) { }
        public virtual void EndEditing() { }
        public virtual void Insert(Foundation.NSAttributedString attrString, System.nint location) { }
        public virtual void LowLevelSetAttributes(System.IntPtr dictionaryAttrsHandle, Foundation.NSRange range) { }
        public virtual bool ReadFromData(Foundation.NSData data, Foundation.NSDictionary options, ref Foundation.NSDictionary returnOptions, ref Foundation.NSError error) { throw null; }
        public virtual bool ReadFromFile(Foundation.NSUrl url, Foundation.NSDictionary options, ref Foundation.NSDictionary returnOptions, ref Foundation.NSError error) { throw null; }
        public virtual bool ReadFromUrl(Foundation.NSUrl url, Foundation.NSDictionary<Foundation.NSString, Foundation.NSObject> options, ref Foundation.NSDictionary<Foundation.NSString, Foundation.NSObject> returnOptions, ref Foundation.NSError error) { throw null; }
        public virtual void RemoveAttribute(string name, Foundation.NSRange range) { }
        public virtual void Replace(Foundation.NSRange range, Foundation.NSAttributedString value) { }
        public virtual void Replace(Foundation.NSRange range, string newValue) { }
        public void SetAttributes(CoreText.CTStringAttributes attrs, Foundation.NSRange range) { }
        public void SetAttributes(Foundation.NSDictionary attributes, Foundation.NSRange range) { }
        public virtual void SetString(Foundation.NSAttributedString attrString) { }
    }
    public partial class NSMutableData : Foundation.NSData, System.Collections.Generic.IEnumerable<byte>, System.Collections.IEnumerable
    {
        public NSMutableData() { }
        protected internal NSMutableData(System.IntPtr handle) { }
        public NSMutableData(System.nuint capacity) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public override byte this[System.nint idx] { set { } }
        public override System.nuint Length { get { throw null; } set { } }
        public virtual System.IntPtr MutableBytes { get { throw null; } }
        public void AppendBytes(byte[] bytes) { }
        public void AppendBytes(byte[] bytes, System.nint start, System.nint len) { }
        public virtual void AppendBytes(System.IntPtr bytes, System.nuint len) { }
        public virtual void AppendData(Foundation.NSData other) { }
        public static Foundation.NSMutableData Create() { throw null; }
        public static Foundation.NSMutableData FromCapacity(System.nint capacity) { throw null; }
        public static Foundation.NSMutableData FromLength(System.nint length) { throw null; }
        public virtual void ReplaceBytes(Foundation.NSRange range, System.IntPtr buffer) { }
        public virtual void ReplaceBytes(Foundation.NSRange range, System.IntPtr buffer, System.nuint length) { }
        public virtual void ResetBytes(Foundation.NSRange range) { }
        public virtual void SetData(Foundation.NSData data) { }
        System.Collections.Generic.IEnumerator<byte> System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class NSMutableDictionary : Foundation.NSDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>>, System.Collections.Generic.IDictionary<Foundation.NSObject, Foundation.NSObject>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public NSMutableDictionary() { }
        public NSMutableDictionary(Foundation.NSDictionary other) { }
        public NSMutableDictionary(Foundation.NSDictionary other, bool copyItems) { }
        public NSMutableDictionary(Foundation.NSUrl url) { }
        protected internal NSMutableDictionary(System.IntPtr handle) { }
        public NSMutableDictionary(string fileName) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public override Foundation.NSObject this[Foundation.NSObject key] { get { throw null; } set { } }
        public override Foundation.NSObject this[Foundation.NSString key] { get { throw null; } set { } }
        public override Foundation.NSObject this[string key] { get { throw null; } set { } }
        int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Count { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.ICollection<Foundation.NSObject> System.Collections.Generic.IDictionary<Foundation.NSObject,Foundation.NSObject>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<Foundation.NSObject> System.Collections.Generic.IDictionary<Foundation.NSObject,Foundation.NSObject>.Values { get { throw null; } }
        bool System.Collections.IDictionary.IsFixedSize { get { throw null; } }
        bool System.Collections.IDictionary.IsReadOnly { get { throw null; } }
        object System.Collections.IDictionary.this[object key] { get { throw null; } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { throw null; } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { throw null; } }
        public void Add(Foundation.NSObject key, Foundation.NSObject value) { }
        public virtual void AddEntries(Foundation.NSDictionary other) { }
        public void Clear() { }
        public static new Foundation.NSMutableDictionary FromDictionary(Foundation.NSDictionary source) { throw null; }
        public static new Foundation.NSMutableDictionary FromFile(string path) { throw null; }
        public static new Foundation.NSMutableDictionary FromObjectAndKey(Foundation.NSObject obj, Foundation.NSObject key) { throw null; }
        public static new Foundation.NSMutableDictionary FromObjectsAndKeys(Foundation.NSObject[] objects, Foundation.NSObject[] keys) { throw null; }
        public static new Foundation.NSMutableDictionary FromObjectsAndKeys(Foundation.NSObject[] objects, Foundation.NSObject[] keys, System.nint count) { throw null; }
        public static new Foundation.NSMutableDictionary FromObjectsAndKeys(object[] objects, object[] keys) { throw null; }
        public static new Foundation.NSMutableDictionary FromObjectsAndKeys(object[] objects, object[] keys, System.nint count) { throw null; }
        public static Foundation.NSDictionary FromSharedKeySet(Foundation.NSObject sharedKeyToken) { throw null; }
        public static new Foundation.NSMutableDictionary FromUrl(Foundation.NSUrl url) { throw null; }
        public new System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>> GetEnumerator() { throw null; }
        public static Foundation.NSMutableDictionary LowlevelFromObjectAndKey(System.IntPtr obj, System.IntPtr key) { throw null; }
        public void LowlevelSetObject(Foundation.NSObject obj, System.IntPtr key) { }
        public void LowlevelSetObject(System.IntPtr obj, System.IntPtr key) { }
        public bool Remove(Foundation.NSObject key) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Add(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject> item) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Contains(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject> keyValuePair) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.CopyTo(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject>[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Foundation.NSObject,Foundation.NSObject>>.Remove(System.Collections.Generic.KeyValuePair<Foundation.NSObject, Foundation.NSObject> keyValuePair) { throw null; }
        void System.Collections.IDictionary.Add(object key, object value) { }
        bool System.Collections.IDictionary.Contains(object key) { throw null; }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { throw null; }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public new bool TryGetValue(Foundation.NSObject key, out Foundation.NSObject value) { throw null; }
    }
    public sealed partial class NSMutableDictionary<TKey, TValue> : Foundation.NSMutableDictionary, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable where TKey : class, ObjCRuntime.INativeObject where TValue : class, ObjCRuntime.INativeObject
    {
        public NSMutableDictionary() { }
        public NSMutableDictionary(Foundation.NSDictionary<TKey, TValue> other) { }
        public NSMutableDictionary(Foundation.NSMutableDictionary<TKey, TValue> other) { }
        public NSMutableDictionary(TKey key, TValue value) { }
        public NSMutableDictionary(TKey[] keys, TValue[] values) { }
        public TValue this[TKey index] { get { throw null; } set { } }
        public new TKey[] Keys { get { throw null; } }
        int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Count { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { throw null; } }
        TValue System.Collections.Generic.IDictionary<TKey,TValue>.this[TKey index] { get { throw null; } set { } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { throw null; } }
        public new TValue[] Values { get { throw null; } }
        public void Add(TKey key, TValue value) { }
        public bool ContainsKey(TKey key) { throw null; }
        public static new Foundation.NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(Foundation.NSObject[] objects, Foundation.NSObject[] keys, System.nint count) { throw null; }
        public static new Foundation.NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys) { throw null; }
        public static new Foundation.NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(object[] objects, object[] keys, System.nint count) { throw null; }
        public static Foundation.NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(TKey[] objects, TValue[] keys) { throw null; }
        public static Foundation.NSMutableDictionary<TKey, TValue> FromObjectsAndKeys(TValue[] objects, TKey[] keys, System.nint count) { throw null; }
        public TKey[] KeysForObject(TValue obj) { throw null; }
        public TValue ObjectForKey(TKey key) { throw null; }
        public TValue[] ObjectsForKeys(TKey[] keys, TValue marker) { throw null; }
        public bool Remove(TKey key) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { throw null; }
        void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
        bool System.Collections.Generic.IDictionary<TKey,TValue>.ContainsKey(TKey key) { throw null; }
        bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { throw null; }
        bool System.Collections.Generic.IDictionary<TKey,TValue>.TryGetValue(TKey key, out TValue value) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(TKey key, out TValue value) { throw null; }
    }
    public partial class NSMutableUrlRequest : Foundation.NSUrlRequest
    {
        public NSMutableUrlRequest() { }
        public NSMutableUrlRequest(Foundation.NSUrl url) { }
        public NSMutableUrlRequest(Foundation.NSUrl url, Foundation.NSUrlRequestCachePolicy cachePolicy, double timeoutInterval) { }
        protected internal NSMutableUrlRequest(System.IntPtr handle) { }
        public virtual new bool AllowsCellularAccess { get { throw null; } set { } }
        public virtual new Foundation.NSData Body { get { throw null; } set { } }
        public virtual new Foundation.NSInputStream BodyStream { get { throw null; } set { } }
        public virtual new Foundation.NSUrlRequestCachePolicy CachePolicy { get { throw null; } set { } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual new Foundation.NSDictionary Headers { get { throw null; } set { } }
        public virtual new string HttpMethod { get { throw null; } set { } }
        public new string this[string key] { get { throw null; } set { } }
        public virtual new Foundation.NSUrl MainDocumentURL { get { throw null; } set { } }
        public virtual new bool ShouldHandleCookies { get { throw null; } set { } }
        public virtual new double TimeoutInterval { get { throw null; } set { } }
        public virtual new Foundation.NSUrl Url { get { throw null; } set { } }
    }
    public enum NSNetServicesStatus : long
    {
        ActivityInProgress = (long)-72003,
        BadArgumentError = (long)-72004,
        CancelledError = (long)-72005,
        CollisionError = (long)-72001,
        InvalidError = (long)-72006,
        NotFoundError = (long)-72002,
        TimeoutError = (long)-72007,
        UnknownError = (long)-72000,
    }
    public partial class NSNotification : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal NSNotification(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual Foundation.NSObject Object { get { throw null; } }
        public virtual Foundation.NSDictionary UserInfo { get { throw null; } }
        public static Foundation.NSNotification FromName(string name, Foundation.NSObject obj) { throw null; }
        public static Foundation.NSNotification FromName(string name, Foundation.NSObject obj, Foundation.NSDictionary userInfo) { throw null; }
    }
    public partial class NSNotificationCenter : Foundation.NSObject
    {
        public NSNotificationCenter() { }
        protected internal NSNotificationCenter(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSNotificationCenter DefaultCenter { get { throw null; } }
        public Foundation.NSObject AddObserver(Foundation.NSString aName, System.Action<Foundation.NSNotification> notify) { throw null; }
        public Foundation.NSObject AddObserver(Foundation.NSString aName, System.Action<Foundation.NSNotification> notify, Foundation.NSObject fromObject) { throw null; }
        public virtual void PostNotification(Foundation.NSNotification notification) { }
        public virtual void PostNotificationName(string aName, Foundation.NSObject anObject) { }
        public virtual void PostNotificationName(string aName, Foundation.NSObject anObject, Foundation.NSDictionary aUserInfo) { }
        public virtual void RemoveObserver(Foundation.NSObject observer) { }
        public virtual void RemoveObserver(Foundation.NSObject observer, string aName, Foundation.NSObject anObject) { }
        public void RemoveObservers(System.Collections.Generic.IEnumerable<Foundation.NSObject> keys) { }
    }
    public partial class NSNumber : Foundation.NSValue, ObjCRuntime.INativeObject, System.IComparable, System.IComparable<Foundation.NSNumber>, System.IDisposable, System.IEquatable<Foundation.NSNumber>
    {
        protected internal NSNumber(System.IntPtr handle) : base (default(System.IntPtr)) { }
        public virtual bool BoolValue { get { throw null; } }
        public virtual byte ByteValue { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual double DoubleValue { get { throw null; } }
        public virtual float FloatValue { get { throw null; } }
        public virtual short Int16Value { get { throw null; } }
        public virtual int Int32Value { get { throw null; } }
        public virtual long Int64Value { get { throw null; } }
        public virtual System.nint LongValue { get { throw null; } }
        public System.nfloat NFloatValue { get { throw null; } }
        public virtual System.nint NIntValue { get { throw null; } }
        public virtual System.nuint NUIntValue { get { throw null; } }
        public virtual sbyte SByteValue { get { throw null; } }
        public virtual string StringValue { get { throw null; } }
        public virtual ushort UInt16Value { get { throw null; } }
        public virtual uint UInt32Value { get { throw null; } }
        public virtual ulong UInt64Value { get { throw null; } }
        public virtual System.nuint UnsignedLongValue { get { throw null; } }
        public virtual System.nint Compare(Foundation.NSNumber otherNumber) { throw null; }
        public int CompareTo(Foundation.NSNumber other) { throw null; }
        public int CompareTo(object obj) { throw null; }
        public virtual string DescriptionWithLocale(Foundation.NSLocale locale) { throw null; }
        public bool Equals(Foundation.NSNumber other) { throw null; }
        public override bool Equals(object other) { throw null; }
        public static Foundation.NSNumber FromBoolean(bool value) { throw null; }
        public static Foundation.NSNumber FromByte(byte value) { throw null; }
        public static Foundation.NSNumber FromDouble(double value) { throw null; }
        public static Foundation.NSNumber FromFloat(float value) { throw null; }
        public static Foundation.NSNumber FromInt16(short value) { throw null; }
        public static Foundation.NSNumber FromInt32(int value) { throw null; }
        public static Foundation.NSNumber FromInt64(long value) { throw null; }
        public static Foundation.NSNumber FromLong(System.nint value) { throw null; }
        public static Foundation.NSNumber FromNFloat(System.nfloat value) { throw null; }
        public static Foundation.NSNumber FromNInt(System.nint value) { throw null; }
        public static Foundation.NSNumber FromNUInt(System.nuint value) { throw null; }
        public static Foundation.NSNumber FromSByte(sbyte value) { throw null; }
        public static Foundation.NSNumber FromUInt16(ushort value) { throw null; }
        public static Foundation.NSNumber FromUInt32(uint value) { throw null; }
        public static Foundation.NSNumber FromUInt64(ulong value) { throw null; }
        public static Foundation.NSNumber FromUnsignedLong(System.nuint value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static explicit operator bool (Foundation.NSNumber source) { throw null; }
        public static explicit operator byte (Foundation.NSNumber source) { throw null; }
        public static explicit operator double (Foundation.NSNumber source) { throw null; }
        public static explicit operator short (Foundation.NSNumber source) { throw null; }
        public static explicit operator int (Foundation.NSNumber source) { throw null; }
        public static explicit operator long (Foundation.NSNumber source) { throw null; }
        public static explicit operator sbyte (Foundation.NSNumber source) { throw null; }
        public static explicit operator float (Foundation.NSNumber source) { throw null; }
        public static explicit operator ushort (Foundation.NSNumber source) { throw null; }
        public static explicit operator uint (Foundation.NSNumber source) { throw null; }
        public static explicit operator ulong (Foundation.NSNumber source) { throw null; }
        public static implicit operator Foundation.NSNumber (bool value) { throw null; }
        public static implicit operator Foundation.NSNumber (byte value) { throw null; }
        public static implicit operator Foundation.NSNumber (double value) { throw null; }
        public static implicit operator Foundation.NSNumber (short value) { throw null; }
        public static implicit operator Foundation.NSNumber (int value) { throw null; }
        public static implicit operator Foundation.NSNumber (long value) { throw null; }
        public static implicit operator Foundation.NSNumber (sbyte value) { throw null; }
        public static implicit operator Foundation.NSNumber (float value) { throw null; }
        public static implicit operator Foundation.NSNumber (ushort value) { throw null; }
        public static implicit operator Foundation.NSNumber (uint value) { throw null; }
        public static implicit operator Foundation.NSNumber (ulong value) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NSObject : ObjCRuntime.INativeObject, System.IDisposable, System.IEquatable<Foundation.NSObject>
    {
        public static readonly System.Reflection.Assembly MonoTouchAssembly;
        public static readonly System.Reflection.Assembly PlatformAssembly;
        public NSObject() { }
        public NSObject(System.IntPtr handle) { }
        public NSObject(System.IntPtr handle, bool alloced) { }
        public static Foundation.NSString ChangeIndexesKey { get { throw null; } }
        public static Foundation.NSString ChangeKindKey { get { throw null; } }
        public static Foundation.NSString ChangeNewKey { get { throw null; } }
        public static Foundation.NSString ChangeNotificationIsPriorKey { get { throw null; } }
        public static Foundation.NSString ChangeOldKey { get { throw null; } }
        public virtual ObjCRuntime.Class Class { get { throw null; } }
        public virtual System.IntPtr ClassHandle { get { throw null; } }
        public virtual string DebugDescription { get { throw null; } }
        public virtual string Description { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } set { } }
        protected internal bool IsDirectBinding { get { throw null; } set { } }
        public virtual bool IsProxy { get { throw null; } }
        public virtual System.nuint RetainCount { get { throw null; } }
        public virtual Foundation.NSObject Self { get { throw null; } }
        public virtual ObjCRuntime.Class Superclass { get { throw null; } }
        public System.IntPtr SuperHandle { get { throw null; } }
        public static Foundation.NSObject Alloc(ObjCRuntime.Class kls) { throw null; }
        public static bool AutomaticallyNotifiesObserversForKey(string key) { throw null; }
        public virtual void AwakeFromNib() { }
        public void BeginInvokeOnMainThread(System.Action action) { }
        public static void CancelPreviousPerformRequest(Foundation.NSObject aTarget) { }
        public virtual bool ConformsToProtocol(System.IntPtr protocol) { throw null; }
        public virtual Foundation.NSObject Copy() { throw null; }
        public Foundation.NSObject DangerousAutorelease() { throw null; }
        public void DangerousRelease() { }
        public Foundation.NSObject DangerousRetain() { throw null; }
        public virtual void DidChangeValue(string forKey) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public bool Equals(Foundation.NSObject obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        ~NSObject() { }
        public static Foundation.NSObject FromObject(object obj) { throw null; }
        public virtual Foundation.NSDictionary GetDictionaryOfValuesFromKeys(Foundation.NSString[] keys) { throw null; }
        public override int GetHashCode() { throw null; }
        public static Foundation.NSSet GetKeyPathsForValuesAffecting(Foundation.NSString key) { throw null; }
        public Foundation.NSObject GetNativeField(string name) { throw null; }
        public virtual System.nuint GetNativeHash() { throw null; }
        public void Init() { }
        protected void InitializeHandle(System.IntPtr handle) { }
        public virtual void Invoke(System.Action action, double delay) { }
        public virtual void Invoke(System.Action action, System.TimeSpan delay) { }
        public static void InvokeInBackground(System.Action action) { }
        public void InvokeOnMainThread(System.Action action) { }
        public virtual bool IsEqual(Foundation.NSObject anObject) { throw null; }
        public virtual bool IsKindOfClass(ObjCRuntime.Class aClass) { throw null; }
        public virtual bool IsMemberOfClass(ObjCRuntime.Class aClass) { throw null; }
        public static bool IsNewRefcountEnabled() { throw null; }
        protected void MarkDirty() { }
        public virtual Foundation.NSObject MutableCopy() { throw null; }
        public virtual void ObserveValue(Foundation.NSString keyPath, Foundation.NSObject ofObject, Foundation.NSDictionary change, System.IntPtr context) { }
        public virtual void PrepareForInterfaceBuilder() { }
        public virtual void RemoveObserver(Foundation.NSObject observer, Foundation.NSString keyPath) { }
        public virtual void RemoveObserver(Foundation.NSObject observer, Foundation.NSString keyPath, System.IntPtr context) { }
        public void RemoveObserver(Foundation.NSObject observer, string keyPath) { }
        public void RemoveObserver(Foundation.NSObject observer, string keyPath, System.IntPtr context) { }
        public void SetNativeField(string name, Foundation.NSObject value) { }
        public virtual void SetNilValueForKey(Foundation.NSString key) { }
        public virtual void SetValueForKey(Foundation.NSObject value, Foundation.NSString key) { }
        public virtual void SetValueForKeyPath(Foundation.NSObject value, Foundation.NSString keyPath) { }
        public void SetValueForKeyPath(System.IntPtr handle, Foundation.NSString keyPath) { }
        public virtual void SetValueForUndefinedKey(Foundation.NSObject value, Foundation.NSString undefinedKey) { }
        public virtual void SetValuesForKeysWithDictionary(Foundation.NSDictionary keyedValues) { }
        public override string ToString() { throw null; }
        public virtual Foundation.NSObject ValueForKey(Foundation.NSString key) { throw null; }
        public virtual Foundation.NSObject ValueForKeyPath(Foundation.NSString keyPath) { throw null; }
        public virtual Foundation.NSObject ValueForUndefinedKey(Foundation.NSString key) { throw null; }
        public virtual void WillChangeValue(string forKey) { }
        public class NSObject_Disposer : NSObject
        {
            private NSObject_Disposer () { }
        }
    }
    public partial class NSOperationQueue : Foundation.NSObject
    {
        public NSOperationQueue() { }
        protected internal NSOperationQueue(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSOperationQueue CurrentQueue { get { throw null; } }
        public static Foundation.NSOperationQueue MainQueue { get { throw null; } }
        public virtual System.nint MaxConcurrentOperationCount { get { throw null; } set { } }
        public virtual string Name { get { throw null; } set { } }
        public virtual System.nint OperationCount { get { throw null; } }
        public virtual bool Suspended { get { throw null; } set { } }
        public virtual void AddOperation(System.Action operation) { }
        public virtual void CancelAllOperations() { }
        public virtual void WaitUntilAllOperationsAreFinished() { }
    }
    public partial struct NSRange
    {
        public System.nint Length;
        public System.nint Location;
        public static readonly System.nint NotFound;
        public NSRange(System.nint start, System.nint len) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NSRunLoop : Foundation.NSObject
    {
        protected internal NSRunLoop(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSRunLoop Current { get { throw null; } }
        public virtual Foundation.NSString CurrentMode { get { throw null; } }
        public static Foundation.NSRunLoop Main { get { throw null; } }
        public static Foundation.NSString NSDefaultRunLoopMode { get { throw null; } }
        public static Foundation.NSString NSRunLoopCommonModes { get { throw null; } }
        public static Foundation.NSString UITrackingRunLoopMode { get { throw null; } }
        public virtual void AcceptInputForMode(Foundation.NSString mode, Foundation.NSDate limitDate) { }
        public virtual CoreFoundation.CFRunLoop GetCFRunLoop() { throw null; }
        public virtual Foundation.NSDate LimitDateForMode(Foundation.NSString mode) { throw null; }
        public virtual void Perform(Foundation.NSString[] modes, System.Action block) { }
        public virtual void Perform(System.Action block) { }
        public virtual void Run() { }
        public virtual void RunUntil(Foundation.NSDate date) { }
        public virtual bool RunUntil(Foundation.NSString runLoopMode, Foundation.NSDate limitdate) { throw null; }
        public void Stop() { }
        public void WakeUp() { }
    }
    public partial class NSSet : Foundation.NSObject, ObjCRuntime.INativeObject, System.Collections.Generic.IEnumerable<Foundation.NSObject>, System.Collections.IEnumerable, System.IDisposable
    {
        public NSSet() { }
        public NSSet(params Foundation.NSObject[] objs) { }
        public NSSet(Foundation.NSSet other) { }
        protected internal NSSet(System.IntPtr handle) { }
        public NSSet(params object[] objs) { }
        public NSSet(params string[] strings) { }
        public virtual Foundation.NSObject AnyObject { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual System.nuint Count { get { throw null; } }
        public virtual bool Contains(Foundation.NSObject id) { throw null; }
        public bool Contains(object obj) { throw null; }
        public static Foundation.NSSet CreateSet() { throw null; }
        public System.Collections.Generic.IEnumerator<Foundation.NSObject> GetEnumerator() { throw null; }
        public virtual bool IntersectsSet(Foundation.NSSet other) { throw null; }
        public virtual bool IsEqualToSet(Foundation.NSSet other) { throw null; }
        public virtual bool IsSubsetOf(Foundation.NSSet other) { throw null; }
        public virtual Foundation.NSObject LookupMember(Foundation.NSObject probe) { throw null; }
        public static Foundation.NSSet MakeNSObjectSet<T>(T[] values) where T : class, ObjCRuntime.INativeObject { throw null; }
        public static Foundation.NSSet operator +(Foundation.NSSet first, Foundation.NSSet second) { throw null; }
        public static Foundation.NSSet operator -(Foundation.NSSet first, Foundation.NSSet second) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public T[] ToArray<T>() where T : class, ObjCRuntime.INativeObject { throw null; }
    }
    public sealed partial class NSSet<TKey> : Foundation.NSSet, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable where TKey : class, ObjCRuntime.INativeObject
    {
        public NSSet() { }
        public NSSet(Foundation.NSSet<TKey> other) { }
        public NSSet(params TKey[] objs) { }
        public new TKey AnyObject { get { throw null; } }
        public bool Contains(TKey obj) { throw null; }
        public TKey LookupMember(TKey probe) { throw null; }
        public static Foundation.NSSet<TKey> operator +(Foundation.NSSet<TKey> first, Foundation.NSSet<TKey> second) { throw null; }
        public static Foundation.NSSet<TKey> operator -(Foundation.NSSet<TKey> first, Foundation.NSSet<TKey> second) { throw null; }
        System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public TKey[] ToArray() { throw null; }
    }
    public partial class NSStream : Foundation.NSObject
    {
        public NSStream() { }
        protected internal NSStream(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public Foundation.NSData DataWrittenToMemoryStream { get { throw null; } }
        public static Foundation.NSString DataWrittenToMemoryStreamKey { get { throw null; } }
        public virtual Foundation.NSError Error { get { throw null; } }
        public Foundation.NSNumber FileCurrentOffset { get { throw null; } }
        public static Foundation.NSString FileCurrentOffsetKey { get { throw null; } }
        public Foundation.NSObject this[Foundation.NSString key] { get { throw null; } set { } }
        public static Foundation.NSString NetworkServiceType { get { throw null; } }
        public static Foundation.NSString NetworkServiceTypeBackground { get { throw null; } }
        public static Foundation.NSString NetworkServiceTypeCallSignaling { get { throw null; } }
        public static Foundation.NSString NetworkServiceTypeVideo { get { throw null; } }
        public static Foundation.NSString NetworkServiceTypeVoice { get { throw null; } }
        public static Foundation.NSString NetworkServiceTypeVoIP { get { throw null; } }
        public static Foundation.NSString SocketSecurityLevelKey { get { throw null; } }
        public static Foundation.NSString SocketSecurityLevelNegotiatedSsl { get { throw null; } }
        public static Foundation.NSString SocketSecurityLevelNone { get { throw null; } }
        public static Foundation.NSString SocketSecurityLevelSslV2 { get { throw null; } }
        public static Foundation.NSString SocketSecurityLevelSslV3 { get { throw null; } }
        public static Foundation.NSString SocketSecurityLevelTlsV1 { get { throw null; } }
        public static Foundation.NSString SocketSslErrorDomain { get { throw null; } }
        public static Foundation.NSString SocksErrorDomain { get { throw null; } }
        public static Foundation.NSString SocksProxyConfigurationKey { get { throw null; } }
        public static Foundation.NSString SocksProxyHostKey { get { throw null; } }
        public static Foundation.NSString SocksProxyPasswordKey { get { throw null; } }
        public static Foundation.NSString SocksProxyPortKey { get { throw null; } }
        public static Foundation.NSString SocksProxyUserKey { get { throw null; } }
        public static Foundation.NSString SocksProxyVersion4 { get { throw null; } }
        public static Foundation.NSString SocksProxyVersion5 { get { throw null; } }
        public static Foundation.NSString SocksProxyVersionKey { get { throw null; } }
        public virtual Foundation.NSStreamStatus Status { get { throw null; } }
        public virtual Foundation.NSObject WeakDelegate { get { throw null; } set { } }
        public virtual void Close() { }
        protected override void Dispose(bool disposing) { }
        protected virtual Foundation.NSObject GetProperty(Foundation.NSString key) { throw null; }
        public virtual void Open() { }
        public virtual void Schedule(Foundation.NSRunLoop aRunLoop, string mode) { }
        protected virtual bool SetProperty(Foundation.NSObject property, Foundation.NSString key) { throw null; }
        public virtual void Unschedule(Foundation.NSRunLoop aRunLoop, string mode) { }
    }
    public enum NSStreamStatus : ulong
    {
        AtEnd = (ulong)5,
        Closed = (ulong)6,
        Error = (ulong)7,
        NotOpen = (ulong)0,
        Open = (ulong)2,
        Opening = (ulong)1,
        Reading = (ulong)3,
        Writing = (ulong)4,
    }
    public partial class NSString : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public static readonly Foundation.NSString Empty;
        public NSString() { }
        protected internal NSString(System.IntPtr handle) { }
        public NSString(string str) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual bool IsAbsolutePath { get { throw null; } }
        public char this[System.nint idx] { get { throw null; } }
        public virtual Foundation.NSString LastPathComponent { get { throw null; } }
        public virtual System.nint Length { get { throw null; } }
        public virtual Foundation.NSString LocalizedCapitalizedString { get { throw null; } }
        public virtual Foundation.NSString LocalizedLowercaseString { get { throw null; } }
        public virtual Foundation.NSString LocalizedUppercaseString { get { throw null; } }
        public virtual string[] PathComponents { get { throw null; } }
        public virtual Foundation.NSString PathExtension { get { throw null; } }
        public static string[] ReadableTypeIdentifiers { get { throw null; } }
        public static string[] WritableTypeIdentifiers { get { throw null; } }
        public virtual string[] WritableTypeIdentifiersForItemProvider { get { throw null; } }
        public virtual Foundation.NSString AbbreviateTildeInPath() { throw null; }
        public virtual Foundation.NSString AppendPathComponent(Foundation.NSString str) { throw null; }
        public virtual Foundation.NSString AppendPathExtension(Foundation.NSString str) { throw null; }
        public virtual string[] AppendPaths(string[] paths) { throw null; }
        public virtual string Capitalize(Foundation.NSLocale locale) { throw null; }
        public virtual bool Contains(Foundation.NSString str) { throw null; }
        public static System.IntPtr CreateNative(string str) { throw null; }
        public static System.IntPtr CreateNative(string str, bool autorelease) { throw null; }
        public virtual Foundation.NSString DeleteLastPathComponent() { throw null; }
        public virtual Foundation.NSString DeletePathExtension() { throw null; }
        public static System.nuint DetectStringEncoding(Foundation.NSData rawData, Foundation.NSDictionary options, out string convertedString, out bool usedLossyConversion) { throw null; }
        public static bool Equals(Foundation.NSString a, Foundation.NSString b) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public virtual Foundation.NSString ExpandTildeInPath() { throw null; }
        public static string FromHandle(System.IntPtr usrhandle) { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual void GetLineStart(out System.nuint startPtr, out System.nuint lineEndPtr, out System.nuint contentsEndPtr, Foundation.NSRange range) { throw null; }
        public static Foundation.NSString GetLocalizedUserNotificationString(Foundation.NSString key, params Foundation.NSObject[] arguments) { throw null; }
        public static string GetLocalizedUserNotificationString(string key, params Foundation.NSObject[] arguments) { throw null; }
        public static Foundation.NSString GetObject(Foundation.NSData data, string typeIdentifier, out Foundation.NSError outError) { throw null; }
        public virtual void GetParagraphPositions(out System.nuint paragraphStartPosition, out System.nuint paragraphEndPosition, out System.nuint contentsEndPosition, Foundation.NSRange range) { throw null; }
        public virtual Foundation.NSRange GetParagraphRange(Foundation.NSRange range) { throw null; }
        public virtual Foundation.NSString GetVariantFittingPresentationWidth(System.nint width) { throw null; }
        public virtual bool HasPrefix(Foundation.NSString prefix) { throw null; }
        public virtual bool HasSuffix(Foundation.NSString suffix) { throw null; }
        public bool IsEqualTo(System.IntPtr handle) { throw null; }
        public virtual Foundation.NSRange LineRangeForRange(Foundation.NSRange range) { throw null; }
        public virtual System.Threading.Tasks.Task<Foundation.NSData> LoadDataAsync(string typeIdentifier) { throw null; }
        public virtual bool LocalizedCaseInsensitiveContains(Foundation.NSString str) { throw null; }
        public static Foundation.NSString LocalizedFormat(Foundation.NSString format, Foundation.NSObject[] args) { throw null; }
        public static Foundation.NSString LocalizedFormat(Foundation.NSString format, params object[] args) { throw null; }
        public static Foundation.NSString LocalizedFormat(string format, params object[] args) { throw null; }
        public virtual bool LocalizedStandardContainsString(Foundation.NSString str) { throw null; }
        public virtual Foundation.NSRange LocalizedStandardRangeOfString(Foundation.NSString str) { throw null; }
        public static bool operator ==(Foundation.NSString a, Foundation.NSString b) { throw null; }
        public static explicit operator Foundation.NSString (string str) { throw null; }
        public static implicit operator string (Foundation.NSString str) { throw null; }
        public static bool operator !=(Foundation.NSString a, Foundation.NSString b) { throw null; }
        public static string[] PathWithComponents(string[] components) { throw null; }
        public static void ReleaseNative(System.IntPtr handle) { }
        public virtual Foundation.NSString Replace(Foundation.NSRange range, Foundation.NSString replacement) { throw null; }
        public virtual Foundation.NSString ResolveSymlinksInPath() { throw null; }
        public virtual Foundation.NSString[] SeparateComponents(Foundation.NSString separator) { throw null; }
        public virtual Foundation.NSString StandarizePath() { throw null; }
        public virtual string ToLower(Foundation.NSLocale locale) { throw null; }
        public override string ToString() { throw null; }
        public virtual string ToUpper(Foundation.NSLocale locale) { throw null; }
        public virtual Foundation.NSString TransliterateString(Foundation.NSString transform, bool reverse) { throw null; }
    }
    public partial class NSUrl : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable, System.IEquatable<Foundation.NSUrl>
    {
        protected internal NSUrl(System.IntPtr handle) { }
        public NSUrl(System.IntPtr ptrUtf8path, bool isDir, Foundation.NSUrl baseURL) { }
        public NSUrl(string urlString) { }
        public NSUrl(string urlString, Foundation.NSUrl relativeToUrl) { }
        public NSUrl(string path, bool isDir) { }
        public NSUrl(string path, bool isDir, Foundation.NSUrl relativeToUrl) { }
        public NSUrl(string path, string relativeToUrl) { }
        public NSUrl(string scheme, string host, string path) { }
        public virtual string AbsoluteString { get { throw null; } }
        public virtual Foundation.NSUrl AbsoluteUrl { get { throw null; } }
        public static Foundation.NSString AddedToDirectoryDateKey { get { throw null; } }
        public static Foundation.NSString AttributeModificationDateKey { get { throw null; } }
        public virtual Foundation.NSUrl BaseUrl { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSString ContentAccessDateKey { get { throw null; } }
        public static Foundation.NSString ContentModificationDateKey { get { throw null; } }
        public static Foundation.NSString CreationDateKey { get { throw null; } }
        public static Foundation.NSString CustomIconKey { get { throw null; } }
        public virtual Foundation.NSData DataRepresentation { get { throw null; } }
        public static Foundation.NSString DocumentIdentifierKey { get { throw null; } }
        public static Foundation.NSString EffectiveIconKey { get { throw null; } }
        public static Foundation.NSString FileAllocatedSizeKey { get { throw null; } }
        public virtual Foundation.NSUrl FilePathUrl { get { throw null; } }
        public static Foundation.NSString FileProtectionComplete { get { throw null; } }
        public static Foundation.NSString FileProtectionCompleteUnlessOpen { get { throw null; } }
        public static Foundation.NSString FileProtectionCompleteUntilFirstUserAuthentication { get { throw null; } }
        public static Foundation.NSString FileProtectionKey { get { throw null; } }
        public static Foundation.NSString FileProtectionNone { get { throw null; } }
        public virtual Foundation.NSUrl FileReferenceUrl { get { throw null; } }
        public static Foundation.NSString FileResourceIdentifierKey { get { throw null; } }
        public static Foundation.NSString FileResourceTypeBlockSpecial { get { throw null; } }
        public static Foundation.NSString FileResourceTypeCharacterSpecial { get { throw null; } }
        public static Foundation.NSString FileResourceTypeDirectory { get { throw null; } }
        public static Foundation.NSString FileResourceTypeKey { get { throw null; } }
        public static Foundation.NSString FileResourceTypeNamedPipe { get { throw null; } }
        public static Foundation.NSString FileResourceTypeRegular { get { throw null; } }
        public static Foundation.NSString FileResourceTypeSocket { get { throw null; } }
        public static Foundation.NSString FileResourceTypeSymbolicLink { get { throw null; } }
        public static Foundation.NSString FileResourceTypeUnknown { get { throw null; } }
        public static Foundation.NSString FileSecurityKey { get { throw null; } }
        public static Foundation.NSString FileSizeKey { get { throw null; } }
        public virtual string Fragment { get { throw null; } }
        public static Foundation.NSString GenerationIdentifierKey { get { throw null; } }
        public virtual System.IntPtr GetFileSystemRepresentationAsUtf8Ptr { get { throw null; } }
        public virtual bool HasDirectoryPath { get { throw null; } }
        public static Foundation.NSString HasHiddenExtensionKey { get { throw null; } }
        public virtual string Host { get { throw null; } }
        public static Foundation.NSString IsAliasFileKey { get { throw null; } }
        public static Foundation.NSString IsApplicationKey { get { throw null; } }
        public static Foundation.NSString IsDirectoryKey { get { throw null; } }
        public static Foundation.NSString IsExcludedFromBackupKey { get { throw null; } }
        public static Foundation.NSString IsExecutableKey { get { throw null; } }
        public virtual bool IsFileUrl { get { throw null; } }
        public static Foundation.NSString IsHiddenKey { get { throw null; } }
        public static Foundation.NSString IsMountTriggerKey { get { throw null; } }
        public static Foundation.NSString IsPackageKey { get { throw null; } }
        public static Foundation.NSString IsReadableKey { get { throw null; } }
        public static Foundation.NSString IsRegularFileKey { get { throw null; } }
        public static Foundation.NSString IsSymbolicLinkKey { get { throw null; } }
        public static Foundation.NSString IsSystemImmutableKey { get { throw null; } }
        public static Foundation.NSString IsUbiquitousItemKey { get { throw null; } }
        public static Foundation.NSString IsUserImmutableKey { get { throw null; } }
        public static Foundation.NSString IsVolumeKey { get { throw null; } }
        public static Foundation.NSString IsWritableKey { get { throw null; } }
        public virtual string ItemTitle { get { throw null; } }
        public virtual Foundation.NSUrl ItemUrl { get { throw null; } }
        public static Foundation.NSString KeysOfUnsetValuesKey { get { throw null; } }
        public static Foundation.NSString LabelColorKey { get { throw null; } }
        public static Foundation.NSString LabelNumberKey { get { throw null; } }
        public virtual string LastPathComponent { get { throw null; } }
        public static Foundation.NSString LinkCountKey { get { throw null; } }
        public static Foundation.NSString LocalizedLabelKey { get { throw null; } }
        public static Foundation.NSString LocalizedNameKey { get { throw null; } }
        public static Foundation.NSString LocalizedTypeDescriptionKey { get { throw null; } }
        public static Foundation.NSString NameKey { get { throw null; } }
        public virtual string ParameterString { get { throw null; } }
        public static Foundation.NSString ParentDirectoryURLKey { get { throw null; } }
        public virtual string Password { get { throw null; } }
        public virtual string Path { get { throw null; } }
        public virtual string[] PathComponents { get { throw null; } }
        public virtual string PathExtension { get { throw null; } }
        public static Foundation.NSString PathKey { get { throw null; } }
        public int Port { get { throw null; } }
        public static Foundation.NSString PreferredIOBlockSizeKey { get { throw null; } }
        public virtual string Query { get { throw null; } }
        public static string[] ReadableTypeIdentifiers { get { throw null; } }
        public virtual string RelativePath { get { throw null; } }
        public virtual string RelativeString { get { throw null; } }
        public virtual string ResourceSpecifier { get { throw null; } }
        public virtual string Scheme { get { throw null; } }
        public virtual Foundation.NSUrl StandardizedUrl { get { throw null; } }
        public static Foundation.NSString ThumbnailDictionaryKey { get { throw null; } }
        public static Foundation.NSString TotalFileAllocatedSizeKey { get { throw null; } }
        public static Foundation.NSString TotalFileSizeKey { get { throw null; } }
        public static Foundation.NSString TypeIdentifierKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemContainerDisplayNameKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemDownloadingErrorKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemDownloadingStatusCurrent { get { throw null; } }
        public static Foundation.NSString UbiquitousItemDownloadingStatusDownloaded { get { throw null; } }
        public static Foundation.NSString UbiquitousItemDownloadingStatusKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemDownloadingStatusNotDownloaded { get { throw null; } }
        public static Foundation.NSString UbiquitousItemDownloadRequestedKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemHasUnresolvedConflictsKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemIsDownloadedKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemIsDownloadingKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemIsSharedKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemIsUploadedKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemIsUploadingKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemPercentDownloadedKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemPercentUploadedKey { get { throw null; } }
        public static Foundation.NSString UbiquitousItemUploadingErrorKey { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemCurrentUserPermissionsKey { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemCurrentUserRoleKey { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemMostRecentEditorNameComponentsKey { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemOwnerNameComponentsKey { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemPermissionsReadOnly { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemPermissionsReadWrite { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemRoleOwner { get { throw null; } }
        public static Foundation.NSString UbiquitousSharedItemRoleParticipant { get { throw null; } }
        public virtual string User { get { throw null; } }
        public static Foundation.NSString VolumeAvailableCapacityForImportantUsageKey { get { throw null; } }
        public static Foundation.NSString VolumeAvailableCapacityForOpportunisticUsageKey { get { throw null; } }
        public static Foundation.NSString VolumeAvailableCapacityKey { get { throw null; } }
        public static Foundation.NSString VolumeCreationDateKey { get { throw null; } }
        public static Foundation.NSString VolumeIdentifierKey { get { throw null; } }
        public static Foundation.NSString VolumeIsAutomountedKey { get { throw null; } }
        public static Foundation.NSString VolumeIsBrowsableKey { get { throw null; } }
        public static Foundation.NSString VolumeIsEjectableKey { get { throw null; } }
        public static Foundation.NSString VolumeIsEncryptedKey { get { throw null; } }
        public static Foundation.NSString VolumeIsInternalKey { get { throw null; } }
        public static Foundation.NSString VolumeIsJournalingKey { get { throw null; } }
        public static Foundation.NSString VolumeIsLocalKey { get { throw null; } }
        public static Foundation.NSString VolumeIsReadOnlyKey { get { throw null; } }
        public static Foundation.NSString VolumeIsRemovableKey { get { throw null; } }
        public static Foundation.NSString VolumeIsRootFileSystemKey { get { throw null; } }
        public static Foundation.NSString VolumeLocalizedFormatDescriptionKey { get { throw null; } }
        public static Foundation.NSString VolumeLocalizedNameKey { get { throw null; } }
        public static Foundation.NSString VolumeMaximumFileSizeKey { get { throw null; } }
        public static Foundation.NSString VolumeNameKey { get { throw null; } }
        public static Foundation.NSString VolumeResourceCountKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsAccessPermissionsKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsAdvisoryFileLockingKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsCasePreservedNamesKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsCaseSensitiveNamesKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsCompressionKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsExclusiveRenamingKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsExtendedSecurityKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsFileCloningKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsHardLinksKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsImmutableFilesKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsJournalingKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsPersistentIDsKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsRenamingKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsRootDirectoryDatesKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsSparseFilesKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsSwapRenamingKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsSymbolicLinksKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsVolumeSizesKey { get { throw null; } }
        public static Foundation.NSString VolumeSupportsZeroRunsKey { get { throw null; } }
        public static Foundation.NSString VolumeTotalCapacityKey { get { throw null; } }
        public static Foundation.NSString VolumeURLForRemountingKey { get { throw null; } }
        public static Foundation.NSString VolumeURLKey { get { throw null; } }
        public static Foundation.NSString VolumeUUIDStringKey { get { throw null; } }
        public static string[] WritableTypeIdentifiers { get { throw null; } }
        public virtual string[] WritableTypeIdentifiersForItemProvider { get { throw null; } }
        public virtual Foundation.NSUrl Append(string pathComponent, bool isDirectory) { throw null; }
        public virtual Foundation.NSUrl AppendPathExtension(string extension) { throw null; }
        public static Foundation.NSUrl CreateAbsoluteUrlWithDataRepresentation(Foundation.NSData data, Foundation.NSUrl relativeToUrl) { throw null; }
        public static Foundation.NSUrl CreateFileUrl(string path, Foundation.NSUrl relativeToUrl) { throw null; }
        public static Foundation.NSUrl CreateFileUrl(string path, bool isDir, Foundation.NSUrl relativeToUrl) { throw null; }
        public static Foundation.NSUrl CreateFileUrl(string[] pathComponents) { throw null; }
        public static Foundation.NSUrl CreateWithDataRepresentation(Foundation.NSData data, Foundation.NSUrl relativeToUrl) { throw null; }
        public bool Equals(Foundation.NSUrl url) { throw null; }
        public static Foundation.NSUrl FromFilename(string url) { throw null; }
        public static Foundation.NSUrl FromString(string s) { throw null; }
        public static Foundation.NSUrl FromUTF8Pointer(System.IntPtr ptrUtf8path, bool isDir, Foundation.NSUrl baseURL) { throw null; }
        public static Foundation.NSData GetBookmarkData(Foundation.NSUrl bookmarkFileUrl, out Foundation.NSError error) { throw null; }
        public virtual bool GetFileSystemRepresentation(System.IntPtr buffer, System.nint maxBufferLength) { throw null; }
        public static Foundation.NSUrl GetObject(Foundation.NSData data, string typeIdentifier, out Foundation.NSError outError) { throw null; }
        public virtual Foundation.NSDictionary GetResourceValues(Foundation.NSString[] keys, out Foundation.NSError error) { throw null; }
        public virtual System.Threading.Tasks.Task<Foundation.NSData> LoadDataAsync(string typeIdentifier) { throw null; }
        public Foundation.NSUrl MakeRelative(string url) { throw null; }
        public static bool operator ==(Foundation.NSUrl x, Foundation.NSUrl y) { throw null; }
        public static implicit operator System.Uri (Foundation.NSUrl url) { throw null; }
        public static implicit operator Foundation.NSUrl (System.Uri uri) { throw null; }
        public static bool operator !=(Foundation.NSUrl x, Foundation.NSUrl y) { throw null; }
        public virtual void RemoveAllCachedResourceValues() { }
        public virtual void RemoveCachedResourceValueForKey(Foundation.NSString key) { }
        public virtual Foundation.NSUrl RemoveLastPathComponent() { throw null; }
        public virtual Foundation.NSUrl RemovePathExtension() { throw null; }
        public bool SetResource(Foundation.NSString nsUrlResourceKey, Foundation.NSObject value) { throw null; }
        public bool SetResource(Foundation.NSString nsUrlResourceKey, Foundation.NSObject value, out Foundation.NSError error) { throw null; }
        public virtual void SetTemporaryResourceValue(Foundation.NSObject value, Foundation.NSString key) { }
        public virtual bool StartAccessingSecurityScopedResource() { throw null; }
        public virtual void StopAccessingSecurityScopedResource() { }
        public override string ToString() { throw null; }
        public bool TryGetResource(Foundation.NSString nsUrlResourceKey, out Foundation.NSObject value) { throw null; }
        public bool TryGetResource(Foundation.NSString nsUrlResourceKey, out Foundation.NSObject value, out Foundation.NSError error) { throw null; }
    }
    public partial class NSUrlAuthenticationChallenge : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal NSUrlAuthenticationChallenge(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSError Error { get { throw null; } }
        public virtual Foundation.NSUrlResponse FailureResponse { get { throw null; } }
        public virtual System.nint PreviousFailureCount { get { throw null; } }
        public virtual Foundation.NSUrlCredential ProposedCredential { get { throw null; } }
        public virtual Foundation.NSUrlProtectionSpace ProtectionSpace { get { throw null; } }
    }
    public partial class NSUrlCredential : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal NSUrlCredential(System.IntPtr handle) { }
        public NSUrlCredential(string user, string password, Foundation.NSUrlCredentialPersistence persistence) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual bool HasPassword { get { throw null; } }
        public virtual string Password { get { throw null; } }
        public virtual Foundation.NSUrlCredentialPersistence Persistence { get { throw null; } }
        public virtual string User { get { throw null; } }
        public static Foundation.NSUrlCredential FromUserPasswordPersistance(string user, string password, Foundation.NSUrlCredentialPersistence persistence) { throw null; }
    }
    public enum NSUrlCredentialPersistence : ulong
    {
        ForSession = (ulong)1,
        None = (ulong)0,
        Permanent = (ulong)2,
        Synchronizable = (ulong)3,
    }
    public enum NSUrlError
    {
        AppTransportSecurityRequiresSecureConnection = -1022,
        BackgroundSessionInUseByAnotherProcess = -996,
        BackgroundSessionRequiresSharedContainer = -995,
        BackgroundSessionWasDisconnected = -997,
        BadServerResponse = -1011,
        BadURL = -1000,
        CallIsActive = -1019,
        Cancelled = -999,
        CannotCloseFile = -3002,
        CannotConnectToHost = -1004,
        CannotCreateFile = -3000,
        CannotDecodeContentData = -1016,
        CannotDecodeRawData = -1015,
        CannotFindHost = -1003,
        CannotLoadFromNetwork = -2000,
        CannotMoveFile = -3005,
        CannotOpenFile = -3001,
        CannotParseResponse = -1017,
        CannotRemoveFile = -3004,
        CannotWriteToFile = -3003,
        ClientCertificateRejected = -1205,
        ClientCertificateRequired = -1206,
        DataLengthExceedsMaximum = -1103,
        DataNotAllowed = -1020,
        DNSLookupFailed = -1006,
        DownloadDecodingFailedMidStream = -3006,
        DownloadDecodingFailedToComplete = -3007,
        FileDoesNotExist = -1100,
        FileIsDirectory = -1101,
        FileOutsideSafeArea = -1104,
        HTTPTooManyRedirects = -1007,
        InternationalRoamingOff = -1018,
        NetworkConnectionLost = -1005,
        NoPermissionsToReadFile = -1102,
        NotConnectedToInternet = -1009,
        RedirectToNonExistentLocation = -1010,
        RequestBodyStreamExhausted = -1021,
        ResourceUnavailable = -1008,
        SecureConnectionFailed = -1200,
        ServerCertificateHasBadDate = -1201,
        ServerCertificateHasUnknownRoot = -1203,
        ServerCertificateNotYetValid = -1204,
        ServerCertificateUntrusted = -1202,
        TimedOut = -1001,
        Unknown = -1,
        UnsupportedURL = -1002,
        UserAuthenticationRequired = -1013,
        UserCancelledAuthentication = -1012,
        ZeroByteResource = -1014,
    }
    public partial class NSUrlProtectionSpace : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal NSUrlProtectionSpace(System.IntPtr handle) { }
        public NSUrlProtectionSpace(string host, int port, string protocol, string realm, string authenticationMethod) { }
        public NSUrlProtectionSpace(string host, int port, string protocol, string realm, string authenticationMethod, bool useProxy) { }
        public virtual string AuthenticationMethod { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodClientCertificate { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodDefault { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodHTMLForm { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodHTTPBasic { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodHTTPDigest { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodNegotiate { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodNTLM { get { throw null; } }
        public static Foundation.NSString AuthenticationMethodServerTrust { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSData[] DistinguishedNames { get { throw null; } }
        public static Foundation.NSString FTP { get { throw null; } }
        public static Foundation.NSString FTPProxy { get { throw null; } }
        public virtual string Host { get { throw null; } }
        public static Foundation.NSString HTTP { get { throw null; } }
        public static Foundation.NSString HTTPProxy { get { throw null; } }
        public static Foundation.NSString HTTPS { get { throw null; } }
        public static Foundation.NSString HTTPSProxy { get { throw null; } }
        public virtual new bool IsProxy { get { throw null; } }
        public virtual System.nint Port { get { throw null; } }
        public virtual string Protocol { get { throw null; } }
        public virtual string ProxyType { get { throw null; } }
        public virtual string Realm { get { throw null; } }
        public virtual bool ReceivesCredentialSecurely { get { throw null; } }
        public static Foundation.NSString SOCKSProxy { get { throw null; } }
    }
    public partial class NSUrlRequest : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSUrlRequest() { }
        public NSUrlRequest(Foundation.NSUrl url) { }
        public NSUrlRequest(Foundation.NSUrl url, Foundation.NSUrlRequestCachePolicy cachePolicy, double timeoutInterval) { }
        protected internal NSUrlRequest(System.IntPtr handle) { }
        public virtual bool AllowsCellularAccess { get { throw null; } }
        public virtual Foundation.NSData Body { get { throw null; } }
        public virtual Foundation.NSInputStream BodyStream { get { throw null; } }
        public virtual Foundation.NSUrlRequestCachePolicy CachePolicy { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSDictionary Headers { get { throw null; } }
        public virtual string HttpMethod { get { throw null; } }
        public string this[string key] { get { throw null; } }
        public virtual Foundation.NSUrl MainDocumentURL { get { throw null; } }
        public virtual bool ShouldHandleCookies { get { throw null; } }
        public virtual double TimeoutInterval { get { throw null; } }
        public virtual Foundation.NSUrl Url { get { throw null; } }
        public static Foundation.NSUrlRequest FromUrl(Foundation.NSUrl url) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum NSUrlRequestCachePolicy : ulong
    {
        ReloadIgnoringCacheData = (ulong)1,
        ReloadIgnoringLocalAndRemoteCacheData = (ulong)4,
        ReloadIgnoringLocalCacheData = (ulong)1,
        ReloadRevalidatingCacheData = (ulong)5,
        ReturnCacheDataDoNotLoad = (ulong)3,
        ReturnCacheDataElseLoad = (ulong)2,
        UseProtocolCachePolicy = (ulong)0,
    }
    public partial class NSUrlResponse : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSUrlResponse() { }
        public NSUrlResponse(Foundation.NSUrl url, string mimetype, System.nint expectedContentLength, string textEncodingName) { }
        protected internal NSUrlResponse(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual long ExpectedContentLength { get { throw null; } }
        public virtual string MimeType { get { throw null; } }
        public virtual string SuggestedFilename { get { throw null; } }
        public virtual string TextEncodingName { get { throw null; } }
        public virtual Foundation.NSUrl Url { get { throw null; } }
    }
    public partial class NSUrlSession : Foundation.NSObject
    {
        protected internal NSUrlSession(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSUrlSessionConfiguration Configuration { get { throw null; } }
        public Foundation.INSUrlSessionDelegate Delegate { get { throw null; } }
        public virtual Foundation.NSOperationQueue DelegateQueue { get { throw null; } }
        public virtual string SessionDescription { get { throw null; } set { } }
        public static Foundation.NSUrlSession SharedSession { get { throw null; } }
        public virtual Foundation.NSObject WeakDelegate { get { throw null; } }
        public virtual Foundation.NSUrlSessionDataTask CreateDataTask(Foundation.NSUrl url) { throw null; }
        public virtual Foundation.NSUrlSessionDataTask CreateDataTask(Foundation.NSUrlRequest request) { throw null; }
        public virtual void FinishTasksAndInvalidate() { }
        public virtual void Flush(System.Action completionHandler) { }
        public virtual System.Threading.Tasks.Task FlushAsync() { throw null; }
        public static Foundation.NSUrlSession FromConfiguration(Foundation.NSUrlSessionConfiguration configuration) { throw null; }
        public static Foundation.NSUrlSession FromConfiguration(Foundation.NSUrlSessionConfiguration configuration, Foundation.INSUrlSessionDelegate sessionDelegate, Foundation.NSOperationQueue delegateQueue) { throw null; }
        public static Foundation.NSUrlSession FromConfiguration(Foundation.NSUrlSessionConfiguration configuration, Foundation.NSUrlSessionDelegate sessionDelegate, Foundation.NSOperationQueue delegateQueue) { throw null; }
        public static Foundation.NSUrlSession FromWeakConfiguration(Foundation.NSUrlSessionConfiguration configuration, Foundation.NSObject weakDelegate, Foundation.NSOperationQueue delegateQueue) { throw null; }
        public virtual System.Threading.Tasks.Task<Foundation.NSUrlSessionTask[]> GetAllTasksAsync() { throw null; }
        public virtual void InvalidateAndCancel() { }
        public virtual void Reset(System.Action completionHandler) { }
        public virtual System.Threading.Tasks.Task ResetAsync() { throw null; }
    }
    public enum NSUrlSessionAuthChallengeDisposition : long
    {
        CancelAuthenticationChallenge = (long)2,
        PerformDefaultHandling = (long)1,
        RejectProtectionSpace = (long)3,
        UseCredential = (long)0,
    }
    public partial class NSUrlSessionConfiguration : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal NSUrlSessionConfiguration(System.IntPtr handle) { }
        public virtual bool AllowsCellularAccess { get { throw null; } set { } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSDictionary ConnectionProxyDictionary { get { throw null; } set { } }
        public static Foundation.NSUrlSessionConfiguration DefaultSessionConfiguration { get { throw null; } }
        public virtual bool Discretionary { get { throw null; } set { } }
        public static Foundation.NSUrlSessionConfiguration EphemeralSessionConfiguration { get { throw null; } }
        public virtual Foundation.NSDictionary HttpAdditionalHeaders { get { throw null; } set { } }
        public virtual Foundation.NSHttpCookieStorage HttpCookieStorage { get { throw null; } set { } }
        public virtual System.nint HttpMaximumConnectionsPerHost { get { throw null; } set { } }
        public virtual bool HttpShouldSetCookies { get { throw null; } set { } }
        public virtual bool HttpShouldUsePipelining { get { throw null; } set { } }
        public virtual string Identifier { get { throw null; } }
        public virtual Foundation.NSUrlRequestCachePolicy RequestCachePolicy { get { throw null; } set { } }
        public virtual bool SessionSendsLaunchEvents { get { throw null; } set { } }
        public virtual string SharedContainerIdentifier { get { throw null; } set { } }
        public virtual bool ShouldUseExtendedBackgroundIdleMode { get { throw null; } set { } }
        public virtual double TimeoutIntervalForRequest { get { throw null; } set { } }
        public virtual double TimeoutIntervalForResource { get { throw null; } set { } }
        public virtual Security.SslProtocol TLSMaximumSupportedProtocol { get { throw null; } set { } }
        public virtual Security.SslProtocol TLSMinimumSupportedProtocol { get { throw null; } set { } }
        public virtual bool WaitsForConnectivity { get { throw null; } set { } }
        public static Foundation.NSUrlSessionConfiguration BackgroundSessionConfiguration(string identifier) { throw null; }
        public static Foundation.NSUrlSessionConfiguration CreateBackgroundSessionConfiguration(string identifier) { throw null; }
    }
    public partial class NSUrlSessionDataDelegate : Foundation.NSUrlSessionTaskDelegate, Foundation.INSUrlSessionDataDelegate, Foundation.INSUrlSessionDelegate, Foundation.INSUrlSessionTaskDelegate, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSUrlSessionDataDelegate() { }
        protected internal NSUrlSessionDataDelegate(System.IntPtr handle) { }
        public virtual void DidReceiveData(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSData data) { }
        public virtual void DidReceiveResponse(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSUrlResponse response, System.Action<Foundation.NSUrlSessionResponseDisposition> completionHandler) { }
        public virtual void WillCacheResponse(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSCachedUrlResponse proposedResponse, System.Action<Foundation.NSCachedUrlResponse> completionHandler) { }
    }
    public partial class NSUrlSessionDataTask : Foundation.NSUrlSessionTask
    {
        public NSUrlSessionDataTask() { }
        protected internal NSUrlSessionDataTask(System.IntPtr handle) { }
        public override System.IntPtr ClassHandle { get { throw null; } }
    }
    public partial class NSUrlSessionDelegate : Foundation.NSObject, Foundation.INSUrlSessionDelegate, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSUrlSessionDelegate() { }
        protected internal NSUrlSessionDelegate(System.IntPtr handle) { }
        public virtual void DidBecomeInvalid(Foundation.NSUrlSession session, Foundation.NSError error) { }
        public virtual void DidFinishEventsForBackgroundSession(Foundation.NSUrlSession session) { }
        public virtual void DidReceiveChallenge(Foundation.NSUrlSession session, Foundation.NSUrlAuthenticationChallenge challenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition, Foundation.NSUrlCredential> completionHandler) { }
    }
    public enum NSUrlSessionResponseDisposition : long
    {
        Allow = (long)1,
        BecomeDownload = (long)2,
        BecomeStream = (long)3,
        Cancel = (long)0,
    }
    public partial class NSUrlSessionTask : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSUrlSessionTask() { }
        protected internal NSUrlSessionTask(System.IntPtr handle) { }
        public virtual long BytesExpectedToReceive { get { throw null; } }
        public virtual long BytesExpectedToSend { get { throw null; } }
        public virtual long BytesReceived { get { throw null; } }
        public virtual long BytesSent { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual long CountOfBytesClientExpectsToReceive { get { throw null; } set { } }
        public virtual long CountOfBytesClientExpectsToSend { get { throw null; } set { } }
        public virtual Foundation.NSUrlRequest CurrentRequest { get { throw null; } }
        public virtual Foundation.NSDate EarliestBeginDate { get { throw null; } set { } }
        public virtual Foundation.NSError Error { get { throw null; } }
        public virtual Foundation.NSUrlRequest OriginalRequest { get { throw null; } }
        public virtual float Priority { get { throw null; } set { } }
        public virtual Foundation.NSUrlResponse Response { get { throw null; } }
        public virtual Foundation.NSUrlSessionTaskState State { get { throw null; } }
        public virtual string TaskDescription { get { throw null; } set { } }
        public virtual System.nuint TaskIdentifier { get { throw null; } }
        public static long TransferSizeUnknown { get { throw null; } }
        public virtual void Cancel() { }
        public virtual void Resume() { }
        public virtual void Suspend() { }
    }
    public partial class NSUrlSessionTaskDelegate : Foundation.NSUrlSessionDelegate, Foundation.INSUrlSessionDelegate, Foundation.INSUrlSessionTaskDelegate, ObjCRuntime.INativeObject, System.IDisposable
    {
        public NSUrlSessionTaskDelegate() { }
        protected internal NSUrlSessionTaskDelegate(System.IntPtr handle) { }
        public virtual void DidCompleteWithError(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSError error) { }
        public virtual void DidReceiveChallenge(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSUrlAuthenticationChallenge challenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition, Foundation.NSUrlCredential> completionHandler) { }
        public virtual void DidSendBodyData(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend) { }
        public virtual void NeedNewBodyStream(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, System.Action<Foundation.NSInputStream> completionHandler) { }
        public virtual void TaskIsWaitingForConnectivity(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task) { }
        public virtual void WillPerformHttpRedirection(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSHttpUrlResponse response, Foundation.NSUrlRequest newRequest, System.Action<Foundation.NSUrlRequest> completionHandler) { }
    }
    public enum NSUrlSessionTaskState : long
    {
        Canceling = (long)2,
        Completed = (long)3,
        Running = (long)0,
        Suspended = (long)1,
    }
    public partial class NSValue : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal NSValue(System.IntPtr handle) { }
        public virtual CoreGraphics.CGAffineTransform CGAffineTransformValue { get { throw null; } }
        public virtual CoreGraphics.CGPoint CGPointValue { get { throw null; } }
        public virtual CoreGraphics.CGRect CGRectValue { get { throw null; } }
        public virtual CoreGraphics.CGSize CGSizeValue { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual Foundation.NSObject NonretainedObjectValue { get { throw null; } }
        public string ObjCType { get { throw null; } }
        public virtual System.IntPtr PointerValue { get { throw null; } }
//        public System.Drawing.PointF PointFValue { get { throw null; } }
        public virtual Foundation.NSRange RangeValue { get { throw null; } }
//        public System.Drawing.RectangleF RectangleFValue { get { throw null; } }
//        public System.Drawing.SizeF SizeFValue { get { throw null; } }
        public static Foundation.NSValue FromCGAffineTransform(CoreGraphics.CGAffineTransform tran) { throw null; }
        public static Foundation.NSValue FromCGPoint(CoreGraphics.CGPoint point) { throw null; }
        public static Foundation.NSValue FromCGRect(CoreGraphics.CGRect rect) { throw null; }
        public static Foundation.NSValue FromCGSize(CoreGraphics.CGSize size) { throw null; }
//        public static Foundation.NSValue FromPointF(System.Drawing.PointF point) { throw null; }
        public static Foundation.NSValue FromRange(Foundation.NSRange range) { throw null; }
//        public static Foundation.NSValue FromRectangleF(System.Drawing.RectangleF rect) { throw null; }
//        public static Foundation.NSValue FromSizeF(System.Drawing.SizeF size) { throw null; }
        public virtual bool IsEqualTo(Foundation.NSValue value) { throw null; }
        public virtual void StoreValueAtAddress(System.IntPtr value) { }
        public static Foundation.NSValue ValueFromNonretainedObject(Foundation.NSObject anObject) { throw null; }
        public static Foundation.NSValue ValueFromPointer(System.IntPtr pointer) { throw null; }
    }
}
namespace ObjCRuntime
{
    public partial class Class : ObjCRuntime.INativeObject
    {
        public static bool ThrowOnInitFailure;
        public Class(System.IntPtr handle) { }
        public Class(System.IntPtr handle, bool owns) { }
        public Class(string name) { }
        public Class(System.Type type) { }
        public System.IntPtr Handle { get { throw null; } }
        public string Name { get { throw null; } }
        public System.IntPtr SuperClass { get { throw null; } }
        public static System.IntPtr GetHandle(string name) { throw null; }
        public static System.IntPtr GetHandle(System.Type type) { throw null; }
        public static System.IntPtr GetHandleIntrinsic(string name) { throw null; }
        public static System.Type Lookup(ObjCRuntime.Class @class) { throw null; }
    }
    public partial interface INativeObject
    {
        System.IntPtr Handle { get; }
    }
    public static partial class Runtime
    {
        public static bool DynamicRegistrationSupported { get { throw null; } }
        public static bool UseAutoreleasePoolInThreadPool { get { throw null; } set { } }
        public static ObjCRuntime.INativeObject GetINativeObject(System.IntPtr ptr, bool owns, System.Type target_type) { throw null; }
        public static T GetINativeObject<T>(System.IntPtr ptr, bool owns) where T : class, ObjCRuntime.INativeObject { throw null; }
        public static Foundation.NSObject GetNSObject(System.IntPtr ptr) { throw null; }
        public static T GetNSObject<T>(System.IntPtr ptr) where T : Foundation.NSObject { throw null; }
        public static T GetNSObject<T>(System.IntPtr ptr, bool owns) where T : Foundation.NSObject { throw null; }
        public static System.IntPtr GetProtocol(string protocol) { throw null; }
        public static System.Collections.Generic.List<System.WeakReference> GetSurfacedObjects() { throw null; }
        public static void RegisterAssembly(System.Reflection.Assembly a) { }
        public static void ReleaseBlockOnMainThread(System.IntPtr block) { }
        public static void StartWWAN(System.Uri uri) { }
        public static void StartWWAN(System.Uri uri, System.Action<System.Exception> callback) { }
        public static Foundation.NSObject TryGetNSObject(System.IntPtr ptr) { throw null; }
    }
}
namespace Security
{
    public enum SslProtocol
    {
        All = 6,
        Dtls_1_0 = 9,
        Ssl_2_0 = 1,
        Ssl_3_0 = 2,
        Ssl_3_0_only = 3,
        Tls_1_0 = 4,
        Tls_1_0_only = 5,
        Tls_1_1 = 7,
        Tls_1_2 = 8,
        Tls_1_3 = 10,
        Unknown = 0,
    }
}
namespace System
{
    [System.SerializableAttribute]
    public partial struct nfloat : System.IComparable, System.IComparable<System.nfloat>, System.IConvertible, System.IEquatable<System.nfloat>, System.IFormattable
    {
        private int _dummyPrimitive;
        public static readonly System.nfloat Epsilon;
        public static readonly System.nfloat MaxValue;
        public static readonly System.nfloat MinValue;
        public static readonly System.nfloat NaN;
        public static readonly System.nfloat NegativeInfinity;
        public static readonly System.nfloat PositiveInfinity;
        public static readonly int Size;
        public nfloat(double v) { throw null; }
        public nfloat(float v) { throw null; }
        public int CompareTo(System.nfloat value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static void CopyArray(System.IntPtr source, System.nfloat[] destination, int startIndex, int length) { }
        public static void CopyArray(System.nfloat[] source, int startIndex, System.IntPtr destination, int length) { }
        public bool Equals(System.nfloat obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static bool IsInfinity(System.nfloat f) { throw null; }
        public static bool IsNaN(System.nfloat f) { throw null; }
        public static bool IsNegativeInfinity(System.nfloat f) { throw null; }
        public static bool IsPositiveInfinity(System.nfloat f) { throw null; }
        public static System.nfloat operator +(System.nfloat l, System.nfloat r) { throw null; }
        public static System.nfloat operator --(System.nfloat v) { throw null; }
        public static System.nfloat operator /(System.nfloat l, System.nfloat r) { throw null; }
        public static bool operator ==(System.nfloat l, System.nfloat r) { throw null; }
        public static explicit operator System.nfloat (decimal v) { throw null; }
        public static explicit operator System.nfloat (double v) { throw null; }
        public static explicit operator System.nfloat (System.IntPtr v) { throw null; }
        public static explicit operator byte (System.nfloat v) { throw null; }
        public static explicit operator char (System.nfloat v) { throw null; }
        public static explicit operator decimal (System.nfloat v) { throw null; }
        public static explicit operator short (System.nfloat v) { throw null; }
        public static explicit operator int (System.nfloat v) { throw null; }
        public static explicit operator long (System.nfloat v) { throw null; }
        public static explicit operator System.IntPtr (System.nfloat v) { throw null; }
        public static explicit operator sbyte (System.nfloat v) { throw null; }
        public static explicit operator float (System.nfloat v) { throw null; }
        public static explicit operator ushort (System.nfloat v) { throw null; }
        public static explicit operator uint (System.nfloat v) { throw null; }
        public static explicit operator ulong (System.nfloat v) { throw null; }
        public static bool operator >(System.nfloat l, System.nfloat r) { throw null; }
        public static bool operator >=(System.nfloat l, System.nfloat r) { throw null; }
        public static implicit operator System.nfloat (byte v) { throw null; }
        public static implicit operator System.nfloat (char v) { throw null; }
        public static implicit operator System.nfloat (short v) { throw null; }
        public static implicit operator System.nfloat (int v) { throw null; }
        public static implicit operator System.nfloat (long v) { throw null; }
        public static implicit operator double (System.nfloat v) { throw null; }
        public static implicit operator System.nfloat (sbyte v) { throw null; }
        public static implicit operator System.nfloat (float v) { throw null; }
        public static implicit operator System.nfloat (ushort v) { throw null; }
        public static implicit operator System.nfloat (uint v) { throw null; }
        public static implicit operator System.nfloat (ulong v) { throw null; }
        public static System.nfloat operator ++(System.nfloat v) { throw null; }
        public static bool operator !=(System.nfloat l, System.nfloat r) { throw null; }
        public static bool operator <(System.nfloat l, System.nfloat r) { throw null; }
        public static bool operator <=(System.nfloat l, System.nfloat r) { throw null; }
        public static System.nfloat operator %(System.nfloat l, System.nfloat r) { throw null; }
        public static System.nfloat operator *(System.nfloat l, System.nfloat r) { throw null; }
        public static System.nfloat operator -(System.nfloat l, System.nfloat r) { throw null; }
        public static System.nfloat operator -(System.nfloat v) { throw null; }
        public static System.nfloat operator +(System.nfloat v) { throw null; }
        public static System.nfloat Parse(string s) { throw null; }
        public static System.nfloat Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.nfloat Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.nfloat Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type targetType, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.nfloat result) { throw null; }
        public static bool TryParse(string s, out System.nfloat result) { throw null; }
    }
    [System.SerializableAttribute]
    public partial struct nint : System.IComparable, System.IComparable<System.nint>, System.IConvertible, System.IEquatable<System.nint>, System.IFormattable
    {
        private int _dummyPrimitive;
        public static readonly System.nint MaxValue;
        public static readonly System.nint MinValue;
        public static readonly int Size;
        public nint(int v) { throw null; }
        public nint(long v) { throw null; }
        public int CompareTo(System.nint value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static void CopyArray(System.IntPtr source, System.nint[] destination, int startIndex, int length) { }
        public static void CopyArray(System.nint[] source, int startIndex, System.IntPtr destination, int length) { }
        public bool Equals(System.nint obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.nint operator +(System.nint l, System.nint r) { throw null; }
        public static System.nint operator &(System.nint l, System.nint r) { throw null; }
        public static System.nint operator |(System.nint l, System.nint r) { throw null; }
        public static System.nint operator --(System.nint v) { throw null; }
        public static System.nint operator /(System.nint l, System.nint r) { throw null; }
        public static bool operator ==(System.nint l, System.nint r) { throw null; }
        public static System.nint operator ^(System.nint l, System.nint r) { throw null; }
        public static explicit operator System.nint (decimal v) { throw null; }
        public static explicit operator System.nint (double v) { throw null; }
        public static explicit operator System.nint (long v) { throw null; }
        public static explicit operator System.nint (System.IntPtr v) { throw null; }
        public static explicit operator System.nint (System.nfloat v) { throw null; }
        public static explicit operator byte (System.nint v) { throw null; }
        public static explicit operator char (System.nint v) { throw null; }
        public static explicit operator short (System.nint v) { throw null; }
        public static explicit operator int (System.nint v) { throw null; }
        public static explicit operator System.IntPtr (System.nint v) { throw null; }
        public static explicit operator System.nuint (System.nint v) { throw null; }
        public static explicit operator sbyte (System.nint v) { throw null; }
        public static explicit operator ushort (System.nint v) { throw null; }
        public static explicit operator uint (System.nint v) { throw null; }
        public static explicit operator ulong (System.nint v) { throw null; }
        public static explicit operator System.nint (System.nuint v) { throw null; }
        public static explicit operator System.nint (float v) { throw null; }
        public static explicit operator System.nint (ushort v) { throw null; }
        public static explicit operator System.nint (uint v) { throw null; }
        public static explicit operator System.nint (ulong v) { throw null; }
        public static bool operator >(System.nint l, System.nint r) { throw null; }
        public static bool operator >=(System.nint l, System.nint r) { throw null; }
        public static implicit operator System.nint (byte v) { throw null; }
        public static implicit operator System.nint (char v) { throw null; }
        public static implicit operator System.nint (short v) { throw null; }
        public static implicit operator System.nint (int v) { throw null; }
        public static implicit operator decimal (System.nint v) { throw null; }
        public static implicit operator double (System.nint v) { throw null; }
        public static implicit operator long (System.nint v) { throw null; }
        public static implicit operator System.nfloat (System.nint v) { throw null; }
        public static implicit operator float (System.nint v) { throw null; }
        public static implicit operator System.nint (sbyte v) { throw null; }
        public static System.nint operator ++(System.nint v) { throw null; }
        public static bool operator !=(System.nint l, System.nint r) { throw null; }
        public static System.nint operator <<(System.nint l, int r) { throw null; }
        public static bool operator <(System.nint l, System.nint r) { throw null; }
        public static bool operator <=(System.nint l, System.nint r) { throw null; }
        public static System.nint operator %(System.nint l, System.nint r) { throw null; }
        public static System.nint operator *(System.nint l, System.nint r) { throw null; }
        public static System.nint operator ~(System.nint v) { throw null; }
        public static System.nint operator >>(System.nint l, int r) { throw null; }
        public static System.nint operator -(System.nint l, System.nint r) { throw null; }
        public static System.nint operator -(System.nint v) { throw null; }
        public static System.nint operator +(System.nint v) { throw null; }
        public static System.nint Parse(string s) { throw null; }
        public static System.nint Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.nint Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.nint Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type targetType, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.nint result) { throw null; }
        public static bool TryParse(string s, out System.nint result) { throw null; }
    }
    public static partial class NMath
    {
        public static readonly System.nfloat E;
        public static readonly System.nfloat PI;
        public static System.nfloat Abs(System.nfloat value) { throw null; }
        public static System.nint Abs(System.nint value) { throw null; }
        public static System.nfloat Acos(System.nfloat d) { throw null; }
        public static System.nfloat Asin(System.nfloat d) { throw null; }
        public static System.nfloat Atan(System.nfloat d) { throw null; }
        public static System.nfloat Atan2(System.nfloat y, System.nfloat x) { throw null; }
        public static long BigMul(System.nint a, System.nint b) { throw null; }
        public static System.nfloat Ceiling(System.nfloat value) { throw null; }
        public static System.nfloat Cos(System.nfloat d) { throw null; }
        public static System.nfloat Cosh(System.nfloat value) { throw null; }
        public static System.nint DivRem(System.nint a, System.nint b, out System.nint result) { throw null; }
        public static System.nfloat Exp(System.nfloat d) { throw null; }
        public static System.nfloat Floor(System.nfloat d) { throw null; }
        public static System.nfloat IEEERemainder(System.nfloat x, System.nfloat y) { throw null; }
        public static System.nfloat Log(System.nfloat d) { throw null; }
        public static System.nfloat Log(System.nfloat a, System.nfloat newBase) { throw null; }
        public static System.nfloat Log10(System.nfloat d) { throw null; }
        public static System.nfloat Max(System.nfloat val1, System.nfloat val2) { throw null; }
        public static System.nint Max(System.nint val1, System.nint val2) { throw null; }
        public static System.nuint Max(System.nuint val1, System.nuint val2) { throw null; }
        public static System.nfloat Min(System.nfloat val1, System.nfloat val2) { throw null; }
        public static System.nint Min(System.nint val1, System.nint val2) { throw null; }
        public static System.nuint Min(System.nuint val1, System.nuint val2) { throw null; }
        public static System.nfloat Pow(System.nfloat x, System.nfloat y) { throw null; }
        public static System.nfloat Round(System.nfloat a) { throw null; }
        public static System.nfloat Round(System.nfloat value, int digits) { throw null; }
        public static System.nfloat Round(System.nfloat value, int digits, System.MidpointRounding mode) { throw null; }
        public static System.nfloat Round(System.nfloat value, System.MidpointRounding mode) { throw null; }
        public static int Sign(System.nfloat value) { throw null; }
        public static int Sign(System.nint value) { throw null; }
        public static System.nfloat Sin(System.nfloat a) { throw null; }
        public static System.nfloat Sinh(System.nfloat value) { throw null; }
        public static System.nfloat Sqrt(System.nfloat d) { throw null; }
        public static System.nfloat Tan(System.nfloat a) { throw null; }
        public static System.nfloat Tanh(System.nfloat value) { throw null; }
        public static System.nfloat Truncate(System.nfloat d) { throw null; }
    }
    [System.SerializableAttribute]
    public partial struct nuint : System.IComparable, System.IComparable<System.nuint>, System.IConvertible, System.IEquatable<System.nuint>, System.IFormattable
    {
        private int _dummyPrimitive;
        public static readonly System.nuint MaxValue;
        public static readonly System.nuint MinValue;
        public static readonly int Size;
        public nuint(uint v) { throw null; }
        public nuint(ulong v) { throw null; }
        public int CompareTo(System.nuint value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static void CopyArray(System.IntPtr source, System.nuint[] destination, int startIndex, int length) { }
        public static void CopyArray(System.nuint[] source, int startIndex, System.IntPtr destination, int length) { }
        public bool Equals(System.nuint obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.nuint operator +(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator &(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator |(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator --(System.nuint v) { throw null; }
        public static System.nuint operator /(System.nuint l, System.nuint r) { throw null; }
        public static bool operator ==(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator ^(System.nuint l, System.nuint r) { throw null; }
        public static explicit operator System.nuint (decimal v) { throw null; }
        public static explicit operator System.nuint (double v) { throw null; }
        public static explicit operator System.nuint (short v) { throw null; }
        public static explicit operator System.nuint (int v) { throw null; }
        public static explicit operator System.nuint (long v) { throw null; }
        public static explicit operator System.nuint (System.IntPtr v) { throw null; }
        public static explicit operator System.nuint (System.nfloat v) { throw null; }
        public static explicit operator byte (System.nuint v) { throw null; }
        public static explicit operator char (System.nuint v) { throw null; }
        public static explicit operator short (System.nuint v) { throw null; }
        public static explicit operator int (System.nuint v) { throw null; }
        public static explicit operator long (System.nuint v) { throw null; }
        public static explicit operator System.IntPtr (System.nuint v) { throw null; }
        public static explicit operator sbyte (System.nuint v) { throw null; }
        public static explicit operator ushort (System.nuint v) { throw null; }
        public static explicit operator uint (System.nuint v) { throw null; }
        public static explicit operator System.nuint (sbyte v) { throw null; }
        public static explicit operator System.nuint (float v) { throw null; }
        public static explicit operator System.nuint (ulong v) { throw null; }
        public static bool operator >(System.nuint l, System.nuint r) { throw null; }
        public static bool operator >=(System.nuint l, System.nuint r) { throw null; }
        public static implicit operator System.nuint (byte v) { throw null; }
        public static implicit operator System.nuint (char v) { throw null; }
        public static implicit operator decimal (System.nuint v) { throw null; }
        public static implicit operator double (System.nuint v) { throw null; }
        public static implicit operator System.nfloat (System.nuint v) { throw null; }
        public static implicit operator float (System.nuint v) { throw null; }
        public static implicit operator ulong (System.nuint v) { throw null; }
        public static implicit operator System.nuint (ushort v) { throw null; }
        public static implicit operator System.nuint (uint v) { throw null; }
        public static System.nuint operator ++(System.nuint v) { throw null; }
        public static bool operator !=(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator <<(System.nuint l, int r) { throw null; }
        public static bool operator <(System.nuint l, System.nuint r) { throw null; }
        public static bool operator <=(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator %(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator *(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator ~(System.nuint v) { throw null; }
        public static System.nuint operator >>(System.nuint l, int r) { throw null; }
        public static System.nuint operator -(System.nuint l, System.nuint r) { throw null; }
        public static System.nuint operator +(System.nuint v) { throw null; }
        public static System.nuint Parse(string s) { throw null; }
        public static System.nuint Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.nuint Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.nuint Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type targetType, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.nuint result) { throw null; }
        public static bool TryParse(string s, out System.nuint result) { throw null; }
    }
}
namespace UIKit
{
    public partial class UIApplication : Foundation.NSObject
    {
        public static bool CheckForEventAndDelegateMismatches;
        public static bool CheckForIllegalCrossThreadCalls;
        public UIApplication() { }
        protected internal UIApplication(System.IntPtr handle) { }
        public virtual string AlternateIconName { get { throw null; } }
        public virtual System.nint ApplicationIconBadgeNumber { get { throw null; } set { } }
        public virtual bool ApplicationSupportsShakeToEdit { get { throw null; } set { } }
        public static double BackgroundFetchIntervalMinimum { get { throw null; } }
        public static double BackgroundFetchIntervalNever { get { throw null; } }
        public static Foundation.NSString BackgroundRefreshStatusDidChangeNotification { get { throw null; } }
        public static System.nint BackgroundTaskInvalid { get { throw null; } }
        public virtual double BackgroundTimeRemaining { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSString ContentSizeCategoryChangedNotification { get { throw null; } }
        public static Foundation.NSString DidBecomeActiveNotification { get { throw null; } }
        public static Foundation.NSString DidChangeStatusBarFrameNotification { get { throw null; } }
        public static Foundation.NSString DidChangeStatusBarOrientationNotification { get { throw null; } }
        public static Foundation.NSString DidEnterBackgroundNotification { get { throw null; } }
        public static Foundation.NSString DidFinishLaunchingNotification { get { throw null; } }
        public static Foundation.NSString DidReceiveMemoryWarningNotification { get { throw null; } }
        public virtual bool IdleTimerDisabled { get { throw null; } set { } }
        public virtual bool IsIgnoringInteractionEvents { get { throw null; } }
        public virtual bool IsRegisteredForRemoteNotifications { get { throw null; } }
        public static Foundation.NSString LaunchOptionsAnnotationKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsBluetoothCentralsKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsBluetoothPeripheralsKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsCloudKitShareMetadataKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsLocalNotificationKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsLocationKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsNewsstandDownloadsKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsRemoteNotificationKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsShortcutItemKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsSourceApplicationKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsUrlKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsUserActivityDictionaryKey { get { throw null; } }
        public static Foundation.NSString LaunchOptionsUserActivityTypeKey { get { throw null; } }
        public static double MinimumKeepAliveTimeout { get { throw null; } }
        public virtual bool NetworkActivityIndicatorVisible { get { throw null; } set { } }
        public static Foundation.NSString OpenSettingsUrlString { get { throw null; } }
        public virtual Foundation.NSString PreferredContentSizeCategory { get { throw null; } }
        public virtual bool ProtectedDataAvailable { get { throw null; } }
        public static Foundation.NSString ProtectedDataDidBecomeAvailable { get { throw null; } }
        public static Foundation.NSString ProtectedDataWillBecomeUnavailable { get { throw null; } }
        public static UIKit.UIApplication SharedApplication { get { throw null; } }
        public static Foundation.NSString SignificantTimeChangeNotification { get { throw null; } }
        public static Foundation.NSString StateRestorationBundleVersionKey { get { throw null; } }
        public static Foundation.NSString StateRestorationSystemVersionKey { get { throw null; } }
        public static Foundation.NSString StateRestorationTimestampKey { get { throw null; } }
        public static Foundation.NSString StateRestorationUserInterfaceIdiomKey { get { throw null; } }
        public virtual CoreGraphics.CGRect StatusBarFrame { get { throw null; } }
        public static Foundation.NSString StatusBarFrameUserInfoKey { get { throw null; } }
        public virtual bool StatusBarHidden { get { throw null; } set { } }
        public virtual double StatusBarOrientationAnimationDuration { get { throw null; } }
        public static Foundation.NSString StatusBarOrientationUserInfoKey { get { throw null; } }
        public virtual bool SupportsAlternateIcons { get { throw null; } }
        public static Foundation.NSString UITrackingRunLoopMode { get { throw null; } }
        public static Foundation.NSString UserDidTakeScreenshotNotification { get { throw null; } }
        public virtual Foundation.NSObject WeakDelegate { get { throw null; } set { } }
        public static Foundation.NSString WillChangeStatusBarFrameNotification { get { throw null; } }
        public static Foundation.NSString WillChangeStatusBarOrientationNotification { get { throw null; } }
        public static Foundation.NSString WillEnterForegroundNotification { get { throw null; } }
        public static Foundation.NSString WillResignActiveNotification { get { throw null; } }
        public static Foundation.NSString WillTerminateNotification { get { throw null; } }
        public virtual System.nint BeginBackgroundTask(System.Action backgroundTimeExpired) { throw null; }
        public virtual System.nint BeginBackgroundTask(string taskName, System.Action expirationHandler) { throw null; }
        public virtual void BeginIgnoringInteractionEvents() { }
        public virtual void BeginReceivingRemoteControlEvents() { }
        public virtual void CancelAllLocalNotifications() { }
        public virtual bool CanOpenUrl(Foundation.NSUrl url) { throw null; }
        public virtual void ClearKeepAliveTimeout() { }
        public virtual void CompleteStateRestoration() { }
        protected override void Dispose(bool disposing) { }
        public virtual void EndBackgroundTask(System.nint taskId) { }
        public virtual void EndIgnoringInteractionEvents() { }
        public virtual void EndReceivingRemoteControlEvents() { }
        public static void EnsureUIThread() { }
        public virtual void ExtendStateRestoration() { }
        public virtual void IgnoreSnapshotOnNextApplicationLaunch() { }
        public static void Main(string[] args) { }
        public static void Main(string[] args, string principalClassName, string delegateClassName) { }
        public static void Main(string[] args, System.Type principalClass, System.Type delegateClass) { }
        public virtual bool OpenUrl(Foundation.NSUrl url) { throw null; }
        public virtual void OpenUrl(Foundation.NSUrl url, Foundation.NSDictionary options, System.Action<bool> completion) { }
        public virtual void RegisterForRemoteNotifications() { }
        public virtual void SetAlternateIconName(string alternateIconName, System.Action<Foundation.NSError> completionHandler) { }
        public virtual System.Threading.Tasks.Task SetAlternateIconNameAsync(string alternateIconName) { throw null; }
        public virtual bool SetKeepAliveTimeout(double timeout, System.Action handler) { throw null; }
        public virtual void SetMinimumBackgroundFetchInterval(double minimumBackgroundFetchInterval) { }
        public virtual void SetStatusBarHidden(bool hidden, bool animated) { }
        public virtual void UnregisterForRemoteNotifications() { }
    }
    public partial class UIColor : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public UIColor(CoreGraphics.CGColor color) { }
        protected internal UIColor(System.IntPtr handle) { }
        public UIColor(System.nfloat white, System.nfloat alpha) { }
        public UIColor(System.nfloat red, System.nfloat green, System.nfloat blue, System.nfloat alpha) { }
        public static UIKit.UIColor Black { get { throw null; } }
        public static UIKit.UIColor Blue { get { throw null; } }
        public static UIKit.UIColor Brown { get { throw null; } }
        public virtual CoreGraphics.CGColor CGColor { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static UIKit.UIColor Clear { get { throw null; } }
        public static UIKit.UIColor Cyan { get { throw null; } }
        public static UIKit.UIColor DarkGray { get { throw null; } }
        public static UIKit.UIColor DarkTextColor { get { throw null; } }
        public static UIKit.UIColor Gray { get { throw null; } }
        public static UIKit.UIColor Green { get { throw null; } }
        public static UIKit.UIColor GroupTableViewBackgroundColor { get { throw null; } }
        public static UIKit.UIColor LightGray { get { throw null; } }
        public static UIKit.UIColor LightTextColor { get { throw null; } }
        public static UIKit.UIColor Magenta { get { throw null; } }
        public static UIKit.UIColor Orange { get { throw null; } }
        public static UIKit.UIColor Purple { get { throw null; } }
        public static string[] ReadableTypeIdentifiers { get { throw null; } }
        public static UIKit.UIColor Red { get { throw null; } }
        public static UIKit.UIColor ScrollViewTexturedBackgroundColor { get { throw null; } }
        public static UIKit.UIColor UnderPageBackgroundColor { get { throw null; } }
        public static UIKit.UIColor ViewFlipsideBackgroundColor { get { throw null; } }
        public static UIKit.UIColor White { get { throw null; } }
        public static string[] WritableTypeIdentifiers { get { throw null; } }
        public virtual string[] WritableTypeIdentifiersForItemProvider { get { throw null; } }
        public static UIKit.UIColor Yellow { get { throw null; } }
        public virtual UIKit.UIColor ColorWithAlpha(System.nfloat alpha) { throw null; }
        public static UIKit.UIColor FromCGColor(CoreGraphics.CGColor color) { throw null; }
        public static UIKit.UIColor FromDisplayP3(System.nfloat red, System.nfloat green, System.nfloat blue, System.nfloat alpha) { throw null; }
        public static UIKit.UIColor FromHSB(System.nfloat hue, System.nfloat saturation, System.nfloat brightness) { throw null; }
        public static UIKit.UIColor FromHSBA(System.nfloat hue, System.nfloat saturation, System.nfloat brightness, System.nfloat alpha) { throw null; }
        public static UIKit.UIColor FromName(string name) { throw null; }
        public static UIKit.UIColor FromRGB(byte red, byte green, byte blue) { throw null; }
        public static UIKit.UIColor FromRGB(int red, int green, int blue) { throw null; }
        public static UIKit.UIColor FromRGB(System.nfloat red, System.nfloat green, System.nfloat blue) { throw null; }
        public static UIKit.UIColor FromRGBA(byte red, byte green, byte blue, byte alpha) { throw null; }
        public static UIKit.UIColor FromRGBA(int red, int green, int blue, int alpha) { throw null; }
        public static UIKit.UIColor FromRGBA(System.nfloat red, System.nfloat green, System.nfloat blue, System.nfloat alpha) { throw null; }
        public static UIKit.UIColor FromWhiteAlpha(System.nfloat white, System.nfloat alpha) { throw null; }
        public void GetHSBA(out System.nfloat hue, out System.nfloat saturation, out System.nfloat brightness, out System.nfloat alpha) { throw null; }
        public static UIKit.UIColor GetObject(Foundation.NSData data, string typeIdentifier, out Foundation.NSError outError) { throw null; }
        public void GetRGBA(out System.nfloat red, out System.nfloat green, out System.nfloat blue, out System.nfloat alpha) { throw null; }
        public virtual bool GetWhite(out System.nfloat white, out System.nfloat alpha) { throw null; }
        public virtual System.Threading.Tasks.Task<Foundation.NSData> LoadDataAsync(string typeIdentifier) { throw null; }
        public virtual void SetColor() { }
        public virtual void SetFill() { }
        public virtual void SetStroke() { }
        public override string ToString() { throw null; }
    }
    public partial class UIFont : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        protected internal UIFont(System.IntPtr handle) { }
        public virtual System.nfloat Ascender { get { throw null; } }
        public static System.nfloat ButtonFontSize { get { throw null; } }
        public virtual System.nfloat CapHeight { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public virtual System.nfloat Descender { get { throw null; } }
        public virtual string FamilyName { get { throw null; } }
        public static string[] FamilyNames { get { throw null; } }
        public static System.nfloat LabelFontSize { get { throw null; } }
        public virtual System.nfloat Leading { get { throw null; } }
        public virtual System.nfloat LineHeight { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual System.nfloat PointSize { get { throw null; } }
        public static UIKit.UIFont PreferredBody { get { throw null; } }
        public static UIKit.UIFont PreferredCallout { get { throw null; } }
        public static UIKit.UIFont PreferredCaption1 { get { throw null; } }
        public static UIKit.UIFont PreferredCaption2 { get { throw null; } }
        public static UIKit.UIFont PreferredFootnote { get { throw null; } }
        public static UIKit.UIFont PreferredHeadline { get { throw null; } }
        public static UIKit.UIFont PreferredSubheadline { get { throw null; } }
        public static UIKit.UIFont PreferredTitle1 { get { throw null; } }
        public static UIKit.UIFont PreferredTitle2 { get { throw null; } }
        public static UIKit.UIFont PreferredTitle3 { get { throw null; } }
        public static System.nfloat SmallSystemFontSize { get { throw null; } }
        public static System.nfloat SystemFontSize { get { throw null; } }
        public virtual System.nfloat xHeight { get { throw null; } }
        public static UIKit.UIFont BoldSystemFontOfSize(System.nfloat size) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static string[] FontNamesForFamilyName(string familyName) { throw null; }
        public static UIKit.UIFont FromName(string name, System.nfloat size) { throw null; }
        public override int GetHashCode() { throw null; }
        public static UIKit.UIFont ItalicSystemFontOfSize(System.nfloat size) { throw null; }
        public static UIKit.UIFont MonospacedDigitSystemFontOfSize(System.nfloat size, System.nfloat weight) { throw null; }
        public static bool operator ==(UIKit.UIFont f1, UIKit.UIFont f2) { throw null; }
        public static bool operator !=(UIKit.UIFont f1, UIKit.UIFont f2) { throw null; }
        public static UIKit.UIFont SystemFontOfSize(System.nfloat size) { throw null; }
        public static UIKit.UIFont SystemFontOfSize(System.nfloat size, System.nfloat weight) { throw null; }
        public override string ToString() { throw null; }
        public virtual UIKit.UIFont WithSize(System.nfloat size) { throw null; }
    }
    public static partial class UIGraphics
    {
        public static CoreGraphics.CGRect PDFContextBounds { get { throw null; } }
        public static void AddPDFContextDestination(string str, CoreGraphics.CGPoint point) { }
        public static void BeginImageContext(CoreGraphics.CGSize size) { }
        public static void BeginImageContextWithOptions(CoreGraphics.CGSize size, bool opaque, System.nfloat scale) { }
        public static void BeginPDFContext(Foundation.NSMutableData data, CoreGraphics.CGRect bounds, Foundation.NSDictionary documentInfo) { }
        public static void BeginPDFContext(string file, CoreGraphics.CGRect bounds, Foundation.NSDictionary documentInfo) { }
        public static void BeginPDFPage() { }
        public static void BeginPDFPage(CoreGraphics.CGRect bounds, Foundation.NSDictionary pageInfo) { }
        public static void EndImageContext() { }
        public static void EndPDFContent() { }
        public static CoreGraphics.CGContext GetCurrentContext() { throw null; }
        public static void PopContext() { }
        public static void PushContext(CoreGraphics.CGContext ctx) { }
        public static void RectClip(CoreGraphics.CGRect rect) { }
        public static void RectFill(CoreGraphics.CGRect rect) { }
        public static void RectFillUsingBlendMode(CoreGraphics.CGRect rect, CoreGraphics.CGBlendMode blendMode) { }
        public static void RectFrame(CoreGraphics.CGRect rect) { }
        public static void RectFrameUsingBlendMode(CoreGraphics.CGRect rect, CoreGraphics.CGBlendMode blendMode) { }
        public static void SetPDFContextDestination(string str, CoreGraphics.CGRect rect) { }
        public static void SetPDFContextURL(Foundation.NSUrl url, CoreGraphics.CGRect rect) { }
    }
    public partial class UIScreen : Foundation.NSObject, ObjCRuntime.INativeObject, System.IDisposable
    {
        public UIScreen() { }
        protected internal UIScreen(System.IntPtr handle) { }
        public virtual CoreGraphics.CGRect ApplicationFrame { get { throw null; } }
        public virtual CoreGraphics.CGRect Bounds { get { throw null; } }
        public virtual System.nfloat Brightness { get { throw null; } set { } }
        public static Foundation.NSString BrightnessDidChangeNotification { get { throw null; } }
        public virtual bool Captured { get { throw null; } }
        public static Foundation.NSString CapturedDidChangeNotification { get { throw null; } }
        public override System.IntPtr ClassHandle { get { throw null; } }
        public static Foundation.NSString DidConnectNotification { get { throw null; } }
        public static Foundation.NSString DidDisconnectNotification { get { throw null; } }
        public static UIKit.UIScreen MainScreen { get { throw null; } }
        public virtual System.nint MaximumFramesPerSecond { get { throw null; } }
        public virtual UIKit.UIScreen MirroredScreen { get { throw null; } }
        public static Foundation.NSString ModeDidChangeNotification { get { throw null; } }
        public virtual CoreGraphics.CGRect NativeBounds { get { throw null; } }
        public virtual System.nfloat NativeScale { get { throw null; } }
        public virtual System.nfloat Scale { get { throw null; } }
        public static UIKit.UIScreen[] Screens { get { throw null; } }
        public virtual bool SupportsFocus { get { throw null; } }
        public virtual bool WantsSoftwareDimming { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
    }
}
