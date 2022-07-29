﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Razor.Tokenizer.Symbols
{
    public enum HtmlSymbolType
    {
        Unknown,
        Text, // Text which isn't one of the below
        WhiteSpace, // Non-newline Whitespace
        NewLine, // Newline
        OpenAngle, // <
        Bang, // !
        Solidus, // /
        QuestionMark, // ?
        DoubleHyphen, // --
        LeftBracket, // [
        CloseAngle, // >
        RightBracket, // ]
        Equals, // =
        DoubleQuote, // "
        SingleQuote, // '
        Transition, // @
        Colon,
        RazorComment,
        RazorCommentStar,
        RazorCommentTransition
    }
}
