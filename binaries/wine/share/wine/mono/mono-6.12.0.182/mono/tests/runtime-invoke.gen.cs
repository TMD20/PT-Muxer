using System;
using System.Reflection;

public struct FooStruct { public int i, j; public static bool operator == (FooStruct f1, FooStruct f2) { return f1.i == f2.i && f1.j == f2.j; } public static bool operator != (FooStruct f1, FooStruct f2) { return f1.i != f2.i || f1.j != f2.j; } public override bool Equals (object obj) { return this == (FooStruct)obj; } public override int GetHashCode () { return 0; } }
public struct FooStruct2 { public long i; public static bool operator == (FooStruct2 f1, FooStruct2 f2) { return f1.i == f2.i; } public static bool operator != (FooStruct2 f1, FooStruct2 f2) { return f1.i != f2.i; } public override bool Equals (object obj) { return this == (FooStruct2)obj; } public override int GetHashCode () { return 0; } }
public struct FooStruct3 { public bool i, j; public static bool operator == (FooStruct3 f1, FooStruct3 f2) { return f1.i == f2.i && f1.j == f2.j; } public static bool operator != (FooStruct3 f1, FooStruct3 f2) { return f1.i != f2.i || f1.j != f2.j; } public override bool Equals (object obj) { return this == (FooStruct3)obj; } public override int GetHashCode () { return 0; } }
public class Tests {
    public static int Main (String[] args) {
        return TestDriver.RunTests (typeof (Tests), args);
    }
	public static int test_0_1 () {
		int res = (int)typeof (Tests).GetMethod ("meth_1").Invoke (null, new object [] { Int32.MinValue, UInt32.MaxValue});
		if (res !=  42) return 1;
		return 0;
	}
	public static int meth_1 (int arg0, uint arg1) {
		if (arg0 != Int32.MinValue) throw new Exception ();
		if (arg1 != UInt32.MaxValue) throw new Exception ();
		return 42;
	}
	public static int test_0_2 () {
		int res = (int)typeof (Tests).GetMethod ("meth_2").Invoke (null, new object [] { Int32.MinValue});
		if (res !=  42) return 1;
		return 0;
	}
	public static int meth_2 (ref int arg0) {
		if (arg0 != Int32.MinValue) throw new Exception ();
		return 42;
	}
	public static int test_0_3 () {
		short res = (short)typeof (Tests).GetMethod ("meth_3").Invoke (null, new object [] { Int16.MinValue, UInt16.MaxValue});
		if (res !=  42) return 1;
		return 0;
	}
	public static short meth_3 (short arg0, ushort arg1) {
		if (arg0 != Int16.MinValue) throw new Exception ();
		if (arg1 != UInt16.MaxValue) throw new Exception ();
		return 42;
	}
	public static int test_0_4 () {
		bool res = (bool)typeof (Tests).GetMethod ("meth_4").Invoke (null, new object [] { true, false, true});
		if (res !=  true) return 1;
		return 0;
	}
	public static bool meth_4 (bool arg0, bool arg1, bool arg2) {
		if (arg0 != true) throw new Exception ();
		if (arg1 != false) throw new Exception ();
		if (arg2 != true) throw new Exception ();
		return true;
	}
	public static int test_0_5 () {
		char res = (char)typeof (Tests).GetMethod ("meth_5").Invoke (null, new object [] { 'A', 'B', 'C'});
		if (res !=  'A') return 1;
		return 0;
	}
	public static char meth_5 (char arg0, char arg1, char arg2) {
		if (arg0 != 'A') throw new Exception ();
		if (arg1 != 'B') throw new Exception ();
		if (arg2 != 'C') throw new Exception ();
		return 'A';
	}
	public static int test_0_6 () {
		long res = (long)typeof (Tests).GetMethod ("meth_6").Invoke (null, new object [] { 0x123456789L, 0x123456789L});
		if (res !=  0x12345678AL) return 1;
		return 0;
	}
	public static long meth_6 (long arg0, long arg1) {
		if (arg0 != 0x123456789L) throw new Exception ();
		if (arg1 != 0x123456789L) throw new Exception ();
		return 0x12345678AL;
	}
	public static int test_0_7 () {
		long res = (long)typeof (Tests).GetMethod ("meth_7").Invoke (null, new object [] { 1, 0x123456789L, 0x123456789L});
		if (res !=  0x12345678AL) return 1;
		return 0;
	}
	public static long meth_7 (int arg0, long arg1, long arg2) {
		if (arg0 != 1) throw new Exception ();
		if (arg1 != 0x123456789L) throw new Exception ();
		if (arg2 != 0x123456789L) throw new Exception ();
		return 0x12345678AL;
	}
	public static int test_0_8 () {
		typeof (Tests).GetMethod ("meth_8").Invoke (null, new object [] { 1, 2, 3, 0x123456789L});
		return 0;
	}
	public static void meth_8 (int arg0, int arg1, int arg2, long arg3) {
		if (arg0 != 1) throw new Exception ();
		if (arg1 != 2) throw new Exception ();
		if (arg2 != 3) throw new Exception ();
		if (arg3 != 0x123456789L) throw new Exception ();
	}
	public static int test_0_9 () {
		typeof (Tests).GetMethod ("meth_9").Invoke (null, new object [] { 1, 2, 3, new FooStruct () { i = 1, j = 2 }});
		return 0;
	}
	public static void meth_9 (int arg0, int arg1, int arg2, FooStruct arg3) {
		if (arg0 != 1) throw new Exception ();
		if (arg1 != 2) throw new Exception ();
		if (arg2 != 3) throw new Exception ();
		if (arg3 != new FooStruct () { i = 1, j = 2 }) throw new Exception ();
	}
	public static int test_0_10 () {
		typeof (Tests).GetMethod ("meth_10").Invoke (null, new object [] { 1, 2, 3, new FooStruct2 () { i = 0x123456789L }});
		return 0;
	}
	public static void meth_10 (int arg0, int arg1, int arg2, FooStruct2 arg3) {
		if (arg0 != 1) throw new Exception ();
		if (arg1 != 2) throw new Exception ();
		if (arg2 != 3) throw new Exception ();
		if (arg3 != new FooStruct2 () { i = 0x123456789L }) throw new Exception ();
	}
	public static int test_0_11 () {
		typeof (Tests).GetMethod ("meth_11").Invoke (null, new object [] { 1, 2, 3, 4, new FooStruct () { i = 1, j = 2 }});
		return 0;
	}
	public static void meth_11 (int arg0, int arg1, int arg2, int arg3, FooStruct arg4) {
		if (arg0 != 1) throw new Exception ();
		if (arg1 != 2) throw new Exception ();
		if (arg2 != 3) throw new Exception ();
		if (arg3 != 4) throw new Exception ();
		if (arg4 != new FooStruct () { i = 1, j = 2 }) throw new Exception ();
	}
	public static int test_0_12 () {
		FooStruct3 res = (FooStruct3)typeof (Tests).GetMethod ("meth_12").Invoke (null, new object [] { new FooStruct3 () { i = true, j = false }});
		if (res !=  new FooStruct3 () { i = true, j = false }) return 1;
		return 0;
	}
	public static FooStruct3 meth_12 (FooStruct3 arg0) {
		if (arg0 != new FooStruct3 () { i = true, j = false }) throw new Exception ();
		return new FooStruct3 () { i = true, j = false };
	}
	public static int test_0_13 () {
		typeof (Tests).GetMethod ("meth_13").Invoke (null, new object [] { 0.123f});
		return 0;
	}
	public static void meth_13 (float arg0) {
		if (arg0 != 0.123f) throw new Exception ();
	}
	public static int test_0_14 () {
		typeof (Tests).GetMethod ("meth_14").Invoke (null, new object [] { 1, 2, 3, 4, 0.123f});
		return 0;
	}
	public static void meth_14 (int arg0, int arg1, int arg2, int arg3, float arg4) {
		if (arg0 != 1) throw new Exception ();
		if (arg1 != 2) throw new Exception ();
		if (arg2 != 3) throw new Exception ();
		if (arg3 != 4) throw new Exception ();
		if (arg4 != 0.123f) throw new Exception ();
	}
	public static int test_0_15 () {
		float res = (float)typeof (Tests).GetMethod ("meth_15").Invoke (null, new object [] { });
		if (res !=  0.123f) return 1;
		return 0;
	}
	public static float meth_15 () {
		return 0.123f;
	}
	public static int test_0_16 () {
		typeof (Tests).GetMethod ("meth_16").Invoke (null, new object [] { 0.123f});
		return 0;
	}
	public static void meth_16 (double arg0) {
		if (arg0 != 0.123f) throw new Exception ();
	}
	public static int test_0_17 () {
		typeof (Tests).GetMethod ("meth_17").Invoke (null, new object [] { 1, 2, 3, 0.123f});
		return 0;
	}
	public static void meth_17 (int arg0, int arg1, int arg2, double arg3) {
		if (arg0 != 1) throw new Exception ();
		if (arg1 != 2) throw new Exception ();
		if (arg2 != 3) throw new Exception ();
		if (arg3 != 0.123f) throw new Exception ();
	}
	public static int test_0_18 () {
		double res = (double)typeof (Tests).GetMethod ("meth_18").Invoke (null, new object [] { });
		if (res !=  0.123f) return 1;
		return 0;
	}
	public static double meth_18 () {
		return 0.123f;
	}
}
