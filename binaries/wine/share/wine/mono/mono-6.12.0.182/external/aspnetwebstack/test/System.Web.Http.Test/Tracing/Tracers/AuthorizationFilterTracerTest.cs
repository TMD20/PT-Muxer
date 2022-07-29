﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.Tracing.Tracers
{
    public class AuthorizationFilterTracerTest
    {
        [Fact]
        public void ExecuteAuthorizationFilterAsync_Traces()
        {
            // Arrange
            HttpResponseMessage response = new HttpResponseMessage();
            Mock<IAuthorizationFilter> mockFilter = new Mock<IAuthorizationFilter>() { CallBase = true };
            mockFilter.Setup(f => f.ExecuteAuthorizationFilterAsync(It.IsAny<HttpActionContext>(), It.IsAny<CancellationToken>(), It.IsAny<Func<Task<HttpResponseMessage>>>())).Returns(TaskHelpers.FromResult(response));
            Mock<HttpActionDescriptor> mockActionDescriptor = new Mock<HttpActionDescriptor>() { CallBase = true };
            mockActionDescriptor.Setup(a => a.ActionName).Returns("test");
            mockActionDescriptor.Setup(a => a.GetParameters()).Returns(new Collection<HttpParameterDescriptor>(new HttpParameterDescriptor[0]));
            HttpActionContext actionContext = ContextUtil.CreateActionContext(actionDescriptor: mockActionDescriptor.Object);
            Func<Task<HttpResponseMessage>> continuation = () => TaskHelpers.FromResult<HttpResponseMessage>(new HttpResponseMessage());
            TestTraceWriter traceWriter = new TestTraceWriter();
            AuthorizationFilterTracer tracer = new AuthorizationFilterTracer(mockFilter.Object, traceWriter);
            TraceRecord[] expectedTraces = new TraceRecord[]
            {
                new TraceRecord(actionContext.Request, TraceCategories.FiltersCategory, TraceLevel.Info) { Kind = TraceKind.Begin, Operation = "ExecuteAuthorizationFilterAsync" },
                new TraceRecord(actionContext.Request, TraceCategories.FiltersCategory, TraceLevel.Info) { Kind = TraceKind.End,  Operation = "ExecuteAuthorizationFilterAsync" },
            };

            // Act
            Task task = ((IAuthorizationFilter)tracer).ExecuteAuthorizationFilterAsync(actionContext, CancellationToken.None, continuation);
            task.Wait();

            // Assert
            Assert.Equal<TraceRecord>(expectedTraces, traceWriter.Traces, new TraceRecordComparer());
        }

        [Fact]
        public void ExecuteAuthorizationFilterAsync_Faults_And_Traces_When_Inner_Faults()
        {
            // Arrange
            Mock<IAuthorizationFilter> mockAttr = new Mock<IAuthorizationFilter>() { CallBase = true };
            HttpResponseMessage response = new HttpResponseMessage();
            InvalidOperationException exception = new InvalidOperationException("test");
            TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>(response);
            tcs.TrySetException(exception);
            mockAttr.Setup(a => a.ExecuteAuthorizationFilterAsync(It.IsAny<HttpActionContext>(), It.IsAny<CancellationToken>(), It.IsAny<Func<Task<HttpResponseMessage>>>())).Returns(tcs.Task);
            Mock<HttpActionDescriptor> mockActionDescriptor = new Mock<HttpActionDescriptor>() { CallBase = true };
            mockActionDescriptor.Setup(a => a.ActionName).Returns("test");
            mockActionDescriptor.Setup(a => a.GetParameters()).Returns(new Collection<HttpParameterDescriptor>(new HttpParameterDescriptor[0]));
            HttpActionContext actionContext = ContextUtil.CreateActionContext(actionDescriptor: mockActionDescriptor.Object);
            Func<Task<HttpResponseMessage>> continuation = () => TaskHelpers.FromResult<HttpResponseMessage>(response);
            TestTraceWriter traceWriter = new TestTraceWriter();
            AuthorizationFilterTracer tracer = new AuthorizationFilterTracer(mockAttr.Object, traceWriter);
            TraceRecord[] expectedTraces = new TraceRecord[]
            {
                new TraceRecord(actionContext.Request, TraceCategories.FiltersCategory, TraceLevel.Info) { Kind = TraceKind.Begin, Operation = "ExecuteAuthorizationFilterAsync" },
                new TraceRecord(actionContext.Request, TraceCategories.FiltersCategory, TraceLevel.Error) { Kind = TraceKind.End,  Operation = "ExecuteAuthorizationFilterAsync" }
            };

            // Act & Assert
            Task task = ((IAuthorizationFilter)tracer).ExecuteAuthorizationFilterAsync(actionContext, CancellationToken.None, continuation);
            Exception thrown = Assert.Throws<InvalidOperationException>(() => task.Wait());

            // Assert
            Assert.Same(exception, thrown);
            Assert.Same(exception, traceWriter.Traces[1].Exception);
            Assert.Equal<TraceRecord>(expectedTraces, traceWriter.Traces, new TraceRecordComparer());
        }
    }
}
