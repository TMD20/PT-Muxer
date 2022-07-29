﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.TestCommon;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Net.Http
{
    public class HttpMessageContentTests
    {
        private static readonly int iterations = 5;

        private static void AddMessageHeaders(HttpHeaders headers)
        {
            headers.Add("N1", new string[] { "V1a", "V1b", "V1c", "V1d", "V1e" });
            headers.Add("N2", "V2");
        }

        private static HttpRequestMessage CreateRequest(Uri requestUri, bool containsEntity)
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod(ParserData.HttpMethod);
            httpRequest.RequestUri = requestUri;
            httpRequest.Version = new Version("1.2");
            AddMessageHeaders(httpRequest.Headers);
            if (containsEntity)
            {
                httpRequest.Content = new StringContent(ParserData.HttpMessageEntity);
            }

            return httpRequest;
        }

        private static HttpResponseMessage CreateResponse(bool containsEntity)
        {
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            httpResponse.StatusCode = ParserData.HttpStatus;
            httpResponse.ReasonPhrase = ParserData.HttpReasonPhrase;
            httpResponse.Version = new Version("1.2");
            AddMessageHeaders(httpResponse.Headers);
            if (containsEntity)
            {
                httpResponse.Content = new StringContent(ParserData.HttpMessageEntity);
            }

            return httpResponse;
        }

        private static string ReadContentAsync(HttpContent content)
        {
            Task task = content.LoadIntoBufferAsync();
            task.Wait(TimeoutConstant.DefaultTimeout);
            Assert.Equal(TaskStatus.RanToCompletion, task.Status);
            return content.ReadAsStringAsync().Result;
        }

        private static void ValidateRequest(HttpContent content, bool containsEntity)
        {
            Assert.Equal(ParserData.HttpRequestMediaType, content.Headers.ContentType);
            long? length = content.Headers.ContentLength;
            Assert.NotNull(length);

            string message = ReadContentAsync(content);

            if (containsEntity)
            {
                Assert.Equal(ParserData.HttpRequestWithEntity.Length, length);
                Assert.Equal(ParserData.HttpRequestWithEntity, message);
            }
            else
            {
                Assert.Equal(ParserData.HttpRequest.Length, length);
                Assert.Equal(ParserData.HttpRequest, message);
            }
        }

        private static void ValidateResponse(HttpContent content, bool containsEntity)
        {
            Assert.Equal(ParserData.HttpResponseMediaType, content.Headers.ContentType);
            long? length = content.Headers.ContentLength;
            Assert.NotNull(length);

            string message = ReadContentAsync(content);

            if (containsEntity)
            {
                Assert.Equal(ParserData.HttpResponseWithEntity.Length, length);
                Assert.Equal(ParserData.HttpResponseWithEntity, message);
            }
            else
            {
                Assert.Equal(ParserData.HttpResponse.Length, length);
                Assert.Equal(ParserData.HttpResponse, message);
            }
        }

        [Fact]
        public void TypeIsCorrect()
        {
            Assert.Type.HasProperties<HttpMessageContent, HttpContent>(TypeAssert.TypeProperties.IsPublicVisibleClass | TypeAssert.TypeProperties.IsDisposable);
        }

        [Fact]
        public void RequestConstructor()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            HttpMessageContent instance = new HttpMessageContent(request);
            Assert.NotNull(instance);
            Assert.Same(request, instance.HttpRequestMessage);
            Assert.Null(instance.HttpResponseMessage);
        }

        [Fact]
        public void RequestConstructorThrowsOnNull()
        {
            Assert.ThrowsArgumentNull(() => { new HttpMessageContent((HttpRequestMessage)null); }, "httpRequest");
        }

        [Fact]
        public void ResponseConstructor()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            HttpMessageContent instance = new HttpMessageContent(response);
            Assert.NotNull(instance);
            Assert.Same(response, instance.HttpResponseMessage);
            Assert.Null(instance.HttpRequestMessage);
        }

        [Fact]
        public void ResponseConstructorThrowsOnNull()
        {
            Assert.ThrowsArgumentNull(() => { new HttpMessageContent((HttpResponseMessage)null); }, "httpResponse");
        }


        [Fact]
        public void SerializeRequest()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, false);
                HttpMessageContent instance = new HttpMessageContent(request);
                ValidateRequest(instance, false);
            }
        }

        [Fact]
        public void SerializeRequestWithExistingHostHeader()
        {
            HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, false);
            string host = ParserData.HttpHostName;
            request.Headers.Host = host;
            HttpMessageContent instance = new HttpMessageContent(request);
            string message = ReadContentAsync(instance);
            Assert.Equal(ParserData.HttpRequestWithHost, message);
        }

        [Fact]
        public void SerializeRequestMultipleTimes()
        {
            HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, false);
            HttpMessageContent instance = new HttpMessageContent(request);
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                ValidateRequest(instance, false);
            }
        }

        [Fact]
        public void SerializeResponse()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpResponseMessage response = CreateResponse(false);
                HttpMessageContent instance = new HttpMessageContent(response);
                ValidateResponse(instance, false);
            }
        }

        [Fact]
        public void SerializeResponseMultipleTimes()
        {
            HttpResponseMessage response = CreateResponse(false);
            HttpMessageContent instance = new HttpMessageContent(response);
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                ValidateResponse(instance, false);
            }
        }

        [Fact]
        public void SerializeRequestWithEntity()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, true);
                HttpMessageContent instance = new HttpMessageContent(request);
                ValidateRequest(instance, true);
            }
        }

        [Fact]
        public void SerializeRequestWithEntityMultipleTimes()
        {
            HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, true);
            HttpMessageContent instance = new HttpMessageContent(request);
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                ValidateRequest(instance, true);
            }
        }

        [Fact]
        public void SerializeResponseWithEntity()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpResponseMessage response = CreateResponse(true);
                HttpMessageContent instance = new HttpMessageContent(response);
                ValidateResponse(instance, true);
            }
        }

        [Fact]
        public void SerializeResponseWithEntityMultipleTimes()
        {
            HttpResponseMessage response = CreateResponse(true);
            HttpMessageContent instance = new HttpMessageContent(response);
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                ValidateResponse(instance, true);
            }
        }

        [Fact]
        public void SerializeRequestAsync()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, false);
                HttpMessageContent instance = new HttpMessageContent(request);
                ValidateRequest(instance, false);
            }
        }

        [Fact]
        public void SerializeResponseAsync()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpResponseMessage response = CreateResponse(false);
                HttpMessageContent instance = new HttpMessageContent(response);
                ValidateResponse(instance, false);
            }
        }

        [Fact]
        public void SerializeRequestWithPortAndQueryAsync()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUriWithPortAndQuery, false);
                HttpMessageContent instance = new HttpMessageContent(request);
                string message = ReadContentAsync(instance);
                Assert.Equal(ParserData.HttpRequestWithPortAndQuery, message);
            }
        }

        [Fact]
        public void SerializeRequestWithEntityAsync()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, true);
                HttpMessageContent instance = new HttpMessageContent(request);
                ValidateRequest(instance, true);
            }
        }

        [Fact]
        public void SerializeResponseWithEntityAsync()
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                HttpResponseMessage response = CreateResponse(true);
                HttpMessageContent instance = new HttpMessageContent(response);
                ValidateResponse(instance, true);
            }
        }

        [Fact]
        public void DisposeInnerHttpRequestMessage()
        {
            HttpRequestMessage request = CreateRequest(ParserData.HttpRequestUri, false);
            HttpMessageContent instance = new HttpMessageContent(request);
            instance.Dispose();
            Assert.ThrowsObjectDisposed(() => { request.Method = HttpMethod.Get; }, typeof(HttpRequestMessage).FullName);
        }

        [Fact]
        public void DisposeInnerHttpResponseMessage()
        {
            HttpResponseMessage response = CreateResponse(false);
            HttpMessageContent instance = new HttpMessageContent(response);
            instance.Dispose();
            Assert.ThrowsObjectDisposed(() => { response.StatusCode = HttpStatusCode.OK; }, typeof(HttpResponseMessage).FullName);
        }
    }
}
