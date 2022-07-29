/* 
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using IndexReader = Lucene.Net.Index.IndexReader;
using OpenBitSet = Lucene.Net.Util.OpenBitSet;
using SpanQuery = Lucene.Net.Search.Spans.SpanQuery;

namespace Lucene.Net.Search
{
	
	/// <summary> Constrains search results to only match those which also match a provided
	/// query. Also provides position information about where each document matches
	/// at the cost of extra space compared with the QueryWrapperFilter.
	/// There is an added cost to this above what is stored in a <see cref="QueryWrapperFilter" />.  Namely,
	/// the position information for each matching document is stored.
	/// <p/>
	/// This filter does not cache.  See the <see cref="Lucene.Net.Search.CachingSpanFilter" /> for a wrapper that
	/// caches.
	/// 
	/// 
	/// </summary>
	/// <version>  $Id:$
	/// </version>
	[Serializable]
	public class SpanQueryFilter:SpanFilter
	{
		protected internal SpanQuery internalQuery;
		
		protected internal SpanQueryFilter()
		{
		}
		
		/// <summary>Constructs a filter which only matches documents matching
		/// <c>query</c>.
		/// </summary>
		/// <param name="query">The <see cref="Lucene.Net.Search.Spans.SpanQuery" /> to use as the basis for the Filter.
		/// </param>
		public SpanQueryFilter(SpanQuery query)
		{
			this.internalQuery = query;
		}
		
		public override DocIdSet GetDocIdSet(IndexReader reader)
		{
			SpanFilterResult result = BitSpans(reader);
			return result.DocIdSet;
		}
		
		public override SpanFilterResult BitSpans(IndexReader reader)
		{
			
			OpenBitSet bits = new OpenBitSet(reader.MaxDoc);
			Lucene.Net.Search.Spans.Spans spans = internalQuery.GetSpans(reader);
			IList<SpanFilterResult.PositionInfo> tmp = new List<SpanFilterResult.PositionInfo>(20);
			int currentDoc = - 1;
			SpanFilterResult.PositionInfo currentInfo = null;
			while (spans.Next())
			{
				int doc = spans.Doc();
				bits.Set(doc);
				if (currentDoc != doc)
				{
					currentInfo = new SpanFilterResult.PositionInfo(doc);
					tmp.Add(currentInfo);
					currentDoc = doc;
				}
				currentInfo.AddPosition(spans.Start(), spans.End());
			}
			return new SpanFilterResult(bits, tmp);
		}


	    public virtual SpanQuery Query
	    {
	        get { return internalQuery; }
	    }

	    public override System.String ToString()
		{
			return "SpanQueryFilter(" + internalQuery + ")";
		}
		
		public  override bool Equals(System.Object o)
		{
			return o is SpanQueryFilter && this.internalQuery.Equals(((SpanQueryFilter) o).internalQuery);
		}
		
		public override int GetHashCode()
		{
			return internalQuery.GetHashCode() ^ unchecked((int) 0x923F64B9);
		}
	}
}