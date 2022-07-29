﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

#if DEBUG

using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;

namespace System.Web.Razor
{
    internal static class RazorDebugHelpers
    {
        private static bool _outputDebuggingEnabled = IsDebuggingEnabled();

        private static readonly Dictionary<char, string> _printableEscapeChars = new Dictionary<char, string>
        {
            { '\0', "\\0" },
            { '\\', "\\\\" },
            { '\'', "'" },
            { '\"', "\\\"" },
            { '\a', "\\a" },
            { '\b', "\\b" },
            { '\f', "\\f" },
            { '\n', "\\n" },
            { '\r', "\\r" },
            { '\t', "\\t" },
            { '\v', "\\v" },
        };

        internal static bool OutputDebuggingEnabled
        {
            get { return _outputDebuggingEnabled; }
        }

        [SuppressMessage("Microsoft.Security", "CA2141:TransparentMethodsMustNotSatisfyLinkDemandsFxCopRule", Justification = "This is debug only")]
        [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "This is debug only")]
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.IO.StringWriter.#ctor", Justification = "This is debug only")]
        internal static void WriteGeneratedCode(string sourceFile, CodeCompileUnit codeCompileUnit)
        {
            if (!OutputDebuggingEnabled)
            {
                return;
            }

            RunTask(() =>
            {
                string extension = Path.GetExtension(sourceFile);
                RazorCodeLanguage language = RazorCodeLanguage.GetLanguageByExtension(extension);
                CodeDomProvider provider = CodeDomProvider.CreateProvider(language.LanguageName);

                using (var writer = new StringWriter())
                {
                    // Trim the html part of cshtml or vbhtml
                    string outputExtension = extension.Substring(0, 3);
                    string outputFileName = Normalize(sourceFile) + "_generated" + outputExtension;
                    string outputPath = Path.Combine(Path.GetDirectoryName(sourceFile), outputFileName);

                    // REVIEW: Do these options need to be tweaked?
                    provider.GenerateCodeFromCompileUnit(codeCompileUnit, writer, new CodeGeneratorOptions());
                    File.WriteAllText(outputPath, writer.ToString());
                }
            });
        }

        internal static void WriteDebugTree(string sourceFile, Block document, PartialParseResult result, TextChange change, RazorEditorParser parser, bool treeStructureChanged)
        {
            if (!OutputDebuggingEnabled)
            {
                return;
            }

            RunTask(() =>
            {
                string outputFileName = Normalize(sourceFile) + "_tree";
                string outputPath = Path.Combine(Path.GetDirectoryName(sourceFile), outputFileName);

                var treeBuilder = new StringBuilder();
                WriteTree(document, treeBuilder);
                treeBuilder.AppendLine();
                treeBuilder.AppendFormat(CultureInfo.CurrentCulture, "Last Change: {0}", change);
                treeBuilder.AppendLine();
                treeBuilder.AppendFormat(CultureInfo.CurrentCulture, "Normalized To: {0}", change.Normalize());
                treeBuilder.AppendLine();
                treeBuilder.AppendFormat(CultureInfo.CurrentCulture, "Partial Parse Result: {0}", result);
                treeBuilder.AppendLine();
                if (result.HasFlag(PartialParseResult.Rejected))
                {
                    treeBuilder.AppendFormat(CultureInfo.CurrentCulture, "Tree Structure Changed: {0}", treeStructureChanged);
                    treeBuilder.AppendLine();
                }
                if (result.HasFlag(PartialParseResult.AutoCompleteBlock))
                {
                    treeBuilder.AppendFormat(CultureInfo.CurrentCulture, "Auto Complete Insert String: \"{0}\"", parser.GetAutoCompleteString());
                    treeBuilder.AppendLine();
                }
                File.WriteAllText(outputPath, treeBuilder.ToString());
            });
        }

        private static void WriteTree(SyntaxTreeNode node, StringBuilder treeBuilder, int depth = 0)
        {
            if (node == null)
            {
                return;
            }
            if (depth > 1)
            {
                WriteIndent(treeBuilder, depth);
            }

            if (depth > 0)
            {
                treeBuilder.Append("|-- ");
            }

            treeBuilder.AppendLine(ConvertEscapseSequences(node.ToString()));
            if (node.IsBlock)
            {
                foreach (SyntaxTreeNode child in ((Block)node).Children)
                {
                    WriteTree(child, treeBuilder, depth + 1);
                }
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "This is debug only")]
        [SuppressMessage("Microsoft.WebAPI", "CR4000:DoNotUseProblematicTaskTypes", Justification = "This rule is not applicable to this assembly.")]
        [SuppressMessage("Microsoft.WebAPI", "CR4001:DoNotCallProblematicMethodsOnTask", Justification = "This rule is not applicable to this assembly.")]
        private static void RunTask(Action action)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    action();
                }
                catch
                {
                    // Catch all errors since this is just a debug helper
                }
            });
        }

        private static void WriteIndent(StringBuilder sb, int depth)
        {
            for (int i = 0; i < (depth - 1) * 4; ++i)
            {
                if (i % 4 == 0)
                {
                    sb.Append("|");
                }
                else
                {
                    sb.Append(" ");
                }
            }
        }

        private static string Normalize(string path)
        {
            return Path.GetFileName(path).Replace('.', '_');
        }

        private static string ConvertEscapseSequences(string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in value)
            {
                sb.Append(GetCharValue(ch));
            }
            return sb.ToString();
        }

        private static string GetCharValue(char ch)
        {
            string value;
            if (_printableEscapeChars.TryGetValue(ch, out value))
            {
                return value;
            }
            return ch.ToString();
        }

        private static bool IsDebuggingEnabled()
        {
            bool enabled;
            return Boolean.TryParse(Environment.GetEnvironmentVariable("RAZOR_DEBUG"), out enabled) && enabled;
        }
    }
}

#endif
