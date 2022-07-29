﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.Tracing
{
    public class HttpRequestMessageExtensionsTest
    {
        [Fact]
        public void GetCorrelationId_Returns_Valid_Guid()
        {
            // Arrange
            HttpRequestMessage request = new HttpRequestMessage();

            // Act
            Guid guid1 = request.GetCorrelationId();
            Guid guid2 = request.GetCorrelationId();

            // Assert
            Assert.Equal(guid1, guid2);
            Assert.NotEqual(guid1, Guid.Empty);
        }
    }
}
