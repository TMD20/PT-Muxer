﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;

namespace System.Web.Razor.Tokenizer.Symbols
{
    public class CSharpSymbol : SymbolBase<CSharpSymbolType>
    {
        // Helper constructor
        public CSharpSymbol(int offset, int line, int column, string content, CSharpSymbolType type)
            : this(new SourceLocation(offset, line, column), content, type, Enumerable.Empty<RazorError>())
        {
        }

        public CSharpSymbol(SourceLocation start, string content, CSharpSymbolType type)
            : this(start, content, type, Enumerable.Empty<RazorError>())
        {
        }

        public CSharpSymbol(int offset, int line, int column, string content, CSharpSymbolType type, IEnumerable<RazorError> errors)
            : base(new SourceLocation(offset, line, column), content, type, errors)
        {
        }

        public CSharpSymbol(SourceLocation start, string content, CSharpSymbolType type, IEnumerable<RazorError> errors)
            : base(start, content, type, errors)
        {
        }

        public bool? EscapedIdentifier { get; set; }
        public CSharpKeyword? Keyword { get; set; }

        public override bool Equals(object obj)
        {
            CSharpSymbol other = obj as CSharpSymbol;
            return base.Equals(obj) && other.Keyword == Keyword;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Keyword.GetHashCode();
        }
    }
}
