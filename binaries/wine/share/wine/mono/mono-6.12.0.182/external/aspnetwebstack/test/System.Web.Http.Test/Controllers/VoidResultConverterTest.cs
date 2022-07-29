﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net;
using System.Net.Http;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.Controllers
{
    public class VoidResultConverterTest
    {
        private readonly VoidResultConverter _converter = new VoidResultConverter();
        private readonly HttpControllerContext _context = new HttpControllerContext();
        private readonly HttpRequestMessage _request = new HttpRequestMessage();

        public VoidResultConverterTest()
        {
            _context.Request = _request;
            _context.Configuration = new HttpConfiguration();
        }

        [Fact]
        public void Convert_WhenContextIsNull_Throws()
        {
            Assert.ThrowsArgumentNull(() => _converter.Convert(controllerContext: null, actionResult: null), "controllerContext");
        }

        [Fact]
        public void Convert_ReturnsResponseMessageWithRequestAssigned()
        {
            var result = _converter.Convert(_context, null);

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.Null(result.Content);
            Assert.Same(_request, result.RequestMessage);
        }
    }
}
