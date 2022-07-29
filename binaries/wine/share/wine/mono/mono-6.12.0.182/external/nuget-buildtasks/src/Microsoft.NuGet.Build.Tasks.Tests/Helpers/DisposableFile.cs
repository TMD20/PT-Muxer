// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.NuGet.Build.Tasks.Tests.Helpers
{
    public sealed class DisposableFile : TempFile, IDisposable
    {
        public DisposableFile(string path)
            : base(path)
        {
        }

        public DisposableFile(TempRoot root, string prefix = null, string extension = null, string directory = null, string callerSourcePath = null, int callerLineNumber = 0)
            : base(root, prefix, extension, directory, callerSourcePath, callerLineNumber)
        {
        }

        public void Dispose()
        {
            if (Path != null && File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
    }
}
