// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Newtonsoft.Json.Linq;
using Xunit;
using Microsoft.NuGet.Build.Tasks.Tests.Helpers;

namespace Microsoft.NuGet.Build.Tasks.Tests
{
    internal static class NuGetTestHelpers
    {
        public static ResolvePackagesResult ResolvePackagesWithJsonFileContents(
            string projectLockJsonFileContents,
            string targetMoniker,
            string runtimeIdentifier,
            bool isLockFileProjectJsonBased = true,
            string projectLanguage = null,
            bool allowFallbackOnTargetSelection = false,
            TryGetRuntimeVersion tryGetRuntimeVersion = null,
            bool includeFrameworkReferences = true,
            string projectJsonFileContents = null,
            bool createTemporaryFolderForPackages = true)
        {
            var rootDirectory = new TempRoot();
            using (rootDirectory)
            {
                var projectDirectory = rootDirectory.CreateDirectory();

                var projectLockJsonFile = projectDirectory.CreateFile(isLockFileProjectJsonBased ? "project.lock.json" : "project.assets.json");
                projectLockJsonFile.WriteAllText(projectLockJsonFileContents);

                if (projectJsonFileContents != null)
                {
                    var projectJsonFile = projectDirectory.CreateFile("project.json");
                    projectJsonFile.WriteAllText(projectJsonFileContents);
                }

                var filesInPackages = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                DisposableDirectory packagesDirectory = null;

                if (createTemporaryFolderForPackages)
                {
                    packagesDirectory = rootDirectory.CreateDirectory();

                    foreach (var fileInPackage in GetFakeFileNamesFromPackages(projectLockJsonFileContents, packagesDirectory.Path))
                    {
                        filesInPackages.Add(fileInPackage);
                    }
                }
                else
                {
                    // We will assume there is a location in the lock file we're using
                    var lockFile = JObject.Parse(projectLockJsonFileContents);
                    var firstLocation = ((JObject)lockFile["packageFolders"]).Properties().First().Name;

                    foreach (var fileInPackage in GetFakeFileNamesFromPackages(projectLockJsonFileContents, firstLocation))
                    {
                        filesInPackages.Add(fileInPackage);
                    }
                }

                // Don't require the packages be restored on the machine
                ResolveNuGetPackageAssets task = null;
                FileExists fileExists = path => filesInPackages.Contains(path) || File.Exists(path);

                task = new ResolveNuGetPackageAssets(fileExists, tryGetRuntimeVersion);
                var sw = new StringWriter();
                task.BuildEngine = new MockBuildEngine(sw);

                task.AllowFallbackOnTargetSelection = allowFallbackOnTargetSelection;
                task.IncludeFrameworkReferences = includeFrameworkReferences;
                task.NuGetPackagesDirectory = packagesDirectory?.Path;
                task.RuntimeIdentifier = runtimeIdentifier;
                task.ProjectLockFile = projectLockJsonFile.Path;
                task.ProjectLanguage = projectLanguage;
                task.TargetMonikers = new ITaskItem[] { new TaskItem(targetMoniker) };

                // When we create the task for unit-testing purposes, the constructor sets an internal bit which should always
                // cause task.Execute to throw.
                Assert.True(task.Execute());

                var analyzers = task.ResolvedAnalyzers;
                var copyLocalItems = task.ResolvedCopyLocalItems;
                var references = task.ResolvedReferences;
                var referencedPackages = task.ReferencedPackages;

                return new ResolvePackagesResult(analyzers, copyLocalItems, references, referencedPackages, rootDirectory.Root);
            }
        }

        /// <summary>
        /// Given the contents of a project.lock.json, figures out all the "fake" full paths that are in those packages as if
        /// those packages are restored on disk.
        /// </summary>
        private static IEnumerable<string> GetFakeFileNamesFromPackages(string projectJsonContents, string packagesDirectory)
        {
            var lockFile = JObject.Parse(projectJsonContents);

            foreach (JProperty library in lockFile["libraries"])
            {
                var files = library.Value["files"] as JArray;
                if (files != null)
                {
                    foreach (string file in files)
                    {
                        yield return Path.Combine(packagesDirectory, library.Name, file).Replace('/', '\\');
                    }
                }

                // Some earlier versions of NuGet didn't include the hash file in the file list, so fake that
                // in here.
                yield return Path.Combine(packagesDirectory, library.Name.Replace('/', '\\'), library.Name.Replace('/', '.') + ".nupkg.sha512");
            }
        }
    }
}
