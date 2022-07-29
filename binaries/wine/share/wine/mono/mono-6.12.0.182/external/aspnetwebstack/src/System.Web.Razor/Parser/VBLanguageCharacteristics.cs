﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;
using System.Web.Razor.Tokenizer;
using System.Web.Razor.Tokenizer.Symbols;

namespace System.Web.Razor.Parser
{
    public class VBLanguageCharacteristics : LanguageCharacteristics<VBTokenizer, VBSymbol, VBSymbolType>
    {
        private static readonly VBLanguageCharacteristics _instance = new VBLanguageCharacteristics();

        private VBLanguageCharacteristics()
        {
        }

        public static VBLanguageCharacteristics Instance
        {
            get { return _instance; }
        }

        public override VBTokenizer CreateTokenizer(ITextDocument source)
        {
            return new VBTokenizer(source);
        }

        public override string GetSample(VBSymbolType type)
        {
            return VBSymbol.GetSample(type);
        }

        public override VBSymbolType FlipBracket(VBSymbolType bracket)
        {
            switch (bracket)
            {
                case VBSymbolType.LeftBrace:
                    return VBSymbolType.RightBrace;
                case VBSymbolType.LeftBracket:
                    return VBSymbolType.RightBracket;
                case VBSymbolType.LeftParenthesis:
                    return VBSymbolType.RightParenthesis;
                case VBSymbolType.RightBrace:
                    return VBSymbolType.LeftBrace;
                case VBSymbolType.RightBracket:
                    return VBSymbolType.LeftBracket;
                case VBSymbolType.RightParenthesis:
                    return VBSymbolType.LeftParenthesis;
                default:
                    return VBSymbolType.Unknown;
            }
        }

        public override VBSymbol CreateMarkerSymbol(SourceLocation location)
        {
            return new VBSymbol(location, String.Empty, VBSymbolType.Unknown);
        }

        public override VBSymbolType GetKnownSymbolType(KnownSymbolType type)
        {
            switch (type)
            {
                case KnownSymbolType.CommentStart:
                    return VBSymbolType.RazorCommentTransition;
                case KnownSymbolType.CommentStar:
                    return VBSymbolType.RazorCommentStar;
                case KnownSymbolType.CommentBody:
                    return VBSymbolType.RazorComment;
                case KnownSymbolType.Identifier:
                    return VBSymbolType.Identifier;
                case KnownSymbolType.Keyword:
                    return VBSymbolType.Keyword;
                case KnownSymbolType.NewLine:
                    return VBSymbolType.NewLine;
                case KnownSymbolType.Transition:
                    return VBSymbolType.Transition;
                case KnownSymbolType.WhiteSpace:
                    return VBSymbolType.WhiteSpace;
                default:
                    return VBSymbolType.Unknown;
            }
        }

        protected override VBSymbol CreateSymbol(SourceLocation location, string content, VBSymbolType type, IEnumerable<RazorError> errors)
        {
            return new VBSymbol(location, content, type, errors);
        }
    }
}
