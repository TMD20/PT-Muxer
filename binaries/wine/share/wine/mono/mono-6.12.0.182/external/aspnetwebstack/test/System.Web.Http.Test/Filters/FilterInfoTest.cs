﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.Filters
{
    public class FilterInfoTest
    {
        [Fact]
        public void Constructor()
        {
            var filterInstance = new Mock<IFilter>().Object;

            FilterInfo filter = new FilterInfo(filterInstance, FilterScope.Controller);

            Assert.Equal(FilterScope.Controller, filter.Scope);
            Assert.Same(filterInstance, filter.Instance);
        }

        [Fact]
        public void Constructor_IfInstanceParameterIsNull_ThrowsException()
        {
            Assert.ThrowsArgumentNull(() =>
            {
                new FilterInfo(instance: null, scope: FilterScope.Controller);
            }, "instance");
        }
    }
}
