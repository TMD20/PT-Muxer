﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Globalization;
using System.Net.Http;
using System.Web.Http.Controllers;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.ValueProviders.Providers
{
    public class RouteDataValueProviderFactoryTest
    {
        private readonly RouteDataValueProviderFactory _factory = new RouteDataValueProviderFactory();

        [Fact]
        public void GetValueProvider_WhenActionContextParameterIsNull_Throws()
        {
            Assert.ThrowsArgumentNull(() => _factory.GetValueProvider(actionContext: null), "actionContext");
        }

        [Fact]
        public void GetValueProvider_ReturnsQueryStringValueProviderInstaceWithInvariantCulture()
        {
            var controllerContext = new HttpControllerContext() { Request = new HttpRequestMessage() };
            var context = new HttpActionContext() { ControllerContext = controllerContext };

            IValueProvider result = _factory.GetValueProvider(context);

            var valueProvider = Assert.IsType<RouteDataValueProvider>(result);
            Assert.Equal(CultureInfo.InvariantCulture, valueProvider.Culture);
        }
    }
}
