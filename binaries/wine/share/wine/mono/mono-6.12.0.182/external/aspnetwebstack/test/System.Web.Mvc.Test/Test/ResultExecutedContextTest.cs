﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Test
{
    public class ResultExecutedContextTest
    {
        [Fact]
        public void ConstructorThrowsIfControllerDescriptorIsNull()
        {
            // Arrange
            ControllerContext controllerContext = null;
            ActionResult result = new ViewResult();
            bool canceled = true;
            Exception exception = null;

            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { new ResultExecutedContext(controllerContext, result, canceled, exception); }, "controllerContext");
        }

        [Fact]
        public void ConstructorThrowsIfResultIsNull()
        {
            // Arrange
            ControllerContext controllerContext = new Mock<ControllerContext>().Object;
            ActionResult result = null;
            bool canceled = true;
            Exception exception = null;

            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { new ResultExecutedContext(controllerContext, result, canceled, exception); }, "result");
        }

        [Fact]
        public void PropertiesAreSetByConstructor()
        {
            // Arrange
            ControllerContext controllerContext = new Mock<ControllerContext>().Object;
            ActionResult result = new ViewResult();
            bool canceled = true;
            Exception exception = new Exception();

            // Act
            ResultExecutedContext resultExecutedContext = new ResultExecutedContext(controllerContext, result, canceled, exception);

            // Assert
            Assert.Equal(result, resultExecutedContext.Result);
            Assert.Equal(canceled, resultExecutedContext.Canceled);
            Assert.Equal(exception, resultExecutedContext.Exception);
        }
    }
}
