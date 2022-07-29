﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Razor.Parser.SyntaxTree
{
    public enum BlockType
    {
        // Code
        Statement,
        Directive,
        Functions,
        Expression,
        Helper,

        // Markup
        Markup,
        Section,
        Template,

        // Special
        Comment
    }
}
