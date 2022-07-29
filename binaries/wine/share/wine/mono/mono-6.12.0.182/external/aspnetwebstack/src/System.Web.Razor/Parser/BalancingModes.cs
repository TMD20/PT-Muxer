﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Razor.Parser
{
    [Flags]
    public enum BalancingModes
    {
        None = 0,
        BacktrackOnFailure = 1,
        NoErrorOnFailure = 2,
        AllowCommentsAndTemplates = 4,
        AllowEmbeddedTransitions = 8
    }
}
