// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Threading;
using Microsoft.Reactive.Testing;
#if NUNIT
using NUnit.Framework;
using TestClassAttribute = NUnit.Framework.TestFixtureAttribute;
using TestMethodAttribute = NUnit.Framework.TestAttribute;
using TestInitializeAttribute = NUnit.Framework.SetUpAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif
using System.Reactive.Linq;
using System.Reactive.Observable.Aliases;

namespace ReactiveTests.Tests
{
    [TestClass]
    public partial class AliasesTest : ReactiveTest
    {
#if !NO_EXPRESSIONS
        [TestMethod]
        public void Qbservable_Aliases()
        {
            var xs = Observable.Return(1).AsQbservable();

            Assert.IsTrue(xs.Filter(x => true).ToEnumerable().SequenceEqual(new[] { 1 }), "Filter");
            Assert.IsTrue(xs.Filter(x => true).Concat(xs.Filter(x => false)).ToEnumerable().SequenceEqual(new[] { 1 }), "Concat/Filter");
            Assert.IsTrue(xs.Map(x => x.ToString()).ToEnumerable().SequenceEqual(new[] { "1" }), "Map");
            Assert.IsTrue(xs.FlatMap(x => xs).ToEnumerable().SequenceEqual(new[] { 1 }), "FlatMap");
        }
#endif
    }
}
