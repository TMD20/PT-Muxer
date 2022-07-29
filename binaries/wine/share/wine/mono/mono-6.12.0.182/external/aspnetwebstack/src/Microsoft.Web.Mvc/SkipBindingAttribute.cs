﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Web.Mvc;

namespace Microsoft.Web.Mvc
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public sealed class SkipBindingAttribute : CustomModelBinderAttribute
    {
        private static readonly NullBinder _nullBinder = new NullBinder();

        public override IModelBinder GetBinder()
        {
            return _nullBinder;
        }

        private class NullBinder : IModelBinder
        {
            public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
            {
                return null;
            }
        }
    }
}
