﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;
using System.Reactive.PlatformServices;

namespace System.Reactive
{
    internal static class ExceptionHelpers
    {
        private static Lazy<IExceptionServices> s_services = new Lazy<IExceptionServices>(Initialize);

        public static void Throw(this Exception exception)
        {
            s_services.Value.Rethrow(exception);
        }

        public static void ThrowIfNotNull(this Exception exception)
        {
            if (exception != null)
                s_services.Value.Rethrow(exception);
        }

        private static IExceptionServices Initialize()
        {
            return PlatformEnlightenmentProvider.Current.GetService<IExceptionServices>() ?? new DefaultExceptionServices();
        }
    }
}

namespace System.Reactive.PlatformServices
{
    /// <summary>
    /// (Infrastructure) Services to rethrow exceptions.
    /// </summary>
    /// <remarks>
    /// This type is used by the Rx infrastructure and not meant for public consumption or implementation.
    /// No guarantees are made about forward compatibility of the type's functionality and its usage.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IExceptionServices
    {
        /// <summary>
        /// Rethrows the specified exception.
        /// </summary>
        /// <param name="exception">Exception to rethrow.</param>
        void Rethrow(Exception exception);
    }
}
