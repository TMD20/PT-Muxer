﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

#if !NO_PERF
using System;
using System.Collections.Generic;

namespace System.Reactive.Linq.ObservableImpl
{
    class Max<TSource> : Producer<TSource>
    {
        private readonly IObservable<TSource> _source;
        private readonly IComparer<TSource> _comparer;

        public Max(IObservable<TSource> source, IComparer<TSource> comparer)
        {
            _source = source;
            _comparer = comparer;
        }

        protected override IDisposable Run(IObserver<TSource> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            // LINQ to Objects makes this distinction in order to make [Max|Max] of an empty collection of reference type objects equal to null.
            if (default(TSource) == null)
            {
                var sink = new _(this, observer, cancel);
                setSink(sink);
                return _source.SubscribeSafe(sink);
            }
            else
            {
                var sink = new Delta(this, observer, cancel);
                setSink(sink);
                return _source.SubscribeSafe(sink);
            }
        }

        class Delta : Sink<TSource>, IObserver<TSource>
        {
            private readonly Max<TSource> _parent;
            private bool _hasValue;
            private TSource _lastValue;

            public Delta(Max<TSource> parent, IObserver<TSource> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _parent = parent;

                _hasValue = false;
                _lastValue = default(TSource);
            }

            public void OnNext(TSource value)
            {
                if (_hasValue)
                {
                    var comparison = 0;

                    try
                    {
                        comparison = _parent._comparer.Compare(value, _lastValue);
                    }
                    catch (Exception ex)
                    {
                        base._observer.OnError(ex);
                        base.Dispose();
                        return;
                    }

                    if (comparison > 0)
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _hasValue = true;
                    _lastValue = value;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                if (!_hasValue)
                {
                    base._observer.OnError(new InvalidOperationException(Strings_Linq.NO_ELEMENTS));
                }
                else
                {
                    base._observer.OnNext(_lastValue);
                    base._observer.OnCompleted();
                }

                base.Dispose();
            }
        }

        class _ : Sink<TSource>, IObserver<TSource>
        {
            private readonly Max<TSource> _parent;
            private TSource _lastValue;

            public _(Max<TSource> parent, IObserver<TSource> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _parent = parent;

                _lastValue = default(TSource);
            }

