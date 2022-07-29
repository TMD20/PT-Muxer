// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.NuGet.Build.Tasks.Tests.Helpers
{
    public sealed class TempRoot : IDisposable
    {
        private readonly List<IDisposable> _temps = new List<IDisposable>();
        public readonly string Root;

        public TempRoot()
        {
            Root = Path.Combine(Path.GetTempPath(), "NuGetBuildTests", Guid.NewGuid().ToString());

            Directory.CreateDirectory(Root);
        }

        public void Dispose()
        {
            if (_temps != null)
            {
                DisposeAll(_temps);
                _temps.Clear();
            }
        }

        private static void DisposeAll(IEnumerable<IDisposable> temps)
        {
            foreach (var temp in temps)
            {
                try
                {
                    if (temp != null)
                    {
                        temp.Dispose();
                    }
                }
                catch
                {
                    // ignore
                }
            }
        }

        public DisposableDirectory CreateDirectory()
        {
            var dir = new DisposableDirectory(this);
            _temps.Add(dir);
            return dir;
        }

        public TempFile CreateFile(string prefix = null, string extension = null, string directory = null, [CallerFilePath]string callerSourcePath = null, [CallerLineNumber]int callerLineNumber = 0)
        {
            return AddFile(new DisposableFile(this, prefix, extension, directory, callerSourcePath, callerLineNumber));
        }

        public DisposableFile AddFile(DisposableFile file)
        {
            _temps.Add(file);
            return file;
        }

        internal static void CreateStream(string fullPath)
        {
            using (var file = new FileStream(fullPath, FileMode.CreateNew)) { }
        }
    }
}
