﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Test
{
    public class ChildActionOnlyAttributeTest
    {
        [Fact]
        public void GuardClause()
        {
            // Arrange
            ChildActionOnlyAttribute attr = new ChildActionOnlyAttribute();

            // Act & Assert
            Assert.ThrowsArgumentNull(
                () => attr.OnAuthorization(null /* filterContext */),
                "filterContext"
                );
        }

        [Fact]
        public void DoesNothingForChildRequest()
        {
            // Arrange
            ChildActionOnlyAttribute attr = new ChildActionOnlyAttribute();
            Mock<AuthorizationContext> context = new Mock<AuthorizationContext>();
            context.Setup(c => c.IsChildAction).Returns(true);

            // Act
            attr.OnAuthorization(context.Object);

            // Assert
            Assert.Null(context.Object.Result);
        }

        [Fact]
        public void ThrowsIfNotChildRequest()
        {
            // Arrange
            ChildActionOnlyAttribute attr = new ChildActionOnlyAttribute();
            Mock<AuthorizationContext> context = new Mock<AuthorizationContext>();
            context.Setup(c => c.IsChildAction).Returns(false);
            context.Setup(c => c.ActionDescriptor.ActionName).Returns("some name");

            // Act & assert
            Assert.Throws<InvalidOperationException>(
                delegate { attr.OnAuthorization(context.Object); },
                @"The action 'some name' is accessible only by a child request.");
        }
    }
}
