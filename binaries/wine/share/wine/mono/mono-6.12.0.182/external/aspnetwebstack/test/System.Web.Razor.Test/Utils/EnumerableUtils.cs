﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace System.Web.Razor.Test.Utils
{
    public static class EnumerableUtils
    {
        public static void RunPairwise<T, V>(IEnumerable<T> left, IEnumerable<V> right, Action<T, V> action)
        {
            IEnumerator<T> leftEnum = left.GetEnumerator();
            IEnumerator<V> rightEnum = right.GetEnumerator();
            while (leftEnum.MoveNext() && rightEnum.MoveNext())
            {
                action(leftEnum.Current, rightEnum.Current);
            }
        }
    }
}
