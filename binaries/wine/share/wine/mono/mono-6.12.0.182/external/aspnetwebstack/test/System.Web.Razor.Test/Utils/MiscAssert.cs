﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Linq.Expressions;
using Xunit;

namespace System.Web.Razor.Test.Utils
{
    public static class MiscAssert
    {
        public static void AssertBothNullOrPropertyEqual<T>(T expected, T actual, Expression<Func<T, object>> propertyExpr, string objectName)
        {
            // Unpack convert expressions
            Expression expr = propertyExpr.Body;
            while (expr.NodeType == ExpressionType.Convert)
            {
                expr = ((UnaryExpression)expr).Operand;
            }

            string propertyName = ((MemberExpression)expr).Member.Name;
            Func<T, object> property = propertyExpr.Compile();

            if (expected == null)
            {
                Assert.Null(actual);
            }
            else
            {
                Assert.NotNull(actual);
                Assert.Equal(property(expected), property(actual));
            }
        }
    }
}
