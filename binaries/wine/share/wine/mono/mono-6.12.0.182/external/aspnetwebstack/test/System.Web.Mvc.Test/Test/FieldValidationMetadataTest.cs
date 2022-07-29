﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.TestUtil;
using Xunit;

namespace System.Web.Mvc.Test
{
    public class FieldValidationMetadataTest
    {
        [Fact]
        public void FieldNameProperty()
        {
            // Arrange
            FieldValidationMetadata metadata = new FieldValidationMetadata();

            // Act & assert
            MemberHelper.TestStringProperty(metadata, "FieldName", String.Empty);
        }

        [Fact]
        public void ValidationRulesProperty()
        {
            // Arrange
            FieldValidationMetadata metadata = new FieldValidationMetadata();

            // Act
            ICollection<ModelClientValidationRule> validationRules = metadata.ValidationRules;

            // Assert
            Assert.NotNull(validationRules);
            Assert.Empty(validationRules);
        }
    }
}
