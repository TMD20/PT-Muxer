﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using Xunit;

namespace System.Web.Razor.Test.Utils
{
    class MiscUtils
    {
        public const int TimeoutInSeconds = 1;

        public static string StripRuntimeVersion(string s)
        {
            return Regex.Replace(s, @"Runtime Version:[\d.]*", "Runtime Version:N.N.NNNNN.N");
        }

        public static void DoWithTimeoutIfNotDebugging(Func<int, bool> withTimeout)
        {
#if DEBUG
            if (Debugger.IsAttached)
            {
                withTimeout(Timeout.Infinite);
            }
            else
            {
#endif
                Assert.True(withTimeout((int)TimeSpan.FromSeconds(TimeoutInSeconds).TotalMilliseconds), "Timeout expired!");
#if DEBUG
            }
#endif
        }
    }
}
