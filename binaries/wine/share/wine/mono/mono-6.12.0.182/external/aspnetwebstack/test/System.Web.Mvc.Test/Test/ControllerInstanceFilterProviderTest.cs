﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Moq;
using Xunit;

namespace System.Web.Mvc.Test
{
    public class ControllerInstanceFilterProviderTest
    {
        [Fact]
        public void GetFiltersWithNullControllerReturnsEmptyCollection()
        {
            // Arrange
            var context = new ControllerContext();
            var descriptor = new Mock<ActionDescriptor>().Object;
            var provider = new ControllerInstanceFilterProvider();

            // Act
            IEnumerable<Filter> result = provider.GetFilters(context, descriptor);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void GetFiltersWithControllerReturnsWrappedController()
        {
            // Arrange
            var controller = new Mock<ControllerBase>().Object;
            var context = new ControllerContext { Controller = controller };
            var descriptor = new Mock<ActionDescriptor>().Object;
            var provider = new ControllerInstanceFilterProvider();

            // Act
            IEnumerable<Filter> result = provider.GetFilters(context, descriptor);

            // Assert
            Filter filter = result.Single();
            Assert.Same(controller, filter.Instance);
            Assert.Equal(Int32.MinValue, filter.Order);
            Assert.Equal(FilterScope.First, filter.Scope);
        }
    }
}
