﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Globalization;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;
using System.Web.Razor.Tokenizer.Symbols;
using Microsoft.Internal.Web.Utils;

namespace System.Web.Razor.Test.Framework
{
    internal class RawTextSymbol : ISymbol
    {
        public SourceLocation Start { get; private set; }
        public string Content { get; private set; }

        public RawTextSymbol(SourceLocation start, string content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }

            Start = start;
            Content = content;
        }

        public override bool Equals(object obj)
        {
            RawTextSymbol other = obj as RawTextSymbol;
            return Equals(Start, other.Start) && Equals(Content, other.Content);
        }

        internal bool EquivalentTo(ISymbol sym)
        {
            return Equals(Start, sym.Start) && Equals(Content, sym.Content);
        }

        public override int GetHashCode()
        {
            return HashCodeCombiner.Start()
                .Add(Start)
                .Add(Content)
                .CombinedHash;
        }

        public void OffsetStart(SourceLocation documentStart)
        {
            Start = documentStart + Start;
        }

        public void ChangeStart(SourceLocation newStart)
        {
            Start = newStart;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "{0} RAW - [{1}]", Start, Content);
        }

        internal void CalculateStart(Span prev)
        {
            if (prev == null)
            {
                Start = SourceLocation.Zero;
            }
            else
            {
                Start = new SourceLocationTracker(prev.Start).UpdateLocation(prev.Content).CurrentLocation;
            }
        }
    }
}
