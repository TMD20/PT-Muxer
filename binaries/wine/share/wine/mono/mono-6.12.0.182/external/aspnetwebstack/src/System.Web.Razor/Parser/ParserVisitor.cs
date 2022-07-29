﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Threading;
using System.Web.Razor.Parser.SyntaxTree;

namespace System.Web.Razor.Parser
{
    public abstract class ParserVisitor
    {
        public CancellationToken? CancelToken { get; set; }

        public virtual void VisitBlock(Block block)
        {
            VisitStartBlock(block);
            foreach (SyntaxTreeNode node in block.Children)
            {
                node.Accept(this);
            }
            VisitEndBlock(block);
        }

        public virtual void VisitStartBlock(Block block)
        {
            ThrowIfCanceled();
        }

        public virtual void VisitSpan(Span span)
        {
            ThrowIfCanceled();
        }

        public virtual void VisitEndBlock(Block block)
        {
            ThrowIfCanceled();
        }

        public virtual void VisitError(RazorError err)
        {
            ThrowIfCanceled();
        }

        public virtual void OnComplete()
        {
            ThrowIfCanceled();
        }

        public virtual void ThrowIfCanceled()
        {
            if (CancelToken != null && CancelToken.Value.IsCancellationRequested)
            {
                throw new OperationCanceledException();
            }
        }
    }
}
