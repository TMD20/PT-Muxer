﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

//#define GENERATE_BASELINES

using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Razor.Generator;
using System.Web.Razor.Test.Utils;
using System.Web.WebPages.TestUtils;
using Xunit;

namespace System.Web.Razor.Test.Generator
{
    public abstract class RazorCodeGeneratorTest<TLanguage>
        where TLanguage : RazorCodeLanguage, new()
    {
        protected static readonly string TestRootNamespaceName = "TestOutput";

        protected abstract string FileExtension { get; }
        protected abstract string LanguageName { get; }
        protected abstract string BaselineExtension { get; }

        protected RazorEngineHost CreateHost()
        {
            return new RazorEngineHost(new TLanguage());
        }

        protected void RunTest(string name, string baselineName = null, bool generatePragmas = true, bool designTimeMode = false, IList<GeneratedCodeMapping> expectedDesignTimePragmas = null, Action<RazorEngineHost> hostConfig = null)
        {
            // Load the test files
            if (baselineName == null)
            {
                baselineName = name;
            }
            string source = TestFile.Create(String.Format("CodeGenerator.{1}.Source.{0}.{2}", name, LanguageName, FileExtension)).ReadAllText();
            string expectedOutput = TestFile.Create(String.Format("CodeGenerator.{1}.Output.{0}.{2}", baselineName, LanguageName, BaselineExtension)).ReadAllText();

            // Set up the host and engine
            RazorEngineHost host = CreateHost();
            host.NamespaceImports.Add("System");
            host.DesignTimeMode = designTimeMode;
            host.StaticHelpers = true;
            host.DefaultClassName = name;

            // Add support for templates, etc.
            host.GeneratedClassContext = new GeneratedClassContext(GeneratedClassContext.DefaultExecuteMethodName,
                                                                   GeneratedClassContext.DefaultWriteMethodName,
                                                                   GeneratedClassContext.DefaultWriteLiteralMethodName,
                                                                   "WriteTo",
                                                                   "WriteLiteralTo",
                                                                   "Template",
                                                                   "DefineSection",
                                                                   "BeginContext",
                                                                   "EndContext")
                                                                   {
                                                                       LayoutPropertyName = "Layout",
                                                                       ResolveUrlMethodName = "Href"
                                                                   };
            if (hostConfig != null)
            {
                hostConfig(host);
            }

            RazorTemplateEngine engine = new RazorTemplateEngine(host);

            // Generate code for the file
            GeneratorResults results = null;
            using (StringTextBuffer buffer = new StringTextBuffer(source))
            {
                results = engine.GenerateCode(buffer, className: name, rootNamespace: TestRootNamespaceName, sourceFileName: generatePragmas ? String.Format("{0}.{1}", name, FileExtension) : null);
            }

            // Generate code
            CodeCompileUnit ccu = results.GeneratedCode;
            CodeDomProvider codeProvider = (CodeDomProvider)Activator.CreateInstance(host.CodeLanguage.CodeDomProviderType);

            CodeGeneratorOptions options = new CodeGeneratorOptions();

            // Both run-time and design-time use these settings. See:
            // * $/Dev10/pu/SP_WebTools/venus/html/Razor/Impl/RazorCodeGenerator.cs:204
            // * $/Dev10/Releases/RTMRel/ndp/fx/src/xsp/System/Web/Compilation/BuildManagerHost.cs:373
            options.BlankLinesBetweenMembers = false;
            options.IndentString = String.Empty;

            StringBuilder output = new StringBuilder();
            using (StringWriter writer = new StringWriter(output))
            {
                codeProvider.GenerateCodeFromCompileUnit(ccu, writer, options);
            }

            WriteBaseline(String.Format(@"test\System.Web.Razor.Test\TestFiles\CodeGenerator\{0}\Output\{1}.{2}", LanguageName, baselineName, BaselineExtension), MiscUtils.StripRuntimeVersion(output.ToString()));

            // Verify code against baseline
#if !GENERATE_BASELINES
            Assert.Equal(expectedOutput, MiscUtils.StripRuntimeVersion(output.ToString()));
#endif

            // Verify design-time pragmas
            if (designTimeMode)
            {
                Assert.True(expectedDesignTimePragmas != null || results.DesignTimeLineMappings == null || results.DesignTimeLineMappings.Count == 0);
                Assert.True(expectedDesignTimePragmas == null || (results.DesignTimeLineMappings != null && results.DesignTimeLineMappings.Count > 0));
                if (expectedDesignTimePragmas != null)
                {
                    Assert.Equal(
                        expectedDesignTimePragmas.ToArray(),
                        results.DesignTimeLineMappings
                               .OrderBy(p => p.Key)
                               .Select(p => p.Value)
                               .ToArray());
                }
            }
        }

        [Conditional("GENERATE_BASELINES")]
        private void WriteBaseline(string baselineFile, string output)
        {
            string root = RecursiveFind("Runtime.sln", Path.GetFullPath("."));
            string baselinePath = Path.Combine(root, baselineFile);

            // Update baseline
            // IMPORTANT! Replace this path with the local path on your machine to the baseline files!
            if (File.Exists(baselinePath))
            {
                File.Delete(baselinePath);
            }
            File.WriteAllText(baselinePath, output.ToString());
        }

        private string RecursiveFind(string path, string start)
        {
            string test = Path.Combine(start, path);
            if (File.Exists(test))
            {
                return start;
            }
            else
            {
                return RecursiveFind(path, new DirectoryInfo(start).Parent.FullName);
            }
        }
    }
}
