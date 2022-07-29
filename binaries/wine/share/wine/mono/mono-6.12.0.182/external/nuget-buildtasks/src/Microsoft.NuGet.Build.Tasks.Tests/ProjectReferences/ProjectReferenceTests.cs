// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.Linq;
using Xunit;

namespace Microsoft.NuGet.Build.Tasks.Tests.ProjectReferences
{
    public class ProjectReferenceTests
    {
        [Fact]
        public void ProjectReferenceToCSProjWithoutAssetsAndNoPathSucceeds()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(Resources.LockFileWithCSProjReference, ".NETFramework,Version=v4.5.2", "win");

            // The lock file doesn't contain any assets for csproj references, so we should produce nothing
            Assert.Empty(result.Analyzers);
            Assert.Empty(result.CopyLocalItems);
            Assert.Empty(result.References);
            Assert.Empty(result.ReferencedPackages);
        }
    }
}
