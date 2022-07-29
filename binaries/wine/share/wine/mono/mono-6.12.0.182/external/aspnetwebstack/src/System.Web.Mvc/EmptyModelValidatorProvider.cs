﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;

namespace System.Web.Mvc
{
    public class EmptyModelValidatorProvider : ModelValidatorProvider
    {
        public override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context)
        {
            return Enumerable.Empty<ModelValidator>();
        }
    }
}
