// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Xunit;

namespace Microsoft.NuGet.Build.Tasks.Tests
{
    internal static class AssertHelpers
    {
        public static void AssertCountOf(int expectedCount, IEnumerable<ITaskItem> items)
        {
            Assert.True(items.Count() == expectedCount, 
                $"Expected {expectedCount} items, but actually got {items.Count()} items:" + Environment.NewLine + string.Join(Environment.NewLine, items.Select(i => i.ItemSpec)));
        }

        /// <summary>
        /// Asserts that the expected path ends with our actual path. "Ends with" in this case is defined by path
        /// components, so "Directory\File" doesn't end with "ile", to prevent any bugs where path components get mangled.
        /// </summary>
        public static void PathEndsWith(string expectedPath, string actualPath)
        {
            // We could implement this with a simple Assert.True(...EndsWithPath),
            // but that results in less user-friendly output from the test than a smarter call to
            // Assert.EndsWith
            if (!actualPath.EndsWithPath(expectedPath))
            {
                Assert.EndsWith("\\" + expectedPath, actualPath);

                // If we get out of sync with this function or EndsWithPath, that Assert might not
                // fail. In that case, fail the test.
                throw new Exception("The Assert.EndsWith in the previous line should have failed.");
            }
        }

        /// <summary>
        /// Returns that the expected path ends with our actual path. "Ends with" in this case is defined by path
        /// components, so "Directory\File" doesn't end with "ile", to prevent any bugs where path components get mangled.
        /// </summary>
        public static bool EndsWithPath(this string path, string suffix)
        {
            return path == suffix || path.EndsWith("\\" + suffix);
        }

        public static void AssertNoTargetPaths(IEnumerable<ITaskItem> items)
        {
            foreach (var item in items)
            {
                Assert.Equal("", item.GetMetadata("DestinationSubDirectory"));
                Assert.Equal("", item.GetMetadata("TargetPath"));
            }
        }

        public static void AssertConsistentTargetPaths(IEnumerable<ITaskItem> items)
        {
            var mapToItem = new Dictionary<string, ITaskItem>(StringComparer.OrdinalIgnoreCase);

            foreach (var item in items)
            {
                string effectiveTargetPath = item.GetMetadata("TargetPath");

                if (string.IsNullOrEmpty(effectiveTargetPath))
                {
                    effectiveTargetPath = Path.GetFileName(item.ItemSpec);
                }

                ITaskItem conflictingItem;
                if (mapToItem.TryGetValue(effectiveTargetPath, out conflictingItem))
                {
                    Assert.True(conflictingItem == null, $"Item {item.ItemSpec} and {conflictingItem.ItemSpec} have the same TargetPath.");
                }

                mapToItem.Add(effectiveTargetPath, item);
            }
        }
    }
}
