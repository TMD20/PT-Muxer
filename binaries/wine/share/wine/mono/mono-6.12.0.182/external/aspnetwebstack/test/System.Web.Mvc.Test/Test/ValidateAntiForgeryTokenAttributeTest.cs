﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Helpers;
using System.Web.TestUtil;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Test
{
    public class ValidateAntiForgeryTokenAttributeTest
    {
        [Fact]
        public void OnAuthorization_ThrowsIfFilterContextIsNull()
        {
            // Arrange
            ValidateAntiForgeryTokenAttribute attribute = new ValidateAntiForgeryTokenAttribute();

            // Act & Assert
            Assert.ThrowsArgumentNull(
                delegate { attribute.OnAuthorization(null); }, "filterContext");
        }

        [Fact]
        public void OnAuthorization_ForwardsAttributes()
        {
            // Arrange
            HttpContextBase context = new Mock<HttpContextBase>().Object;
            Mock<AuthorizationContext> authorizationContextMock = new Mock<AuthorizationContext>();
            authorizationContextMock.SetupGet(ac => ac.HttpContext).Returns(context);
            bool validateCalled = false;
            Action validateMethod = () =>
            {
                validateCalled = true;
            };
            ValidateAntiForgeryTokenAttribute attribute = new ValidateAntiForgeryTokenAttribute(validateMethod);

            // Act
            attribute.OnAuthorization(authorizationContextMock.Object);

            // Assert
            Assert.True(validateCalled);
        }

        [Fact]
        public void ValidateThunk_DefaultsToAntiForgeryMethod()
        {
            // Arrange
            ValidateAntiForgeryTokenAttribute attribute = new ValidateAntiForgeryTokenAttribute();

            // Act & Assert
            Assert.Equal(AntiForgery.Validate, attribute.ValidateAction);
        }
    }
}
