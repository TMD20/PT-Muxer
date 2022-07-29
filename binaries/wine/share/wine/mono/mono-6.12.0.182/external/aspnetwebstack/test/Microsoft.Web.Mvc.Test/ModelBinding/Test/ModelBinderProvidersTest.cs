﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Linq;
using Xunit;

namespace Microsoft.Web.Mvc.ModelBinding.Test
{
    public class ModelBinderProvidersTest
    {
        [Fact]
        public void CollectionDefaults()
        {
            // Arrange
            Type[] expectedTypes = new[]
            {
                typeof(TypeMatchModelBinderProvider),
                typeof(BinaryDataModelBinderProvider),
                typeof(KeyValuePairModelBinderProvider),
                typeof(ComplexModelDtoModelBinderProvider),
                typeof(ArrayModelBinderProvider),
                typeof(DictionaryModelBinderProvider),
                typeof(CollectionModelBinderProvider),
                typeof(TypeConverterModelBinderProvider),
                typeof(MutableObjectModelBinderProvider)
            };

            // Act
            Type[] actualTypes = ModelBinderProviders.Providers.Select(p => p.GetType()).ToArray();

            // Assert
            Assert.Equal(expectedTypes, actualTypes);
        }
    }
}
