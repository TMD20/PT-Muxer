﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Generator;
using System.Web.Razor.Parser;
using Microsoft.CSharp;
using Xunit;

namespace System.Web.Razor.Test
{
    public class CSharpRazorCodeLanguageTest
    {
        [Fact]
        public void CreateCodeParserReturnsNewCSharpCodeParser()
        {
            // Arrange
            RazorCodeLanguage service = new CSharpRazorCodeLanguage();

            // Act
            ParserBase parser = service.CreateCodeParser();

            // Assert
            Assert.NotNull(parser);
            Assert.IsType<CSharpCodeParser>(parser);
        }

        [Fact]
        public void CreateCodeGeneratorParserListenerReturnsNewCSharpCodeGeneratorParserListener()
        {
            // Arrange
            RazorCodeLanguage service = new CSharpRazorCodeLanguage();

            // Act
            RazorEngineHost host = new RazorEngineHost(service);
            RazorCodeGenerator generator = service.CreateCodeGenerator("Foo", "Bar", "Baz", host);

            // Assert
            Assert.NotNull(generator);
            Assert.IsType<CSharpRazorCodeGenerator>(generator);
            Assert.Equal("Foo", generator.ClassName);
            Assert.Equal("Bar", generator.RootNamespaceName);
            Assert.Equal("Baz", generator.SourceFileName);
            Assert.Same(host, generator.Host);
        }

        [Fact]
        public void CodeDomProviderTypeReturnsVBCodeProvider()
        {
            // Arrange
            RazorCodeLanguage service = new CSharpRazorCodeLanguage();

            // Assert
            Assert.Equal(typeof(CSharpCodeProvider), service.CodeDomProviderType);
        }
    }
}
