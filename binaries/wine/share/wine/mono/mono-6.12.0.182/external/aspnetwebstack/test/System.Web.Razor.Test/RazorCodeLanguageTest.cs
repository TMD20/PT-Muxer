﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Xunit;

namespace System.Web.Razor.Test
{
    public class RazorCodeLanguageTest
    {
        [Fact]
        public void ServicesPropertyContainsEntriesForCSharpCodeLanguageService()
        {
            // Assert
            Assert.Equal(2, RazorCodeLanguage.Languages.Count);
            Assert.IsType<CSharpRazorCodeLanguage>(RazorCodeLanguage.Languages["cshtml"]);
            Assert.IsType<VBRazorCodeLanguage>(RazorCodeLanguage.Languages["vbhtml"]);
        }

        [Fact]
        public void GetServiceByExtensionReturnsEntryMatchingExtensionWithoutPreceedingDot()
        {
            Assert.IsType<CSharpRazorCodeLanguage>(RazorCodeLanguage.GetLanguageByExtension("cshtml"));
        }

        [Fact]
        public void GetServiceByExtensionReturnsEntryMatchingExtensionWithPreceedingDot()
        {
            Assert.IsType<CSharpRazorCodeLanguage>(RazorCodeLanguage.GetLanguageByExtension(".cshtml"));
        }

        [Fact]
        public void GetServiceByExtensionReturnsNullIfNoServiceForSpecifiedExtension()
        {
            Assert.Null(RazorCodeLanguage.GetLanguageByExtension("foobar"));
        }

        [Fact]
        public void MultipleCallsToGetServiceWithSameExtensionReturnSameObject()
        {
            // Arrange
            RazorCodeLanguage expected = RazorCodeLanguage.GetLanguageByExtension("cshtml");

            // Act
            RazorCodeLanguage actual = RazorCodeLanguage.GetLanguageByExtension("cshtml");

            // Assert
            Assert.Same(expected, actual);
        }
    }
}
