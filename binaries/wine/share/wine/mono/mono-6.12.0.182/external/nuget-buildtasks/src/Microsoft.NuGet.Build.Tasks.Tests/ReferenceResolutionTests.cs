// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.NuGet.Build.Tasks.Tests.Helpers;
using Xunit;

namespace Microsoft.NuGet.Build.Tasks.Tests
{
    public partial class ReferenceResolutionTests
    {
        [Fact]
        public static void TestReferenceResolutionWithRuntimeIDWin10X86()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86");

            AssertHelpers.AssertCountOf(101, result.References);
            AssertHelpers.AssertCountOf(119, result.CopyLocalItems);
            AssertHelpers.AssertNoTargetPaths(result.CopyLocalItems);
        }

        [Fact]
        public static void TestReferenceResolutionWithRuntimeIDWin10X64()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x64");

            AssertHelpers.AssertCountOf(101, result.References);
            AssertHelpers.AssertCountOf(119, result.CopyLocalItems);
            AssertHelpers.AssertNoTargetPaths(result.CopyLocalItems);
        }

        [Fact]
        public static void TestReferenceResolutionWithRuntimeIDWin10X86Aot()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86-aot");

            AssertHelpers.AssertCountOf(101, result.References);
            AssertHelpers.AssertCountOf(141, result.CopyLocalItems);
            AssertHelpers.AssertNoTargetPaths(result.CopyLocalItems);
        }

        [Fact]
        public static void TestReferenceResolutionWithRuntimeIDWin10X64Aot()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x64-aot");

            AssertHelpers.AssertCountOf(101, result.References);
            AssertHelpers.AssertCountOf(141, result.CopyLocalItems);
            AssertHelpers.AssertNoTargetPaths(result.CopyLocalItems);
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingRuntimeIDAndFallback()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "missing-runtime-identifier",
                allowFallbackOnTargetSelection: true);

            // We should still have references. We'll assert that CopyLocalItems contains something, but it's purely best
            // effort and so there's no promise that it'll ever contain any specific items
            AssertHelpers.AssertCountOf(101, result.References);
            Assert.NotEmpty(result.CopyLocalItems);
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingRuntimeIDAndNoFallback()
        {
            var exception = Assert.Throws<ExceptionFromResource>(() =>
                NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                    Json.Json.Win10,
                    targetMoniker: ".NETCore,Version=v5.0",
                    runtimeIdentifier: "missing-runtime-identifier",
                    allowFallbackOnTargetSelection: false));

            Assert.Equal(nameof(Strings.MissingRuntimeInProjectJson), exception.ResourceName);
            Assert.Equal(new[] { "missing-runtime-identifier", "\"missing-runtime-identifier\": { }" }, exception.MessageArgs);
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingRuntimeIDAndNoFallbackAndNoRuntimesSection()
        {
            var exception = Assert.Throws<ExceptionFromResource>(() =>
                NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                    Json.Json.Win10,
                    targetMoniker: ".NETCore,Version=v5.0",
                    runtimeIdentifier: "missing-runtime-identifier",
                    allowFallbackOnTargetSelection: false,
                    projectJsonFileContents: "{ }"));

            Assert.Equal(nameof(Strings.MissingRuntimesSectionInProjectJson), exception.ResourceName);
            Assert.Equal(new[] { "\"runtimes\": { \"missing-runtime-identifier\": { } }" }, exception.MessageArgs);
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingRuntimeIDAndNoFallbackInProjectCsproj()
        {
            using (var tempRoot = new TempRoot())
            using (var disposableFile = new DisposableFile(tempRoot.CreateFile(extension: "assets.json").Path))
            {
                var exception = Assert.Throws<ExceptionFromResource>(() =>
                NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                    Encoding.UTF8.GetString(Json.Json.WithTargets_assets, 0, Json.Json.WithTargets_assets.Length),
                    targetMoniker: ".NETFramework,Version=v4.5",
                    runtimeIdentifier: "missing-runtime-identifier",
                    allowFallbackOnTargetSelection: false,
                    isLockFileProjectJsonBased: false));

                Assert.Equal(nameof(Strings.MissingRuntimeIdentifierInProjectFile), exception.ResourceName);
                Assert.Equal(new[] { "missing-runtime-identifier", "missing-runtime-identifier" }, exception.MessageArgs);
            }
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingRuntimeIDAndNoFallbackAndNoRuntimesSectionInProjectCsproj()
        {
            var exception = Assert.Throws<ExceptionFromResource>(() =>
                NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                    Json.Json.Win10,
                    targetMoniker: ".NETCore,Version=v5.0",
                    runtimeIdentifier: "missing-runtime-identifier",
                    allowFallbackOnTargetSelection: false,
                    projectJsonFileContents: "{ }"));

            Assert.Equal(nameof(Strings.MissingRuntimesSectionInProjectJson), exception.ResourceName);
            Assert.Equal(new[] { "\"runtimes\": { \"missing-runtime-identifier\": { } }" }, exception.MessageArgs);
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingTargetFrameworkAndNoFallback()
        {
            var exception = Assert.Throws<ExceptionFromResource>(() =>
                NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                    Json.Json.Win10,
                    targetMoniker: "Missing,Version=1.0",
                    runtimeIdentifier: "missing-runtime-identifier",
                    allowFallbackOnTargetSelection: false));

            Assert.Equal(nameof(Strings.MissingFrameworkInProjectJson), exception.ResourceName);
            Assert.Equal(new[] { "Missing,Version=1.0" }, exception.MessageArgs);
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingTargetFrameworkAndNoFallbackInProjectCsproj()
        {
            using (var tempRoot = new TempRoot())
            using (var disposableFile = new DisposableFile(tempRoot.CreateFile(extension: "assets.json").Path))
            {
                var exception = Assert.Throws<ExceptionFromResource>(() =>
                    NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                        Encoding.UTF8.GetString(Json.Json.WithoutTargets_assets, 0, Json.Json.WithoutTargets_assets.Length),
                        targetMoniker: "Missing,Version=1.0",
                        runtimeIdentifier: "missing-runtime-identifier",
                        allowFallbackOnTargetSelection: false,
                        isLockFileProjectJsonBased: false));

                Assert.Equal(nameof(Strings.MissingFrameworkInProjectFile), exception.ResourceName);
                Assert.Equal(new[] { "Missing,Version=1.0" }, exception.MessageArgs);
            }
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingTargetFrameworkAndFallback()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: "MissingFrameworkMoniker,Version=v42.0",
                runtimeIdentifier: "",
                allowFallbackOnTargetSelection: true);

            // We should still have references. Since we have no runtime ID, we should have no copy local items
            AssertHelpers.AssertCountOf(101, result.References);
            AssertHelpers.AssertCountOf(0, result.CopyLocalItems);
        }

        [Fact]
        public static void TestReferenceResolutionWithMissingTargetFrameworkAndFallbackInProjectCsproj()
        {
            using (var tempRoot = new TempRoot())
            using (var disposableFile = new DisposableFile(tempRoot.CreateFile(extension: "assets.json").Path))
            {
                var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                        Encoding.UTF8.GetString(Json.Json.WithTargets_assets, 0, Json.Json.WithTargets_assets.Length),
                        targetMoniker: "MissingFrameworkMoniker,Version=v42.0",
                        runtimeIdentifier: "",
                        allowFallbackOnTargetSelection: true,
                        isLockFileProjectJsonBased: false);

                // We should still have references. Since we have no runtime ID, we should have no copy local items
                AssertHelpers.AssertCountOf(1, result.References);
                AssertHelpers.AssertCountOf(0, result.CopyLocalItems);
            }
        }

        [Theory]
        [InlineData(true, nameof(Strings.NoTargetsInLockFileForProjectJson))]
        [InlineData(false, nameof(Strings.NoTargetsInLockFileForProjectFile))]
        public static void TestReferenceResolutionWithMissingTargets(bool isProjectJsonBased, string errorResourceName)
        {
            using (var tempRoot = new TempRoot())
            using (var disposableFile = new DisposableFile(tempRoot.CreateFile(extension: "assets.json").Path))
            {
                var exception = Assert.Throws<ExceptionFromResource>(() =>
                    NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                            Encoding.UTF8.GetString(Json.Json.WithoutTargets_assets, 0, Json.Json.WithoutTargets_assets.Length),
                            targetMoniker: "MissingFrameworkMoniker,Version=v42.0",
                            runtimeIdentifier: "",
                            allowFallbackOnTargetSelection: true,
                            isLockFileProjectJsonBased: isProjectJsonBased));

                Assert.Equal(errorResourceName, exception.ResourceName);
            }
        }

        [Fact]
        public static void TestReferenceResolutionWithNoRuntimeID()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "");

            // We should still have references, but no copy local
            AssertHelpers.AssertCountOf(101, result.References);
            AssertHelpers.AssertCountOf(0, result.CopyLocalItems);
        }

        [Fact]
        public static void PackagesHaveMetadataWithPackageIdAndVersion()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86");

            var immutableCopyLocalitem = result.CopyLocalItems.Single(i => i.ItemSpec.EndsWith("System.Collections.Immutable.dll"));

            Assert.Equal("System.Collections.Immutable", immutableCopyLocalitem.GetMetadata(ResolveNuGetPackageAssets.NuGetPackageIdMetadata));
            Assert.Equal("1.1.36", immutableCopyLocalitem.GetMetadata(ResolveNuGetPackageAssets.NuGetPackageVersionMetadata));
        }


        [Fact]
        public static void ReferencedPackagesCorrectlyParsed()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "");

            // We should still have references, but no copy local
            AssertHelpers.AssertCountOf(5, result.ReferencedPackages);

            var packageNames = result.ReferencedPackages.Select(t => t.ItemSpec);

            Assert.Contains("Microsoft.NETCore.UniversalWindowsPlatform", packageNames);
        }

        [Fact]
        public static void ExcludingFrameworkReferencesActuallyExcludesFrameworkReferences()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.FluentAssertions,
                targetMoniker: ".NETFramework,Version=v4.5.2",
                runtimeIdentifier: "",
                includeFrameworkReferences: false);

            // We should only have references from the core package
            AssertHelpers.AssertCountOf(2, result.References);
            Assert.True(result.References.All(r => r.ItemSpec.Contains("FluentAssertions")));

            // This should still count as the reference to a package
            var packageNames = result.ReferencedPackages.Select(t => t.ItemSpec);
            Assert.Contains("FluentAssertions", packageNames);
        }

        [Fact]
        public static void IncludingFrameworkReferencesActuallyIncludesFrameworkReferences()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.FluentAssertions,
                targetMoniker: ".NETFramework,Version=v4.5.2",
                runtimeIdentifier: "",
                includeFrameworkReferences: true);

            // We should have references to the package itself plus framework packages
            AssertHelpers.AssertCountOf(4, result.References);
            Assert.True(result.References.All(r => r.ItemSpec.Contains("FluentAssertions") ||
                                                   r.ItemSpec == "System.Xml" ||
                                                   r.ItemSpec == "System.Xml.Linq"));

            // This should still count as the reference to a package
            var packageNames = result.ReferencedPackages.Select(t => t.ItemSpec);
            Assert.Contains("FluentAssertions", packageNames);
        }

        [Fact]
        public static void AllPackageReferencesAreMarkedAsSuch()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.FluentAssertions,
                targetMoniker: ".NETFramework,Version=v4.5.2",
                runtimeIdentifier: "",
                includeFrameworkReferences: true);

            // We should have references to the package itself plus framework packages
            AssertHelpers.AssertCountOf(4, result.References);
            Assert.All(result.References, r => Assert.Equal(ResolveNuGetPackageAssets.NuGetSourceType_Package, r.GetMetadata(ResolveNuGetPackageAssets.NuGetSourceType)));
        }

        [Fact]
        public static void CopyLocalContentsIncludePdbsIfAvailable()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.FluentAssertionsAndWin10,
                targetMoniker: "UAP,Version=v10.0",
                runtimeIdentifier: "win10-x86",
                includeFrameworkReferences: true);

            Assert.Single(result.CopyLocalItems, r => r.ItemSpec.EndsWithPath("FluentAssertions.dll"));
            Assert.Single(result.CopyLocalItems, r => r.ItemSpec.EndsWithPath("FluentAssertions.pdb"));
            Assert.Single(result.CopyLocalItems, r => r.ItemSpec.EndsWithPath("FluentAssertions.Core.dll"));
            Assert.Single(result.CopyLocalItems, r => r.ItemSpec.EndsWithPath("FluentAssertions.Core.pdb"));
        }

        [Fact]
        public static void FrameworkReferencesAreNotProvidedIfAlreadyProvidedByAnotherPackage()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.FluentAssertionsAndWin10,
                targetMoniker: "UAP,Version=v10.0",
                runtimeIdentifier: "",
                includeFrameworkReferences: true);

            // There should be exactly one reference to System.Xml.dll, and no other references
            Assert.Single(result.References.Where(r => r.ItemSpec.EndsWith("System.Xml.dll")));
            Assert.Empty(result.References.Where(r => r.ItemSpec == "System.Xml"));
        }

        [Fact]
        public static void AllNuGetReferencesHaveValidIsFrameworkReferenceProperty()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.FluentAssertions,
                targetMoniker: ".NETFramework,Version=v4.5.2",
                runtimeIdentifier: "");

            var key = ResolveNuGetPackageAssets.NuGetIsFrameworkReference;
            var values = result.References.Select(r => r.GetMetadata(key));

            Assert.All(result.References, r => Assert.Contains(key, r.MetadataNames.Cast<string>()));
            Assert.All(values, v => Assert.Contains(v, new[] { "true", "false" }));
        }

        [Fact]
        public static void AllReferencesHaveCorrectIsFrameworkReferenceProperty()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.FluentAssertions,
                targetMoniker: ".NETFramework,Version=v4.5.2",
                runtimeIdentifier: "");

            var references = result.References.ToDictionary(
                r => r.ItemSpec,
                r => r.GetMetadata(ResolveNuGetPackageAssets.NuGetIsFrameworkReference)
            );

            AssertHelpers.AssertCountOf(4, result.References);

            var corePath = Path.Combine(result.ReferenceTemporaryPath, @"FluentAssertions\3.4.1\lib\net45\FluentAssertions.Core.dll");
            Assert.True(references.ContainsKey(corePath));
            Assert.Equal("false", references[corePath]);

            var mainPath = Path.Combine(result.ReferenceTemporaryPath, @"FluentAssertions\3.4.1\lib\net45\FluentAssertions.dll");
            Assert.True(references.ContainsKey(mainPath));
            Assert.Equal("false", references[mainPath]);

            Assert.Equal("true", references["System.Xml"]);
            Assert.Equal("true", references["System.Xml.Linq"]);
        }

        [Fact]
        public static void NativeWinMDSetsMetadata()
        {
            string imageRuntimeVersion = "WindowsRuntime 1.3";
            TryGetRuntimeVersion tryGetRuntimeVersion = p => imageRuntimeVersion;
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.nativeWinMD,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86",
                tryGetRuntimeVersion: tryGetRuntimeVersion);

            var winmd = result.CopyLocalItems.FirstOrDefault(c =>
                Path.GetExtension(c.ItemSpec).Equals(".winmd", StringComparison.OrdinalIgnoreCase));

            Assert.NotNull(winmd);
            Assert.Equal(imageRuntimeVersion, winmd.GetMetadata("ImageRuntime"));
            Assert.Equal("true", winmd.GetMetadata("WinMDFile"));
            Assert.Equal("Native", winmd.GetMetadata("WinMDFileType"));
            Assert.False(string.IsNullOrEmpty(winmd.GetMetadata("Implementation")), "implementation should be set for native winmd");
            Assert.Equal(Path.GetFileNameWithoutExtension(winmd.ItemSpec) + ".dll", winmd.GetMetadata("Implementation"), StringComparer.OrdinalIgnoreCase);
        }

        [Fact]
        public static void ManagedWinMDDoesNotSetsMetadata()
        {
            string imageRuntimeVersion = "WindowsRuntime 1.4;CLR v4.0.30319";
            TryGetRuntimeVersion tryGetRuntimeVersion = p => imageRuntimeVersion;
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.nativeWinMD,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86",
                tryGetRuntimeVersion: tryGetRuntimeVersion);

            var winmd = result.CopyLocalItems.FirstOrDefault(c =>
                Path.GetExtension(c.ItemSpec).Equals(".winmd", StringComparison.OrdinalIgnoreCase));

            Assert.NotNull(winmd);
            Assert.Equal(imageRuntimeVersion, winmd.GetMetadata("ImageRuntime"));
            Assert.Equal("true", winmd.GetMetadata("WinMDFile"));
            Assert.Equal("Managed", winmd.GetMetadata("WinMDFileType"));
            Assert.True(string.IsNullOrEmpty(winmd.GetMetadata("Implementation")), "implementation should not be set for managed winmd");
        }

        [Fact]
        public static void BogusWinMDDoesNotSetImplementation()
        {
            string imageRuntimeVersion = "BogusRuntime 1.4;C1R v4.0.30319";
            TryGetRuntimeVersion tryGetRuntimeVersion = p => imageRuntimeVersion;
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.nativeWinMD,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86",
                tryGetRuntimeVersion: tryGetRuntimeVersion);

            var winmd = result.CopyLocalItems.FirstOrDefault(c =>
                Path.GetExtension(c.ItemSpec).Equals(".winmd", StringComparison.OrdinalIgnoreCase));

            Assert.NotNull(winmd);
            Assert.Equal(imageRuntimeVersion, winmd.GetMetadata("ImageRuntime"));
            Assert.True(string.IsNullOrEmpty(winmd.GetMetadata("WinMDFile")));
            Assert.True(string.IsNullOrEmpty(winmd.GetMetadata("WinMDFileType")));
            Assert.True(string.IsNullOrEmpty(winmd.GetMetadata("Implementation")), "implementation should not be set for bogus winmd");
        }

        [Fact]
        public static void TestTargetPathCollisionsFound()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10_Edm,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86");

            AssertHelpers.AssertConsistentTargetPaths(result.CopyLocalItems);
        }

        [Fact]
        public static void TestTargetPathCollisionsFound2()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.Win10_xunit,
                targetMoniker: ".NETCore,Version=v5.0",
                runtimeIdentifier: "win10-x86");

            AssertHelpers.AssertConsistentTargetPaths(result.CopyLocalItems);
        }

        [Fact]
        public static void MultipleProjectFileDependencyGroups()
        {
            var resultFor45 = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.MultipleProjectFileDependencyGroups,
                targetMoniker: ".NETFramework,Version=v4.5",
                runtimeIdentifier: "win",
                allowFallbackOnTargetSelection: true);

            var packageNames = resultFor45.ReferencedPackages.Select(t => t.ItemSpec);

            Assert.Equal("Newtonsoft.Json", packageNames.Single());

            var resultFor46 = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.MultipleProjectFileDependencyGroups,
                targetMoniker: ".NETFramework,Version=v4.6",
                runtimeIdentifier: "win",
                allowFallbackOnTargetSelection: true);

            AssertHelpers.AssertCountOf(1, resultFor46.ReferencedPackages);

            packageNames = resultFor46.ReferencedPackages.Select(t => t.ItemSpec);

            Assert.Contains("FluentAssertions", packageNames);
        }

        // Regression test for https://devdiv.visualstudio.com/DevDiv/_workitems?id=500532&_a=edit
        [Fact]
        public static void MultipleProjectFileDependencyGroups_MismatchedCases()
        {
            var resultFor45 = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.MultipleProjectFileDependencyGroups_CaseMismatch,
                targetMoniker: ".NETFramework,Version=v4.5",
                runtimeIdentifier: "win",
                allowFallbackOnTargetSelection: true);

            var packageNames = resultFor45.ReferencedPackages.Select(t => t.ItemSpec);

            Assert.Equal("Newtonsoft.Json", packageNames.Single(), ignoreCase: true);

            var resultFor46 = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.MultipleProjectFileDependencyGroups,
                targetMoniker: ".NETFramework,Version=v4.6",
                runtimeIdentifier: "win",
                allowFallbackOnTargetSelection: true);

            AssertHelpers.AssertCountOf(1, resultFor46.ReferencedPackages);

            packageNames = resultFor46.ReferencedPackages.Select(t => t.ItemSpec);

            Assert.Equal("FluentAssertions", packageNames.Single(), ignoreCase: true);
        }

        [Fact]
        public static void ProjectsNotIncludedInReferences()
        {
            var result = NuGetTestHelpers.ResolvePackagesWithJsonFileContents(
                Json.Json.ProjectDependency,
                targetMoniker: ".NETFramework,Version=v4.5.2",
                runtimeIdentifier: "win");

            Assert.DoesNotContain("ClassLibrary1", result.ReferencedPackages.Select(t => t.ItemSpec));
        }
    }
}
