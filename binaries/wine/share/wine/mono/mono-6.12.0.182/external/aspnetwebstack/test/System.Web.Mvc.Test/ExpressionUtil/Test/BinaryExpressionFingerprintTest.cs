﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Linq.Expressions;
using System.Reflection;
using Xunit;

namespace System.Web.Mvc.ExpressionUtil.Test
{
    public class BinaryExpressionFingerprintTest
    {
        [Fact]
        public void Properties()
        {
            // Arrange
            ExpressionType expectedNodeType = ExpressionType.Add;
            Type expectedType = typeof(DateTime);
            MethodInfo expectedMethod = typeof(DateTime).GetMethod("op_Addition", new Type[] { typeof(DateTime), typeof(TimeSpan) });

            // Act
            BinaryExpressionFingerprint fingerprint = new BinaryExpressionFingerprint(expectedNodeType, expectedType, expectedMethod);

            // Assert
            Assert.Equal(expectedNodeType, fingerprint.NodeType);
            Assert.Equal(expectedType, fingerprint.Type);
            Assert.Equal(expectedMethod, fingerprint.Method);
        }

        [Fact]
        public void Comparison_Equality()
        {
            // Arrange
            ExpressionType nodeType = ExpressionType.Add;
            Type type = typeof(DateTime);
            MethodInfo method = typeof(DateTime).GetMethod("op_Addition", new Type[] { typeof(DateTime), typeof(TimeSpan) });

            // Act
            BinaryExpressionFingerprint fingerprint1 = new BinaryExpressionFingerprint(nodeType, type, method);
            BinaryExpressionFingerprint fingerprint2 = new BinaryExpressionFingerprint(nodeType, type, method);

            // Assert
            Assert.Equal(fingerprint1, fingerprint2);
            Assert.Equal(fingerprint1.GetHashCode(), fingerprint2.GetHashCode());
        }

        [Fact]
        public void Comparison_Inequality_FingerprintType()
        {
            // Arrange
            ExpressionType nodeType = ExpressionType.Add;
            Type type = typeof(DateTime);
            MethodInfo method = typeof(DateTime).GetMethod("op_Addition", new Type[] { typeof(DateTime), typeof(TimeSpan) });

            // Act
            BinaryExpressionFingerprint fingerprint1 = new BinaryExpressionFingerprint(nodeType, type, method);
            DummyExpressionFingerprint fingerprint2 = new DummyExpressionFingerprint(nodeType, type);

            // Assert
            Assert.NotEqual<ExpressionFingerprint>(fingerprint1, fingerprint2);
        }

        [Fact]
        public void Comparison_Inequality_Method()
        {
            // Arrange
            ExpressionType nodeType = ExpressionType.Add;
            Type type = typeof(DateTime);
            MethodInfo method = typeof(DateTime).GetMethod("op_Addition", new Type[] { typeof(DateTime), typeof(TimeSpan) });

            // Act
            BinaryExpressionFingerprint fingerprint1 = new BinaryExpressionFingerprint(nodeType, type, method);
            BinaryExpressionFingerprint fingerprint2 = new BinaryExpressionFingerprint(nodeType, type, null /* method */);

            // Assert
            Assert.NotEqual(fingerprint1, fingerprint2);
        }

        [Fact]
        public void Comparison_Inequality_Type()
        {
            // Arrange
            ExpressionType nodeType = ExpressionType.Add;
            Type type = typeof(DateTime);
            MethodInfo method = typeof(DateTime).GetMethod("op_Addition", new Type[] { typeof(DateTime), typeof(TimeSpan) });

            // Act
            BinaryExpressionFingerprint fingerprint1 = new BinaryExpressionFingerprint(nodeType, type, method);
            BinaryExpressionFingerprint fingerprint2 = new BinaryExpressionFingerprint(nodeType, typeof(object), method);

            // Assert
            Assert.NotEqual(fingerprint1, fingerprint2);
        }
    }
}
