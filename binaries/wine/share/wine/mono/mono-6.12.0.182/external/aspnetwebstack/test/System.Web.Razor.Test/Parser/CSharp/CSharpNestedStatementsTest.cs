﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Generator;
using System.Web.Razor.Parser;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Test.Framework;
using Xunit;

namespace System.Web.Razor.Test.Parser.CSharp
{
    public class CSharpNestedStatementsTest : CsHtmlCodeParserTestBase
    {
        [Fact]
        public void NestedSimpleStatement()
        {
            ParseBlockTest("@while(true) { foo(); }",
                new StatementBlock(
                    Factory.CodeTransition(),
                    Factory.Code("while(true) { foo(); }")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void NestedKeywordStatement()
        {
            ParseBlockTest("@while(true) { for(int i = 0; i < 10; i++) { foo(); } }",
                new StatementBlock(
                    Factory.CodeTransition(),
                    Factory.Code("while(true) { for(int i = 0; i < 10; i++) { foo(); } }")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void NestedCodeBlock()
        {
            ParseBlockTest("@while(true) { { { { foo(); } } } }",
                new StatementBlock(
                    Factory.CodeTransition(),
                    Factory.Code("while(true) { { { { foo(); } } } }")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void NestedImplicitExpression()
        {
            ParseBlockTest("@while(true) { @foo }",
                new StatementBlock(
                    Factory.CodeTransition(),
                    Factory.Code("while(true) { ")
                           .AsStatement(),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.Code("foo")
                               .AsImplicitExpression(CSharpCodeParser.DefaultKeywords, acceptTrailingDot: true)
                               .Accepts(AcceptedCharacters.NonWhiteSpace)),
                    Factory.Code(" }")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void NestedExplicitExpression()
        {
            ParseBlockTest("@while(true) { @(foo) }",
                new StatementBlock(
                    Factory.CodeTransition(),
                    Factory.Code("while(true) { ")
                           .AsStatement(),
                    new ExpressionBlock(
                        Factory.CodeTransition(),
                        Factory.MetaCode("(")
                               .Accepts(AcceptedCharacters.None),
                        Factory.Code("foo")
                               .AsExpression(),
                        Factory.MetaCode(")")
                               .Accepts(AcceptedCharacters.None)),
                    Factory.Code(" }")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.None)));
        }

        [Fact]
        public void NestedMarkupBlock()
        {
            ParseBlockTest("@while(true) { <p>Hello</p> }",
                new StatementBlock(
                    Factory.CodeTransition(),
                    Factory.Code("while(true) {")
                           .AsStatement(),
                    new MarkupBlock(
                        Factory.Markup(" <p>Hello</p> ")
                               .With(new MarkupCodeGenerator())
                               .Accepts(AcceptedCharacters.None)),
                    Factory.Code("}")
                           .AsStatement()
                           .Accepts(AcceptedCharacters.None)));
        }
    }
}
