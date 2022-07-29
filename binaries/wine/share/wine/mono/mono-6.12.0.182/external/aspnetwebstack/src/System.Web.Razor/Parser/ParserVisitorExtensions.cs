﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Parser.SyntaxTree;

namespace System.Web.Razor.Parser
{
    public static class ParserVisitorExtensions
    {
        public static void Visit(this ParserVisitor self, ParserResults result)
        {
            if (self == null)
            {
                throw new ArgumentNullException("self");
            }
            if (result == null)
            {
                throw new ArgumentNullException("result");
            }

            result.Document.Accept(self);
            foreach (RazorError error in result.ParserErrors)
            {
                self.VisitError(error);
            }
            self.OnComplete();
        }
    }
}
