﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.Razor.Parser;
using System.Web.Razor.Parser.SyntaxTree;

namespace System.Web.Razor.Test.Framework
{
    public abstract class CodeParserTestBase : ParserTestBase
    {
        protected abstract ISet<string> KeywordSet { get; }

        protected override ParserBase SelectActiveParser(ParserBase codeParser, ParserBase markupParser)
        {
            return codeParser;
        }

        protected void ImplicitExpressionTest(string input, params RazorError[] errors)
        {
            ImplicitExpressionTest(input, AcceptedCharacters.NonWhiteSpace, errors);
        }

        protected void ImplicitExpressionTest(string input, AcceptedCharacters acceptedCharacters, params RazorError[] errors)
        {
            ImplicitExpressionTest(input, input, acceptedCharacters, errors);
        }

        protected void ImplicitExpressionTest(string input, string expected, params RazorError[] errors)
        {
            ImplicitExpressionTest(input, expected, AcceptedCharacters.NonWhiteSpace, errors);
        }

        protected override void SingleSpanBlockTest(string document, BlockType blockType, SpanKind spanType, AcceptedCharacters acceptedCharacters = AcceptedCharacters.Any)
        {
            SingleSpanBlockTest(document, blockType, spanType, acceptedCharacters, expectedError: null);
        }

        protected override void SingleSpanBlockTest(string document, string spanContent, BlockType blockType, SpanKind spanType, AcceptedCharacters acceptedCharacters = AcceptedCharacters.Any)
        {
            SingleSpanBlockTest(document, spanContent, blockType, spanType, acceptedCharacters, expectedErrors: null);
        }

        protected override void SingleSpanBlockTest(string document, BlockType blockType, SpanKind spanType, params RazorError[] expectedError)
        {
            SingleSpanBlockTest(document, document, blockType, spanType, expectedError);
        }

        protected override void SingleSpanBlockTest(string document, string spanContent, BlockType blockType, SpanKind spanType, params RazorError[] expectedErrors)
        {
            SingleSpanBlockTest(document, spanContent, blockType, spanType, AcceptedCharacters.Any, expectedErrors ?? new RazorError[0]);
        }

        protected override void SingleSpanBlockTest(string document, BlockType blockType, SpanKind spanType, AcceptedCharacters acceptedCharacters, params RazorError[] expectedError)
        {
            SingleSpanBlockTest(document, document, blockType, spanType, acceptedCharacters, expectedError);
        }

        protected override void SingleSpanBlockTest(string document, string spanContent, BlockType blockType, SpanKind spanType, AcceptedCharacters acceptedCharacters, params RazorError[] expectedErrors)
        {
            Block b = CreateSimpleBlockAndSpan(spanContent, blockType, spanType, acceptedCharacters);
            ParseBlockTest(document, b, expectedErrors ?? new RazorError[0]);
        }

        protected void ImplicitExpressionTest(string input, string expected, AcceptedCharacters acceptedCharacters, params RazorError[] errors)
        {
            var factory = CreateSpanFactory();
            ParseBlockTest(SyntaxConstants.TransitionString + input,
                           new ExpressionBlock(
                               factory.CodeTransition(),
                               factory.Code(expected)
                                   .AsImplicitExpression(KeywordSet)
                                   .Accepts(acceptedCharacters)),
                           errors);
        }
    }
}
