﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using Xunit;

namespace System.Web.Mvc.Test
{
    public class ActionMethodDispatcherCacheTest
    {
        [Fact]
        public void GetDispatcher()
        {
            // Arrange
            MethodInfo methodInfo = typeof(object).GetMethod("ToString");
            ActionMethodDispatcherCache cache = new ActionMethodDispatcherCache();

            // Act
            ActionMethodDispatcher dispatcher1 = cache.GetDispatcher(methodInfo);
            ActionMethodDispatcher dispatcher2 = cache.GetDispatcher(methodInfo);

            // Assert
            Assert.Same(methodInfo, dispatcher1.MethodInfo);
            Assert.Same(dispatcher1, dispatcher2);
        }
    }
}
