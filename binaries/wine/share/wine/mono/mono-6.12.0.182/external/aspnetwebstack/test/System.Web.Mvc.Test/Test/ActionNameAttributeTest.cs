﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Test
{
    public class ActionNameAttributeTest
    {
        [Fact]
        public void ConstructorThrowsIfNameIsEmpty()
        {
            // Act & Assert
            Assert.ThrowsArgumentNullOrEmpty(
                delegate { new ActionNameAttribute(String.Empty); }, "name");
        }

        [Fact]
        public void ConstructorThrowsIfNameIsNull()
        {
            // Act & Assert
            Assert.ThrowsArgumentNullOrEmpty(
                delegate { new ActionNameAttribute(null); }, "name");
        }

        [Fact]
        public void IsValidForRequestReturnsFalseIfGivenNameDoesNotMatch()
        {
            // Arrange
            ActionNameAttribute attr = new ActionNameAttribute("Bar");

            // Act
            bool returned = attr.IsValidName(null, "foo", null);

            // Assert
            Assert.False(returned);
        }

        [Fact]
        public void IsValidForRequestReturnsTrueIfGivenNameMatches()
        {
            // Arrange
            ActionNameAttribute attr = new ActionNameAttribute("Bar");

            // Act
            bool returned = attr.IsValidName(null, "bar", null);

            // Assert
            Assert.True(returned);
        }

        [Fact]
        public void NameProperty()
        {
            // Arrange
            ActionNameAttribute attr = new ActionNameAttribute("someName");

            // Act & Assert
            Assert.Equal("someName", attr.Name);
        }
    }
}
