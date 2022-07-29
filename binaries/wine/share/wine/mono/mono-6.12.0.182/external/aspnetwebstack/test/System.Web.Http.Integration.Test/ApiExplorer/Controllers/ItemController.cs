﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Http.ApiExplorer
{
    public class ItemController : ApiController
    {
        public Item GetItem(string name, int series)
        {
            return new Item()
            {
                Name = name,
                Series = series
            };
        }

        [HttpPost]
        [HttpPut]
        public Item PostItem(Item item)
        {
            return item;
        }

        [HttpDelete]
        public void RemoveItem(int id)
        {
        }

        public class Item
        {
            public int Series { get; set; }
            public string Name { get; set; }
        }
    }
}
