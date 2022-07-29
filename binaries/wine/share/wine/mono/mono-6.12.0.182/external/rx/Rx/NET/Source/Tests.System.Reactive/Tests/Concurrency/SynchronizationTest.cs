﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
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
using ReactiveTests.Dummies;

namespace ReactiveTests.Tests
{
    [TestClass]
    public class SynchronizationTests
    {
        [TestMethod]
        public void Synchronization_SubscribeOn_ArgumentChecking()
        {
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.SubscribeOn(default(IObservable<int>), Scheduler.Immediate));
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.SubscribeOn(DummyObservable<int>.Instance, default(IScheduler)));

#if !NO_SYNCCTX
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.SubscribeOn(default(IObservable<int>), new MySyncCtx()));
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.SubscribeOn(DummyObservable<int>.Instance, default(SynchronizationContext)));
#endif
        }

        [TestMethod]
        public void Synchronization_ObserveOn_ArgumentChecking()
        {
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.ObserveOn(default(IObservable<int>), Scheduler.Immediate));
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.ObserveOn(DummyObservable<int>.Instance, default(IScheduler)));

#if !NO_SYNCCTX
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.ObserveOn(default(IObservable<int>), new MySyncCtx()));
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.ObserveOn(DummyObservable<int>.Instance, default(SynchronizationContext)));
#endif
        }

        [TestMethod]
        public void Synchronization_Synchronize_ArgumentChecking()
        {
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.Synchronize(default(IObservable<int>)));
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.Synchronize(default(IObservable<int>), new object()));
            ReactiveAssert.Throws<ArgumentNullException>(() => Synchronization.Synchronize(DummyObservable<int>.Instance, null));
        }

        class MySyncCtx : SynchronizationContext
        {
        }
    }
}
