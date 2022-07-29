﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Xunit;
using Xunit.Extensions;

namespace System.Web.Http.Filters
{
    [CLSCompliant(false)]
    public class FilterAttributeTest
    {
        [Theory]
        [InlineData(typeof(UniqueFilterAttribute), false)]
        [InlineData(typeof(MultiFilterAttribute), true)]
        [InlineData(typeof(DefaultFilterAttribute), true)]
        public void AllowMultiple(Type filterType, bool expectedAllowsMultiple)
        {
            var attribute = (FilterAttribute)Activator.CreateInstance(filterType);

            Assert.Equal(expectedAllowsMultiple, attribute.AllowMultiple);
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
        public sealed class UniqueFilterAttribute : FilterAttribute
        {
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
        public sealed class MultiFilterAttribute : FilterAttribute
        {
        }

        public sealed class DefaultFilterAttribute : FilterAttribute
        {
        }
    }
}
