﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.WebPages.Test
{
    public class ApplicationPartTest
    {
        [Fact]
        public void ApplicationPartThrowsIfRootVirtualPathIsNullOrEmpty()
        {
            // Arrange
            var assembly = new Mock<TestResourceAssembly>().Object;

            Assert.ThrowsArgumentNullOrEmptyString(() => new ApplicationPart(assembly, rootVirtualPath: null), "rootVirtualPath");
            Assert.ThrowsArgumentNullOrEmptyString(() => new ApplicationPart(assembly, rootVirtualPath: String.Empty), "rootVirtualPath");
        }

        [Fact]
        public void ResolveVirtualPathResolvesRegularPathsUsingBaseVirtualPath()
        {
            // Arrange
            var basePath = "~/base/";
            var path = "somefile";
            var appPartRoot = "~/app/";

            // Act
            var virtualPath = ApplicationPart.ResolveVirtualPath(appPartRoot, basePath, path);

            // Assert
            Assert.Equal(virtualPath, "~/base/somefile");
        }

        [Fact]
        public void ResolveVirtualPathResolvesAppRelativePathsUsingAppVirtualPath()
        {
            // Arrange
            var basePath = "~/base";
            var path = "@/somefile";
            var appPartRoot = "~/app/";

            // Act
            var virtualPath = ApplicationPart.ResolveVirtualPath(appPartRoot, basePath, path);

            // Assert
            Assert.Equal(virtualPath, "~/app/somefile");
        }

        [Fact]
        public void ResolveVirtualPathDoesNotAffectRootRelativePaths()
        {
            // Arrange
            var basePath = "~/base";
            var path = "~/somefile";
            var appPartRoot = "~/app/";

            // Act
            var virtualPath = ApplicationPart.ResolveVirtualPath(appPartRoot, basePath, path);

            // Assert
            Assert.Equal(virtualPath, "~/somefile");
        }

        [Fact]
        public void GetResourceNameFromVirtualPathForTopLevelPath()
        {
            // Arrange
            var moduleName = "my-module";
            var path = "foo.baz";

            // Act 
            var name = ApplicationPart.GetResourceNameFromVirtualPath(moduleName, path);

            // Assert
            Assert.Equal(name, moduleName + "." + path);
        }

        [Fact]
        public void GetResourceNameFromVirtualPathForItemInSubDir()
        {
            // Arrange
            var moduleName = "my-module";
            var path = "/bar/foo";

            // Act 
            var name = ApplicationPart.GetResourceNameFromVirtualPath(moduleName, path);

            // Assert
            Assert.Equal(name, "my-module.bar.foo");
        }

        [Fact]
        public void GetResourceNameFromVirtualPathForItemWithSpaces()
        {
            // Arrange
            var moduleName = "my-module";
            var path = "/program files/data files/my file .foo";

            // Act 
            var name = ApplicationPart.GetResourceNameFromVirtualPath(moduleName, path);

            // Assert
            Assert.Equal(name, "my-module.program_files.data_files.my file .foo");
        }

        [Fact]
        public void GetResourceVirtualPathForTopLevelItem()
        {
            // Arrange
            var moduleName = "my-module";
            var moduleRoot = "~/root-path";
            var path = moduleRoot + "/foo.txt";

            // Act
            var virtualPath = ApplicationPart.GetResourceVirtualPath(moduleName, moduleRoot, path);

            // Assert
            Assert.Equal(virtualPath, "~/r.ashx/" + moduleName + "/" + "foo.txt");
        }

        [Fact]
        public void GetResourceVirtualPathForTopLevelItemAndModuleRootWithTrailingSlash()
        {
            // Arrange
            var moduleName = "my-module";
            var moduleRoot = "~/root-path/";
            var path = moduleRoot + "/foo.txt";

            // Act
            var virtualPath = ApplicationPart.GetResourceVirtualPath(moduleName, moduleRoot, path);

            // Assert
            Assert.Equal(virtualPath, "~/r.ashx/" + moduleName + "/" + "foo.txt");
        }

        [Fact]
        public void GetResourceVirtualPathForTopLevelItemAndNestedModuleRootPath()
        {
            // Arrange
            var moduleName = "my-module";
            var moduleRoot = "~/root-path/sub-path";
            var path = moduleRoot + "/foo.txt";

            // Act
            var virtualPath = ApplicationPart.GetResourceVirtualPath(moduleName, moduleRoot, path);

            // Assert
            Assert.Equal(virtualPath, "~/r.ashx/" + moduleName + "/" + "foo.txt");
        }

        [Fact]
        public void GetResourceVirtualPathEncodesModuleName()
        {
            // Arrange
            var moduleName = "Debugger Package v?&%";
            var moduleRoot = "~/root-path/sub-path";
            var path = moduleRoot + "/foo.txt";

            // Act
            var virtualPath = ApplicationPart.GetResourceVirtualPath(moduleName, moduleRoot, path);

            // Assert
            Assert.Equal(virtualPath, "~/r.ashx/" + "Debugger%20Package%20v?&%" + "/" + "foo.txt");
        }

        [Fact]
        public void GetResourceVirtualPathForNestedItemPath()
        {
            // Arrange
            var moduleName = "DebuggerPackage";
            var moduleRoot = "~/root-path/sub-path";
            var itemPath = "some-path/some-more-please/foo.txt";
            var path = moduleRoot + "/" + itemPath;

            // Act
            var virtualPath = ApplicationPart.GetResourceVirtualPath(moduleName, moduleRoot, path);

            // Assert
            Assert.Equal(virtualPath, "~/r.ashx/" + moduleName + "/" + itemPath);
        }

        [Fact]
        public void GetResourceVirtualPathForItemPathWithParameters()
        {
            // Arrange
            var moduleName = "DebuggerPackage";
            var moduleRoot = "~/root-path/sub-path";
            var itemPath = "some-path/some-more-please/foo.jpg?size=45&height=20";
            var path = moduleRoot + "/" + itemPath;

            // Act
            var virtualPath = ApplicationPart.GetResourceVirtualPath(moduleName, moduleRoot, path);

            // Assert
            Assert.Equal(virtualPath, "~/r.ashx/" + moduleName + "/" + itemPath);
        }
    }
}
