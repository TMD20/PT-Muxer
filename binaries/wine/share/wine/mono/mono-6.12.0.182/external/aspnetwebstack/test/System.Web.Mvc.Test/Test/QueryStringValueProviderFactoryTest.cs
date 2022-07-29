﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Specialized;
using System.Globalization;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Test
{
    public class QueryStringValueProviderFactoryTest
    {
        private static readonly NameValueCollection _backingStore = new NameValueCollection()
        {
            { "foo", "fooValue" }
        };

        private static readonly NameValueCollection _unvalidatedBackingStore = new NameValueCollection()
        {
            { "foo", "fooUnvalidated" }
        };

        [Fact]
        public void GetValueProvider()
        {
            // Arrange
            Mock<MockableUnvalidatedRequestValues> mockUnvalidatedValues = new Mock<MockableUnvalidatedRequestValues>();
            QueryStringValueProviderFactory factory = new QueryStringValueProviderFactory(_ => mockUnvalidatedValues.Object);

            Mock<ControllerContext> mockControllerContext = new Mock<ControllerContext>();
            mockControllerContext.Setup(o => o.HttpContext.Request.QueryString).Returns(_backingStore);

            // Act
            IValueProvider valueProvider = factory.GetValueProvider(mockControllerContext.Object);

            // Assert
            Assert.Equal(typeof(QueryStringValueProvider), valueProvider.GetType());
            ValueProviderResult vpResult = valueProvider.GetValue("foo");

            Assert.NotNull(vpResult);
            Assert.Equal("fooValue", vpResult.AttemptedValue);
            Assert.Equal(CultureInfo.InvariantCulture, vpResult.Culture);
        }

        [Fact]
        public void GetValueProvider_GetValue_SkipValidation()
        {
            // Arrange
            Mock<MockableUnvalidatedRequestValues> mockUnvalidatedValues = new Mock<MockableUnvalidatedRequestValues>();
            mockUnvalidatedValues.Setup(o => o.QueryString).Returns(_unvalidatedBackingStore);
            QueryStringValueProviderFactory factory = new QueryStringValueProviderFactory(_ => mockUnvalidatedValues.Object);

            Mock<ControllerContext> mockControllerContext = new Mock<ControllerContext>();
            mockControllerContext.Setup(o => o.HttpContext.Request.QueryString).Returns(_backingStore);

            // Act
            IUnvalidatedValueProvider valueProvider = (IUnvalidatedValueProvider)factory.GetValueProvider(mockControllerContext.Object);

            // Assert
            Assert.Equal(typeof(QueryStringValueProvider), valueProvider.GetType());
            ValueProviderResult vpResult = valueProvider.GetValue("foo", skipValidation: true);

            Assert.NotNull(vpResult);
            Assert.Equal("fooUnvalidated", vpResult.AttemptedValue);
            Assert.Equal(CultureInfo.InvariantCulture, vpResult.Culture);
        }

        [Fact]
        public void GetValueProvider_ThrowsIfControllerContextIsNull()
        {
            // Arrange
            QueryStringValueProviderFactory factory = new QueryStringValueProviderFactory();

            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { factory.GetValueProvider(null); }, "controllerContext");
        }
    }
}
