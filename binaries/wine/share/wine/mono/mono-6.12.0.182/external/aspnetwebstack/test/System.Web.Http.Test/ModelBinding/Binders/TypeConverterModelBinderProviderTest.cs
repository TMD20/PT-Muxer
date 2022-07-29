﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Http.Metadata.Providers;
using System.Web.Http.Util;
using Xunit;

namespace System.Web.Http.ModelBinding.Binders
{
    public class TypeConverterModelBinderProviderTest
    {
        [Fact]
        public void GetBinder_NoTypeConverterExistsFromString_ReturnsNull()
        {
            // Arrange
            ModelBindingContext bindingContext = GetBindingContext(typeof(void)); // no TypeConverter exists Void -> String

            TypeConverterModelBinderProvider provider = new TypeConverterModelBinderProvider();

            // Act
            IModelBinder binder = provider.GetBinder(null, bindingContext);

            // Assert
            Assert.Null(binder);
        }

        [Fact]
        public void GetBinder_NullValueProviderResult_ReturnsNull()
        {
            // Arrange
            ModelBindingContext bindingContext = GetBindingContext(typeof(int));
            bindingContext.ValueProvider = new SimpleHttpValueProvider(); // clear the ValueProvider

            TypeConverterModelBinderProvider provider = new TypeConverterModelBinderProvider();

            // Act
            IModelBinder binder = provider.GetBinder(null, bindingContext);

            // Assert
            Assert.Null(binder);
        }

        [Fact]
        public void GetBinder_TypeConverterExistsFromString_ReturnsNull()
        {
            // Arrange
            ModelBindingContext bindingContext = GetBindingContext(typeof(int)); // TypeConverter exists Int32 -> String

            TypeConverterModelBinderProvider provider = new TypeConverterModelBinderProvider();

            // Act
            IModelBinder binder = provider.GetBinder(null, bindingContext);

            // Assert
            Assert.IsType<TypeConverterModelBinder>(binder);
        }

        private static ModelBindingContext GetBindingContext(Type modelType)
        {
            return new ModelBindingContext
            {
                ModelMetadata = new EmptyModelMetadataProvider().GetMetadataForType(null, modelType),
                ModelName = "theModelName",
                ValueProvider = new SimpleHttpValueProvider
                {
                    { "theModelName", "someValue" }
                }
            };
        }
    }
}
