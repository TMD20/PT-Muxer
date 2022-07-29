﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Generator;
using System.Web.Razor.Parser;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Resources;
using System.Web.Razor.Test.Framework;
using Xunit;

namespace System.Web.Razor.Test.Parser.VB
{
    public class VBSectionTest : VBHtmlMarkupParserTestBase
    {
        [Fact]
        public void ParseSectionBlockCapturesNewlineImmediatelyFollowing()
        {
            ParseDocumentTest(@"@Section
",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator(String.Empty),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section\r\n"),
                        new MarkupBlock())),
                new RazorError(
                    String.Format(
                        RazorResources.ParseError_Unexpected_Character_At_Section_Name_Start,
                        RazorResources.ErrorComponent_EndOfFile),
                    10, 1, 0),
                new RazorError(
                    String.Format(
                        RazorResources.ParseError_BlockNotTerminated,
                        "Section", "End Section"),
                    1, 0, 1));
        }

        [Fact]
        public void ParseSectionRequiresNameBeOnSameLineAsSectionKeyword()
        {
            ParseDocumentTest(@"@Section 
Foo
    <p>Body</p>
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator(String.Empty),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section "),
                        new MarkupBlock(
                            Factory.Markup("\r\nFoo\r\n    <p>Body</p>\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()),
                new RazorError(
                    String.Format(
                        RazorResources.ParseError_Unexpected_Character_At_Section_Name_Start,
                        RazorResources.ErrorComponent_Newline),
                    9, 0, 9));
        }

        [Fact]
        public void ParseSectionAllowsNameToBeOnDifferentLineAsSectionKeywordIfUnderscoresUsed()
        {
            ParseDocumentTest(@"@Section _
_
Foo
    <p>Body</p>
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("Foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section _\r\n_\r\nFoo"),
                        new MarkupBlock(
                            Factory.Markup("\r\n    <p>Body</p>\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }

        [Fact]
        public void ParseSectionReportsErrorAndTerminatesSectionBlockIfKeywordNotFollowedByIdentifierStartCharacter()
        {
            ParseDocumentTest(@"@Section 9
    <p>Foo</p>
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator(String.Empty),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section "),
                        new MarkupBlock(
                            Factory.Markup("9\r\n    <p>Foo</p>\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()),
                new RazorError(
                    String.Format(
                        RazorResources.ParseError_Unexpected_Character_At_Section_Name_Start,
                        String.Format(RazorResources.ErrorComponent_Character, "9")),
                    9, 0, 9));
        }

        [Fact]
        public void ParserOutputsErrorOnNestedSections()
        {
            ParseDocumentTest(@"@Section foo
    @Section bar
        <p>Foo</p>
    End Section
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section foo"),
                        new MarkupBlock(
                            Factory.Markup("\r\n"),
                            new SectionBlock(new SectionCodeGenerator("bar"),
                                Factory.Code("    ").AsStatement(),
                                Factory.CodeTransition(),
                                Factory.MetaCode("Section bar"),
                                new MarkupBlock(
                                    Factory.Markup("\r\n        <p>Foo</p>\r\n    ")),
                                Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                            Factory.Markup("\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()),
                new RazorError(
                    String.Format(
                        RazorResources.ParseError_Sections_Cannot_Be_Nested,
                        RazorResources.SectionExample_VB),
                    26, 1, 12));
        }

        [Fact]
        public void ParseSectionHandlesEOFAfterIdentifier()
        {
            ParseDocumentTest("@Section foo",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section foo")
                               .AutoCompleteWith(SyntaxConstants.VB.EndSectionKeyword),
                        new MarkupBlock())),
                new RazorError(
                    String.Format(
                        RazorResources.ParseError_BlockNotTerminated,
                        "Section", "End Section"),
                    1, 0, 1));
        }

        [Fact]
        public void ParseSectionHandlesUnterminatedSection()
        {
            ParseDocumentTest(@"@Section foo
    <p>Foo</p>",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section foo")
                               .AutoCompleteWith(SyntaxConstants.VB.EndSectionKeyword),
                        new MarkupBlock(
                            Factory.Markup("\r\n    <p>Foo</p>")))),
                new RazorError(
                    String.Format(
                        RazorResources.ParseError_BlockNotTerminated,
                        "Section", "End Section"),
                    1, 0, 1));
        }

        [Fact]
        public void ParseDocumentParsesNamedSectionCorrectly()
        {
            ParseDocumentTest(@"@Section foo
    <p>Foo</p>
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section foo"),
                        new MarkupBlock(
                            Factory.Markup("\r\n    <p>Foo</p>\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }

        [Fact]
        public void ParseSectionTerminatesOnFirstEndSection()
        {
            ParseDocumentTest(@"@Section foo
    <p>End Section</p>",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section foo"),
                        new MarkupBlock(
                            Factory.Markup("\r\n    <p>")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.Markup("</p>")));
        }

        [Fact]
        public void ParseSectionAllowsEndSectionInVBExpression()
        {
            ParseDocumentTest(@"@Section foo
    I really want to render the word @(""End Section""), so this is how I do it
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section foo"),
                        new MarkupBlock(
                            Factory.Markup("\r\n    I really want to render the word "),
                            new ExpressionBlock(
                                Factory.CodeTransition(),
                                Factory.MetaCode("(").Accepts(AcceptedCharacters.None),
                                Factory.Code("\"End Section\"").AsExpression(),
                                Factory.MetaCode(")").Accepts(AcceptedCharacters.None)),
                            Factory.Markup(", so this is how I do it\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }

        // These are tests that are normally in HtmlToCodeSwitchTest, but we want to verify them for VB 
        // since VB has slightly different section terminating behavior which follow slightly different
        // code paths

        [Fact]
        public void SectionBodyTreatsTwoAtSignsAsEscapeSequence()
        {
            ParseDocumentTest(@"@Section Foo
    <foo>@@bar</foo>
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("Foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section Foo").AutoCompleteWith(null),
                        new MarkupBlock(
                            Factory.Markup("\r\n    <foo>"),
                            Factory.Markup("@").Hidden(),
                            Factory.Markup("@bar</foo>\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }

        [Fact]
        public void SectionBodyTreatsPairsOfAtSignsAsEscapeSequence()
        {
            ParseDocumentTest(@"@Section Foo
    <foo>@@@@@bar</foo>
End Section",
                new MarkupBlock(
                    Factory.EmptyHtml(),
                    new SectionBlock(new SectionCodeGenerator("Foo"),
                        Factory.CodeTransition(),
                        Factory.MetaCode("Section Foo").AutoCompleteWith(null),
                        new MarkupBlock(
                            Factory.Markup("\r\n    <foo>"),
                            Factory.Markup("@").Hidden(),
                            Factory.Markup("@"),
                            Factory.Markup("@").Hidden(),
                            Factory.Markup("@"),
                            new ExpressionBlock(
                                Factory.CodeTransition(),
                                Factory.Code("bar")
                                       .AsImplicitExpression(VBCodeParser.DefaultKeywords)
                                       .Accepts(AcceptedCharacters.NonWhiteSpace)),
                            Factory.Markup("</foo>\r\n")),
                        Factory.MetaCode("End Section").Accepts(AcceptedCharacters.None)),
                    Factory.EmptyHtml()));
        }
    }
}
