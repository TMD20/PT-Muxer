﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Web.WebPages.Administration.PackageManager;
using Moq;
using Xunit;

namespace System.Web.WebPages.Administration.Test
{
    public class PackageManagerModuleTest
    {
        [Fact]
        public void InitSourceFileDoesNotAffectSourcesFileWhenFeedIsNotNull()
        {
            // Arrange
            bool sourceFileCalled = false;
            var sourceFile = GetPackagesSourceFile();
            sourceFile.Setup(s => s.Exists()).Returns(false);
            sourceFile.Setup(s => s.WriteSources(It.IsAny<IEnumerable<WebPackageSource>>())).Callback(() => sourceFileCalled = true);
            sourceFile.Setup(c => c.ReadSources()).Callback(() => sourceFileCalled = true);
            ISet<WebPackageSource> set = new HashSet<WebPackageSource>();

            // Act 
            PackageManagerModule.InitPackageSourceFile(sourceFile.Object, ref set);

            // Assert
            Assert.False(sourceFileCalled);
        }

        [Fact]
        public void InitSourceFileWritesToDiskIfSourcesFileDoesNotExist()
        {
            // Arrange
            ISet<WebPackageSource> set = null;
            var sourceFile = GetPackagesSourceFile();
            sourceFile.Setup(s => s.Exists()).Returns(false);
            sourceFile.Setup(s => s.WriteSources(It.IsAny<IEnumerable<WebPackageSource>>()));

            // Act
            PackageManagerModule.InitPackageSourceFile(sourceFile.Object, ref set);

            Assert.NotNull(set);
            Assert.Equal(set.Count(), 2);
            Assert.Equal(set.First().Source, "http://go.microsoft.com/fwlink/?LinkID=226946");
            Assert.Equal(set.Last().Source, "http://go.microsoft.com/fwlink/?LinkID=226948");
        }

        [Fact]
        public void InitSourceFileReadsFromDiskWhenFileAlreadyExists()
        {
            // Arrange
            var sourceFile = GetPackagesSourceFile();
            sourceFile.Setup(s => s.Exists()).Returns(true);
            ISet<WebPackageSource> set = null;

            // Act
            PackageManagerModule.InitPackageSourceFile(sourceFile.Object, ref set);

            // Assert
            Assert.NotNull(set);
            Assert.Equal(set.Count(), 2);
        }

        [Fact]
        public void AddFeedWritesSourceIfItDoesNotExist()
        {
            // Arrange
            bool writeCalled = false;
            var sourceFile = GetPackagesSourceFile();
            sourceFile.Setup(c => c.WriteSources(It.IsAny<IEnumerable<WebPackageSource>>())).Callback(() => writeCalled = true);
            ISet<WebPackageSource> set = new HashSet<WebPackageSource>(GetSources());

            // Act
            bool returnValue = PackageManagerModule.AddPackageSource(sourceFile.Object, set, new WebPackageSource(source: "http://www.microsoft.com/feed3", name: "Feed3"));

            // Assert
            Assert.Equal(set.Count(), 3);
            Assert.True(writeCalled);
            Assert.True(returnValue);
        }

        [Fact]
        public void AddFeedDoesNotWritesSourceIfExists()
        {
            // Arrange
            bool writeCalled = false;
            var sourceFile = GetPackagesSourceFile();
            sourceFile.Setup(c => c.WriteSources(It.IsAny<IEnumerable<WebPackageSource>>())).Callback(() => writeCalled = true);
            ISet<WebPackageSource> set = new HashSet<WebPackageSource>(GetSources());

            // Act
            bool returnValue = PackageManagerModule.AddPackageSource(sourceFile.Object, set, new WebPackageSource(source: "http://www.microsoft.com/feed1", name: "Feed1"));

            // Assert
            Assert.Equal(set.Count(), 2);
            Assert.False(writeCalled);
            Assert.False(returnValue);
        }

        [Fact]
        public void RemoveFeedRemovesSourceFromSet()
        {
            // Arrange
            bool writeCalled = false;
            var sourceFile = GetPackagesSourceFile();
            sourceFile.Setup(c => c.WriteSources(It.IsAny<IEnumerable<WebPackageSource>>())).Callback(() => writeCalled = true);
            ISet<WebPackageSource> set = new HashSet<WebPackageSource>(GetSources());

            // Act
            PackageManagerModule.RemovePackageSource(sourceFile.Object, set, "feed1");

            // Assert
            Assert.Equal(set.Count(), 1);
            Assert.False(set.Any(s => s.Name == "Feed1"));
            Assert.True(writeCalled);
        }

        [Fact]
        public void RemoveFeedDoesNotAffectSourceFileIsFeedDoesNotExist()
        {
            // Arrange
            bool writeCalled = false;
            var sourceFile = GetPackagesSourceFile();
            sourceFile.Setup(c => c.WriteSources(It.IsAny<IEnumerable<WebPackageSource>>())).Callback(() => writeCalled = true);
            ISet<WebPackageSource> set = new HashSet<WebPackageSource>(GetSources());

            // Act
            PackageManagerModule.RemovePackageSource(sourceFile.Object, set, "feed3");

            // Assert
            Assert.Equal(set.Count(), 2);
            Assert.False(writeCalled);
        }

        private static Mock<IPackagesSourceFile> GetPackagesSourceFile()
        {
            var sourceFile = new Mock<IPackagesSourceFile>();
            sourceFile.Setup(c => c.ReadSources()).Returns(GetSources());
            return sourceFile;
        }

        private static IEnumerable<WebPackageSource> GetSources()
        {
            return new[]
            {
                new WebPackageSource(name: "Feed1", source: "http://www.microsoft.com/feed1"),
                new WebPackageSource(name: "Feed2", source: "http://www.microsoft.com/feed2")
            };
        }
    }
}
