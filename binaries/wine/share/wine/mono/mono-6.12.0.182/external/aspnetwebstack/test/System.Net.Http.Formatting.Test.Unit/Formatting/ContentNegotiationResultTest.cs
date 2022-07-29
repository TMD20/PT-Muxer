﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http.Headers;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Net.Http.Formatting
{
    public class ContentNegotiationResultTest
    {
        private readonly MediaTypeFormatter _formatter = new Mock<MediaTypeFormatter>().Object;
        private readonly MediaTypeHeaderValue _mediaType = new MediaTypeHeaderValue("app/json");

        [Fact]
        public void Constructor_WhenFormatterParameterIsNull_Throws()
        {
            Assert.ThrowsArgumentNull(() => new ContentNegotiationResult(formatter: null, mediaType: null), "formatter");
        }

        [Fact]
        public void MediaTypeProperty()
        {
            Assert.Reflection.Property(new ContentNegotiationResult(_formatter, _mediaType),
                nr => nr.MediaType, _mediaType, allowNull: true, roundTripTestValue: new MediaTypeHeaderValue("foo/bar"));
        }

        [Fact]
        public void FormatterProperty()
        {
            Assert.Reflection.Property(new ContentNegotiationResult(_formatter, _mediaType),
                nr => nr.Formatter, _formatter, allowNull: false, roundTripTestValue: new JsonMediaTypeFormatter());
        }
    }
}
