﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Mvc
{
    public class ByteArrayModelBinder : IModelBinder
    {
        public virtual object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException("bindingContext");
            }

            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            // case 1: there was no <input ... /> element containing this data
            if (valueResult == null)
            {
                return null;
            }

            string value = valueResult.AttemptedValue;

            // case 2: there was an <input ... /> element but it was left blank
            if (String.IsNullOrEmpty(value))
            {
                return null;
            }

            // Future proofing. If the byte array is actually an instance of System.Data.Linq.Binary
            // then we need to remove these quotes put in place by the ToString() method.
            string realValue = value.Replace("\"", String.Empty);
            return Convert.FromBase64String(realValue);
        }
    }
}
