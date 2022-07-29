using System.IO;
using System.Text;

foreach (var file in Directory.GetFiles (".", "*.cs", SearchOption.AllDirectories)) {
	var text = File.ReadAllText (file);
	if (text.Contains ("#if NUNIT"))
		continue;
	Console.Error.WriteLine (file + " : " + text.Contains ("using Microsoft.VisualStudio.TestTools.UnitTesting;"));
	text = text.Replace (
"using Microsoft.VisualStudio.TestTools.UnitTesting;",
@"#if NUNIT
using NUnit.Framework;
using TestClassAttribute = NUnit.Framework.TestFixtureAttribute;
using TestMethodAttribute = NUnit.Framework.TestAttribute;
using TestInitializeAttribute = NUnit.Framework.SetUpAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif".Replace ("\n", "\r\n"));

	text = text.Replace ("[Timeout", "//[Timeout"); // no TimeoutAttribute in NUnit.

	using (var tw = new StreamWriter (file, false, new UTF8Encoding (true, true)))
		tw.Write (text);
}
