﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace System.Web.Razor.Utils
{
    internal static class EnumUtil
    {
        public static IEnumerable<T> Single<T>(T item)
        {
            yield return item;
        }

        public static IEnumerable<T> Prepend<T>(T item, IEnumerable<T> enumerable)
        {
            yield return item;
            foreach (T t in enumerable)
            {
                yield return t;
            }
        }
    }
}
