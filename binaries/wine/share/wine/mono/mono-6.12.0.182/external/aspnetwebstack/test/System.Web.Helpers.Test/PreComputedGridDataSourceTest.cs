﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Linq;
using Moq;
using Xunit;

namespace System.Web.Helpers.Test
{
    public class PreComputedGridDataSourceTest
    {
        [Fact]
        public void PreSortedDataSourceReturnsRowCountItWasSpecified()
        {
            // Arrange
            int rows = 20;
            var dataSource = new PreComputedGridDataSource(new WebGrid(GetContext()), values: Enumerable.Range(0, 10).Cast<dynamic>(), totalRows: rows);

            // Act and Assert
            Assert.Equal(rows, dataSource.TotalRowCount);
        }

        [Fact]
        public void PreSortedDataSourceReturnsAllRows()
        {
            // Arrange
            var grid = new WebGrid(GetContext());
            var dataSource = new PreComputedGridDataSource(grid: grid, values: Enumerable.Range(0, 10).Cast<dynamic>(), totalRows: 10);

            // Act 
            var rows = dataSource.GetRows(new SortInfo { SortColumn = String.Empty }, 0);

            // Assert
            Assert.Equal(rows.Count, 10);
            Assert.Equal(rows.First().Value, 0);
            Assert.Equal(rows.Last().Value, 9);
        }

        private HttpContextBase GetContext()
        {
            return new Mock<HttpContextBase>().Object;
        }
    }
}
