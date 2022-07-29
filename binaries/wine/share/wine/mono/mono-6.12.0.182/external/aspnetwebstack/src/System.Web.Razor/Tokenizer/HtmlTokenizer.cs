﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Razor.Parser;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;
using System.Web.Razor.Tokenizer.Symbols;

namespace System.Web.Razor.Tokenizer
{
    // Tokenizer _loosely_ based on http://dev.w3.org/html5/spec/Overview.html#tokenization
    public class HtmlTokenizer : Tokenizer<HtmlSymbol, HtmlSymbolType>
    {
        private const char TransitionChar = '@';

        public HtmlTokenizer(ITextDocument source)
            : base(source)
        {
            CurrentState = Data;
        }

        protected override State StartState
        {
            get { return Data; }
        }

        public override HtmlSymbolType RazorCommentType
        {
            get { return HtmlSymbolType.RazorComment; }
        }

        public override HtmlSymbolType RazorCommentTransitionType
        {
            get { return HtmlSymbolType.RazorCommentTransition; }
        }

        public override HtmlSymbolType RazorCommentStarType
        {
            get { return HtmlSymbolType.RazorCommentStar; }
        }

        internal static IEnumerable<HtmlSymbol> Tokenize(string content)
        {
            using (SeekableTextReader reader = new SeekableTextReader(content))
            {
                HtmlTokenizer tok = new HtmlTokenizer(reader);
                HtmlSymbol sym;
                while ((sym = tok.NextSymbol()) != null)
                {
                    yield return sym;
                }
            }
        }

        protected override HtmlSymbol CreateSymbol(SourceLocation start, string content, HtmlSymbolType type, IEnumerable<RazorError> errors)
        {
            return new HtmlSymbol(start, content, type, errors);
        }

        // http://dev.w3.org/html5/spec/Overview.html#data-state
        private StateResult Data()
        {
            if (ParserHelpers.IsWhitespace(CurrentCharacter))
            {
                return Stay(Whitespace());
            }
            else if (ParserHelpers.IsNewLine(CurrentCharacter))
            {
                return Stay(Newline());
            }
            else if (CurrentCharacter == '@')
            {
                TakeCurrent();
                if (CurrentCharacter == '*')
                {
                    return Transition(EndSymbol(HtmlSymbolType.RazorCommentTransition), AfterRazorCommentTransition);
                }
                else if (CurrentCharacter == '@')
                {
                    // Could be escaped comment transition
                    return Transition(EndSymbol(HtmlSymbolType.Transition), () =>
                    {
                        TakeCurrent();
                        return Transition(EndSymbol(HtmlSymbolType.Transition), Data);
                    });
                }
                return Stay(EndSymbol(HtmlSymbolType.Transition));
            }
            else if (AtSymbol())
            {
                return Stay(Symbol());
            }
            else
            {
                return Transition(Text);
            }
        }

        private StateResult Text()
        {
            char prev = '\0';
            while (!EndOfFile && !ParserHelpers.IsWhitespaceOrNewLine(CurrentCharacter) && !AtSymbol())
            {
                prev = CurrentCharacter;
                TakeCurrent();
            }

            if (CurrentCharacter == '@')
            {
                char next = Peek();
                if (ParserHelpers.IsLetterOrDecimalDigit(prev) && ParserHelpers.IsLetterOrDecimalDigit(next))
                {
                    TakeCurrent(); // Take the "@"
                    return Stay(); // Stay in the Text state
                }
            }

            // Output the Text token and return to the Data state to tokenize the next character (if there is one)
            return Transition(EndSymbol(HtmlSymbolType.Text), Data);
        }

        private HtmlSymbol Symbol()
        {
            Debug.Assert(AtSymbol());
            char sym = CurrentCharacter;
            TakeCurrent();
            switch (sym)
            {
                case '<':
                    return EndSymbol(HtmlSymbolType.OpenAngle);
                case '!':
                    return EndSymbol(HtmlSymbolType.Bang);
                case '/':
                    return EndSymbol(HtmlSymbolType.Solidus);
                case '?':
                    return EndSymbol(HtmlSymbolType.QuestionMark);
                case '[':
                    return EndSymbol(HtmlSymbolType.LeftBracket);
                case '>':
                    return EndSymbol(HtmlSymbolType.CloseAngle);
                case ']':
                    return EndSymbol(HtmlSymbolType.RightBracket);
                case '=':
                    return EndSymbol(HtmlSymbolType.Equals);
                case '"':
                    return EndSymbol(HtmlSymbolType.DoubleQuote);
                case '\'':
                    return EndSymbol(HtmlSymbolType.SingleQuote);
                case '-':
                    Debug.Assert(CurrentCharacter == '-');
                    TakeCurrent();
                    return EndSymbol(HtmlSymbolType.DoubleHyphen);
                default:
                    Debug.Fail("Unexpected symbol!");
                    return EndSymbol(HtmlSymbolType.Unknown);
            }
        }

        private HtmlSymbol Whitespace()
        {
            while (ParserHelpers.IsWhitespace(CurrentCharacter))
            {
                TakeCurrent();
            }
            return EndSymbol(HtmlSymbolType.WhiteSpace);
        }

        private HtmlSymbol Newline()
        {
            Debug.Assert(ParserHelpers.IsNewLine(CurrentCharacter));
            // CSharp Spec §2.3.1
            bool checkTwoCharNewline = CurrentCharacter == '\r';
            TakeCurrent();
            if (checkTwoCharNewline && CurrentCharacter == '\n')
            {
                TakeCurrent();
            }
            return EndSymbol(HtmlSymbolType.NewLine);
        }

        private bool AtSymbol()
        {
            return CurrentCharacter == '<' ||
                   CurrentCharacter == '<' ||
                   CurrentCharacter == '!' ||
                   CurrentCharacter == '/' ||
                   CurrentCharacter == '?' ||
                   CurrentCharacter == '[' ||
                   CurrentCharacter == '>' ||
                   CurrentCharacter == ']' ||
                   CurrentCharacter == '=' ||
                   CurrentCharacter == '"' ||
                   CurrentCharacter == '\'' ||
                   CurrentCharacter == '@' ||
                   (CurrentCharacter == '-' && Peek() == '-');
        }
    }
}
