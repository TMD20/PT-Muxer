﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Routing;
using Microsoft.Web.UnitTestUtil;
using Moq;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.Mvc.Html.Test
{
    public class ValidationExtensionsTest
    {
        // Validate

        [Fact]
        public void Validate_AddsClientValidationMetadata()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext()
                {
                    FormId = "form_id"
                };
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                htmlHelper.Validate("baz");

                // Assert
                Assert.NotNull(formContext.GetValidationMetadataForField("baz"));
                Assert.Equal(expectedValidationRules, formContext.FieldValidators["baz"].ValidationRules.ToArray());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        [Fact]
        public void Validate_DoesNothingIfClientValidationIsNotEnabled()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
            htmlHelper.ViewContext.FormContext = new FormContext();
            htmlHelper.ViewContext.ClientValidationEnabled = false;

            // Act 
            htmlHelper.Validate("foo");

            // Assert
            Assert.Empty(htmlHelper.ViewContext.FormContext.FieldValidators);
        }

        [Fact]
        public void Validate_DoesNothingIfUnobtrusiveJavaScriptIsEnabled()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
            htmlHelper.ViewContext.FormContext = new FormContext();
            htmlHelper.ViewContext.ClientValidationEnabled = true;
            htmlHelper.ViewContext.UnobtrusiveJavaScriptEnabled = true;

            // Act 
            htmlHelper.Validate("foo");

            // Assert
            Assert.Empty(htmlHelper.ViewContext.FormContext.FieldValidators);
        }

        [Fact]
        public void Validate_ThrowsIfModelNameIsNull()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act & assert
            Assert.ThrowsArgumentNull(
                delegate { htmlHelper.Validate((string)null /* modelName */); }, "modelName");
        }

        [Fact]
        public void ValidateFor_AddsClientValidationMetadata()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext()
                {
                    FormId = "form_id"
                };
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                htmlHelper.ValidateFor(m => m.baz);

                // Assert
                Assert.NotNull(formContext.GetValidationMetadataForField("baz"));
                Assert.Equal(expectedValidationRules, formContext.FieldValidators["baz"].ValidationRules.ToArray());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        // ValidationMessage

        [Fact]
        public void ValidationMessageAllowsEmptyModelName()
        {
            // Arrange
            ViewDataDictionary vdd = new ViewDataDictionary();
            vdd.ModelState.AddModelError("", "some error text");
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(vdd);

            // Act 
            MvcHtmlString html = htmlHelper.ValidationMessage("");

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">some error text</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageReturnsNullForNullModelState()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithNullModelState());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("foo");

            // Assert
            Assert.Null(html);
        }

        [Fact]
        public void ValidationMessageReturnsFirstErrorWithMessage()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act 
            MvcHtmlString html = htmlHelper.ValidationMessage("foo");

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">foo error &lt;1&gt;</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageReturnsGenericMessageInsteadOfExceptionText()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act 
            MvcHtmlString html = htmlHelper.ValidationMessage("quux");

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">The value &#39;quuxValue&#39; is invalid.</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageReturnsNullForInvalidName()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("boo");

            // Assert
            Assert.Null(html);
        }

        [Fact]
        public void ValidationMessageReturnsWithObjectAttributes()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("foo", new { bar = "bar" });

            // Assert
            Assert.Equal(@"<span bar=""bar"" class=""field-validation-error"">foo error &lt;1&gt;</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageReturnsWithObjectAttributesWithUnderscores()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("foo", new { foo_bar = "bar" });

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"" foo-bar=""bar"">foo error &lt;1&gt;</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageReturnsWithCustomMessage()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("foo", "bar error");

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">bar error</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageReturnsWithCustomMessageAndObjectAttributes()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("foo", "bar error", new { baz = "baz" });

            // Assert
            Assert.Equal(@"<span baz=""baz"" class=""field-validation-error"">bar error</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageReturnsWithCustomMessageAndObjectAttributesWithUnderscores()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("foo", "bar error", new { foo_baz = "baz" });

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"" foo-baz=""baz"">bar error</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageThrowsIfModelNameIsNull()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper();

            // Act & Assert
            Assert.ThrowsArgumentNull(
                delegate { htmlHelper.ValidationMessage(null); }, "modelName");
        }

        [Fact]
        public void ValidationMessageWithClientValidation_DefaultMessage_Valid()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext();
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                MvcHtmlString html = htmlHelper.ValidationMessage("baz"); // 'baz' is valid

                // Assert
                Assert.Equal(@"<span class=""field-validation-valid"" id=""baz_validationMessage""></span>", html.ToHtmlString());
                Assert.NotNull(formContext.GetValidationMetadataForField("baz"));
                Assert.Equal("baz_validationMessage", formContext.FieldValidators["baz"].ValidationMessageId);
                Assert.True(formContext.FieldValidators["baz"].ReplaceValidationMessageContents);
                Assert.Equal(expectedValidationRules, formContext.FieldValidators["baz"].ValidationRules.ToArray());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        [Fact]
        public void ValidationMessageWithClientValidation_DefaultMessage_Valid_Unobtrusive()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext();
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.UnobtrusiveJavaScriptEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                MvcHtmlString html = htmlHelper.ValidationMessage("baz"); // 'baz' is valid

                // Assert
                Assert.Equal(@"<span class=""field-validation-valid"" data-valmsg-for=""baz"" data-valmsg-replace=""true""></span>", html.ToHtmlString());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        [Fact]
        public void ValidationMessageWithClientValidation_ExplicitMessage_Valid()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext();
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                MvcHtmlString html = htmlHelper.ValidationMessage("baz", "some explicit message"); // 'baz' is valid

                // Assert
                Assert.Equal(@"<span class=""field-validation-valid"" id=""baz_validationMessage"">some explicit message</span>", html.ToHtmlString());
                Assert.NotNull(formContext.GetValidationMetadataForField("baz"));
                Assert.Equal("baz_validationMessage", formContext.FieldValidators["baz"].ValidationMessageId);
                Assert.False(formContext.FieldValidators["baz"].ReplaceValidationMessageContents);
                Assert.Equal(expectedValidationRules, formContext.FieldValidators["baz"].ValidationRules.ToArray());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        [Fact]
        public void ValidationMessageWithClientValidation_ExplicitMessage_Valid_Unobtrusive()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext();
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.UnobtrusiveJavaScriptEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                MvcHtmlString html = htmlHelper.ValidationMessage("baz", "some explicit message"); // 'baz' is valid

                // Assert
                Assert.Equal(@"<span class=""field-validation-valid"" data-valmsg-for=""baz"" data-valmsg-replace=""false"">some explicit message</span>", html.ToHtmlString());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        [Fact]
        public void ValidationMessageWithModelStateAndNoErrors()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessage("baz");

            // Assert
            Assert.Null(html);
        }

        // ValidationMessageFor

        [Fact]
        public void ValidationMessageForThrowsIfExpressionIsNull()
        {
            // Arrange
            HtmlHelper<object> htmlHelper = MvcHelper.GetHtmlHelper();

            // Act & Assert
            Assert.ThrowsArgumentNull(
                () => htmlHelper.ValidationMessageFor<object, object>(null),
                "expression"
                );
        }

        [Fact]
        public void ValidationMessageForReturnsNullIfModelStateIsNull()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithNullModelState());

            // Act 
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.foo);

            // Assert
            Assert.Null(html);
        }

        [Fact]
        public void ValidationMessageForReturnsFirstErrorWithErrorMessage()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act 
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.foo);

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">foo error &lt;1&gt;</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageForReturnsGenericMessageInsteadOfExceptionText()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act 
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.quux);

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">The value &#39;quuxValue&#39; is invalid.</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageForReturnsWithObjectAttributes()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.foo, null /* validationMessage */, new { bar = "bar" });

            // Assert
            Assert.Equal(@"<span bar=""bar"" class=""field-validation-error"">foo error &lt;1&gt;</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageForReturnsWithObjectAttributesWithUnderscores()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.foo, null /* validationMessage */, new { foo_bar = "bar" });

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"" foo-bar=""bar"">foo error &lt;1&gt;</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageForReturnsWithCustomMessage()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.foo, "bar error");

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">bar error</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageForReturnsWithCustomMessageAndObjectAttributes()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.foo, "bar error", new { baz = "baz" });

            // Assert
            Assert.Equal(@"<span baz=""baz"" class=""field-validation-error"">bar error</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageForWithClientValidation()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext();
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.baz);

                // Assert
                Assert.Equal(@"<span class=""field-validation-valid"" id=""baz_validationMessage""></span>", html.ToHtmlString());
                Assert.NotNull(formContext.GetValidationMetadataForField("baz"));
                Assert.Equal("baz_validationMessage", formContext.FieldValidators["baz"].ValidationMessageId);
                Assert.Equal(expectedValidationRules, formContext.FieldValidators["baz"].ValidationRules.ToArray());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        [Fact]
        public void ValidationMessageForWithClientValidation_Unobtrusive()
        {
            var originalProviders = ModelValidatorProviders.Providers.ToArray();
            ModelValidatorProviders.Providers.Clear();

            try
            {
                // Arrange
                HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
                FormContext formContext = new FormContext();
                htmlHelper.ViewContext.ClientValidationEnabled = true;
                htmlHelper.ViewContext.UnobtrusiveJavaScriptEnabled = true;
                htmlHelper.ViewContext.FormContext = formContext;

                ModelClientValidationRule[] expectedValidationRules = new ModelClientValidationRule[]
                {
                    new ModelClientValidationRule() { ValidationType = "ValidationRule1" },
                    new ModelClientValidationRule() { ValidationType = "ValidationRule2" }
                };

                Mock<ModelValidator> mockValidator = new Mock<ModelValidator>(ModelMetadata.FromStringExpression("", htmlHelper.ViewContext.ViewData), htmlHelper.ViewContext);
                mockValidator.Setup(v => v.GetClientValidationRules())
                    .Returns(expectedValidationRules);
                Mock<ModelValidatorProvider> mockValidatorProvider = new Mock<ModelValidatorProvider>();
                mockValidatorProvider.Setup(vp => vp.GetValidators(It.IsAny<ModelMetadata>(), It.IsAny<ControllerContext>()))
                    .Returns(new[] { mockValidator.Object });
                ModelValidatorProviders.Providers.Add(mockValidatorProvider.Object);

                // Act
                MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.baz);

                // Assert
                Assert.Equal(@"<span class=""field-validation-valid"" data-valmsg-for=""baz"" data-valmsg-replace=""true""></span>", html.ToHtmlString());
            }
            finally
            {
                ModelValidatorProviders.Providers.Clear();
                foreach (var provider in originalProviders)
                {
                    ModelValidatorProviders.Providers.Add(provider);
                }
            }
        }

        [Fact]
        public void ValidationMessageForWithModelStateAndNoErrors()
        {
            // Arrange
            HtmlHelper<ValidationModel> htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationMessageFor(m => m.baz);

            // Assert
            Assert.Null(html);
        }

        // ValidationSummary

        [Fact]
        public void ValidationSummary()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary();

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors""><ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryAddsIdIfClientValidationEnabled()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
            htmlHelper.ViewContext.FormContext = new FormContext();
            htmlHelper.ViewContext.ClientValidationEnabled = true;

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary();

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors"" id=""validationSummary""><ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>"
                         , html.ToHtmlString());
            Assert.Equal("validationSummary", htmlHelper.ViewContext.FormContext.ValidationSummaryId);
        }

        [Fact]
        public void ValidationSummaryDoesNotAddIdIfUnobtrusiveJavaScriptEnabled()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
            htmlHelper.ViewContext.FormContext = new FormContext();
            htmlHelper.ViewContext.ClientValidationEnabled = true;
            htmlHelper.ViewContext.UnobtrusiveJavaScriptEnabled = true;

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary();

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors"" data-valmsg-summary=""true""><ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithDictionary()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
            RouteValueDictionary htmlAttributes = new RouteValueDictionary();
            htmlAttributes["class"] = "my-class";

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary(null /* message */, htmlAttributes);

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors my-class""><ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithDictionaryAndMessage()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());
            RouteValueDictionary htmlAttributes = new RouteValueDictionary();
            htmlAttributes["class"] = "my-class";

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary("This is my message.", htmlAttributes);

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors my-class""><span>This is my message.</span>
<ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithNoErrors_ReturnsNullIfClientValidationDisabled()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(new ViewDataDictionary());

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary();

            // Assert
            Assert.Null(html);
        }

        [Fact]
        public void ValidationSummaryWithNoErrors_EmptyUlIfClientValidationEnabled()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(new ViewDataDictionary());
            htmlHelper.ViewContext.ClientValidationEnabled = true;
            htmlHelper.ViewContext.FormContext = new FormContext();

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary();

            // Assert
            Assert.Equal(@"<div class=""validation-summary-valid"" id=""validationSummary""><ul><li style=""display:none""></li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithObjectAttributes()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary(null /* message */, new { baz = "baz" });

            // Assert
            Assert.Equal(@"<div baz=""baz"" class=""validation-summary-errors""><ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithObjectAttributesWithUnderscores()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary(null /* message */, new { foo_baz = "baz" });

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors"" foo-baz=""baz""><ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithObjectAttributesAndMessage()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary("This is my message.", new { baz = "baz" });

            // Assert
            Assert.Equal(@"<div baz=""baz"" class=""validation-summary-errors""><span>This is my message.</span>
<ul><li>foo error &lt;1&gt;</li>
<li>foo error 2</li>
<li>bar error &lt;1&gt;</li>
<li>bar error 2</li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithNoModelErrors()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary(true /* excludePropertyErrors */, "This is my message.");

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors""><span>This is my message.</span>
<ul><li style=""display:none""></li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithOnlyModelErrors()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelAndPropertyErrors());

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary(true /* excludePropertyErrors */, "This is my message.");

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors""><span>This is my message.</span>
<ul><li>Something is wrong.</li>
<li>Something else is also wrong.</li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationSummaryWithOnlyModelErrorsAndPrefix()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors("MyPrefix"));

            // Act
            MvcHtmlString html = htmlHelper.ValidationSummary(true /* excludePropertyErrors */, "This is my message.");

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors""><span>This is my message.</span>
<ul><li style=""display:none""></li>
</ul></div>"
                         , html.ToHtmlString());
        }

        [Fact]
        public void ValidationMessageWithPrefix()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelErrors("MyPrefix"));

            // Act 
            MvcHtmlString html = htmlHelper.ValidationMessage("foo");

            // Assert
            Assert.Equal(@"<span class=""field-validation-error"">foo error &lt;1&gt;</span>", html.ToHtmlString());
        }

        [Fact]
        public void ValidationErrorOrdering()
        {
            // Arrange
            HtmlHelper htmlHelper = MvcHelper.GetHtmlHelper(GetViewDataWithModelWithDisplayOrderErrors());

            // Act 
            MvcHtmlString html = htmlHelper.ValidationSummary();

            // Assert
            Assert.Equal(@"<div class=""validation-summary-errors""><ul><li>Error 1</li>
<li>Error 2</li>
<li>Error 3</li>
<li>Error 4</li>
</ul></div>", html.ToHtmlString());

        }

        private class ValidationModel
        {
            public string foo { get; set; }
            public string bar { get; set; }
            public string baz { get; set; }
            public string quux { get; set; }
        }

        public class ModelWithOrdering
        {
            [Required]
            [Display(Order = 2)]
            public int Second { get; set; }

            [Required]
            [Display(Order = 1)]
            public string First { get; set; }

            [Required]
            [Display(Order = 4)]
            public string Fourth { get; set; }

            [Required]
            [Display(Order = 3)]
            public string Third { get; set; }
        }

        private static ViewDataDictionary<ValidationModel> GetViewDataWithNullModelState()
        {
            ViewDataDictionary<ValidationModel> viewData = new ViewDataDictionary<ValidationModel>();
            viewData.ModelState["foo"] = null;
            return viewData;
        }

        private static ViewDataDictionary<ValidationModel> GetViewDataWithModelErrors()
        {
            ViewDataDictionary<ValidationModel> viewData = new ViewDataDictionary<ValidationModel>();
            ModelState modelStateFoo = new ModelState();
            ModelState modelStateBar = new ModelState();
            ModelState modelStateBaz = new ModelState();

            modelStateFoo.Errors.Add(new ModelError(new InvalidOperationException("foo error from exception")));
            modelStateFoo.Errors.Add(new ModelError("foo error <1>"));
            modelStateFoo.Errors.Add(new ModelError("foo error 2"));
            modelStateBar.Errors.Add(new ModelError("bar error <1>"));
            modelStateBar.Errors.Add(new ModelError("bar error 2"));

            viewData.ModelState["foo"] = modelStateFoo;
            viewData.ModelState["bar"] = modelStateBar;
            viewData.ModelState["baz"] = modelStateBaz;

            viewData.ModelState.SetModelValue("quux", new ValueProviderResult(null, "quuxValue", null));
            viewData.ModelState.AddModelError("quux", new InvalidOperationException("Some error text."));
            return viewData;
        }

        private static ViewDataDictionary<ValidationModel> GetViewDataWithModelAndPropertyErrors()
        {
            ViewDataDictionary<ValidationModel> viewData = new ViewDataDictionary<ValidationModel>();
            ModelState modelStateFoo = new ModelState();
            ModelState modelStateBar = new ModelState();
            ModelState modelStateBaz = new ModelState();
            modelStateFoo.Errors.Add(new ModelError("foo error <1>"));
            modelStateFoo.Errors.Add(new ModelError("foo error 2"));
            modelStateBar.Errors.Add(new ModelError("bar error <1>"));
            modelStateBar.Errors.Add(new ModelError("bar error 2"));
            viewData.ModelState["foo"] = modelStateFoo;
            viewData.ModelState["bar"] = modelStateBar;
            viewData.ModelState["baz"] = modelStateBaz;
            viewData.ModelState.SetModelValue("quux", new ValueProviderResult(null, "quuxValue", null));
            viewData.ModelState.AddModelError("quux", new InvalidOperationException("Some error text."));
            viewData.ModelState.AddModelError(String.Empty, "Something is wrong.");
            viewData.ModelState.AddModelError(String.Empty, "Something else is also wrong.");
            return viewData;
        }

        private static ViewDataDictionary<ValidationModel> GetViewDataWithModelErrors(string prefix)
        {
            ViewDataDictionary<ValidationModel> viewData = new ViewDataDictionary<ValidationModel>();
            viewData.TemplateInfo.HtmlFieldPrefix = prefix;
            ModelState modelStateFoo = new ModelState();
            ModelState modelStateBar = new ModelState();
            ModelState modelStateBaz = new ModelState();
            modelStateFoo.Errors.Add(new ModelError("foo error <1>"));
            modelStateFoo.Errors.Add(new ModelError("foo error 2"));
            modelStateBar.Errors.Add(new ModelError("bar error <1>"));
            modelStateBar.Errors.Add(new ModelError("bar error 2"));
            viewData.ModelState[prefix + ".foo"] = modelStateFoo;
            viewData.ModelState[prefix + ".bar"] = modelStateBar;
            viewData.ModelState[prefix + ".baz"] = modelStateBaz;
            viewData.ModelState.SetModelValue(prefix + ".quux", new ValueProviderResult(null, "quuxValue", null));
            viewData.ModelState.AddModelError(prefix + ".quux", new InvalidOperationException("Some error text."));
            return viewData;
        }


        private static ViewDataDictionary<ModelWithOrdering> GetViewDataWithModelWithDisplayOrderErrors()
        {
            ViewDataDictionary<ModelWithOrdering> viewData = new ViewDataDictionary<ModelWithOrdering>();

            var model = new ModelWithOrdering();

            // Error names for each property on ModelWithOrdering. 
            viewData.ModelState.AddModelError("First", "Error 1");
            viewData.ModelState.AddModelError("Second", "Error 2");
            viewData.ModelState.AddModelError("Third", "Error 3");
            viewData.ModelState.AddModelError("Fourth", "Error 4");

            return viewData;
        }
    }
}
