﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace WebMatrix.Data
{
    internal interface IConnectionConfiguration
    {
        string ConnectionString { get; }
        IDbProviderFactory ProviderFactory { get; }
    }
}
