﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Linq;
using System.Web.Razor.Generator;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;

namespace System.Web.Razor.Parser
{
    internal class MarkupCollapser : MarkupRewriter
    {
        public MarkupCollapser(Action<SpanBuilder, SourceLocation, string> markupSpanFactory) : base(markupSpanFactory)
        {
        }

        protected override bool CanRewrite(Span span)
        {
            return span.Kind == SpanKind.Markup && span.CodeGenerator is MarkupCodeGenerator;
        }

        protected override SyntaxTreeNode RewriteSpan(BlockBuilder parent, Span span)
        {
            // Only rewrite if we have a previous that is also markup (CanRewrite does this check for us!)
            Span previous = parent.Children.LastOrDefault() as Span;
            if (previous == null || !CanRewrite(previous))
            {
                return span;
            }

            // Merge spans
            parent.Children.Remove(previous);
            SpanBuilder merged = new SpanBuilder();
            FillSpan(merged, previous.Start, previous.Content + span.Content);
            return merged.Build();
        }
    }
}
