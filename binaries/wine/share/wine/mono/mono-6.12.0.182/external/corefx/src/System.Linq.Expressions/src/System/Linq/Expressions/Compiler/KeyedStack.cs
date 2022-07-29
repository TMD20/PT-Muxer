// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace System.Linq.Expressions.Compiler
{
    /// <summary>
    /// A simple dictionary of stacks, keyed off a particular type
    /// This is useful for storing free lists of variables
    /// </summary>
    internal sealed class KeyedStack<TKey, TValue> where TValue : class
    {
        private readonly Dictionary<TKey, Stack<TValue>> _data = new Dictionary<TKey, Stack<TValue>>();

        internal void Push(TKey key, TValue value)
        {
            Stack<TValue> stack;
            if (!_data.TryGetValue(key, out stack))
            {
                _data.Add(key, stack = new Stack<TValue>());
            }

            stack.Push(value);
        }

        internal TValue TryPop(TKey key)
        {
            Stack<TValue> stack;
            TValue value;
            return _data.TryGetValue(key, out stack) && stack.TryPop(out value) ? value : null;
        }
    }
}
