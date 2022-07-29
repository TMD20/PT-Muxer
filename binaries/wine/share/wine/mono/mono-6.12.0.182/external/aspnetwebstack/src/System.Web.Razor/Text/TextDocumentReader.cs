﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.IO;

namespace System.Web.Razor.Text
{
    public class TextDocumentReader : TextReader, ITextDocument
    {
        public TextDocumentReader(ITextDocument source)
        {
            Document = source;
        }

        internal ITextDocument Document { get; private set; }

        public SourceLocation Location
        {
            get { return Document.Location; }
        }

        public int Length
        {
            get { return Document.Length; }
        }

        public int Position
        {
            get { return Document.Position; }
            set { Document.Position = value; }
        }

        public override int Read()
        {
            return Document.Read();
        }

        public override int Peek()
        {
            return Document.Peek();
        }
    }
}
