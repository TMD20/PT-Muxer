﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Razor.Generator
{
    public enum ExpressionRenderingMode
    {
        /// <summary>
        /// Indicates that expressions should be written to the output stream
        /// </summary>
        /// <example>
        /// If @foo is rendered with WriteToOutput, the code generator would output the following code:
        /// 
        /// Write(foo);
        /// </example>
        WriteToOutput,

        /// <summary>
        /// Indicates that expressions should simply be placed as-is in the code, and the context in which
        /// the code exists will be used to render it
        /// </summary>
        /// <example>
        /// If @foo is rendered with InjectCode, the code generator would output the following code:
        /// 
        /// foo
        /// </example>
        InjectCode
    }
}
