﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.WebPages.Scope;
using Xunit;

namespace System.Web.WebPages.Test
{
    public class ScopeStorageKeyComparerTest
    {
        [Fact]
        public void ScopeStorageComparerPerformsCaseInsensitiveOrdinalComparisonForStrings()
        {
            // Arrange
            var dictionary = new Dictionary<object, object>(ScopeStorageComparer.Instance) { { "foo", "bar" } };

            // Act and Assert
            Assert.Equal(dictionary["foo"], "bar");
            Assert.Equal(dictionary["foo"], dictionary["FOo"]);
        }

        [Fact]
        public void ScopeStorageComparerPerformsRegularComparisonForOtherTypes()
        {
            // Arrange
            var stateStorage = new Dictionary<object, object> { { 4, "4-value" }, { new Person { ID = 10 }, "person-value" } };

            // Act and Assert
            Assert.Equal(stateStorage[4], "4-value");
            Assert.Equal(stateStorage[(int)8 / 2], stateStorage[4]);
            Assert.Equal(stateStorage[new Person { ID = 10 }], "person-value");
        }

        private class Person
        {
            public int ID { get; set; }

            public override bool Equals(object o)
            {
                var other = o as Person;
                return (other != null) && (other.ID == ID);
            }

            public override int GetHashCode()
            {
                return ID;
            }
        }
    }
}
