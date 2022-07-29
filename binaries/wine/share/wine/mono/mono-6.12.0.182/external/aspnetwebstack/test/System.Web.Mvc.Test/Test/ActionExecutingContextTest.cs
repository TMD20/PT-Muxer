﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Test
{
    public class ActionExecutingContextTest
    {
        [Fact]
        public void ConstructorThrowsIfActionDescriptorIsNull()
        {
            // Arrange
            ControllerContext controllerContext = new Mock<ControllerContext>().Object;
            ActionDescriptor actionDescriptor = null;
            Dictionary<string, object> actionParameters = new Dictionary<string, object>();

            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { new ActionExecutingContext(controllerContext, actionDescriptor, actionParameters); }, "actionDescriptor");
        }

        [Fact]
        public void ConstructorThrowsIfActionParametersIsNull()
        {
            // Arrange
            ControllerContext controllerContext = new Mock<ControllerContext>().Object;
            ActionDescriptor actionDescriptor = new Mock<ActionDescriptor>().Object;
            Dictionary<string, object> actionParameters = null;

            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { new ActionExecutingContext(controllerContext, actionDescriptor, actionParameters); }, "actionParameters");
        }

        [Fact]
        public void PropertiesAreSetByConstructor()
        {
            // Arrange
            ControllerContext controllerContext = new Mock<ControllerContext>().Object;
            ActionDescriptor actionDescriptor = new Mock<ActionDescriptor>().Object;
            Dictionary<string, object> actionParameters = new Dictionary<string, object>();

            // Act
            ActionExecutingContext actionExecutingContext = new ActionExecutingContext(controllerContext, actionDescriptor, actionParameters);

            // Assert
            Assert.Equal(actionDescriptor, actionExecutingContext.ActionDescriptor);
            Assert.Equal(actionParameters, actionExecutingContext.ActionParameters);
        }
    }
}
