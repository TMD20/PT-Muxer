﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Controllers;

namespace System.Web.Http.Routing
{
    /// <summary>
    /// <see cref="IHttpRoute"/> defines the interface for a route expressing how to map an incoming <see cref="HttpRequestMessage"/> to a particular controller
    /// and action.
    /// </summary>
    public interface IHttpRoute
    {
        /// <summary>
        /// Gets the route template describing the URI pattern to match against. 
        /// </summary>
        string RouteTemplate { get; }

        /// <summary>
        /// Gets the default values for route parameters if not provided by the incoming <see cref="HttpRequestMessage"/>.
        /// </summary>
        IDictionary<string, object> Defaults { get; }

        /// <summary>
        /// Gets the constraints for the route parameters.
        /// </summary>
        IDictionary<string, object> Constraints { get; }

        /// <summary>
        /// Gets any additional data tokens not used directly to determine whether a route matches an incoming <see cref="HttpRequestMessage"/>.
        /// </summary>
        IDictionary<string, object> DataTokens { get; }

        /// <summary>
        /// Determine whether this route is a match for the incoming request by looking up the <see cref="IHttpRouteData"/> for the route.
        /// </summary>
        /// <param name="virtualPathRoot">The virtual path root.</param>
        /// <param name="request">The request.</param>
        /// <returns>The <see cref="IHttpRouteData"/> for a route if matches; otherwise <c>null</c>.</returns>
        IHttpRouteData GetRouteData(string virtualPathRoot, HttpRequestMessage request);

        /// <summary>
        /// Compute a URI based on the route and the values provided.
        /// </summary>
        /// <param name="controllerContext">The controller context.</param>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        IHttpVirtualPathData GetVirtualPath(HttpControllerContext controllerContext, IDictionary<string, object> values);
    }
}
