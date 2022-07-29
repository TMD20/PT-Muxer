﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http;
using System.Threading;

namespace System.Web.Http
{
    public static class ScenarioHelper
    {
        public static string BaseAddress = "http://localhost";
        public static void RunTest(string controllerName, string routeSuffix, HttpRequestMessage request,
            Action<HttpResponseMessage> assert, Action<HttpConfiguration> configurer = null)
        {
            // Arrange
            HttpConfiguration config = new HttpConfiguration();

            config.Routes.MapHttpRoute("Default", "{controller}" + routeSuffix, new { controller = controllerName });
            if (configurer != null)
            {
                configurer(config);
            }
            HttpServer server = new HttpServer(config);
            HttpMessageInvoker invoker = new HttpMessageInvoker(server);
            HttpResponseMessage response = null;
            try
            {
                // Act
                response = invoker.SendAsync(request, CancellationToken.None).Result;

                // Assert
                assert(response);
            }
            finally
            {
                request.Dispose();
                if (response != null)
                {
                    response.Dispose();
                }
            }
        }
    }
}
