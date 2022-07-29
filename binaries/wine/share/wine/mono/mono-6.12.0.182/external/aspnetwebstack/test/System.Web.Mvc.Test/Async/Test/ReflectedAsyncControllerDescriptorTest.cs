﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Async.Test
{
    public class ReflectedAsyncControllerDescriptorTest
    {
        [Fact]
        public void ConstructorSetsControllerTypeProperty()
        {
            // Arrange
            Type controllerType = typeof(string);

            // Act
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(controllerType);

            // Assert
            Assert.Same(controllerType, cd.ControllerType);
        }

        [Fact]
        public void ConstructorThrowsIfControllerTypeIsNull()
        {
            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { new ReflectedAsyncControllerDescriptor(null); }, "controllerType");
        }

        [Fact]
        public void FindActionReturnsActionDescriptorIfFound()
        {
            // Arrange
            Type controllerType = typeof(MyController);
            MethodInfo asyncMethodInfo = controllerType.GetMethod("FooAsync");
            MethodInfo completedMethodInfo = controllerType.GetMethod("FooCompleted");
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(controllerType);

            // Act
            ActionDescriptor ad = cd.FindAction(new Mock<ControllerContext>().Object, "NewName");

            // Assert
            Assert.Equal("NewName", ad.ActionName);
            var castAd = Assert.IsType<ReflectedAsyncActionDescriptor>(ad);

            Assert.Same(asyncMethodInfo, castAd.AsyncMethodInfo);
            Assert.Same(completedMethodInfo, castAd.CompletedMethodInfo);
            Assert.Same(cd, ad.ControllerDescriptor);
        }

        [Fact]
        public void FindActionReturnsNullIfNoActionFound()
        {
            // Arrange
            Type controllerType = typeof(MyController);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(controllerType);

            // Act
            ActionDescriptor ad = cd.FindAction(new Mock<ControllerContext>().Object, "NonExistent");

            // Assert
            Assert.Null(ad);
        }

        [Fact]
        public void FindActionThrowsIfActionNameIsEmpty()
        {
            // Arrange
            Type controllerType = typeof(MyController);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(controllerType);

            // Act & assert
            Assert.ThrowsArgumentNullOrEmpty(
                delegate { cd.FindAction(new Mock<ControllerContext>().Object, ""); }, "actionName");
        }

        [Fact]
        public void FindActionThrowsIfActionNameIsNull()
        {
            // Arrange
            Type controllerType = typeof(MyController);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(controllerType);

            // Act & assert
            Assert.ThrowsArgumentNullOrEmpty(
                delegate { cd.FindAction(new Mock<ControllerContext>().Object, null); }, "actionName");
        }

        [Fact]
        public void FindActionThrowsIfControllerContextIsNull()
        {
            // Arrange
            Type controllerType = typeof(MyController);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(controllerType);

            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { cd.FindAction(null, "someName"); }, "controllerContext");
        }

        [Fact]
        public void GetCanonicalActionsReturnsEmptyArray()
        {
            // this method does nothing by default

            // Arrange
            Type controllerType = typeof(MyController);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(controllerType);

            // Act
            ActionDescriptor[] canonicalActions = cd.GetCanonicalActions();

            // Assert
            Assert.Empty(canonicalActions);
        }

        [Fact]
        public void GetCustomAttributesCallsTypeGetCustomAttributes()
        {
            // Arrange
            object[] expected = new object[0];
            Mock<Type> mockType = new Mock<Type>();
            mockType.Setup(t => t.GetCustomAttributes(true)).Returns(expected);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(mockType.Object);

            // Act
            object[] returned = cd.GetCustomAttributes(true);

            // Assert
            Assert.Same(expected, returned);
        }

        [Fact]
        public void GetCustomAttributesWithAttributeTypeCallsTypeGetCustomAttributes()
        {
            // Arrange
            object[] expected = new object[0];
            Mock<Type> mockType = new Mock<Type>();
            mockType.Setup(t => t.GetCustomAttributes(typeof(ObsoleteAttribute), true)).Returns(expected);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(mockType.Object);

            // Act
            object[] returned = cd.GetCustomAttributes(typeof(ObsoleteAttribute), true);

            // Assert
            Assert.Same(expected, returned);
        }

        [Fact]
        public void IsDefinedCallsTypeIsDefined()
        {
            // Arrange
            Mock<Type> mockType = new Mock<Type>();
            mockType.Setup(t => t.IsDefined(typeof(ObsoleteAttribute), true)).Returns(true);
            ReflectedAsyncControllerDescriptor cd = new ReflectedAsyncControllerDescriptor(mockType.Object);

            // Act
            bool isDefined = cd.IsDefined(typeof(ObsoleteAttribute), true);

            // Assert
            Assert.True(isDefined);
        }

        private class MyController : AsyncController
        {
            [ActionName("NewName")]
            public void FooAsync()
            {
            }

            public void FooCompleted()
            {
            }
        }
    }
}
