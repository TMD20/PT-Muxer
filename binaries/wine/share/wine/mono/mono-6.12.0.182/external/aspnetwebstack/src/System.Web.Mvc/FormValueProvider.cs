﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Globalization;
using System.Web.Helpers;

namespace System.Web.Mvc
{
    public sealed class FormValueProvider : NameValueCollectionValueProvider
    {
        public FormValueProvider(ControllerContext controllerContext)
            : this(controllerContext, new UnvalidatedRequestValuesWrapper(controllerContext.HttpContext.Request.Unvalidated()))
        {
        }

        // For unit testing
        internal FormValueProvider(ControllerContext controllerContext, IUnvalidatedRequestValues unvalidatedValues)
            : base(controllerContext.HttpContext.Request.Form, unvalidatedValues.Form, CultureInfo.CurrentCulture)
        {
        }
    }
}
