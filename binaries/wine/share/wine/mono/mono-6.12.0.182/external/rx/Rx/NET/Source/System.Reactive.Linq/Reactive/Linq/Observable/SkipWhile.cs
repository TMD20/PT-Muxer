﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

#if !NO_PERF
using System;

namespace System.Reactive.Linq.ObservableImpl
{
    class SkipWhile<TSource> : Producer<TSource>
    {
        private readonly IObservable<TSource> _source;
        private readonly Func<TSource, bool> _predicate;
        private readonly Func<TSource, int, bool> _predicateI;

        public SkipWhile(IObservable<TSource> source, Func<TSource, bool> predicate)
        {
            _source = source;
            _predicate = predicate;
        }

        public SkipWhile(IObservable<TSource> source, Func<TSource, int, bool> predicate)
        {
            _source = source;
            _predicateI = predicate;
        }

        protected override IDisposable Run(IObserver<TSource> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            if (_predicate != null)
            {
                var sink = new _(this, observer, cancel);
                setSink(sink);
                return _source.SubscribeSafe(sink);
            }
            else
            {
                var sink = new SkipWhileImpl(this, observer, cancel);
                setSink(sink);
                return _source.SubscribeSafe(sink);
            }
        }

        class _ : Sink<TSource>, IObserver<TSource>
        {
            private readonly SkipWhile<TSource> _parent;
            private bool _running;

            public _(SkipWhile<TSource> parent, IObserver<TSource> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _parent = parent;
                _running = false;
            }

            public void OnNext(TSource value)
            {
                if (!_running)
                {
                    try
                    {
                        _running = !_parent._predicate(value);
                    }
                    catch (Exception exception)
                    {
                        base._observer.OnError(exception);
                        base.Dispose();
                        return;
                    }
                }

                if (_running)
                {
                    base._observer.OnNext(value);
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnCompleted();
                base.Dispose();
            }
        }

        class SkipWhileImpl : Sink<TSource>, IObserver<TSource>
        {
            private readonly SkipWhile<TSource> _parent;
            private bool _running;
            private int _index;

            public SkipWhileImpl(SkipWhile<TSource> parent, IObserver<TSource> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _parent = parent;
                _running = false;
                _index = 0;
            }

            public void OnNext(TSource value)
            {
                if (!_running)
                {
                    try
                    {
                        _running = !_parent._predicateI(value, checked(_index++));
                    }
                    catch (Exception exception)
                    {
                        base._observer.OnError(exception);
                        base.Dispose();
                        return;
                    }
                }

                if (_running)
                {
                    base._observer.OnNext(value);
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }
}
#endif