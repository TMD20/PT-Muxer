// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Internal.Runtime.Augments
{
#if !MONO 
    public 
#endif 
    enum CausalityRelation
    {
        AssignDelegate = 0,
        Join = 1,
        Choice = 2,
        Cancel = 3,
        Error = 4,
    }

#if !MONO 
    public 
#endif 
    enum CausalitySource
    {
        Application = 0,
        Library = 1,
        System = 2,
    }

#if !MONO 
    public 
#endif 
    enum CausalityTraceLevel
    {
        Required = 0,
        Important = 1,
        Verbose = 2,
    }

#if !MONO 
    public 
#endif 
    enum AsyncStatus
    {
        Started = 0,
        Completed = 1,
        Canceled = 2,
        Error = 3,
    }

#if !MONO 
    public 
#endif 
    enum CausalitySynchronousWork
    {
        CompletionNotification = 0,
        ProgressNotification = 1,
        Execution = 2,
    }
}
