﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Web.Mvc.ModelBinding
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class ModelBinderProviderOptionsAttribute : Attribute
    {
        // Specifies that a provider should appear at the front of the list, e.g. other providers should
        // not be auto-registered at the front unless explicitly requested.
        public bool FrontOfList { get; set; }
    }
}
