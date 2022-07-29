﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using System.Web.Http.Metadata.Providers;
using System.Web.Http.ModelBinding;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.Tracing.Tracers
{
    public class FormatterParameterBindingTracerTest
    {

        /// <summary>
        /// This test verifies that our <see cref="FormatterParameterBindingTracer"/>
        /// intercepts the async bind request and redirects it to use tracing formatters
        /// correlated to the request.
        /// </summary>
        [Fact]
        public void ExecuteBindingAsync_Traces_And_Invokes_Inner_ReadAsync()
        {
            // Arrange
            Mock<HttpParameterDescriptor> mockParamDescriptor = new Mock<HttpParameterDescriptor>() { CallBase = true };
            mockParamDescriptor.Setup(d => d.ParameterName).Returns("paramName");
            mockParamDescriptor.Setup(d => d.ParameterType).Returns(typeof (string));
            FormatterParameterBinding binding = new FormatterParameterBinding(mockParamDescriptor.Object, new MediaTypeFormatterCollection(), null);
            TestTraceWriter traceWriter = new TestTraceWriter();
            FormatterParameterBindingTracer tracer = new FormatterParameterBindingTracer(binding, traceWriter);
            HttpActionContext actionContext = ContextUtil.CreateActionContext();
            actionContext.Request.Content = new StringContent("true");
            actionContext.Request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            ModelMetadataProvider metadataProvider = new EmptyModelMetadataProvider();

            TraceRecord[] expectedTraces = new TraceRecord[]
            {
                new TraceRecord(actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Info) { Kind = TraceKind.Begin, Operation = "ExecuteBindingAsync" },
                new TraceRecord(actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Info) { Kind = TraceKind.End, Operation = "ExecuteBindingAsync" }
            };

            // Act
            Task task = tracer.ExecuteBindingAsync(metadataProvider, actionContext, CancellationToken.None);
            task.Wait();

            // Assert
            Assert.Equal<TraceRecord>(expectedTraces, traceWriter.Traces, new TraceRecordComparer());
            Assert.Equal("True", actionContext.ActionArguments["paramName"]);
        }

        [Fact]
        public void ExecuteBindingAsync_Traces_And_Throws_When_Inner_Throws()
        {
            // Arrange
            Mock<HttpParameterDescriptor> mockParamDescriptor = new Mock<HttpParameterDescriptor>() { CallBase = true };
            mockParamDescriptor.Setup(d => d.ParameterName).Returns("paramName");
            mockParamDescriptor.Setup(d => d.ParameterType).Returns(typeof(string));
            Mock<FormatterParameterBinding> mockBinding = new Mock<FormatterParameterBinding>(mockParamDescriptor.Object, new MediaTypeFormatterCollection(), null) { CallBase = true };
            InvalidOperationException exception = new InvalidOperationException("test");
            mockBinding.Setup(
                b =>
                b.ExecuteBindingAsync(It.IsAny<ModelMetadataProvider>(), It.IsAny<HttpActionContext>(),
                                      It.IsAny<CancellationToken>())).Throws(exception);

            TestTraceWriter traceWriter = new TestTraceWriter();
            FormatterParameterBindingTracer tracer = new FormatterParameterBindingTracer(mockBinding.Object, traceWriter);
            HttpActionContext actionContext = ContextUtil.CreateActionContext();
            ModelMetadataProvider metadataProvider = new EmptyModelMetadataProvider();

            TraceRecord[] expectedTraces = new TraceRecord[]
            {
                new TraceRecord(actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Info) { Kind = TraceKind.Begin, Operation = "ExecuteBindingAsync" },
                new TraceRecord(actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Error) { Kind = TraceKind.End, Operation = "ExecuteBindingAsync" }
            };

            // Act & Assert
            Exception thrown = Assert.Throws<InvalidOperationException>(() => tracer.ExecuteBindingAsync(metadataProvider, actionContext, CancellationToken.None));

            // Assert
            Assert.Same(exception, thrown);
            Assert.Same(exception, traceWriter.Traces[1].Exception);
            Assert.Equal<TraceRecord>(expectedTraces, traceWriter.Traces, new TraceRecordComparer());
        }

        [Fact]
        public void ExecuteBindingAsync_Traces_And_Faults_When_Inner_Faults()
        {
            // Arrange

            Mock<HttpParameterDescriptor> mockParamDescriptor = new Mock<HttpParameterDescriptor>() { CallBase = true };
            mockParamDescriptor.Setup(d => d.ParameterName).Returns("paramName");
            mockParamDescriptor.Setup(d => d.ParameterType).Returns(typeof(string));
            Mock<FormatterParameterBinding> mockBinding = new Mock<FormatterParameterBinding>(mockParamDescriptor.Object, new MediaTypeFormatterCollection(), null) { CallBase = true };
            InvalidOperationException exception = new InvalidOperationException("test");
            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            tcs.TrySetException(exception);

            mockBinding.Setup(
                b =>
                b.ExecuteBindingAsync(It.IsAny<ModelMetadataProvider>(), It.IsAny<HttpActionContext>(),
                                      It.IsAny<CancellationToken>())).Returns(tcs.Task);

            TestTraceWriter traceWriter = new TestTraceWriter();
            FormatterParameterBindingTracer tracer = new FormatterParameterBindingTracer(mockBinding.Object, traceWriter);
            HttpActionContext actionContext = ContextUtil.CreateActionContext();
            ModelMetadataProvider metadataProvider = new EmptyModelMetadataProvider();

            TraceRecord[] expectedTraces = new TraceRecord[]
            {
                new TraceRecord(actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Info) { Kind = TraceKind.Begin, Operation = "ExecuteBindingAsync" },
                new TraceRecord(actionContext.Request, TraceCategories.ModelBindingCategory, TraceLevel.Error) { Kind = TraceKind.End, Operation = "ExecuteBindingAsync" }
            };

            // Act & Assert
            Task task = tracer.ExecuteBindingAsync(metadataProvider, actionContext, CancellationToken.None);

            // Assert
            Exception thrown = Assert.Throws<InvalidOperationException>(() => task.Wait());
            Assert.Same(exception, thrown);
            Assert.Same(exception, traceWriter.Traces[1].Exception);
            Assert.Equal<TraceRecord>(expectedTraces, traceWriter.Traces, new TraceRecordComparer());
        }

    }
}
