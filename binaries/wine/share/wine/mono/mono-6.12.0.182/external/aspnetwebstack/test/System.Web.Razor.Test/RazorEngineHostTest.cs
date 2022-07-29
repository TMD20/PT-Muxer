﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.CodeDom;
using System.Web.Razor.Generator;
using System.Web.Razor.Parser;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Razor.Test
{
    public class RazorEngineHostTest
    {
        [Fact]
        public void ConstructorRequiresNonNullCodeLanguage()
        {
            Assert.ThrowsArgumentNull(() => new RazorEngineHost(null), "codeLanguage");
            Assert.ThrowsArgumentNull(() => new RazorEngineHost(null, () => new HtmlMarkupParser()), "codeLanguage");
        }

        [Fact]
        public void ConstructorRequiresNonNullMarkupParser()
        {
            Assert.ThrowsArgumentNull(() => new RazorEngineHost(new CSharpRazorCodeLanguage(), null), "markupParserFactory");
        }

        [Fact]
        public void ConstructorWithCodeLanguageSetsPropertiesAppropriately()
        {
            // Arrange
            RazorCodeLanguage language = new CSharpRazorCodeLanguage();

            // Act
            RazorEngineHost host = new RazorEngineHost(language);

            // Assert
            VerifyCommonDefaults(host);
            Assert.Same(language, host.CodeLanguage);
            Assert.IsType<HtmlMarkupParser>(host.CreateMarkupParser());
        }

        [Fact]
        public void ConstructorWithCodeLanguageAndMarkupParserSetsPropertiesAppropriately()
        {
            // Arrange
            RazorCodeLanguage language = new CSharpRazorCodeLanguage();
            ParserBase expected = new HtmlMarkupParser();

            // Act
            RazorEngineHost host = new RazorEngineHost(language, () => expected);

            // Assert
            VerifyCommonDefaults(host);
            Assert.Same(language, host.CodeLanguage);
            Assert.Same(expected, host.CreateMarkupParser());
        }

        [Fact]
        public void DecorateCodeParserRequiresNonNullCodeParser()
        {
            Assert.ThrowsArgumentNull(() => CreateHost().DecorateCodeParser(null), "incomingCodeParser");
        }

        [Fact]
        public void DecorateMarkupParserRequiresNonNullMarkupParser()
        {
            Assert.ThrowsArgumentNull(() => CreateHost().DecorateMarkupParser(null), "incomingMarkupParser");
        }

        [Fact]
        public void DecorateCodeGeneratorRequiresNonNullCodeGenerator()
        {
            Assert.ThrowsArgumentNull(() => CreateHost().DecorateCodeGenerator(null), "incomingCodeGenerator");
        }

        [Fact]
        public void PostProcessGeneratedCodeRequiresNonNullCompileUnit()
        {
            Assert.ThrowsArgumentNull(() => CreateHost().PostProcessGeneratedCode(codeCompileUnit: null,
                                                                                      generatedNamespace: new CodeNamespace(),
                                                                                      generatedClass: new CodeTypeDeclaration(),
                                                                                      executeMethod: new CodeMemberMethod()),
                                          "codeCompileUnit");
        }

        [Fact]
        public void PostProcessGeneratedCodeRequiresNonNullGeneratedNamespace()
        {
            Assert.ThrowsArgumentNull(() => CreateHost().PostProcessGeneratedCode(codeCompileUnit: new CodeCompileUnit(),
                                                                                      generatedNamespace: null,
                                                                                      generatedClass: new CodeTypeDeclaration(),
                                                                                      executeMethod: new CodeMemberMethod()),
                                          "generatedNamespace");
        }

        [Fact]
        public void PostProcessGeneratedCodeRequiresNonNullGeneratedClass()
        {
            Assert.ThrowsArgumentNull(() => CreateHost().PostProcessGeneratedCode(codeCompileUnit: new CodeCompileUnit(),
                                                                                      generatedNamespace: new CodeNamespace(),
                                                                                      generatedClass: null,
                                                                                      executeMethod: new CodeMemberMethod()),
                                          "generatedClass");
        }

        [Fact]
        public void PostProcessGeneratedCodeRequiresNonNullExecuteMethod()
        {
            Assert.ThrowsArgumentNull(() => CreateHost().PostProcessGeneratedCode(codeCompileUnit: new CodeCompileUnit(),
                                                                                      generatedNamespace: new CodeNamespace(),
                                                                                      generatedClass: new CodeTypeDeclaration(),
                                                                                      executeMethod: null),
                                          "executeMethod");
        }

        [Fact]
        public void DecorateCodeParserDoesNotModifyIncomingParser()
        {
            // Arrange
            ParserBase expected = new CSharpCodeParser();

            // Act
            ParserBase actual = CreateHost().DecorateCodeParser(expected);

            // Assert
            Assert.Same(expected, actual);
        }

        [Fact]
        public void DecorateMarkupParserReturnsIncomingParser()
        {
            // Arrange
            ParserBase expected = new HtmlMarkupParser();

            // Act
            ParserBase actual = CreateHost().DecorateMarkupParser(expected);

            // Assert
            Assert.Same(expected, actual);
        }

        [Fact]
        public void DecorateCodeGeneratorReturnsIncomingCodeGenerator()
        {
            // Arrange
            RazorCodeGenerator expected = new CSharpRazorCodeGenerator("Foo", "Bar", "Baz", CreateHost());

            // Act
            RazorCodeGenerator actual = CreateHost().DecorateCodeGenerator(expected);

            // Assert
            Assert.Same(expected, actual);
        }

        [Fact]
        public void PostProcessGeneratedCodeDoesNotModifyCode()
        {
            // Arrange
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace ns = new CodeNamespace();
            CodeTypeDeclaration typeDecl = new CodeTypeDeclaration();
            CodeMemberMethod execMethod = new CodeMemberMethod();

            // Act
            CreateHost().PostProcessGeneratedCode(compileUnit, ns, typeDecl, execMethod);

            // Assert
            Assert.Empty(compileUnit.Namespaces);
            Assert.Empty(ns.Imports);
            Assert.Empty(ns.Types);
            Assert.Empty(typeDecl.Members);
            Assert.Empty(execMethod.Statements);
        }

        private static RazorEngineHost CreateHost()
        {
            return new RazorEngineHost(new CSharpRazorCodeLanguage());
        }

        private static void VerifyCommonDefaults(RazorEngineHost host)
        {
            Assert.Equal(GeneratedClassContext.Default, host.GeneratedClassContext);
            Assert.Empty(host.NamespaceImports);
            Assert.False(host.DesignTimeMode);
            Assert.Equal(RazorEngineHost.InternalDefaultClassName, host.DefaultClassName);
            Assert.Equal(RazorEngineHost.InternalDefaultNamespace, host.DefaultNamespace);
        }
    }
}
