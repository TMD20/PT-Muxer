﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using Xunit;

namespace System.Web.Mvc.Test
{
    public class ParameterBindingInfoTest
    {
        [Fact]
        public void BinderProperty()
        {
            // Arrange
            ParameterBindingInfo bindingInfo = new ParameterBindingInfoHelper();

            // Act & assert
            Assert.Null(bindingInfo.Binder);
        }

        [Fact]
        public void ExcludeProperty()
        {
            // Arrange
            ParameterBindingInfo bindingInfo = new ParameterBindingInfoHelper();

            // Act
            ICollection<string> exclude = bindingInfo.Exclude;

            // Assert
            Assert.NotNull(exclude);
            Assert.Empty(exclude);
        }

        [Fact]
        public void IncludeProperty()
        {
            // Arrange
            ParameterBindingInfo bindingInfo = new ParameterBindingInfoHelper();

            // Act
            ICollection<string> include = bindingInfo.Include;

            // Assert
            Assert.NotNull(include);
            Assert.Empty(include);
        }

        [Fact]
        public void PrefixProperty()
        {
            // Arrange
            ParameterBindingInfo bindingInfo = new ParameterBindingInfoHelper();

            // Act & assert
            Assert.Null(bindingInfo.Prefix);
        }

        private class ParameterBindingInfoHelper : ParameterBindingInfo
        {
        }
    }
}
