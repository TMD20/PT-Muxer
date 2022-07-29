﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.WebPages
{
    // Attribute placed on a WebPage derived class that indicates the virtual path that it's associated with
    // This is used to support scenarios where pages are compiled ahead of time in external class libraries
    // Specifically, this is used by the RazorSingleFileGenerator.
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class PageVirtualPathAttribute : Attribute
    {
        public PageVirtualPathAttribute(string virtualPath)
        {
            VirtualPath = virtualPath;
        }

        public string VirtualPath { get; private set; }
    }
}
