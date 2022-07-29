﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Linq;
using System.Web.WebPages.TestUtils;
using Xunit;

namespace System.Web.WebPages.Administration.Test
{
    public class PreApplicationStartCodeTest
    {
        [Fact]
        public void StartTest()
        {
            AppDomainUtils.RunInSeparateAppDomain(() =>
            {
                var adminPackageAssembly = typeof(PreApplicationStartCode).Assembly;
                AppDomainUtils.SetPreAppStartStage();
                PreApplicationStartCode.Start();
                // Call a second time to ensure multiple calls do not cause issues
                PreApplicationStartCode.Start();

                // TODO: Need a way to see if the module was actually registered
                var registeredAssemblies = ApplicationPart.GetRegisteredParts().ToList();
                Assert.Equal(1, registeredAssemblies.Count);
                registeredAssemblies.First().Assembly.Equals(adminPackageAssembly);
            });
        }

        [Fact]
        public void TestPreAppStartClass()
        {
            PreAppStartTestHelper.TestPreAppStartClass(typeof(PreApplicationStartCode));
        }
    }
}
