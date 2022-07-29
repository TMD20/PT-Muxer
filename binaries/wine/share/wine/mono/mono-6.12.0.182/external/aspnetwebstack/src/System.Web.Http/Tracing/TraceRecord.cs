﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace System.Web.Http.Tracing
{
    /// <summary>
    /// Data object used by <see cref="ITraceWriter"/> to record traces.
    /// </summary>
    public class TraceRecord
    {
        private Lazy<Dictionary<object, object>> _properties = new Lazy<Dictionary<object, object>>(
            () => new Dictionary<object, object>());

        public TraceRecord(HttpRequestMessage request, string category, TraceLevel level)
        {
            Timestamp = DateTime.UtcNow;
            Request = request;
            RequestId = request != null ? request.GetCorrelationId() : Guid.Empty;
            Category = category;
            Level = level;
        }

        /// <summary>
        /// Gets or sets the tracing category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// Gets or sets the kind of trace.
        /// </summary>
        public TraceKind Kind { get; set; }

        /// <summary>
        /// Gets or sets the tracing level.
        /// </summary>
        public TraceLevel Level { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the logical operation name being performed.
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets the logical name of the object performing the operation
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// Optional user-defined property bag.
        /// </summary>
        public Dictionary<object, object> Properties
        {
            get { return _properties.Value; }
        }

        /// <summary>
        /// Gets the <see cref="HttpRequestMessage"/>
        /// </summary>
        public HttpRequestMessage Request { get; private set; }

        /// <summary>
        /// Gets the correlation ID  from the <see cref="Request"/>.
        /// </summary>
        public Guid RequestId { get; private set; }

        /// <summary>
        /// Gets or sets the <see cref="HttpStatusCode"/> associated with the <see cref="HttpResponseMessage"/>.
        /// </summary>
        public HttpStatusCode Status { get; set; }

        /// <summary>
        /// Gets the <see cref="DateTime"/> of this trace (via <see cref="DateTime.UtcNow"/>)
        /// </summary>
        public DateTime Timestamp { get; private set; }
    }
}
