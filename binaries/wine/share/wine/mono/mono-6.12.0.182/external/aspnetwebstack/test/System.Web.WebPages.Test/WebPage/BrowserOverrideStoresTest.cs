﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Moq;
using Xunit;

namespace System.Web.WebPages.Test
{
    public class BrowserOverrideStoresTest
    {
        [Fact]
        public void DefaultBrowserOverrideStoreIsCookie()
        {
            // Act & Assert
            Assert.Equal(typeof(CookieBrowserOverrideStore), BrowserOverrideStores.Current.GetType());
        }

        [Fact]
        public void SetBrowserOverrideStoreReturnsSetBrowserOverrideStore()
        {
            // Arrange
            BrowserOverrideStores stores = new BrowserOverrideStores();
            Mock<BrowserOverrideStore> store = new Mock<BrowserOverrideStore>();

            // Act
            stores.CurrentInternal = store.Object;

            // Assert
            Assert.Same(store.Object, stores.CurrentInternal);
        }

        [Fact]
        public void SetBrowserOverrideStoreNullReturnsRequestBrowserOverrideStore()
        {
            //Arrange
            BrowserOverrideStores stores = new BrowserOverrideStores();

            // Act
            stores.CurrentInternal = null;

            // Assert
            Assert.Equal(typeof(RequestBrowserOverrideStore), stores.CurrentInternal.GetType());
        }
    }
}
