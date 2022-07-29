﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Web.WebPages.Scope
{
    public interface IScopeStorageProvider
    {
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "The state storage API is designed to allow contexts to be set")]
        IDictionary<object, object> CurrentScope { get; set; }

        IDictionary<object, object> GlobalScope { get; }
    }
}
