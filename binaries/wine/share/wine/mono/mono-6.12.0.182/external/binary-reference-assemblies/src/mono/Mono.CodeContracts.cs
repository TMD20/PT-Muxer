// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Mono.CodeContracts.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.CodeContracts.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.CodeContracts.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace Mono.CodeContracts.Rewrite
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AssemblyRef
    {
        public AssemblyRef(Mono.CodeContracts.Rewrite.AssemblyRef.TwoStreams streams) { throw null;}
        public AssemblyRef(string filename) { throw null;}
        public string Filename { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsFilename { get { throw null; } }
        public bool IsSet { get { throw null; } }
        public bool IsStream { get { throw null; } }
        public Mono.CodeContracts.Rewrite.AssemblyRef.TwoStreams Streams { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static implicit operator Mono.CodeContracts.Rewrite.AssemblyRef (System.IO.Stream stream) { throw null; }
        public static implicit operator Mono.CodeContracts.Rewrite.AssemblyRef (string filename) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct TwoStreams
        {
            public TwoStreams(System.IO.Stream assembly, System.IO.Stream symbols) { throw null;}
            public System.IO.Stream Assembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
            public System.IO.Stream Symbols { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        }
    }
    public partial class Rewriter
    {
        internal Rewriter() { }
        public static Mono.CodeContracts.Rewrite.RewriterResults Rewrite(Mono.CodeContracts.Rewrite.RewriterOptions options) { throw null; }
    }
    public partial class RewriterOptions
    {
        public RewriterOptions() { }
        public Mono.CodeContracts.Rewrite.AssemblyRef Assembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool BreakIntoDebugger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Debug { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ForceAssemblyRename { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int Level { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CodeContracts.Rewrite.AssemblyRef OutputFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Rewrite { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ThrowOnFailure { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool WritePdbFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class RewriterResults
    {
        internal RewriterResults() { }
        public bool AnyErrors { get { throw null; } }
        public bool AnyWarnings { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Errors { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Warnings { get { throw null; } }
    }
}
namespace Mono.CodeContracts.Static
{
    public partial class Checker
    {
        internal Checker() { }
        public static Mono.CodeContracts.Static.CheckResults Check(Mono.CodeContracts.Static.CheckOptions options) { throw null; }
    }
    public partial class CheckOptions
    {
        public CheckOptions() { }
        public string Assembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Method { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ShowDebug { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class CheckResults
    {
        internal CheckResults() { }
        public bool AnyErrors { get { throw null; } }
        public bool AnyWarnings { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Errors { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<string>> Results { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Warnings { get { throw null; } }
    }
}
namespace Mono.CodeContracts.Static.Analysis.Numerical
{
    public partial class DisInterval : Mono.CodeContracts.Static.Analysis.Numerical.IntervalBase<Mono.CodeContracts.Static.Analysis.Numerical.DisInterval, Mono.CodeContracts.Static.Analysis.Numerical.Rational>
    {
        internal DisInterval() : base (default(Mono.CodeContracts.Static.Analysis.Numerical.Rational), default(Mono.CodeContracts.Static.Analysis.Numerical.Rational)) { }
        public static readonly Mono.CodeContracts.Static.Analysis.Numerical.DisInterval NotZero;
        public Mono.CodeContracts.Static.Analysis.Numerical.Interval AsInterval { get { throw null; } }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Bottom { get { throw null; } }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval BottomValue { get { throw null; } }
        public override bool IsBottom { get { throw null; } }
        public bool IsNotZero { get { throw null; } }
        public bool IsPositiveOrZero { get { throw null; } }
        public override bool IsTop { get { throw null; } }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Top { get { throw null; } }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval TopValue { get { throw null; } }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Clone() { throw null; }
        public override void Dump(System.IO.TextWriter tw) { }
        public override bool Equals(object other) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval EverythingExcept(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval interval) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval For(Mono.CodeContracts.Static.Analysis.Numerical.Interval interval) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval For(Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> intervals) { throw null; }
        public override int GetHashCode() { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval ImmutableVersion() { throw null; }
        protected override bool IsFiniteBound(Mono.CodeContracts.Static.Analysis.Numerical.Rational n) { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Join(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Join(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that, bool widening, out bool weaker) { weaker = default(bool); throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval JoinAll(Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> list) { throw null; }
        public override bool LessEqual(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Meet(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> Normalize(Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> intervals, out bool isBottom) { isBottom = default(bool); throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator +(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator /(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator *(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator -(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator -(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left) { throw null; }
        public Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Select(System.Func<Mono.CodeContracts.Static.Analysis.Numerical.Interval, Mono.CodeContracts.Static.Analysis.Numerical.Interval> selector) { throw null; }
        public override string ToString() { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Widen(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { throw null; }
    }
    public enum ExpressionOperator
    {
        Add = 16,
        And = 3,
        Constant = 0,
        ConvertToInt32 = 24,
        Div = 19,
        Equal = 9,
        Equal_Obj = 10,
        GreaterEqualThan = 15,
        GreaterThan = 14,
        LessEqualThan = 13,
        LessThan = 12,
        LogicalAnd = 6,
        LogicalNot = 8,
        LogicalOr = 7,
        Mod = 20,
        Mult = 18,
        Not = 2,
        NotEqual = 11,
        Or = 4,
        SizeOf = 22,
        Sub = 17,
        UnaryMinus = 21,
        Unknown = 23,
        Variable = 1,
        Xor = 5,
    }
    public partial class Interval : Mono.CodeContracts.Static.Analysis.Numerical.IntervalBase<Mono.CodeContracts.Static.Analysis.Numerical.Interval, Mono.CodeContracts.Static.Analysis.Numerical.Rational>, System.IEquatable<Mono.CodeContracts.Static.Analysis.Numerical.Interval>
    {
        internal Interval() : base (default(Mono.CodeContracts.Static.Analysis.Numerical.Rational), default(Mono.CodeContracts.Static.Analysis.Numerical.Rational)) { }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Bottom { get { throw null; } }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval BottomValue { get { throw null; } }
        public override bool IsBottom { get { throw null; } }
        public override bool IsTop { get { throw null; } }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Top { get { throw null; } }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval TopValue { get { throw null; } }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval ApplyConversion(Mono.CodeContracts.Static.Analysis.Numerical.ExpressionOperator conv, Mono.CodeContracts.Static.Analysis.Numerical.Interval intv) { throw null; }
        public static bool AreConsecutiveIntegers(Mono.CodeContracts.Static.Analysis.Numerical.Interval prev, Mono.CodeContracts.Static.Analysis.Numerical.Interval next) { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Clone() { throw null; }
        public override void Dump(System.IO.TextWriter tw) { }
        public bool Equals(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(Mono.CodeContracts.Static.Analysis.Numerical.Rational value) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(Mono.CodeContracts.Static.Analysis.Numerical.Rational lowerBound, Mono.CodeContracts.Static.Analysis.Numerical.Rational upperBound) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(Mono.CodeContracts.Static.Analysis.Numerical.Rational lowerBound, long upperBound) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(long value) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(long lower, Mono.CodeContracts.Static.Analysis.Numerical.Rational upperBound) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(long lowerBound, long upperBound) { throw null; }
        public override int GetHashCode() { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval ImmutableVersion() { throw null; }
        public bool Includes(int x) { throw null; }
        public bool Includes(long x) { throw null; }
        protected override bool IsFiniteBound(Mono.CodeContracts.Static.Analysis.Numerical.Rational n) { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Join(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Join(Mono.CodeContracts.Static.Analysis.Numerical.Interval that, bool widening, out bool weaker) { weaker = default(bool); throw null; }
        public override bool LessEqual(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { throw null; }
        public bool LessEqual(System.Collections.Generic.IEnumerable<Mono.CodeContracts.Static.Analysis.Numerical.Interval> right) { throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Meet(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { throw null; }
        public bool OnTheLeftOf(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator +(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator /(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator *(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator -(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator -(Mono.CodeContracts.Static.Analysis.Numerical.Interval l) { throw null; }
        public bool OverlapsWith(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { throw null; }
        public bool TryGetSingletonFiniteInt32(out int value) { value = default(int); throw null; }
        public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Widen(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { throw null; }
    }
    public abstract partial class IntervalBase<TInterval, TNumeric> : Mono.CodeContracts.Static.Lattices.IAbstractDomain<TInterval> where TInterval : Mono.CodeContracts.Static.Analysis.Numerical.IntervalBase<TInterval, TNumeric>
    {
        protected IntervalBase(TNumeric lowerBound, TNumeric upperBound) { }
        public abstract TInterval Bottom { get; }
        public abstract bool IsBottom { get; }
        public bool IsFinite { get { throw null; } }
        public bool IsSinglePoint { get { throw null; } }
        public abstract bool IsTop { get; }
        public TNumeric LowerBound { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public abstract TInterval Top { get; }
        public TNumeric UpperBound { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public abstract TInterval Clone();
        public abstract void Dump(System.IO.TextWriter tw);
        public abstract TInterval ImmutableVersion();
        protected abstract bool IsFiniteBound(TNumeric n);
        public abstract TInterval Join(TInterval that);
        public abstract TInterval Join(TInterval that, bool widening, out bool weaker);
        public abstract bool LessEqual(TInterval that);
        public abstract TInterval Meet(TInterval that);
        public override string ToString() { throw null; }
        public abstract TInterval Widen(TInterval that);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Rational : System.IEquatable<Mono.CodeContracts.Static.Analysis.Numerical.Rational>
    {
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational MaxValue;
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational MinusInfinity;
        public static readonly Mono.CodeContracts.Static.Analysis.Numerical.Rational MinusOne;
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational MinValue;
        public static readonly Mono.CodeContracts.Static.Analysis.Numerical.Rational One;
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational PlusInfinity;
        public static readonly Mono.CodeContracts.Static.Analysis.Numerical.Rational Zero;
        public long Down { get { throw null; } }
        public bool IsInfinity { get { throw null; } }
        public bool IsInt32 { get { throw null; } }
        public bool IsInteger { get { throw null; } }
        public bool IsMaxValue { get { throw null; } }
        public bool IsMinusInfinity { get { throw null; } }
        public bool IsMinValue { get { throw null; } }
        public bool IsPlusInfinity { get { throw null; } }
        public bool IsZero { get { throw null; } }
        public Mono.CodeContracts.Static.Analysis.Numerical.Rational NextInt32 { get { throw null; } }
        public Mono.CodeContracts.Static.Analysis.Numerical.Rational NextInt64 { get { throw null; } }
        public Mono.CodeContracts.Static.Analysis.Numerical.Rational PreviousInt32 { get { throw null; } }
        public int Sign { get { throw null; } }
        public long Up { get { throw null; } }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational Abs(Mono.CodeContracts.Static.Analysis.Numerical.Rational a) { throw null; }
        public bool Equals(Mono.CodeContracts.Static.Analysis.Numerical.Rational other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational For(long number) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational For(long nominator, long denominator) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool IsInRange(long min, long max) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational Max(Mono.CodeContracts.Static.Analysis.Numerical.Rational a, Mono.CodeContracts.Static.Analysis.Numerical.Rational b) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational Min(Mono.CodeContracts.Static.Analysis.Numerical.Rational a, Mono.CodeContracts.Static.Analysis.Numerical.Rational b) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator +(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator +(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long i) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator /(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator ==(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static explicit operator double (Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static explicit operator int (Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static explicit operator long (Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator >(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator >(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { throw null; }
        public static bool operator >(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator >=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator >=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { throw null; }
        public static bool operator >=(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static implicit operator Mono.CodeContracts.Static.Analysis.Numerical.Rational (long l) { throw null; }
        public static bool operator !=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator <(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator <(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { throw null; }
        public static bool operator <(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator <=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static bool operator <=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { throw null; }
        public static bool operator <=(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator *(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator -(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator -(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long i) { throw null; }
        public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator -(Mono.CodeContracts.Static.Analysis.Numerical.Rational value) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryAdd(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); throw null; }
        public static bool TryDivide(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); throw null; }
        public static bool TryMultiply(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); throw null; }
        public static bool TrySubtract(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); throw null; }
        public static bool TryUnaryMinus(Mono.CodeContracts.Static.Analysis.Numerical.Rational value, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); throw null; }
    }
    public partial class RationalThreshold : Mono.CodeContracts.Static.Analysis.Numerical.Threshold<Mono.CodeContracts.Static.Analysis.Numerical.Rational>
    {
        public RationalThreshold(int size) : base (default(int)) { }
        protected override Mono.CodeContracts.Static.Analysis.Numerical.Rational MinusInfinity { get { throw null; } }
        protected override Mono.CodeContracts.Static.Analysis.Numerical.Rational PlusInfinity { get { throw null; } }
        protected override Mono.CodeContracts.Static.Analysis.Numerical.Rational Zero { get { throw null; } }
        protected override bool LessThan(Mono.CodeContracts.Static.Analysis.Numerical.Rational a, Mono.CodeContracts.Static.Analysis.Numerical.Rational b) { throw null; }
    }
    public abstract partial class Threshold<T>
    {
        protected int NextFree;
        protected readonly System.Collections.Generic.List<T> Values;
        protected Threshold(int size) { }
        public int Count { get { throw null; } }
        protected abstract T MinusInfinity { get; }
        protected abstract T PlusInfinity { get; }
        protected abstract T Zero { get; }
        public bool Add(T value) { throw null; }
        public int BinarySearch(T value, int low, int hi) { throw null; }
        public T GetNext(T value) { throw null; }
        public T GetPrevious(T value) { throw null; }
        protected abstract bool LessThan(T a, T b);
    }
}
namespace Mono.CodeContracts.Static.DataStructures
{
    public partial interface IImmutableIntMap<T>
    {
        T Any { get; }
        int Count { get; }
        T this[int key] { get; }
        System.Collections.Generic.IEnumerable<int> Keys { get; }
        System.Collections.Generic.IEnumerable<T> Values { get; }
        Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value);
        bool Contains(int key);
        T Lookup(int key);
        Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key);
        void Visit(System.Action<int, T> action);
        void Visit(System.Action<T> action);
    }
    public static partial class ImmutableIntMap<T>
    {
        public static readonly Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Empty;
    }
    public static partial class SequenceExtensions
    {
        public static bool All<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Predicate<T> predicate) { throw null; }
        public static bool Any<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Predicate<T> predicate) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Append<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, Mono.CodeContracts.Static.DataStructures.Sequence<T> append) { throw null; }
        public static void Apply<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Action<T> action) { }
        public static System.Collections.Generic.IEnumerable<T> AsEnumerable<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Coerce<S, T>(this Mono.CodeContracts.Static.DataStructures.Sequence<S> list) where S : T { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Cons<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> rest, T elem) { throw null; }
        public static void ForEach<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> seq, System.Action<T> action) { }
        public static bool IsEmpty<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { throw null; }
        public static T Last<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { throw null; }
        public static int Length<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Reverse<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<S> Select<T, S>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Func<T, S> selector) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Where<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Predicate<T> keep) { throw null; }
    }
    public partial class Sequence<T> : System.IEquatable<Mono.CodeContracts.Static.DataStructures.Sequence<T>>
    {
        internal Sequence() { }
        public static readonly Mono.CodeContracts.Static.DataStructures.Sequence<T> Empty;
        public T Head { get { throw null; } }
        public Mono.CodeContracts.Static.DataStructures.Sequence<T> Tail { get { throw null; } }
        public static void Apply(Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Action<T> action) { }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Cons(T elem, Mono.CodeContracts.Static.DataStructures.Sequence<T> tail) { throw null; }
        public static bool Contains(Mono.CodeContracts.Static.DataStructures.Sequence<T> l, T o) { throw null; }
        public bool Equals(Mono.CodeContracts.Static.DataStructures.Sequence<T> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> From(System.Collections.Generic.IEnumerable<T> elems) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> From(params T[] elems) { throw null; }
        public override int GetHashCode() { throw null; }
        public static int LengthOf(Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { throw null; }
        public static System.Collections.Generic.IEnumerable<T> PrivateGetEnumerable(Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<S> Select<S>(Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Func<T, S> selector) { throw null; }
        public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Singleton(T value) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace Mono.CodeContracts.Static.DataStructures.Patricia
{
    public partial class BranchNode<T> : Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T>
    {
        public readonly int BranchingBit;
        public readonly Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> Left;
        public readonly int Prefix;
        public readonly Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> Right;
        public BranchNode(int prefix, int branchingBit, Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> left, Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> right) { }
        public override int Count { get { throw null; } }
        public override int Key { get { throw null; } }
        public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value) { throw null; }
        protected internal override void AppendToBuilder(System.Text.StringBuilder sb) { }
        public override bool Contains(int key) { throw null; }
        protected internal override void Dump(System.IO.TextWriter tw, string prefix) { }
        protected internal override void FillKeysTo(System.Collections.Generic.List<int> list) { }
        protected internal override void FillValuesTo(System.Collections.Generic.List<T> list) { }
        public override T Lookup(int key) { throw null; }
        public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key) { throw null; }
        public override void Visit(System.Action<int, T> action) { }
        public override void Visit(System.Action<T> action) { }
    }
    public partial class EmptyNode<T> : Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T>
    {
        public static readonly Mono.CodeContracts.Static.DataStructures.Patricia.EmptyNode<T> Instance;
        public EmptyNode() { }
        public override int Count { get { throw null; } }
        public override int Key { get { throw null; } }
        public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value) { throw null; }
        protected internal override void AppendToBuilder(System.Text.StringBuilder sb) { }
        public override bool Contains(int key) { throw null; }
        protected internal override void Dump(System.IO.TextWriter tw, string prefix) { }
        protected internal override void FillKeysTo(System.Collections.Generic.List<int> list) { }
        protected internal override void FillValuesTo(System.Collections.Generic.List<T> list) { }
        public override T Lookup(int key) { throw null; }
        public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key) { throw null; }
        public override void Visit(System.Action<int, T> action) { }
        public override void Visit(System.Action<T> action) { }
    }
    public partial class LeafNode<T> : Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T>
    {
        public LeafNode(int key, T value) { }
        public override int Count { get { throw null; } }
        public override int Key { get { throw null; } }
        public T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value) { throw null; }
        protected internal override void AppendToBuilder(System.Text.StringBuilder sb) { }
        public override bool Contains(int key) { throw null; }
        protected internal override void Dump(System.IO.TextWriter tw, string prefix) { }
        protected internal override void FillKeysTo(System.Collections.Generic.List<int> list) { }
        protected internal override void FillValuesTo(System.Collections.Generic.List<T> list) { }
        public override T Lookup(int key) { throw null; }
        public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key) { throw null; }
        public override void Visit(System.Action<int, T> action) { }
        public override void Visit(System.Action<T> action) { }
    }
    public abstract partial class PatriciaTrieNode<T> : Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>
    {
        protected PatriciaTrieNode() { }
        public T Any { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract int Count { get; }
        public T this[int key] { get { throw null; } }
        public abstract int Key { get; }
        public System.Collections.Generic.IEnumerable<int> Keys { get { throw null; } }
        public System.Collections.Generic.IEnumerable<T> Values { get { throw null; } }
        public abstract Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value);
        protected internal abstract void AppendToBuilder(System.Text.StringBuilder sb);
        public abstract bool Contains(int key);
        public void Dump(System.IO.TextWriter tw) { }
        protected internal abstract void Dump(System.IO.TextWriter tw, string prefix);
        protected internal abstract void FillKeysTo(System.Collections.Generic.List<int> list);
        protected internal abstract void FillValuesTo(System.Collections.Generic.List<T> list);
        protected static bool IsZeroBitAt(int key, int branchingBit) { throw null; }
        protected static Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Join(Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> left, Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> right) { throw null; }
        public abstract T Lookup(int key);
        protected static bool MatchPrefix(int key, int prefix, int maskBit) { throw null; }
        public abstract Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key);
        public override string ToString() { throw null; }
        public abstract void Visit(System.Action<int, T> action);
        public abstract void Visit(System.Action<T> action);
    }
}
namespace Mono.CodeContracts.Static.Lattices
{
    public static partial class AbstractDomainExtensions
    {
        public static string BottomSymbolIfAny<T>(this Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> domain) { throw null; }
        public static bool IsNormal<T>(this Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> domain) { throw null; }
        public static bool TryTrivialJoin<T>(this T left, T right, out T result) where T : Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> { result = default(T); throw null; }
        public static bool TryTrivialLessEqual<T>(this T left, T right, out bool result) where T : Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> { result = default(bool); throw null; }
        public static bool TryTrivialMeet<T>(this T left, T right, out T result) where T : Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> { result = default(T); throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FlatDomain<T> : Mono.CodeContracts.Static.Lattices.IAbstractDomain<Mono.CodeContracts.Static.Lattices.FlatDomain<T>>, System.IEquatable<Mono.CodeContracts.Static.Lattices.FlatDomain<T>> where T : System.IEquatable<T>
    {
        public static readonly Mono.CodeContracts.Static.Lattices.FlatDomain<T> BottomValue;
        public static readonly Mono.CodeContracts.Static.Lattices.FlatDomain<T> TopValue;
        public readonly T Value;
        public FlatDomain(T value) { throw null;}
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Bottom { get { throw null; } }
        public bool IsBottom { get { throw null; } }
        public bool IsTop { get { throw null; } }
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Top { get { throw null; } }
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Clone() { throw null; }
        public void Dump(System.IO.TextWriter tw) { }
        public bool Equals(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { throw null; }
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> ImmutableVersion() { throw null; }
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Join(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { throw null; }
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Join(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that, bool widening, out bool weaker) { weaker = default(bool); throw null; }
        public bool LessEqual(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { throw null; }
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Meet(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { throw null; }
        public static implicit operator Mono.CodeContracts.Static.Lattices.FlatDomain<T> (T value) { throw null; }
        public override string ToString() { throw null; }
        public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Widen(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { throw null; }
    }
    public partial interface IAbstractDomain<T>
    {
        T Bottom { get; }
        bool IsBottom { get; }
        bool IsTop { get; }
        T Top { get; }
        T Clone();
        void Dump(System.IO.TextWriter tw);
        T ImmutableVersion();
        T Join(T that);
        T Join(T that, bool widen, out bool weaker);
        bool LessEqual(T that);
        T Meet(T that);
        T Widen(T that);
    }
}
