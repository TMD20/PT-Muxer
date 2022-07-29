﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace System.Web.Mvc
{
    // The purpose of this interface is to make something as supporting client-side
    // validation, which could be discovered at runtime by whatever validation
    // framework you're using. Because this interface is designed to be independent
    // of underlying implementation details, where you apply this interface will
    // depend on your specific validation framework.
    //
    // For DataAnnotations, you'll apply this interface to your validation attribute
    // (the class which derives from ValidationAttribute). When you've implemented
    // this interface, it will alleviate the need of writing a validator and registering
    // it with the DataAnnotationsModelValidatorProvider.
    public interface IClientValidatable
    {
        IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context);
    }
}
