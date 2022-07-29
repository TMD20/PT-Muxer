﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace System.Web.Mvc
{
    public class StringLengthAttributeAdapter : DataAnnotationsModelValidator<StringLengthAttribute>
    {
        public StringLengthAttributeAdapter(ModelMetadata metadata, ControllerContext context, StringLengthAttribute attribute)
            : base(metadata, context, attribute)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            return new[] { new ModelClientValidationStringLengthRule(ErrorMessage, Attribute.MinimumLength, Attribute.MaximumLength) };
        }
    }
}
