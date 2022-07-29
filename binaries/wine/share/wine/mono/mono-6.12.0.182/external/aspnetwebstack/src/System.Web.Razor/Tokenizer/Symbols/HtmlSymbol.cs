﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;

namespace System.Web.Razor.Tokenizer.Symbols
{
    public class HtmlSymbol : SymbolBase<HtmlSymbolType>
    {
        // Helper constructor
        public HtmlSymbol(int offset, int line, int column, string content, HtmlSymbolType type)
            : this(new SourceLocation(offset, line, column), content, type, Enumerable.Empty<RazorError>())
        {
        }

        public HtmlSymbol(SourceLocation start, string content, HtmlSymbolType type)
            : base(start, content, type, Enumerable.Empty<RazorError>())
        {
        }

        public HtmlSymbol(int offset, int line, int column, string content, HtmlSymbolType type, IEnumerable<RazorError> errors)
            : base(new SourceLocation(offset, line, column), content, type, errors)
        {
        }

        public HtmlSymbol(SourceLocation start, string content, HtmlSymbolType type, IEnumerable<RazorError> errors)
            : base(start, content, type, errors)
        {
        }
    }
}