            public void OnNext(TSource value)
            {
                if (value != null)
                {
                    if (_lastValue == null)
                    {
                        _lastValue = value;
                    }
                    else
                    {
                        var comparison = 0;

                        try
                        {
                            comparison = _parent._comparer.Compare(value, _lastValue);
                        }
                        catch (Exception ex)
                        {
                            base._observer.OnError(ex);
                            base.Dispose();
                            return;
                        }

                        if (comparison > 0)
                        {
                            _lastValue = value;
                        }
                    }
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnNext(_lastValue);
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }

    class MaxDouble : Producer<double>
    {
        private readonly IObservable<double> _source;

        public MaxDouble(IObservable<double> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<double> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<double>, IObserver<double>
        {
            private bool _hasValue;
            private double _lastValue;

            public _(IObserver<double> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _hasValue = false;
                _lastValue = default(double);
            }

            public void OnNext(double value)
            {
                if (_hasValue)
                {
                    if (value > _lastValue || double.IsNaN(value))
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                    _hasValue = true;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                if (!_hasValue)
                {
                    base._observer.OnError(new InvalidOperationException(Strings_Linq.NO_ELEMENTS));
                }
                else
                {
                    base._observer.OnNext(_lastValue);
                    base._observer.OnCompleted();
                }

                base.Dispose();
            }
        }
    }

    class MaxSingle : Producer<float>
    {
        private readonly IObservable<float> _source;

        public MaxSingle(IObservable<float> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<float> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<float>, IObserver<float>
        {
            private bool _hasValue;
            private float _lastValue;

            public _(IObserver<float> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _hasValue = false;
                _lastValue = default(float);
            }

            public void OnNext(float value)
            {
                if (_hasValue)
                {
                    if (value > _lastValue || float.IsNaN(value))
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                    _hasValue = true;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                if (!_hasValue)
                {
                    base._observer.OnError(new InvalidOperationException(Strings_Linq.NO_ELEMENTS));
                }
                else
                {
                    base._observer.OnNext(_lastValue);
                    base._observer.OnCompleted();
                }

                base.Dispose();
            }
        }
    }

    class MaxDecimal : Producer<decimal>
    {
        private readonly IObservable<decimal> _source;

        public MaxDecimal(IObservable<decimal> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<decimal> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<decimal>, IObserver<decimal>
        {
            private bool _hasValue;
            private decimal _lastValue;

            public _(IObserver<decimal> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _hasValue = false;
                _lastValue = default(decimal);
            }

            public void OnNext(decimal value)
            {
                if (_hasValue)
                {
                    if (value > _lastValue)
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                    _hasValue = true;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                if (!_hasValue)
                {
                    base._observer.OnError(new InvalidOperationException(Strings_Linq.NO_ELEMENTS));
                }
                else
                {
                    base._observer.OnNext(_lastValue);
                    base._observer.OnCompleted();
                }

                base.Dispose();
            }
        }
    }

    class MaxInt32 : Producer<int>
    {
        private readonly IObservable<int> _source;

        public MaxInt32(IObservable<int> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<int> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<int>, IObserver<int>
        {
            private bool _hasValue;
            private int _lastValue;

            public _(IObserver<int> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _hasValue = false;
                _lastValue = default(int);
            }

            public void OnNext(int value)
            {
                if (_hasValue)
                {
                    if (value > _lastValue)
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                    _hasValue = true;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                if (!_hasValue)
                {
                    base._observer.OnError(new InvalidOperationException(Strings_Linq.NO_ELEMENTS));
                }
                else
                {
                    base._observer.OnNext(_lastValue);
                    base._observer.OnCompleted();
                }

                base.Dispose();
            }
        }
    }

    class MaxInt64 : Producer<long>
    {
        private readonly IObservable<long> _source;

        public MaxInt64(IObservable<long> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<long> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<long>, IObserver<long>
        {
            private bool _hasValue;
            private long _lastValue;

            public _(IObserver<long> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _hasValue = false;
                _lastValue = default(long);
            }

            public void OnNext(long value)
            {
                if (_hasValue)
                {
                    if (value > _lastValue)
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                    _hasValue = true;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                if (!_hasValue)
                {
                    base._observer.OnError(new InvalidOperationException(Strings_Linq.NO_ELEMENTS));
                }
                else
                {
                    base._observer.OnNext(_lastValue);
                    base._observer.OnCompleted();
                }

                base.Dispose();
            }
        }
    }

    class MaxDoubleNullable : Producer<double?>
    {
        private readonly IObservable<double?> _source;

        public MaxDoubleNullable(IObservable<double?> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<double?> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<double?>, IObserver<double?>
        {
            private double? _lastValue;

            public _(IObserver<double?> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _lastValue = default(double?);
            }

            public void OnNext(double? value)
            {
                if (!value.HasValue)
                    return;

                if (_lastValue.HasValue)
                {
                    if (value > _lastValue || double.IsNaN((double)value))
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnNext(_lastValue);
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }

    class MaxSingleNullable : Producer<float?>
    {
        private readonly IObservable<float?> _source;

        public MaxSingleNullable(IObservable<float?> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<float?> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<float?>, IObserver<float?>
        {
            private float? _lastValue;

            public _(IObserver<float?> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _lastValue = default(float?);
            }

            public void OnNext(float? value)
            {
                if (!value.HasValue)
                    return;

                if (_lastValue.HasValue)
                {
                    if (value > _lastValue || float.IsNaN((float)value))
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnNext(_lastValue);
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }

    class MaxDecimalNullable : Producer<decimal?>
    {
        private readonly IObservable<decimal?> _source;

        public MaxDecimalNullable(IObservable<decimal?> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<decimal?> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<decimal?>, IObserver<decimal?>
        {
            private decimal? _lastValue;

            public _(IObserver<decimal?> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _lastValue = default(decimal?);
            }

            public void OnNext(decimal? value)
            {
                if (!value.HasValue)
                    return;

                if (_lastValue.HasValue)
                {
                    if (value > _lastValue)
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnNext(_lastValue);
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }

    class MaxInt32Nullable : Producer<int?>
    {
        private readonly IObservable<int?> _source;

        public MaxInt32Nullable(IObservable<int?> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<int?> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<int?>, IObserver<int?>
        {
            private int? _lastValue;

            public _(IObserver<int?> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _lastValue = default(int?);
            }

            public void OnNext(int? value)
            {
                if (!value.HasValue)
                    return;

                if (_lastValue.HasValue)
                {
                    if (value > _lastValue)
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnNext(_lastValue);
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }

    class MaxInt64Nullable : Producer<long?>
    {
        private readonly IObservable<long?> _source;

        public MaxInt64Nullable(IObservable<long?> source)
        {
            _source = source;
        }

        protected override IDisposable Run(IObserver<long?> observer, IDisposable cancel, Action<IDisposable> setSink)
        {
            var sink = new _(observer, cancel);
            setSink(sink);
            return _source.SubscribeSafe(sink);
        }

        class _ : Sink<long?>, IObserver<long?>
        {
            private long? _lastValue;

            public _(IObserver<long?> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                _lastValue = default(long?);
            }

            public void OnNext(long? value)
            {
                if (!value.HasValue)
                    return;

                if (_lastValue.HasValue)
                {
                    if (value > _lastValue)
                    {
                        _lastValue = value;
                    }
                }
                else
                {
                    _lastValue = value;
                }
            }

            public void OnError(Exception error)
            {
                base._observer.OnError(error);
                base.Dispose();
            }

            public void OnCompleted()
            {
                base._observer.OnNext(_lastValue);
                base._observer.OnCompleted();
                base.Dispose();
            }
        }
    }
}
#endif