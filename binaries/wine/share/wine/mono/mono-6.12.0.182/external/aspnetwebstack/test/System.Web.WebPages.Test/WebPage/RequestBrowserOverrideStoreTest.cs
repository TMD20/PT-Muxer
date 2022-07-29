﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Moq;
using Xunit;

namespace System.Web.WebPages.Test
{
    public class RequestBrowserOverrideStoreTest
    {
        [Fact]
        public void GetOverriddenUserAgentReturnsRequestUserAgent()
        {
            // Arrange
            RequestBrowserOverrideStore requestStore = new RequestBrowserOverrideStore();
            Mock<HttpContextBase> context = new Mock<HttpContextBase>();
            context.Setup(c => c.Request.UserAgent).Returns("testUserAgent");

            // Act & Assert
            Assert.Equal("testUserAgent", requestStore.GetOverriddenUserAgent(context.Object));
        }

        [Fact]
        public void SetOverriddenUserAgentDoesNotOverrideUserAgent()
        {
            // Arrange
            RequestBrowserOverrideStore requestStore = new RequestBrowserOverrideStore();
            Mock<HttpContextBase> context = new Mock<HttpContextBase>();
            context.Setup(c => c.Request.UserAgent).Returns("testUserAgent");

            // Act
            requestStore.SetOverriddenUserAgent(context.Object, "setUserAgent");

            // Assert
            Assert.Equal("testUserAgent", requestStore.GetOverriddenUserAgent(context.Object));
        }
    }
}
