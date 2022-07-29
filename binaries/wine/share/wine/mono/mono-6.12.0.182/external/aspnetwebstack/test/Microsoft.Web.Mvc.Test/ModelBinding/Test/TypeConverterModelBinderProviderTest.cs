﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Web.Mvc;
using Microsoft.Web.UnitTestUtil;
using Xunit;

namespace Microsoft.Web.Mvc.ModelBinding.Test
{
    public class TypeConverterModelBinderProviderTest
    {
        [Fact]
        public void GetBinder_NoTypeConverterExistsFromString_ReturnsNull()
        {
            // Arrange
            ExtensibleModelBindingContext bindingContext = GetBindingContext(typeof(void)); // no TypeConverter exists Void -> String

            TypeConverterModelBinderProvider provider = new TypeConverterModelBinderProvider();

            // Act
            IExtensibleModelBinder binder = provider.GetBinder(null, bindingContext);

            // Assert
            Assert.Null(binder);
        }

        [Fact]
        public void GetBinder_NullValueProviderResult_ReturnsNull()
        {
            // Arrange
            ExtensibleModelBindingContext bindingContext = GetBindingContext(typeof(int));
            bindingContext.ValueProvider = new SimpleValueProvider(); // clear the ValueProvider

            TypeConverterModelBinderProvider provider = new TypeConverterModelBinderProvider();

            // Act
            IExtensibleModelBinder binder = provider.GetBinder(null, bindingContext);

            // Assert
            Assert.Null(binder);
        }

        [Fact]
        public void GetBinder_TypeConverterExistsFromString_ReturnsNull()
        {
            // Arrange
            ExtensibleModelBindingContext bindingContext = GetBindingContext(typeof(int)); // TypeConverter exists Int32 -> String

            TypeConverterModelBinderProvider provider = new TypeConverterModelBinderProvider();

            // Act
            IExtensibleModelBinder binder = provider.GetBinder(null, bindingContext);

            // Assert
            Assert.IsType<TypeConverterModelBinder>(binder);
        }

        private static ExtensibleModelBindingContext GetBindingContext(Type modelType)
        {
            return new ExtensibleModelBindingContext
            {
                ModelMetadata = new EmptyModelMetadataProvider().GetMetadataForType(null, modelType),
                ModelName = "theModelName",
                ValueProvider = new SimpleValueProvider
                {
                    { "theModelName", "someValue" }
                }
            };
        }
    }
}
