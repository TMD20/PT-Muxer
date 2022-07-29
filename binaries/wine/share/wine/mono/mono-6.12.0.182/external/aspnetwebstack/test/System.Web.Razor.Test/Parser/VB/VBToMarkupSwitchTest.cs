﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Editor;
using System.Web.Razor.Parser;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Test.Framework;
using System.Web.Razor.Tokenizer.Symbols;
using Xunit;
using Xunit.Extensions;

namespace System.Web.Razor.Test.Parser.VB
{
    public class VBToMarkupSwitchTest : VBHtmlCodeParserTestBase
    {
        [Fact]
        public void ParseBlockSwitchesToMarkupWhenAtSignFollowedByLessThanInStatementBlock()
        {
            ParseBlockTest(@"Code
    If True Then
        @<p>It's True!</p>
    End If
End Code",
                new StatementBlock(
                    Factory.MetaCode("Code").Accepts(AcceptedCharacters.None),
                    Factory.Code("\r\n    If True Then\r\n").AsStatement(),
                    new MarkupBlock(
                        Factory.Markup("        "),
                        Factory.MarkupTransition(),
                        Factory.Markup("<p>It's True!</p>\r\n").Accepts(AcceptedCharacters.None)),
                    Factory.Code("    End If\r\n").AsStatement(),
                    Factory.MetaCode("End Code").Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void ParseBlockGivesWhiteSpacePreceedingMarkupBlockToCodeInDesignTimeMode()
        {
            ParseBlockTest(@"Code
    @<p>Foo</p>
End Code",
                new StatementBlock(
                    Factory.MetaCode("Code").Accepts(AcceptedCharacters.None),
                    Factory.Code("\r\n    ").AsStatement(),
                    new MarkupBlock(
                        Factory.MarkupTransition(),
                        Factory.Markup("<p>Foo</p>").Accepts(AcceptedCharacters.None)),
                    Factory.Code("\r\n").AsStatement(),
                    Factory.MetaCode("End Code").Accepts(AcceptedCharacters.None)),
                designTimeParser: true);
        }

        [Theory]
        [InlineData("While", "End While", AcceptedCharacters.None)]
        [InlineData("If", "End If", AcceptedCharacters.None)]
        [InlineData("Select", "End Select", AcceptedCharacters.None)]
        [InlineData("For", "Next", AcceptedCharacters.WhiteSpace | AcceptedCharacters.NonWhiteSpace)]
        [InlineData("Try", "End Try", AcceptedCharacters.None)]
        [InlineData("With", "End With", AcceptedCharacters.None)]
        [InlineData("Using", "End Using", AcceptedCharacters.None)]
        public void SimpleMarkupSwitch(string keyword, string endSequence, AcceptedCharacters acceptedCharacters)
        {
            ParseBlockTest(keyword + @"
    If True Then
        @<p>It's True!</p>
    End If
" + endSequence,
                new StatementBlock(
                    Factory.Code(keyword + "\r\n    If True Then\r\n").AsStatement(),
                    new MarkupBlock(
                        Factory.Markup("        "),
                        Factory.MarkupTransition(),
                        Factory.Markup("<p>It's True!</p>\r\n").Accepts(AcceptedCharacters.None)),
                    Factory.Code("    End If\r\n" + endSequence).AsStatement().Accepts(acceptedCharacters)));
        }

        [Theory]
        [InlineData("While", "End While", AcceptedCharacters.None)]
        [InlineData("If", "End If", AcceptedCharacters.None)]
        [InlineData("Select", "End Select", AcceptedCharacters.None)]
        [InlineData("For", "Next", AcceptedCharacters.WhiteSpace | AcceptedCharacters.NonWhiteSpace)]
        [InlineData("Try", "End Try", AcceptedCharacters.None)]
        [InlineData("With", "End With", AcceptedCharacters.None)]
        [InlineData("Using", "End Using", AcceptedCharacters.None)]
        public void SingleLineMarkupSwitch(string keyword, string endSequence, AcceptedCharacters acceptedCharacters)
        {
            ParseBlockTest(keyword + @"
    If True Then
        @:<p>It's True!</p>
        This is code!
    End If
" + endSequence,
                new StatementBlock(
                    Factory.Code(keyword + "\r\n    If True Then\r\n").AsStatement(),
                    new MarkupBlock(
                        Factory.Markup("        "),
                        Factory.MarkupTransition(),
                        Factory.MetaMarkup(":", HtmlSymbolType.Colon),
                        Factory.Markup("<p>It's True!</p>\r\n")
                                .With(new SingleLineMarkupEditHandler(CSharpLanguageCharacteristics.Instance.TokenizeString))
                                .Accepts(AcceptedCharacters.None)),
                    Factory.Code("        This is code!\r\n    End If\r\n" + endSequence)
                            .AsStatement()
                            .Accepts(acceptedCharacters)));
        }
    }
}
