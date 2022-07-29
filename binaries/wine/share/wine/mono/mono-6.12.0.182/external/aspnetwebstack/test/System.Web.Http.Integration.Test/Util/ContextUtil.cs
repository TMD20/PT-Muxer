﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using Moq;

// TODO: move this class to TestCommon after it has been refactored
namespace System.Web.Http
{
    public static class ContextUtil
    {
        public static HttpControllerContext CreateControllerContext()
        {
            return CreateControllerContext(null, null, null);
        }

        public static HttpControllerContext CreateControllerContext(HttpConfiguration configuration)
        {
            return CreateControllerContext(configuration, null, null);
        }

        public static HttpControllerContext CreateControllerContext(HttpRequestMessage request)
        {
            return CreateControllerContext(null, null, request);
        }

        public static HttpControllerContext CreateControllerContext(HttpConfiguration configuration, IHttpRouteData routeData)
        {
            return CreateControllerContext(configuration, routeData, null);
        }

        public static HttpControllerContext CreateControllerContext(IHttpRouteData routeData, HttpRequestMessage request)
        {
            return CreateControllerContext(null, routeData, request);
        }

        public static HttpControllerContext CreateControllerContext(HttpConfiguration configuration, HttpRequestMessage request)
        {
            return CreateControllerContext(configuration, null, request);
        }

        public static HttpControllerContext CreateControllerContext(HttpConfiguration configuration, IHttpRouteData routeData, HttpRequestMessage request)
        {
            HttpConfiguration config = configuration ?? new HttpConfiguration();
            IHttpRouteData route = routeData ?? new HttpRouteData(new HttpRoute());
            HttpRequestMessage req = request ?? new HttpRequestMessage();
            req.Properties[HttpPropertyKeys.HttpConfigurationKey] = config;
            req.Properties[HttpPropertyKeys.HttpRouteDataKey] = route;
            return new HttpControllerContext(config, route, req);
        }

        public static HttpActionContext CreateActionContext(HttpControllerContext controllerContext = null, HttpActionDescriptor actionDescriptor = null)
        {
            HttpControllerContext context = controllerContext ?? ContextUtil.CreateControllerContext();
            HttpActionDescriptor descriptor = actionDescriptor ?? new Mock<HttpActionDescriptor>() { CallBase = true }.Object;

            if (descriptor.Configuration == null)
            {
                descriptor.Configuration = controllerContext.Configuration;
            }

            return new HttpActionContext(context, descriptor);
        }
    }
}
