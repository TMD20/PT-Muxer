﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Generator;
using System.Web.Razor.Parser;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Resources;
using System.Web.Razor.Test.Framework;
using Xunit;

namespace System.Web.Razor.Test.Parser.VB
{
    public class VBTemplateTest : VBHtmlCodeParserTestBase
    {
        private const string TestTemplateCode = "@@<p>Foo #@item</p>";

        private TemplateBlock TestTemplate()
        {
            return new TemplateBlock(new TemplateBlockCodeGenerator(),
                new MarkupBlock(
                    Factory.MarkupTransition(),
                    Factory.MetaMarkup("@"),
                    Factory.Markup("<p>Foo #"),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("item")
                               .AsImplicitExpression(VBCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Markup("</p>").Accepts(AcceptedCharacters.None)));
        }

        private const string TestNestedTemplateCode = "@@<p>Foo #@Html.Repeat(10,@@<p>@item</p>)</p>";

        private TemplateBlock TestNestedTemplate()
        {
            return new TemplateBlock(new TemplateBlockCodeGenerator(),
                new MarkupBlock(
                    Factory.MarkupTransition(),
                    Factory.MetaMarkup("@"),
                    Factory.Markup("<p>Foo #"),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("Html.Repeat(10,")
                               .AsImplicitExpression(VBCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.Any),
                        new TemplateBlock(new TemplateBlockCodeGenerator(),
                            new MarkupBlock(
                                Factory.MarkupTransition(),
                                Factory.MetaMarkup("@"),
                                Factory.Markup("<p>"),
                                new ExpressionBlock(
                                    Factory.CodeTransition(),
                                    Factory.Code("item")
                                           .AsImplicitExpression(VBCodeParser.DefaultKeywords)
                                           .Accepts(AcceptedCharacters.NonWhiteSpace)),
                                Factory.Markup("</p>").Accepts(AcceptedCharacters.None))),
                        Factory.Code(")")
                               .AsImplicitExpression(VBCodeParser.DefaultKeywords)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Markup("</p>").Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void ParseBlockHandlesSimpleAnonymousSectionInExplicitExpressionParens()
        {
            ParseBlockTest("(Html.Repeat(10," + TestTemplateCode + "))",
                new ExpressionBlock(
                    Factory.MetaCode("(").Accepts(AcceptedCharacters.None),
                    Factory.Code("Html.Repeat(10,").AsExpression(),
                    TestTemplate(),
                    Factory.Code(")").AsExpression(),
                    Factory.MetaCode(")").Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void ParseBlockHandlesSimpleAnonymousSectionInImplicitExpressionParens()
        {
            ParseBlockTest("Html.Repeat(10," + TestTemplateCode + ")",
                new ExpressionBlock(
                    Factory.Code("Html.Repeat(10,").AsImplicitExpression(KeywordSet),
                    TestTemplate(),
                    Factory.Code(")").AsImplicitExpression(KeywordSet).Accepts(AcceptedCharacters.NonWhiteSpace)));
        }

        [Fact]
        public void ParseBlockHandlesTwoAnonymousSectionsInImplicitExpressionParens()
        {
            ParseBlockTest("Html.Repeat(10," + TestTemplateCode + "," + TestTemplateCode + ")",
                new ExpressionBlock(
                    Factory.Code("Html.Repeat(10,").AsImplicitExpression(KeywordSet),
                    TestTemplate(),
                    Factory.Code(",").AsImplicitExpression(KeywordSet),
                    TestTemplate(),
                    Factory.Code(")").AsImplicitExpression(KeywordSet).Accepts(AcceptedCharacters.NonWhiteSpace)));
        }

        [Fact]
        public void ParseBlockProducesErrorButCorrectlyParsesNestedAnonymousSectionInImplicitExpressionParens()
        {
            ParseBlockTest("Html.Repeat(10," + TestNestedTemplateCode + ")",
                new ExpressionBlock(
                    Factory.Code("Html.Repeat(10,").AsImplicitExpression(KeywordSet),
                    TestNestedTemplate(),
                    Factory.Code(")").AsImplicitExpression(KeywordSet).Accepts(AcceptedCharacters.NonWhiteSpace)),
                GetNestedSectionError(41, 0, 41));
        }

        [Fact]
        public void ParseBlockHandlesSimpleAnonymousSectionInStatementWithinCodeBlock()
        {
            ParseBlockTest(@"For Each foo in Bar 
    Html.ExecuteTemplate(foo," + TestTemplateCode + @")
Next foo",
                new StatementBlock(
                    Factory.Code("For Each foo in Bar \r\n    Html.ExecuteTemplate(foo,")
                           .AsStatement(),
                    TestTemplate(),
                    Factory.Code(")\r\nNext foo")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.WhiteSpace | AcceptedCharacters.NonWhiteSpace)));
        }

        [Fact]
        public void ParseBlockHandlesTwoAnonymousSectionsInStatementWithinCodeBlock()
        {
            ParseBlockTest(@"For Each foo in Bar 
    Html.ExecuteTemplate(foo," + TestTemplateCode + "," + TestTemplateCode + @")
Next foo",
                new StatementBlock(
                    Factory.Code("For Each foo in Bar \r\n    Html.ExecuteTemplate(foo,")
                           .AsStatement(),
                    TestTemplate(),
                    Factory.Code(",").AsStatement(),
                    TestTemplate(),
                    Factory.Code(")\r\nNext foo")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.WhiteSpace | AcceptedCharacters.NonWhiteSpace)));
        }

        [Fact]
        public void ParseBlockProducesErrorButCorrectlyParsesNestedAnonymousSectionInStatementWithinCodeBlock()
        {
            ParseBlockTest(@"For Each foo in Bar 
    Html.ExecuteTemplate(foo," + TestNestedTemplateCode + @")
Next foo",
                new StatementBlock(
                    Factory.Code("For Each foo in Bar \r\n    Html.ExecuteTemplate(foo,")
                           .AsStatement(),
                    TestNestedTemplate(),
                    Factory.Code(")\r\nNext foo")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.WhiteSpace | AcceptedCharacters.NonWhiteSpace)),
                GetNestedSectionError(77, 1, 55));
        }

        [Fact]
        public void ParseBlockHandlesSimpleAnonymousSectionInStatementWithinStatementBlock()
        {
            ParseBlockTest(@"Code 
    Dim foo = bar
    Html.ExecuteTemplate(foo," + TestTemplateCode + @")
End Code",
                new StatementBlock(
                    Factory.MetaCode("Code").Accepts(AcceptedCharacters.None),
                    Factory.Code(" \r\n    Dim foo = bar\r\n    Html.ExecuteTemplate(foo,")
                           .AsStatement(),
                    TestTemplate(),
                    Factory.Code(")\r\n").AsStatement(),
                    Factory.MetaCode("End Code").Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void ParseBlockHandlessTwoAnonymousSectionsInStatementWithinStatementBlock()
        {
            ParseBlockTest(@"Code
    Dim foo = bar
    Html.ExecuteTemplate(foo," + TestTemplateCode + "," + TestTemplateCode + @")
End Code",
                new StatementBlock(
                    Factory.MetaCode("Code").Accepts(AcceptedCharacters.None),
                    Factory.Code("\r\n    Dim foo = bar\r\n    Html.ExecuteTemplate(foo,")
                           .AsStatement(),
                    TestTemplate(),
                    Factory.Code(",").AsStatement(),
                    TestTemplate(),
                    Factory.Code(")\r\n").AsStatement(),
                    Factory.MetaCode("End Code").Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void ParseBlockProducesErrorButCorrectlyParsesNestedAnonymousSectionInStatementWithinStatementBlock()
        {
            ParseBlockTest(@"Code
    Dim foo = bar
    Html.ExecuteTemplate(foo," + TestNestedTemplateCode + @")
End Code",
                new StatementBlock(
                    Factory.MetaCode("Code").Accepts(AcceptedCharacters.None),
                    Factory.Code("\r\n    Dim foo = bar\r\n    Html.ExecuteTemplate(foo,")
                           .AsStatement(),
                    TestNestedTemplate(),
                    Factory.Code(")\r\n").AsStatement(),
                    Factory.MetaCode("End Code").Accepts(AcceptedCharacters.None)),
                GetNestedSectionError(80, 2, 55));
        }

        private static RazorError GetNestedSectionError(int absoluteIndex, int lineIndex, int characterIndex)
        {
            return new RazorError(
                RazorResources.ParseError_InlineMarkup_Blocks_Cannot_Be_Nested,
                absoluteIndex, lineIndex, characterIndex);
        }
    }
}
