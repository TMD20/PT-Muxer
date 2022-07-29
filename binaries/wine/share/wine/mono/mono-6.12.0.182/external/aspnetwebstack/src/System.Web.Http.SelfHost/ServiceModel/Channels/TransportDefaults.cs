﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Http.SelfHost.ServiceModel.Channels
{
    internal static class TransportDefaults
    {
        internal const long MaxReceivedMessageSize = 65536;
        internal const long MaxBufferPoolSize = 512 * 1024;
        internal const int MaxBufferSize = (int)MaxReceivedMessageSize;
        internal const int MaxFaultSize = MaxBufferSize;
    }
}
