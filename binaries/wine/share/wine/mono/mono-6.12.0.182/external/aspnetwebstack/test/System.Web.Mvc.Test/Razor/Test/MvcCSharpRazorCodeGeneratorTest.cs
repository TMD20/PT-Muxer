﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Web.Razor;
using Moq;
using Xunit;

namespace System.Web.Mvc.Razor.Test
{
    public class MvcCSharpRazorCodeGeneratorTest
    {
        [Fact]
        public void Constructor()
        {
            // Arrange
            Mock<RazorEngineHost> mockHost = new Mock<RazorEngineHost>();

            // Act
            var generator = new MvcCSharpRazorCodeGenerator("FooClass", "Root.Namespace", "SomeSourceFile.cshtml", mockHost.Object);

            // Assert
            Assert.Equal("FooClass", generator.ClassName);
            Assert.Equal("Root.Namespace", generator.RootNamespaceName);
            Assert.Equal("SomeSourceFile.cshtml", generator.SourceFileName);
            Assert.Same(mockHost.Object, generator.Host);
        }

        [Fact]
        public void Constructor_DoesNotSetBaseTypeForNonMvcHost()
        {
            // Arrange
            Mock<RazorEngineHost> mockHost = new Mock<RazorEngineHost>();
            mockHost.SetupGet(h => h.NamespaceImports).Returns(new HashSet<string>());

            // Act
            var generator = new MvcCSharpRazorCodeGenerator("FooClass", "Root.Namespace", "SomeSourceFile.cshtml", mockHost.Object);

            // Assert
            Assert.Equal(0, generator.Context.GeneratedClass.BaseTypes.Count);
        }

        [Fact]
        public void Constructor_DoesNotSetBaseTypeForSpecialPage()
        {
            // Arrange
            Mock<MvcWebPageRazorHost> mockHost = new Mock<MvcWebPageRazorHost>("_viewStart.cshtml", "_viewStart.cshtml");
            mockHost.SetupGet(h => h.NamespaceImports).Returns(new HashSet<string>());

            // Act
            var generator = new MvcCSharpRazorCodeGenerator("FooClass", "Root.Namespace", "_viewStart.cshtml", mockHost.Object);

            // Assert
            Assert.Equal(0, generator.Context.GeneratedClass.BaseTypes.Count);
        }

        [Fact]
        public void Constructor_SetsBaseTypeForRegularPage()
        {
            // Arrange
            Mock<MvcWebPageRazorHost> mockHost = new Mock<MvcWebPageRazorHost>("SomeSourceFile.cshtml", "SomeSourceFile.cshtml") { CallBase = true };
            mockHost.SetupGet(h => h.NamespaceImports).Returns(new HashSet<string>());

            // Act
            var generator = new MvcCSharpRazorCodeGenerator("FooClass", "Root.Namespace", "SomeSourceFile.cshtml", mockHost.Object);

            // Assert
            Assert.Equal(1, generator.Context.GeneratedClass.BaseTypes.Count);
            Assert.Equal("System.Web.Mvc.WebViewPage<dynamic>", generator.Context.GeneratedClass.BaseTypes[0].BaseType);
        }
    }
}
