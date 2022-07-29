﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.ValueProviders;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Http.ModelBinding
{
    // These tests primarily focus on getting the right binding contract. They don't actually execute the contract. 
    public class DefaultActionValueBinderTest
    {
        [Fact]
        public void BindValuesAsync_Throws_Null_ActionDescriptor()
        {
            // Arrange
            HttpActionDescriptor actionDescriptor = new ReflectedHttpActionDescriptor { MethodInfo = (MethodInfo)MethodInfo.GetCurrentMethod() };
            
            // Act and Assert
            Assert.ThrowsArgumentNull(
                () => new DefaultActionValueBinder().GetBinding(null),
                "actionDescriptor");
        }

        private void Action_Int(int id) { }

        [Fact]
        public void Check_Int_Is_ModelBound()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Int"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
        }

        private void Action_Int_FromUri([FromUri] int id) { }

        [Fact]
        public void Check_Explicit_Int_Is_ModelBound()
        {
            // Even though int is implicitly model bound, still ok to specify it explicitly
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Int_FromUri"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
        }

        // All types in this signature are model bound
        private void Action_SimpleTypes(char ch, Byte b, Int16 i16, UInt16 u16, Int32 i32, UInt32 u32, Int64 i64, UInt64 u64, string s, DateTime d, Decimal dec, Guid g, DateTimeOffset dateTimeOffset, TimeSpan timespan) { }

        [Fact]
        public void Check_SimpleTypes_Are_ModelBound()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_SimpleTypes"));

            for(int i = 0; i < binding.ParameterBindings.Length; i++)
            {
                AssertIsModelBound(binding, 0);
            }        
        }

        private void Action_ComplexTypeWithStringConverter(ComplexTypeWithStringConverter x) { }

        [Fact]
        public void Check_String_TypeConverter_Is_ModelBound()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_ComplexTypeWithStringConverter"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);            
        }

        private void Action_ComplexTypeWithStringConverter_Body_Override([FromBody] ComplexTypeWithStringConverter x) { }

        [Fact]
        public void Check_String_TypeConverter_With_Body_Override()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_ComplexTypeWithStringConverter_Body_Override"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsBody(binding, 0);
        }

        private void Action_NullableInt(Nullable<int> id) { }

        [Fact]
        public void Check_NullableInt_Is_ModelBound()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_NullableInt"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
        }

        private void Action_Nullable_ValueType(Nullable<ComplexValueType> id) { }

        [Fact]
        public void Check_Nullable_ValueType_Is_FromBody()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();
                        
            var binding = binder.GetBinding(GetAction("Action_Nullable_ValueType"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsBody(binding, 0);
        }


        private void Action_IntArray(int[] arrayFrombody) { }

        [Fact]
        public void Check_IntArray_Is_FromBody()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_IntArray"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsBody(binding, 0);
        }


        private void Action_SimpleType_Body([FromBody] int i) { }

        [Fact]
        public void Check_SimpleType_Body()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_SimpleType_Body"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsBody(binding, 0);
        }

        private void Action_Empty() { }

        [Fact]
        public void Check_Empty_Action()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Empty"));

            Assert.NotNull(binding.ParameterBindings);
            Assert.Equal(0, binding.ParameterBindings.Length);            
        }

        private void Action_String_String(string s1, string s2) { }

        [Fact]
        public void Check_String_String_IsModelBound()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_String_String"));

            Assert.Equal(2, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
            AssertIsModelBound(binding, 1);
        }

        private void Action_Complex_Type(ComplexType complex) { }

        [Fact]
        public void Check_Complex_Type_FromBody()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Complex_Type"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsBody(binding, 0);            
        }

        private void Action_Complex_ValueType(ComplexValueType complex) { }

        [Fact]
        public void Check_Complex_ValueType_FromBody()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Complex_ValueType"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsBody(binding, 0);
        }

        private void Action_Default_Custom_Model_Binder([ModelBinder] ComplexType complex) { }

        [Fact]
        public void Check_Customer_Binder()
        {
            // Mere presence of a ModelBinder attribute means the type is model bound.

            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Default_Custom_Model_Binder"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
        }

        private void Action_Complex_Type_Uri([FromUri] ComplexType complex) { }

        [Fact]
        public void Check_Complex_Type_FromUri()
        {
            // [FromUri] is just a specific instance of ModelBinder attribute
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Complex_Type_Uri"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
        }

        private void Action_Two_Complex_Types(ComplexType complexBody1, ComplexType complexBody2) { }

        [Fact]
        public void Check_Two_Complex_Types_FromBody()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            // It's illegal to have multiple parameters from the body. 
            // But we should still be able to get a binding for it. We just can't execute it. 
            var binding = binder.GetBinding(GetAction("Action_Two_Complex_Types"));
                        
            Assert.Equal(2, binding.ParameterBindings.Length);
            AssertIsError(binding, 0);
            AssertIsError(binding, 1);
        }

        private void Action_Complex_Type_UriAndBody([FromUri] ComplexType complexUri, ComplexType complexBody) { }

        [Fact]
        public void Check_Complex_Type_FromBody_And_FromUri()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Complex_Type_UriAndBody"));

            Assert.Equal(2, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
            AssertIsBody(binding, 1);
        }

        private void Action_CancellationToken(CancellationToken ct) { }

        [Fact]
        public void Check_Cancellation_Token()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_CancellationToken"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsCancellationToken(binding, 0);
        }

        private void Action_CustomModelBinder_On_Parameter_WithProvider([ModelBinder(typeof(CustomModelBinderProvider))] ComplexType complex) { }

        [Fact]
        public void Check_CustomModelBinder_On_Parameter()
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Services.ReplaceRange(typeof(ValueProviderFactory), new ValueProviderFactory[] {
                new CustomValueProviderFactory(),
            });

            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_CustomModelBinder_On_Parameter_WithProvider", config));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);

            ModelBinderParameterBinding p = (ModelBinderParameterBinding) binding.ParameterBindings[0];
            Assert.IsType<CustomModelBinderProvider>(p.ModelBinderProvider);

            // Since the ModelBinderAttribute didn't specify the valueproviders, we should pull those from config.
            Assert.Equal(1, p.ValueProviderFactories.Count());
            Assert.IsType<CustomValueProviderFactory>(p.ValueProviderFactories.First());
        }

        // Model binder attribute is on the type's declaration.
        private void Action_ComplexParameter_With_ModelBinder(ComplexTypeWithModelBinder complex) { }

        [Fact]
        public void Check_Parameter_With_ModelBinder_Attribute_On_Type()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_ComplexParameter_With_ModelBinder"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsModelBound(binding, 0);
        }

        private void Action_Conflicting_Attributes([FromBody][FromUri] int i) { }

        [Fact]
        public void Error_Conflicting_Attributes()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Conflicting_Attributes"));

            // Have 2 attributes that conflict with each other. Still get the contract, but it has an error in it. 
            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsError(binding, 0);
        }

        private void Action_HttpContent_Parameter(HttpContent c) { }

        [Fact]
        public void Check_HttpContent()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_HttpContent_Parameter"));
                        
            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsError(binding, 0);
        }

        private void Action_Derived_HttpContent_Parameter(StreamContent c) { }

        [Fact]
        public void Check_Derived_HttpContent()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Derived_HttpContent_Parameter"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsError(binding, 0);
        }

        private void Action_Request_Parameter(HttpRequestMessage request) { }

        [Fact]
        public void Check_Request_Parameter()
        {
            DefaultActionValueBinder binder = new DefaultActionValueBinder();

            var binding = binder.GetBinding(GetAction("Action_Request_Parameter"));

            Assert.Equal(1, binding.ParameterBindings.Length);
            AssertIsCustomBinder<HttpRequestParameterBinding>(binding, 0);
        }
        


        // Assert that the binding contract says the given parameter comes from the body
        private void AssertIsBody(HttpActionBinding binding, int paramIdx)
        {
            HttpParameterBinding p = binding.ParameterBindings[paramIdx];
            Assert.NotNull(p);
            Assert.True(p.IsValid);
            Assert.True(p.WillReadBody);            
        }

        // Assert that the binding contract says the given parameter is not from the body (will be handled by model binding)
        private void AssertIsModelBound(HttpActionBinding binding, int paramIdx)
        {
            HttpParameterBinding p = binding.ParameterBindings[paramIdx];
            Assert.NotNull(p);
            Assert.IsType<ModelBinderParameterBinding>(p);
            Assert.True(p.IsValid);
            Assert.False(p.WillReadBody);   
        }

        // Assert that the binding contract says the given parameter will be bound to the cancellation token. 
        private void AssertIsCancellationToken(HttpActionBinding binding, int paramIdx)
        {
            AssertIsCustomBinder<CancellationTokenParameterBinding>(binding, paramIdx);            
        }

        private void AssertIsError(HttpActionBinding binding, int paramIdx)
        {
            HttpParameterBinding p = binding.ParameterBindings[paramIdx];
            Assert.NotNull(p);
            Assert.False(p.IsValid);
            Assert.False(p.WillReadBody);   
        }

        private void AssertIsCustomBinder<T>(HttpActionBinding binding, int paramIdx)
        {           
            HttpParameterBinding p = binding.ParameterBindings[paramIdx];
            Assert.NotNull(p);
            Assert.IsType<T>(p);
            Assert.True(p.IsValid);
            Assert.False(p.WillReadBody);   
        }


        // Helper to get an ActionDescriptor for a method name. 
        private HttpActionDescriptor GetAction(string name)
        {
            return GetAction(name, new HttpConfiguration());
        }

        private HttpActionDescriptor GetAction(string name, HttpConfiguration config)
        {
            MethodInfo method = this.GetType().GetMethod(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            Assert.NotNull(method);
            return new ReflectedHttpActionDescriptor { MethodInfo = method, Configuration = config };
        }

        // Complex type to use with tests
        class ComplexType
        {
        }

        struct ComplexValueType
        {
        }

        // Complex type to use with tests
        [ModelBinder]
        class ComplexTypeWithModelBinder
        {
        }

        // Add Type converter for string, which causes the type to be viewed as a Simple type. 
        [TypeConverter(typeof(MyTypeConverter))]
        public class ComplexTypeWithStringConverter
        {
            public string Data { get; set; }
            public ComplexTypeWithStringConverter(string data)
            {
                Data = data;
            }
        }

        // A string type converter
        public class MyTypeConverter : TypeConverter
        {
            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == typeof(string))
                {
                    return true;
                }
                return base.CanConvertFrom(context, sourceType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
                if (value is string)
                {
                    return new ComplexTypeWithStringConverter((string)value);
                }

                return base.ConvertFrom(context, culture, value);
            }
        }

        class CustomModelBinderProvider : ModelBinderProvider
        {
            public override IModelBinder GetBinder(HttpActionContext actionContext, ModelBindingContext bindingContext)
            {
                throw new NotImplementedException();
            }
        }
        class CustomValueProviderFactory : ValueProviderFactory
        {
            public override IValueProvider GetValueProvider(HttpActionContext actionContext)
            {
                throw new NotImplementedException();
            }
        }
    }   
}
