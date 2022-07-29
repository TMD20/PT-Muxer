// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace I18N.MidEast
{
    [System.SerializableAttribute]
    public partial class CP1254 : I18N.Common.ByteEncoding
    {
        public CP1254() : base (default(int), default(char[]), default(string), default(string), default(string), default(string), default(bool), default(bool), default(bool), default(bool), default(int)) { }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        protected unsafe override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }
    }
    [System.SerializableAttribute]
    public partial class CP1255 : I18N.Common.ByteEncoding
    {
        public CP1255() : base (default(int), default(char[]), default(string), default(string), default(string), default(string), default(bool), default(bool), default(bool), default(bool), default(int)) { }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        protected unsafe override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }
    }
    [System.SerializableAttribute]
    public partial class CP1256 : I18N.Common.ByteEncoding
    {
        public CP1256() : base (default(int), default(char[]), default(string), default(string), default(string), default(string), default(bool), default(bool), default(bool), default(bool), default(int)) { }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        protected unsafe override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }
    }
    [System.SerializableAttribute]
    public partial class CP28596 : I18N.Common.ByteEncoding
    {
        public CP28596() : base (default(int), default(char[]), default(string), default(string), default(string), default(string), default(bool), default(bool), default(bool), default(bool), default(int)) { }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        protected unsafe override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }
    }
    [System.SerializableAttribute]
    public partial class CP28598 : I18N.Common.ByteEncoding
    {
        public CP28598() : base (default(int), default(char[]), default(string), default(string), default(string), default(string), default(bool), default(bool), default(bool), default(bool), default(int)) { }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        protected unsafe override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }
    }
    [System.SerializableAttribute]
    public partial class CP28599 : I18N.Common.ByteEncoding
    {
        public CP28599() : base (default(int), default(char[]), default(string), default(string), default(string), default(string), default(bool), default(bool), default(bool), default(bool), default(int)) { }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        protected unsafe override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }
    }
    [System.SerializableAttribute]
    public partial class CP38598 : I18N.Common.ByteEncoding
    {
        public CP38598() : base (default(int), default(char[]), default(string), default(string), default(string), default(string), default(bool), default(bool), default(bool), default(bool), default(int)) { }
        public override int GetByteCount(string s) { throw null; }
        public unsafe override int GetByteCountImpl(char* chars, int count) { throw null; }
        public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { throw null; }
        protected unsafe override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }
    }
    [System.SerializableAttribute]
    public partial class ENCiso_8859_6 : I18N.MidEast.CP28596
    {
        public ENCiso_8859_6() { }
    }
    [System.SerializableAttribute]
    public partial class ENCiso_8859_8 : I18N.MidEast.CP28598
    {
        public ENCiso_8859_8() { }
    }
    [System.SerializableAttribute]
    public partial class ENCiso_8859_9 : I18N.MidEast.CP28599
    {
        public ENCiso_8859_9() { }
    }
    [System.SerializableAttribute]
    public partial class ENCwindows_1254 : I18N.MidEast.CP1254
    {
        public ENCwindows_1254() { }
    }
    [System.SerializableAttribute]
    public partial class ENCwindows_1255 : I18N.MidEast.CP1255
    {
        public ENCwindows_1255() { }
    }
    [System.SerializableAttribute]
    public partial class ENCwindows_1256 : I18N.MidEast.CP1256
    {
        public ENCwindows_1256() { }
    }
    [System.SerializableAttribute]
    public partial class ENCwindows_38598 : I18N.MidEast.CP38598
    {
        public ENCwindows_38598() { }
    }
}
