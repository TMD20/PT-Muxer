﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using Moq;
using Xunit;

namespace System.Web.WebPages.Test
{
    public class CultureUtilTest
    {
        [Fact]
        public void SetAutoCultureWithNoUserLanguagesDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(null);
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentCulture;

            // Act
            CultureUtil.SetCulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentCulture);
        }

        [Fact]
        public void SetAutoUICultureWithNoUserLanguagesDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(null);
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentUICulture;

            // Act
            CultureUtil.SetUICulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentUICulture);
        }

        [Fact]
        public void SetAutoCultureWithEmptyUserLanguagesDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(Enumerable.Empty<string>());
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentCulture;

            // Act
            CultureUtil.SetCulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentCulture);
        }

        [Fact]
        public void SetAutoUICultureWithEmptyUserLanguagesDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(Enumerable.Empty<string>());
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentUICulture;

            // Act
            CultureUtil.SetUICulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentUICulture);
        }

        [Fact]
        public void SetAutoCultureWithBlankUserLanguagesDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { " " });
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentCulture;

            // Act
            CultureUtil.SetCulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentCulture);
        }

        [Fact]
        public void SetAutoUICultureWithBlankUserLanguagesDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { " " });
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentUICulture;

            // Act
            CultureUtil.SetUICulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentUICulture);
        }

        [Fact]
        public void SetAutoCultureWithInvalidLanguageDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { "aa-AA", "bb-BB", "cc-CC" });
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentCulture;

            // Act
            CultureUtil.SetCulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentCulture);
        }

        [Fact]
        public void SetAutoUICultureWithInvalidLanguageDoesNothing()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { "aa-AA", "bb-BB", "cc-CC" });
            Thread thread = GetThread();
            CultureInfo culture = thread.CurrentUICulture;

            // Act
            CultureUtil.SetUICulture(thread, context, "auto");

            // Assert
            Assert.Equal(culture, thread.CurrentUICulture);
        }

        [Fact]
        public void SetAutoCultureDetectsUserLanguageCulture()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { "en-GB", "en-US", "ar-eg" });
            Thread thread = GetThread();

            // Act
            CultureUtil.SetCulture(thread, context, "auto");

            // Assert
            Assert.Equal(CultureInfo.GetCultureInfo("en-GB"), thread.CurrentCulture);
            Assert.Equal("05/01/1979", new DateTime(1979, 1, 5).ToString("d", thread.CurrentCulture));
        }

        [Fact]
        public void SetAutoUICultureDetectsUserLanguageCulture()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { "en-GB", "en-US", "ar-eg" });
            Thread thread = GetThread();

            // Act
            CultureUtil.SetUICulture(thread, context, "auto");

            // Assert
            Assert.Equal(CultureInfo.GetCultureInfo("en-GB"), thread.CurrentUICulture);
            Assert.Equal("05/01/1979", new DateTime(1979, 1, 5).ToString("d", thread.CurrentUICulture));
        }

        [Fact]
        public void SetAutoCultureUserLanguageWithQParameterCulture()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { "en-GB;q=0.3", "en-US", "ar-eg;q=0.5" });
            Thread thread = GetThread();

            // Act
            CultureUtil.SetCulture(thread, context, "auto");

            // Assert
            Assert.Equal(CultureInfo.GetCultureInfo("en-GB"), thread.CurrentCulture);
            Assert.Equal("05/01/1979", new DateTime(1979, 1, 5).ToString("d", thread.CurrentCulture));
        }

        [Fact]
        public void SetAutoUICultureDetectsUserLanguageWithQParameterCulture()
        {
            // Arrange
            var context = GetContextForSetCulture(new[] { "en-GB;q=0.3", "en-US", "ar-eg;q=0.5" });
            Thread thread = GetThread();

            // Act
            CultureUtil.SetUICulture(thread, context, "auto");

            // Assert
            Assert.Equal(CultureInfo.GetCultureInfo("en-GB"), thread.CurrentUICulture);
            Assert.Equal("05/01/1979", new DateTime(1979, 1, 5).ToString("d", thread.CurrentUICulture));
        }

        [Fact]
        public void SetCultureWithInvalidCultureThrows()
        {
            // Arrange
            var context = GetContextForSetCulture();
            Thread thread = GetThread();

            // Act and Assert
            Assert.Throws<CultureNotFoundException>(() => CultureUtil.SetCulture(thread, context, "sans-culture"));
        }

        [Fact]
        public void SetUICultureWithInvalidCultureThrows()
        {
            // Arrange
            var context = GetContextForSetCulture();
            Thread thread = GetThread();

            // Act and Assert
            Assert.Throws<CultureNotFoundException>(() => CultureUtil.SetUICulture(thread, context, "sans-culture"));
        }

        [Fact]
        public void SetCultureWithValidCulture()
        {
            // Arrange
            var context = GetContextForSetCulture();
            Thread thread = GetThread();

            // Act
            CultureUtil.SetCulture(thread, context, "en-GB");

            // Assert
            Assert.Equal(CultureInfo.GetCultureInfo("en-GB"), thread.CurrentCulture);
            Assert.Equal("05/01/1979", new DateTime(1979, 1, 5).ToString("d", thread.CurrentCulture));
        }

        [Fact]
        public void SetUICultureWithValidCulture()
        {
            // Arrange
            var context = GetContextForSetCulture();
            Thread thread = GetThread();

            // Act
            CultureUtil.SetUICulture(thread, context, "en-GB");

            // Assert
            Assert.Equal(CultureInfo.GetCultureInfo("en-GB"), thread.CurrentUICulture);
            Assert.Equal("05/01/1979", new DateTime(1979, 1, 5).ToString("d", thread.CurrentUICulture));
        }

        private static Thread GetThread()
        {
            return new Thread(() => { });
        }

        private static HttpContextBase GetContextForSetCulture(IEnumerable<string> userLanguages = null)
        {
            Mock<HttpContextBase> contextMock = new Mock<HttpContextBase>();
            contextMock.Setup(context => context.Request.UserLanguages).Returns(userLanguages == null ? null : userLanguages.ToArray());
            return contextMock.Object;
        }
    }
}
