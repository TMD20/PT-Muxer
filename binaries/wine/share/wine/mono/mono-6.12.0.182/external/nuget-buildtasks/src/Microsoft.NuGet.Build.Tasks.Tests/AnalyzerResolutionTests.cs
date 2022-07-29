// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System.Linq;
using Xunit;

namespace Microsoft.NuGet.Build.Tasks.Tests
{
    public class AnalyzerResolutionTests
    {
        [Fact]
        public static void TestAnalyzerResolutionCSharp()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.analyzers,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "",
                projectLanguage: "C#");

            AssertHelpers.AssertCountOf(8, result.Analyzers);
        }

        [Fact]
        public static void TestAnalyzerResolutionVisualBasic()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.analyzers,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "",
                projectLanguage: "vb");

            AssertHelpers.AssertCountOf(8, result.Analyzers);
        }
    }
}
