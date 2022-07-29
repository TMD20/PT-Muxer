﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;

namespace System.Web.Razor.Parser
{
    internal class WhiteSpaceRewriter : MarkupRewriter
    {
        public WhiteSpaceRewriter(Action<SpanBuilder, SourceLocation, string> markupSpanFactory) : base(markupSpanFactory)
        {
        }

        protected override bool CanRewrite(Block block)
        {
            return block.Type == BlockType.Expression && Parent != null;
        }

        //public override void VisitBlock(Block block)
        //{
        //    BlockBuilder parent = null;
        //    if (_blocks.Count > 0)
        //    {
        //        parent = _blocks.Peek();
        //    }
        //    BlockBuilder newBlock = new BlockBuilder(block);
        //    newBlock.Children.Clear();
        //    _blocks.Push(newBlock);
        //    if (block.Type == BlockType.Expression && parent != null)
        //    {
        //        VisitExpressionBlock(block, parent);
        //    }
        //    else
        //    {
        //        base.VisitBlock(block);
        //    }
        //    if (_blocks.Count > 1)
        //    {
        //        parent.Children.Add(_blocks.Pop().Build());
        //    }
        //}

        //public override void VisitSpan(Span span)
        //{
        //    Debug.Assert(_blocks.Count > 0);
        //    _blocks.Peek().Children.Add(span);
        //}

        protected override SyntaxTreeNode RewriteBlock(BlockBuilder parent, Block block)
        {
            BlockBuilder newBlock = new BlockBuilder(block);
            newBlock.Children.Clear();
            Span ws = block.Children.FirstOrDefault() as Span;
            IEnumerable<SyntaxTreeNode> newNodes = block.Children;
            if (ws.Content.All(Char.IsWhiteSpace))
            {
                // Add this node to the parent
                SpanBuilder builder = new SpanBuilder(ws);
                builder.ClearSymbols();
                FillSpan(builder, ws.Start, ws.Content);
                parent.Children.Add(builder.Build());

                // Remove the old whitespace node
                newNodes = block.Children.Skip(1);
            }

            foreach (SyntaxTreeNode node in newNodes)
            {
                newBlock.Children.Add(node);
            }
            return newBlock.Build();
        }
    }
}
