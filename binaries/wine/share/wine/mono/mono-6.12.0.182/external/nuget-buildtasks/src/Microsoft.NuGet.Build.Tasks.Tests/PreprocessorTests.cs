// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.NuGet.Build.Tasks;
using Xunit;

namespace Microsoft.NuGet.Build.Tasks.Tests
{
    public class PreprocessorTests
    {
        private string Preprocess(string text, IReadOnlyDictionary<string, string> values)
        {
            var writer = new StringWriter();
            Preprocessor.Preprocess(new StringReader(text), writer, values);
            return writer.ToString();
        }

        [Fact]
        public void EmptyStringYieldsEmptyString()
        {
            Assert.Equal("", Preprocess("", new Dictionary<string, string>()));
        }

        [Fact]
        public void NonEmptyStringWithNoTokensYieldsIdentity()
        {
            Assert.Equal("Hello, World!", Preprocess("Hello, World!", new Dictionary<string, string>()));
        }

        [Fact]
        public void NonEmptyStringWithNoTokensYieldsIdentityWithValues()
        {
            Assert.Equal("Hello, World!", Preprocess("Hello, World!", new Dictionary<string, string>() { { "CompanyName", "Microsoft" } }));
        }

        [Fact]
        public void DoubleDollarIsEscape()
        {
            Assert.Equal("Pay Jason $42", Preprocess("Pay Jason $$42", new Dictionary<string, string>()));
        }

        [Fact]
        public void ReplaceWithSimpleValue()
        {
            Assert.Equal("Microsoft", Preprocess("$CompanyName$", new Dictionary<string, string>() { { "CompanyName", "Microsoft" } }));
        }

        [Fact]
        public void UnterminatedIsNotAToken()
        {
            Assert.Equal("$CompanyName", Preprocess("$CompanyName", new Dictionary<string, string>() { { "CompanyName", "Microsoft" } }));
        }

        [Fact]
        public void SimpleDollarIsTrivial()
        {
            Assert.Equal("$", Preprocess("$", new Dictionary<string, string>() { }));
        }

        [Fact]
        public void UnterminatedIsNotAToken2()
        {
            Assert.Equal("$CompanyName $CompanyName", Preprocess("$CompanyName $CompanyName", new Dictionary<string, string>() { { "CompanyName", "Microsoft" } }));
        }

        [Fact]
        public void ReplaceWithTwoValues()
        {
            Assert.Equal("Microsoft", Preprocess("$CompanyName1$$CompanyName2$", new Dictionary<string, string>() { { "CompanyName1", "Micro" }, { "CompanyName2", "soft" } }));
        }

        [Fact]
        public void ReplaceWithSimpleValueTwice()
        {
            Assert.Equal("MicrosoftMicrosoft", Preprocess("$CompanyName$$CompanyName$", new Dictionary<string, string>() { { "CompanyName", "Microsoft" } }));
        }

        [Fact]
        public void ReplaceWithOtherTextBeforeAndAfter()
        {
            Assert.Equal(" Microsoft ", Preprocess(" $CompanyName$ ", new Dictionary<string, string>() { { "CompanyName", "Microsoft" } }));
        }

        [Fact]
        public void ReplaceWithInvalidTokenThrows()
        {
            Assert.Throws<ExceptionFromResource>(() => Preprocess("$UnknownToken$", new Dictionary<string, string>()));
        }
    }
}
