﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace System.Web.Razor.Parser.SyntaxTree
{
    [Flags]
    public enum AcceptedCharacters
    {
        None = 0,
        NewLine = 1,
        WhiteSpace = 2,

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "NonWhite", Justification = "This is not a compound word, it is two words")]
        NonWhiteSpace = 4,

        AllWhiteSpace = NewLine | WhiteSpace,
        Any = AllWhiteSpace | NonWhiteSpace,

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Newline", Justification = "This would be a breaking change to a previous released API")]
        AnyExceptNewline = NonWhiteSpace | WhiteSpace
    }
}
