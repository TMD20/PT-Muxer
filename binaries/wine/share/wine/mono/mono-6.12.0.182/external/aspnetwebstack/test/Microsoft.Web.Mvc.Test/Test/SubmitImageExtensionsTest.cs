﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Web.UnitTestUtil;
using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace Microsoft.Web.Mvc.Test
{
    public class SubmitImageExtensionsTest
    {
        [Fact]
        public void SubmitImageWithEmptyImageSrcThrowsArgumentNullException()
        {
            HtmlHelper html = MvcHelper.GetHtmlHelper(new ViewDataDictionary());
            Assert.ThrowsArgumentNull(() => html.SubmitImage("name", null), "imageSrc");
        }

        [Fact]
        public void SubmitImageWithAttributesWithUnderscores()
        {
            HtmlHelper html = MvcHelper.GetHtmlHelper(new ViewDataDictionary());
            MvcHtmlString button = html.SubmitImage("specified-name", "/mvc.jpg", new { foo_bar = "baz" });
            Assert.Equal("<input foo-bar=\"baz\" id=\"specified-name\" name=\"specified-name\" src=\"/mvc.jpg\" type=\"image\" />", button.ToHtmlString());
        }

        [Fact]
        public void SubmitImageWithTypeAttributeRendersExplicitTypeAttribute()
        {
            HtmlHelper html = MvcHelper.GetHtmlHelper(new ViewDataDictionary());
            MvcHtmlString button = html.SubmitImage("specified-name", "/mvc.jpg", new { type = "not-image" });
            Assert.Equal("<input id=\"specified-name\" name=\"specified-name\" src=\"/mvc.jpg\" type=\"not-image\" />", button.ToHtmlString());
        }

        [Fact]
        public void SubmitImageWithNameAndImageUrlRendersNameAndSrcAttributes()
        {
            HtmlHelper html = MvcHelper.GetHtmlHelper(new ViewDataDictionary());
            MvcHtmlString button = html.SubmitImage("button-name", "/mvc.gif");
            Assert.Equal("<input id=\"button-name\" name=\"button-name\" src=\"/mvc.gif\" type=\"image\" />", button.ToHtmlString());
        }

        [Fact]
        public void SubmitImageWithImageUrlStartingWithTildeRendersAppPath()
        {
            HtmlHelper html = MvcHelper.GetHtmlHelperWithPath(new ViewDataDictionary(), "/app");
            MvcHtmlString button = html.SubmitImage("button-name", "~/mvc.gif");
            Assert.Equal("<input id=\"button-name\" name=\"button-name\" src=\"/$(SESSION)/app/mvc.gif\" type=\"image\" />", button.ToHtmlString());
        }

        [Fact]
        public void SubmitImageWithNameAndIdRendersBothAttributesCorrectly()
        {
            HtmlHelper html = MvcHelper.GetHtmlHelper(new ViewDataDictionary());
            MvcHtmlString button = html.SubmitImage("button-name", "/mvc.png", new { id = "button-id" });
            Assert.Equal("<input id=\"button-id\" name=\"button-name\" src=\"/mvc.png\" type=\"image\" />", button.ToHtmlString());
        }

        [Fact]
        public void SubmitButtonWithNameAndValueSpecifiedAndPassedInAsAttributeChoosesExplicitAttributes()
        {
            HtmlHelper html = MvcHelper.GetHtmlHelper(new ViewDataDictionary());
            MvcHtmlString button = html.SubmitImage("specified-name", "/specified-src.bmp", new RouteValueDictionary(new { name = "name-attribute", src = "src-attribute" }));
            Assert.Equal("<input id=\"specified-name\" name=\"name-attribute\" src=\"src-attribute\" type=\"image\" />", button.ToHtmlString());
        }
    }
}
