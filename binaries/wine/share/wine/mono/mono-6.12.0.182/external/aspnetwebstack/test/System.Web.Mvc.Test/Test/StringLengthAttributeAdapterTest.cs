﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;

namespace System.Web.Mvc.Test
{
    public class StringLengthAttributeAdapterTest
    {
        [Fact]
        public void ClientRulesWithStringLengthAttribute()
        {
            // Arrange
            var metadata = ModelMetadataProviders.Current.GetMetadataForProperty(() => null, typeof(string), "Length");
            var context = new ControllerContext();
            var attribute = new StringLengthAttribute(10) { MinimumLength = 3 };
            var adapter = new StringLengthAttributeAdapter(metadata, context, attribute);

            // Act
            var rules = adapter.GetClientValidationRules()
                .OrderBy(r => r.ValidationType)
                .ToArray();

            // Assert
            ModelClientValidationRule rule = Assert.Single(rules);
            Assert.Equal("length", rule.ValidationType);
            Assert.Equal(2, rule.ValidationParameters.Count);
            Assert.Equal(3, rule.ValidationParameters["min"]);
            Assert.Equal(10, rule.ValidationParameters["max"]);
            Assert.Equal("The field Length must be a string with a minimum length of 3 and a maximum length of 10.", rule.ErrorMessage);
        }
    }
}
