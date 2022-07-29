﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.Razor.Parser;

namespace System.Web.Razor.Test.Framework
{
    public abstract class VBHtmlMarkupParserTestBase : MarkupParserTestBase
    {
        protected override ISet<string> KeywordSet
        {
            get { return VBCodeParser.DefaultKeywords; }
        }

        protected override SpanFactory CreateSpanFactory()
        {
            return SpanFactory.CreateVbHtml();
        }

        public override ParserBase CreateMarkupParser()
        {
            return new HtmlMarkupParser();
        }

        public override ParserBase CreateCodeParser()
        {
            return new VBCodeParser();
        }
    }
}
