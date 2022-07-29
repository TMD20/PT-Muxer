// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Struct, Inherited=false, AllowMultiple=false)]
    public sealed class ExcludeFromCodeCoverageAttribute: Attribute
    {
        public ExcludeFromCodeCoverageAttribute()
        { }
    }
}
