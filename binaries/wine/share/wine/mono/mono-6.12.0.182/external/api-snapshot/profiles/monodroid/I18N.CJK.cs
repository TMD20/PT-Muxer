// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace I18N.CJK
{
    [System.SerializableAttribute]
    public partial class CP50220 : I18N.CJK.ISO2022JPEncoding
    {
        public CP50220() : base (default(int), default(bool), default(bool)) { }
        public override string EncodingName { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class CP50221 : I18N.CJK.ISO2022JPEncoding
    {
        public CP50221() : base (default(int), default(bool), default(bool)) { }
        public override string EncodingName { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class CP50222 : I18N.CJK.ISO2022JPEncoding
    {
        public CP50222() : base (default(int), default(bool), default(bool)) { }
        public override string EncodingName { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class CP51932 : I18N.Common.MonoSafeEncoding
    {
        public CP51932() : base (default(int)) { }
        public override string BodyName { get { throw null; } }
        public override string EncodingName { get { throw null; } }
        public override string HeaderName { get { throw null; } }
        public override bool IsBrowserDisplay { get { throw null; } }
        public override bool IsBrowserSave { get { throw null; } }
        public override bool IsMailNewsDisplay { get { throw null; } }
        public override bool IsMailNewsSave { get { throw null; } }
        public override string WebName { get { throw null; } }
        public override int GetByteCount(char[] chars, int index, int length) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override int GetCharCount(byte[] bytes, int index, int count) { throw null; }
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { throw null; }
        public override System.Text.Decoder GetDecoder() { throw null; }
        public override System.Text.Encoder GetEncoder() { throw null; }
        public override int GetMaxByteCount(int charCount) { throw null; }
        public override int GetMaxCharCount(int byteCount) { throw null; }
    }
    public partial class CP51932Encoder : I18N.Common.MonoSafeEncoder
    {
        public CP51932Encoder(I18N.Common.MonoSafeEncoding encoding) : base (default(I18N.Common.MonoSafeEncoding)) { }
        public override int GetByteCount(char[] chars, int index, int count, bool flush) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class CP54936 : I18N.CJK.GB18030Encoding
    {
        public CP54936() { }
    }
    [System.SerializableAttribute]
    public partial class CP932 : I18N.Common.MonoSafeEncoding
    {
        public CP932() : base (default(int)) { }
        public override string BodyName { get { throw null; } }
        public override string EncodingName { get { throw null; } }
        public override string HeaderName { get { throw null; } }
        public override bool IsBrowserDisplay { get { throw null; } }
        public override bool IsBrowserSave { get { throw null; } }
        public override bool IsMailNewsDisplay { get { throw null; } }
        public override bool IsMailNewsSave { get { throw null; } }
        public override string WebName { get { throw null; } }
        public override int WindowsCodePage { get { throw null; } }
        public override int GetByteCount(char[] chars, int index, int count) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override int GetCharCount(byte[] bytes, int index, int count) { throw null; }
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { throw null; }
        public override System.Text.Decoder GetDecoder() { throw null; }
        public override System.Text.Encoder GetEncoder() { throw null; }
        public override int GetMaxByteCount(int charCount) { throw null; }
        public override int GetMaxCharCount(int byteCount) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ENCeuc_jp : I18N.CJK.CP51932
    {
        public ENCeuc_jp() { }
    }
    [System.SerializableAttribute]
    public partial class ENCiso_2022_jp : I18N.CJK.CP50220
    {
        public ENCiso_2022_jp() { }
    }
    [System.SerializableAttribute]
    public partial class ENCshift_jis : I18N.CJK.CP932
    {
        public ENCshift_jis() { }
    }
    [System.SerializableAttribute]
    public partial class GB18030Encoding : I18N.Common.MonoSafeEncoding
    {
        public GB18030Encoding() : base (default(int)) { }
        public override string BodyName { get { throw null; } }
        public override string EncodingName { get { throw null; } }
        public override string HeaderName { get { throw null; } }
        public override bool IsBrowserDisplay { get { throw null; } }
        public override bool IsBrowserSave { get { throw null; } }
        public override bool IsMailNewsDisplay { get { throw null; } }
        public override bool IsMailNewsSave { get { throw null; } }
        public override string WebName { get { throw null; } }
        public override int GetByteCount(char[] chars, int index, int length) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        public override int GetCharCount(byte[] bytes, int start, int len) { throw null; }
        public override int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx) { throw null; }
        public override System.Text.Decoder GetDecoder() { throw null; }
        public override System.Text.Encoder GetEncoder() { throw null; }
        public override int GetMaxByteCount(int len) { throw null; }
        public override int GetMaxCharCount(int len) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ISO2022JPEncoding : I18N.Common.MonoSafeEncoding
    {
        public ISO2022JPEncoding(int codePage, bool allow1ByteKana, bool allowShiftIO) : base (default(int)) { }
        public override string BodyName { get { throw null; } }
        public override string HeaderName { get { throw null; } }
        public override string WebName { get { throw null; } }
        public override int GetByteCount(char[] chars, int charIndex, int charCount) { throw null; }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { throw null; }
        protected override int GetBytesInternal(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush, object state) { throw null; }
        public override int GetCharCount(byte[] bytes, int index, int count) { throw null; }
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { throw null; }
        public override int GetMaxByteCount(int charCount) { throw null; }
        public override int GetMaxCharCount(int byteCount) { throw null; }
    }
}
