﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.IO;
using System.Linq;
using System.Text;

namespace System.Web.Razor.Parser
{
    internal static class TextReaderExtensions
    {
        public static string ReadUntil(this TextReader reader, char terminator)
        {
            return ReadUntil(reader, terminator, inclusive: false);
        }

        public static string ReadUntil(this TextReader reader, char terminator, bool inclusive)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            // Rather not allocate an array to use ReadUntil(TextReader, params char[]) so we'll just call the predicate version directly
            return reader.ReadUntil(c => c == terminator, inclusive);
        }

        public static string ReadUntil(this TextReader reader, params char[] terminators)
        {
            // NOTE: Using named parameters would be difficult here, hence the inline comment
            return reader.ReadUntil(inclusive: false, terminators: terminators);
        }

        public static string ReadUntil(this TextReader reader, bool inclusive, params char[] terminators)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            if (terminators == null)
            {
                throw new ArgumentNullException("terminators");
            }

            return reader.ReadUntil(c => terminators.Any(tc => tc == c), inclusive: inclusive);
        }

        public static string ReadUntil(this TextReader reader, Predicate<char> condition)
        {
            return reader.ReadUntil(condition, inclusive: false);
        }

        public static string ReadUntil(this TextReader reader, Predicate<char> condition, bool inclusive)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            if (condition == null)
            {
                throw new ArgumentNullException("condition");
            }

            StringBuilder builder = new StringBuilder();
            int ch = -1;
            while ((ch = reader.Peek()) != -1 && !condition((char)ch))
            {
                reader.Read(); // Advance the reader
                builder.Append((char)ch);
            }

            if (inclusive && reader.Peek() != -1)
            {
                builder.Append((char)reader.Read());
            }

            return builder.ToString();
        }

        public static string ReadWhile(this TextReader reader, Predicate<char> condition)
        {
            return reader.ReadWhile(condition, inclusive: false);
        }

        public static string ReadWhile(this TextReader reader, Predicate<char> condition, bool inclusive)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            if (condition == null)
            {
                throw new ArgumentNullException("condition");
            }

            return reader.ReadUntil(ch => !condition(ch), inclusive);
        }

        public static string ReadWhiteSpace(this TextReader reader)
        {
            return reader.ReadWhile(c => Char.IsWhiteSpace(c));
        }

        public static string ReadUntilWhiteSpace(this TextReader reader)
        {
            return reader.ReadUntil(c => Char.IsWhiteSpace(c));
        }
    }
}
