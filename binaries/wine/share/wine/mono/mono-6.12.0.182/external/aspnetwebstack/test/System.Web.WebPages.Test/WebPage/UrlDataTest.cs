﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Xunit;
using Assert = Microsoft.TestCommon.AssertEx;

namespace System.Web.WebPages.Test
{
    public class UrlDataTest
    {
        [Fact]
        public void UrlDataListConstructorTests()
        {
            Assert.NotNull(new UrlDataList(null));
            Assert.NotNull(new UrlDataList(String.Empty));
            Assert.NotNull(new UrlDataList("abc/foo"));
        }

        [Fact]
        public void AddTest()
        {
            var d = new UrlDataList(null);
            var item = "!!@#$#$";
            Assert.Throws<NotSupportedException>(() => { d.Add(item); }, "The UrlData collection is read-only.");
        }

        [Fact]
        public void ClearTest()
        {
            var d = new UrlDataList(null);
            Assert.Throws<NotSupportedException>(() => { d.Clear(); }, "The UrlData collection is read-only.");
        }

        [Fact]
        public void IndexOfTest()
        {
            var item = "!!@#$#$";
            var item2 = "13l53125";
            var d = new UrlDataList(item + "/" + item2);
            Assert.True(d.IndexOf(item) == 0);
            Assert.True(d.IndexOf(item2) == 1);
        }

        [Fact]
        public void InsertAtTest()
        {
            var d = new UrlDataList("x/y/z");
            Assert.Throws<NotSupportedException>(() => { d.Insert(1, "a"); }, "The UrlData collection is read-only.");
        }

        [Fact]
        public void ContainsTest()
        {
            var item = "!!@#$#$";
            var d = new UrlDataList(item);
            Assert.True(d.Contains(item));
        }

        [Fact]
        public void CopyToTest()
        {
            var d = new UrlDataList("x/y");
            string[] array = new string[2];
            d.CopyTo(array, 0);
            Assert.Equal(array[0], d[0]);
            Assert.Equal(array[1], d[1]);
        }

        [Fact]
        public void GetEnumeratorTest()
        {
            var d = new UrlDataList("x");
            var e = d.GetEnumerator();
            e.MoveNext();
            Assert.Equal("x", e.Current);
        }

        [Fact]
        public void RemoveTest()
        {
            var d = new UrlDataList("x");
            Assert.Throws<NotSupportedException>(() => { d.Remove("x"); }, "The UrlData collection is read-only.");
        }

        [Fact]
        public void RemoveAtTest()
        {
            var d = new UrlDataList("x/y");
            Assert.Throws<NotSupportedException>(() => { d.RemoveAt(0); }, "The UrlData collection is read-only.");
        }

        [Fact]
        public void CountTest()
        {
            var d = new UrlDataList("x");
            Assert.Equal(1, d.Count);
        }

        [Fact]
        public void IsReadOnlyTest()
        {
            var d = new UrlDataList(null);
            Assert.Equal(true, d.IsReadOnly);
        }

        [Fact]
        public void ItemTest()
        {
            var d = new UrlDataList("x/y");
            Assert.Equal("x", d[0]);
            Assert.Equal("y", d[1]);
        }
    }
}
