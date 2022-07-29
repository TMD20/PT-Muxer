// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.NuGet.Build.Tasks.Tests
{
    public class ResolvePackagesResult
    {
        public ResolvePackagesResult(
            ITaskItem[] analyzers,
            ITaskItem[] copyLocalItems,
            ITaskItem[] references,
            ITaskItem[] referencedPackages,
            string referenceTemporaryPath)
        {
            Analyzers = analyzers ?? new ITaskItem[] { };
            CopyLocalItems = copyLocalItems ?? new ITaskItem[] { };
            References = references ?? new ITaskItem[] { };
            ReferencedPackages = referencedPackages ?? new ITaskItem[] { };
            ReferenceTemporaryPath = referenceTemporaryPath;
        }

        public ITaskItem[] Analyzers { get; }
        public ITaskItem[] CopyLocalItems { get; }
        public ITaskItem[] References { get; }
        public ITaskItem[] ReferencedPackages { get; }


        /// <summary>
        /// Gets the temporary path created during testing process
        /// </summary>
        /// <remarks>
        /// You must assume this path no longer exists on disk, and can only be used to form absolute paths that match items in this object from relative paths
        /// </remarks>
        public string ReferenceTemporaryPath { get; }
    }
}
