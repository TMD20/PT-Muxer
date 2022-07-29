﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Razor.Editor
{
    /// <summary>
    /// Used within <see cref="F:SpanEditHandler.EditorHints"/>.
    /// </summary>
    [Flags]
    public enum EditorHints
    {
        /// <summary>
        /// The default (Markup or Code) editor behavior for Statement completion should be used.
        /// Editors can always use the default behavior, even if the span is labeled with a different CompletionType.
        /// </summary>
        None = 0, // 0000 0000

        /// <summary>
        /// Indicates that Virtual Path completion should be used for this span if the editor supports it.
        /// Editors need not support this mode of completion, and will use the default (<see cref="F:EditorHints.None"/>) behavior
        /// if they do not support it.
        /// </summary>
        VirtualPath = 1, // 0000 0001

        /// <summary>
        /// Indicates that this span's content contains the path to the layout page for this document.
        /// </summary>
        LayoutPage = 2, // 0000 0010
    }
}
