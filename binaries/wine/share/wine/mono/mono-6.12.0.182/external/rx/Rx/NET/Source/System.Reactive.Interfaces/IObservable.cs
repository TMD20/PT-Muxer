﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

#if NO_RXINTERFACES
namespace System
{
    /// <summary>
    /// Represents a push-style collection.
    /// </summary>
#if !NO_VARIANCE
    public interface IObservable<out T>
#else
    public interface IObservable<T>
#endif
    {
        /// <summary>
        /// Subscribes an observer to the observable sequence.
        /// </summary>
        IDisposable Subscribe(IObserver<T> observer);
    }
}
#elif !WINDOWSPHONE7 // TypeForwardedTo is not presen on windows phone 7 so we can't really target
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.IObservable<>))]
#endif

