﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Text;
using Xunit;

namespace System.Web.Razor.Test.Text
{
    public class LineTrackingStringBufferTest
    {
        [Fact]
        public void CtorInitializesProperties()
        {
            LineTrackingStringBuffer buffer = new LineTrackingStringBuffer();
            Assert.Equal(0, buffer.Length);
        }

        [Fact]
        public void CharAtCorrectlyReturnsLocation()
        {
            LineTrackingStringBuffer buffer = new LineTrackingStringBuffer();
            buffer.Append("foo\rbar\nbaz\r\nbiz");
            LineTrackingStringBuffer.CharacterReference chr = buffer.CharAt(14);
            Assert.Equal('i', chr.Character);
            Assert.Equal(new SourceLocation(14, 3, 1), chr.Location);
        }
    }
}
