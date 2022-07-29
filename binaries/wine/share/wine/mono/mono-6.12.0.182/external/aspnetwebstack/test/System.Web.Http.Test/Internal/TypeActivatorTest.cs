﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http.Controllers;
using Microsoft.TestCommon;
using Xunit;
using Xunit.Extensions;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.Internal
{
    public class TypeActivatorTest
    {
        [Fact]
        public void TypeIsCorrect()
        {
            Assert.Type.HasProperties(typeof(TypeActivator), TypeAssert.TypeProperties.IsClass | TypeAssert.TypeProperties.IsStatic);
        }

        public static TheoryDataSet<Type, Type> ValidTypeParameters
        {
            get
            {
                return new TheoryDataSet<Type, Type>
                {
                    { typeof(List<int>), typeof(IList<int>)},
                    { typeof(Dictionary<int, int>), typeof(IDictionary<int, int>)},
                    { typeof(HttpRequestMessage), typeof(HttpRequestMessage)},
                    { typeof(HttpConfiguration), typeof(HttpConfiguration)},
                    { typeof(ReflectedHttpActionDescriptor), typeof(HttpActionDescriptor) }, 
                    { typeof(ApiControllerActionSelector), typeof(IHttpActionSelector)},
                    { typeof(ApiControllerActionInvoker), typeof(IHttpActionInvoker)},
                    { typeof(List<HttpStatusCode>), typeof(IEnumerable<HttpStatusCode>)},
                };
            }
        }

        [Theory]
        [PropertyData("ValidTypeParameters")]
        public void CreateType(Type instanceType, Type baseType)
        {
            // Arrange
            Func<object> instanceDelegate = TypeActivator.Create(instanceType);

            // Act
            object instance = instanceDelegate();

            // Assert
            Assert.IsType(instanceType, instance);
        }

        [Theory]
        [InlineData(typeof(int))]
        [InlineData(typeof(Guid))]
        [InlineData(typeof(HttpStatusCode))]
        [InlineData(typeof(string))]
        [InlineData(typeof(Uri))]
        [InlineData(typeof(IDictionary<object, object>))]
        [InlineData(typeof(List<>))]
        public void CreateTypeInvalidThrowsInvalidArgument(Type type)
        {
            // Value types, interfaces, and open generics cause ArgumentException
            Assert.Throws<ArgumentException>(() => TypeActivator.Create(type));
        }

        [Theory]
        [InlineData(typeof(HttpContent))]
        [InlineData(typeof(HttpActionDescriptor))]
        public void CreateTypeInvalidThrowsInvalidOperation(Type type)
        {
            // Abstract types cause InvalidOperationException
            Assert.Throws<InvalidOperationException>(() => TypeActivator.Create(type));
        }

        [Theory]
        [PropertyData("ValidTypeParameters")]
        public void CreateOfT(Type instanceType, Type baseType)
        {
            // Arrange
            Type activatorType = typeof(TypeActivator);
            MethodInfo createMethodInfo = activatorType.GetMethod("Create", Type.EmptyTypes);
            MethodInfo genericCreateMethodInfo = createMethodInfo.MakeGenericMethod(instanceType);
            Func<object> instanceDelegate = (Func<object>)genericCreateMethodInfo.Invoke(null, null);

            // Act
            object instance = instanceDelegate();

            // Assert
            Assert.IsType(instanceType, instance);
        }

        [Fact]
        public void CreateOfTInvalid()
        {
            // string doesn't have a default ctor
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<string>());

            // Uri doesn't have a default ctor
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<Uri>());

            // HttpContent is abstract
            Assert.Throws<InvalidOperationException>(() => TypeActivator.Create<HttpContent>());

            // HttpActionDescriptor is abstract
            Assert.Throws<InvalidOperationException>(() => TypeActivator.Create<HttpActionDescriptor>());
        }

        [Theory]
        [PropertyData("ValidTypeParameters")]
        public void CreateOfTBase(Type instanceType, Type baseType)
        {
            // Arrange
            Type activatorType = typeof(TypeActivator);
            MethodInfo createMethodInfo = null;
            foreach (MethodInfo methodInfo in activatorType.GetMethods())
            {
                ParameterInfo[] parameterInfo = methodInfo.GetParameters();
                if (methodInfo.Name == "Create" && methodInfo.ContainsGenericParameters && parameterInfo.Length == 1 && parameterInfo[0].ParameterType == typeof(Type))
                {
                    createMethodInfo = methodInfo;
                    break;
                }
            }

            MethodInfo genericCreateMethodInfo = createMethodInfo.MakeGenericMethod(baseType);
            Func<object> instanceDelegate = (Func<object>)genericCreateMethodInfo.Invoke(null, new object[] { instanceType });

            // Act
            object instance = instanceDelegate();

            // Assert
            Assert.IsType(instanceType, instance);
        }

        [Fact]
        public void CreateOfTBaseInvalid()
        {
            // int not being a ref type
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<object>(typeof(int)));

            // GUID is not a ref type
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<object>(typeof(Guid)));

            // HttpStatusCode is not a ref type
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<object>(typeof(HttpStatusCode)));

            // string does not have a default ctor
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<string>(typeof(string)));

            // ObjectContent does not have a default ctor
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<HttpContent>(typeof(ObjectContent)));

            // Base type and instance type flipped
            Assert.Throws<ArgumentException>(() => TypeActivator.Create<ReflectedHttpActionDescriptor>(typeof(HttpActionDescriptor)));
        }
    }
}