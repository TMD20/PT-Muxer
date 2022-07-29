﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http;
using System.Web.Http.Controllers;

namespace System.Web.Http.Dispatcher
{
    /// <summary>
    /// Defines the methods that are required for an <see cref="IHttpControllerActivator"/>.
    /// </summary>
    public interface IHttpControllerActivator
    {
        IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType);
    }
}
