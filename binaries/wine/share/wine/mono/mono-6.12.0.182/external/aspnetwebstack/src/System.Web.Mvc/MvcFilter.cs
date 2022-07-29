﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Mvc
{
    public abstract class MvcFilter : IMvcFilter
    {
        protected MvcFilter()
        {
        }

        protected MvcFilter(bool allowMultiple, int order)
        {
            AllowMultiple = allowMultiple;
            Order = order;
        }

        public bool AllowMultiple { get; private set; }

        public int Order { get; private set; }
    }
}
