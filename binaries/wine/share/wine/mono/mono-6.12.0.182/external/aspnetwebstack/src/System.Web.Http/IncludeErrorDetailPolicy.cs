﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Http
{
    /// <summary>
    /// Enum to indicate whether error details, such as exception messages and stack traces, should be included in error messages.
    /// </summary>
    public enum IncludeErrorDetailPolicy
    {
        /// <summary>
        /// Only include error details when responding to a local request.
        /// </summary>
        LocalOnly = 0,

        /// <summary>
        /// Always include error details.
        /// </summary>
        Always,

        /// <summary>
        /// Never include error details.
        /// </summary>
        Never
    }
}
