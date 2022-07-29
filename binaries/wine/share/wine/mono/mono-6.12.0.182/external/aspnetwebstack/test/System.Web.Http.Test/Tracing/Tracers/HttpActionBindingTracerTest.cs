﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.Tracing.Tracers
{
    public class HttpActionBindingTracerTest
    {
        private Mock<HttpActionDescriptor> _mockActionDescriptor;
        private Mock<HttpParameterDescriptor> _mockParameterDescriptor;
        private Mock<HttpParameterBinding> _mockParameterBinding;
        private HttpActionBinding _actionBinding;
        private HttpActionContext _actionContext;
        private HttpControllerContext _controllerContext;
        private HttpControllerDescriptor _controllerDescriptor;

        public HttpActionBindingTracerTest()
        {
            _mockActionDescriptor = new Mock<HttpActionDescriptor>() { CallBase = true };
            _mockActionDescriptor.Setup(a => a.ActionName).Returns("test");
            _mockActionDescriptor.Setup(a => a.GetParameters()).Returns(new Collection<HttpParameterDescriptor>(new HttpParameterDescriptor[0]));

            _mockParameterDescriptor = new Mock<HttpParameterDescriptor>() { CallBase = true };
            _mockParameterBinding = new Mock<HttpParameterBinding>(_mockParameterDescriptor.Object) { CallBase = true };
            _actionBinding = new HttpActionBinding(_mockActionDescriptor.Object, new HttpParameterBinding[] { _mockParameterBinding.Object });

            _controllerDescriptor = new HttpControllerDescriptor(new HttpConfiguration(), "controller", typeof(ApiController));

            _controllerContext = ContextUtil.CreateControllerContext(request: new HttpRequestMessage());
            _controllerContext.ControllerDescriptor = _controllerDescriptor;

            _actionContext = ContextUtil.CreateActionContext(_controllerContext, actionDescriptor: _mockActionDescriptor.Object);

        }

        [Fact]
        public void BindValuesAsync_Invokes_Inner_And_Traces()
        {
            // Arrange
            bool wasInvoked = false;
            Mock<HttpActionBinding> mockBinder = new Mock<HttpActionBinding>() { CallBase = true };
            mockBinder.Setup(b => b.ExecuteBindingAsync(
                It.IsAny<HttpActionContext>(),
                It.IsAny<CancellationToken>())).
                    Callback(() => wasInvoked = true).Returns(TaskHelpers.Completed());

            TestTraceWriter traceWriter = new TestTraceWriter();
            HttpActionBindingTracer tracer = new HttpActionBindingTracer(mockBinder.Object, traceWriter);

            TraceRecord[] expectedTraces = new TraceRecord[]
            {
                new TraceRecord(_actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Info) { Kind = TraceKind.Begin },
                new TraceRecord(_actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Info) { Kind = TraceKind.End }
            };

            // Act
            tracer.ExecuteBindingAsync(_actionContext, CancellationToken.None).Wait();

            // Assert
            Assert.Equal<TraceRecord>(expectedTraces, traceWriter.Traces, new TraceRecordComparer());
            Assert.True(wasInvoked);
        }

        [Fact]
        public void ExecuteBindingAsync_Faults_And_Traces_When_Inner_Faults()
        {
            // Arrange
            InvalidOperationException exception = new InvalidOperationException();
            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            tcs.TrySetException(exception);
            Mock<HttpActionBinding> mockBinder = new Mock<HttpActionBinding>() { CallBase = true };
            mockBinder.Setup(b => b.ExecuteBindingAsync(
                 It.IsAny<HttpActionContext>(),
                 It.IsAny<CancellationToken>())).
                    Returns(tcs.Task);

            TestTraceWriter traceWriter = new TestTraceWriter();
            HttpActionBindingTracer tracer = new HttpActionBindingTracer(mockBinder.Object, traceWriter);

            TraceRecord[] expectedTraces = new TraceRecord[]
            {
                new TraceRecord(_actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Info) { Kind = TraceKind.Begin },
                new TraceRecord(_actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Error) { Kind = TraceKind.End }
            };

            // Act
            Task task = tracer.ExecuteBindingAsync(_actionContext, CancellationToken.None);

            // Assert
            Exception thrown = Assert.Throws<InvalidOperationException>(() => task.Wait());
            Assert.Equal<TraceRecord>(expectedTraces, traceWriter.Traces, new TraceRecordComparer());
            Assert.Same(exception, thrown);
            Assert.Same(exception, traceWriter.Traces[1].Exception);
        }
    }
}
