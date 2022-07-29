﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO;
using System.Web.Routing;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Test
{
    public class PartialViewResultTest
    {
        private const string _viewName = "My cool partial view.";

        [Fact]
        public void EmptyViewNameUsesActionNameAsViewName()
        {
            // Arrange
            ControllerBase controller = new Mock<ControllerBase>().Object;
            HttpContextBase httpContext = CreateHttpContext();
            RouteData routeData = new RouteData();
            routeData.Values["action"] = _viewName;
            ControllerContext context = new ControllerContext(httpContext, routeData, controller);
            Mock<IViewEngine> viewEngine = new Mock<IViewEngine>(MockBehavior.Strict);
            Mock<IView> view = new Mock<IView>(MockBehavior.Strict);
            List<IViewEngine> viewEngines = new List<IViewEngine>();
            viewEngines.Add(viewEngine.Object);
            Mock<ViewEngineCollection> viewEngineCollection = new Mock<ViewEngineCollection>(MockBehavior.Strict, viewEngines);
            PartialViewResult result = new PartialViewResultHelper { ViewEngineCollection = viewEngineCollection.Object };
            viewEngine
                .Setup(e => e.FindPartialView(It.IsAny<ControllerContext>(), _viewName, It.IsAny<bool>()))
                .Callback<ControllerContext, string, bool>(
                    (controllerContext, viewName, useCache) =>
                    {
                        Assert.Same(httpContext, controllerContext.HttpContext);
                        Assert.Same(routeData, controllerContext.RouteData);
                    })
                .Returns(new ViewEngineResult(view.Object, viewEngine.Object));
            viewEngineCollection
                .Setup(e => e.FindPartialView(It.IsAny<ControllerContext>(), _viewName))
                .Returns(new ViewEngineResult(view.Object, viewEngine.Object));
            view
                .Setup(o => o.Render(It.IsAny<ViewContext>(), httpContext.Response.Output))
                .Callback<ViewContext, TextWriter>(
                    (viewContext, writer) =>
                    {
                        Assert.Same(view.Object, viewContext.View);
                        Assert.Same(result.ViewData, viewContext.ViewData);
                        Assert.Same(result.TempData, viewContext.TempData);
                        Assert.Same(controller, viewContext.Controller);
                    });
            viewEngine
                .Setup(e => e.ReleaseView(context, It.IsAny<IView>()))
                .Callback<ControllerContext, IView>(
                    (controllerContext, releasedView) => { Assert.Same(releasedView, view.Object); });

            // Act
            result.ExecuteResult(context);

            // Assert
            viewEngine.Verify();
            viewEngineCollection.Verify();
            view.Verify();
        }

        [Fact]
        public void EngineLookupFailureThrows()
        {
            // Arrange
            ControllerBase controller = new Mock<ControllerBase>().Object;
            HttpContextBase httpContext = CreateHttpContext();
            RouteData routeData = new RouteData();
            routeData.Values["action"] = _viewName;
            ControllerContext context = new ControllerContext(httpContext, routeData, controller);
            Mock<IViewEngine> viewEngine = new Mock<IViewEngine>(MockBehavior.Strict);
            List<IViewEngine> viewEngines = new List<IViewEngine>();
            viewEngines.Add(viewEngine.Object);
            Mock<ViewEngineCollection> viewEngineCollection = new Mock<ViewEngineCollection>(MockBehavior.Strict, viewEngines);
            PartialViewResult result = new PartialViewResultHelper { ViewEngineCollection = viewEngineCollection.Object };
            viewEngineCollection
                .Setup(e => e.FindPartialView(It.IsAny<ControllerContext>(), _viewName))
                .Returns(new ViewEngineResult(new[] { "location1", "location2" }));
            viewEngine
                .Setup(e => e.FindPartialView(It.IsAny<ControllerContext>(), _viewName, It.IsAny<bool>()))
                .Callback<ControllerContext, string, bool>(
                    (controllerContext, viewName, useCache) =>
                    {
                        Assert.Same(httpContext, controllerContext.HttpContext);
                        Assert.Same(routeData, controllerContext.RouteData);
                    })
                .Returns(new ViewEngineResult(new[] { "location1", "location2" }));

            // Act & Assert
            Assert.Throws<InvalidOperationException>(
                () => result.ExecuteResult(context),
                @"The partial view '" + _viewName + @"' was not found or no view engine supports the searched locations. The following locations were searched:
location1
location2");

            viewEngine.Verify();
            viewEngineCollection.Verify();
        }

        [Fact]
        public void EngineLookupSuccessRendersView()
        {
            // Arrange
            ControllerBase controller = new Mock<ControllerBase>().Object;
            HttpContextBase httpContext = CreateHttpContext();
            RouteData routeData = new RouteData();
            ControllerContext context = new ControllerContext(httpContext, routeData, controller);
            Mock<IViewEngine> viewEngine = new Mock<IViewEngine>(MockBehavior.Strict);
            List<IViewEngine> viewEngines = new List<IViewEngine>();
            viewEngines.Add(viewEngine.Object);
            Mock<ViewEngineCollection> viewEngineCollection = new Mock<ViewEngineCollection>(MockBehavior.Strict, viewEngines);
            Mock<IView> view = new Mock<IView>(MockBehavior.Strict);
            PartialViewResult result = new PartialViewResultHelper { ViewEngineCollection = viewEngineCollection.Object, ViewName = _viewName };
            view
                .Setup(o => o.Render(It.IsAny<ViewContext>(), httpContext.Response.Output))
                .Callback<ViewContext, TextWriter>(
                    (viewContext, writer) =>
                    {
                        Assert.Same(view.Object, viewContext.View);
                        Assert.Same(result.ViewData, viewContext.ViewData);
                        Assert.Same(result.TempData, viewContext.TempData);
                        Assert.Same(controller, viewContext.Controller);
                    });
            viewEngineCollection
                .Setup(e => e.FindPartialView(It.IsAny<ControllerContext>(), _viewName))
                .Returns(new ViewEngineResult(view.Object, viewEngine.Object));
            viewEngine
                .Setup(e => e.FindPartialView(It.IsAny<ControllerContext>(), _viewName, It.IsAny<bool>()))
                .Callback<ControllerContext, string, bool>(
                    (controllerContext, viewName, useCache) =>
                    {
                        Assert.Same(httpContext, controllerContext.HttpContext);
                        Assert.Same(routeData, controllerContext.RouteData);
                    })
                .Returns(new ViewEngineResult(view.Object, viewEngine.Object));
            viewEngine
                .Setup(e => e.ReleaseView(context, It.IsAny<IView>()))
                .Callback<ControllerContext, IView>(
                    (controllerContext, releasedView) => { Assert.Same(releasedView, view.Object); });

            // Act
            result.ExecuteResult(context);

            // Assert
            viewEngineCollection.Verify();
            viewEngine.Verify();
            view.Verify();
        }

        [Fact]
        public void ExecuteResultWithExplicitViewObject()
        {
            // Arrange
            ControllerBase controller = new Mock<ControllerBase>().Object;
            HttpContextBase httpContext = CreateHttpContext();
            RouteData routeData = new RouteData();
            routeData.Values["action"] = _viewName;
            ControllerContext context = new ControllerContext(httpContext, routeData, controller);
            Mock<IView> view = new Mock<IView>(MockBehavior.Strict);
            PartialViewResult result = new PartialViewResultHelper { View = view.Object };
            view
                .Setup(o => o.Render(It.IsAny<ViewContext>(), httpContext.Response.Output))
                .Callback<ViewContext, TextWriter>(
                    (viewContext, writer) =>
                    {
                        Assert.Same(view.Object, viewContext.View);
                        Assert.Same(result.ViewData, viewContext.ViewData);
                        Assert.Same(result.TempData, viewContext.TempData);
                        Assert.Same(controller, viewContext.Controller);
                    });

            // Act
            result.ExecuteResult(context);

            // Assert
            view.Verify();
        }

        private static HttpContextBase CreateHttpContext()
        {
            Mock<HttpContextBase> mockHttpContext = new Mock<HttpContextBase>();
            mockHttpContext.Setup(c => c.Response.Output).Returns(TextWriter.Null);
            return mockHttpContext.Object;
        }

        private class PartialViewResultHelper : PartialViewResult
        {
            public PartialViewResultHelper()
            {
                ViewEngineCollection = new ViewEngineCollection(new IViewEngine[] { new WebFormViewEngine() });
            }
        }
    }
}
