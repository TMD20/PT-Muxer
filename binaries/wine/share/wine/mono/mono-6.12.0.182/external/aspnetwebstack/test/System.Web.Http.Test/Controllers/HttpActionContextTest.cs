﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Http.Controllers;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http
{
    public class HttpActionContextTest
    {
        [Fact]
        public void Default_Constructor()
        {
            HttpActionContext actionContext = new HttpActionContext();

            Assert.Null(actionContext.ControllerContext);
            Assert.Null(actionContext.ActionDescriptor);
            Assert.Null(actionContext.Response);
            Assert.Null(actionContext.Request);
            Assert.NotNull(actionContext.ActionArguments);
            Assert.NotNull(actionContext.ModelState);
        }

        [Fact]
        public void Parameter_Constructor()
        {
            HttpControllerContext controllerContext = ContextUtil.CreateControllerContext();
            HttpActionDescriptor actionDescriptor = new Mock<HttpActionDescriptor>().Object;
            HttpActionContext actionContext = new HttpActionContext(controllerContext, actionDescriptor);

            Assert.Same(controllerContext, actionContext.ControllerContext);
            Assert.Same(actionDescriptor, actionContext.ActionDescriptor);
            Assert.Same(controllerContext.Request, actionContext.Request);
            Assert.Null(actionContext.Response);
            Assert.NotNull(actionContext.ActionArguments);
            Assert.NotNull(actionContext.ModelState);
        }

        [Fact]
        public void Constructor_Throws_IfControllerContextIsNull()
        {
            Assert.ThrowsArgumentNull(
                () => new HttpActionContext(null, new Mock<HttpActionDescriptor>().Object),
                "controllerContext");
        }

        [Fact]
        public void Constructor_Throws_IfActionDescriptorIsNull()
        {
            Assert.ThrowsArgumentNull(
                () => new HttpActionContext(ContextUtil.CreateControllerContext(), null),
                "actionDescriptor");
        }

        [Fact]
        public void ControllerContext_Property()
        {
            Assert.Reflection.Property<HttpActionContext, HttpControllerContext>(
                instance: new HttpActionContext(),
                propertyGetter: ac => ac.ControllerContext,
                expectedDefaultValue: null,
                allowNull: false,
                roundTripTestValue: ContextUtil.CreateControllerContext());
        }

        [Fact]
        public void ActionDescriptor_Property()
        {
            Assert.Reflection.Property<HttpActionContext, HttpActionDescriptor>(
                instance: new HttpActionContext(),
                propertyGetter: ac => ac.ActionDescriptor,
                expectedDefaultValue: null,
                allowNull: false,
                roundTripTestValue: new Mock<HttpActionDescriptor>().Object);
        }
    }
}
