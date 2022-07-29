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

namespace Lucene.Net.Search
{
	/// <summary>  The results of a SpanQueryFilter.  Wraps the BitSet and the position information from the SpanQuery
	/// 
	/// <p/>
	/// NOTE: This API is still experimental and subject to change. 
	/// </summary>
	public class SpanFilterResult
	{
		private DocIdSet docIdSet;
		private IList<PositionInfo> positions; //Spans spans;
		
		/// <summary> </summary>
		/// <param name="docIdSet">The DocIdSet for the Filter
		/// </param>
		/// <param name="positions">A List of <see cref="Lucene.Net.Search.SpanFilterResult.PositionInfo" /> objects
		/// </param>
		public SpanFilterResult(DocIdSet docIdSet, IList<PositionInfo> positions)
		{
			this.docIdSet = docIdSet;
			this.positions = positions;
		}

	    /// <summary> The first entry in the array corresponds to the first "on" bit.
	    /// Entries are increasing by document order
	    /// </summary>
	    /// <value> A List of PositionInfo objects </value>
	    public virtual IList<PositionInfo> Positions
	    {
	        get { return positions; }
	    }

	    /// <summary>Returns the docIdSet </summary>
	    public virtual DocIdSet DocIdSet
	    {
	        get { return docIdSet; }
	    }

	    public class PositionInfo
		{
			private int doc;
            private IList<StartEnd> positions;
			
			
			public PositionInfo(int doc)
			{
				this.doc = doc;
				positions = new List<StartEnd>();
			}
			
			public virtual void  AddPosition(int start, int end)
			{
				positions.Add(new StartEnd(start, end));
			}

	        public virtual int Doc
	        {
	            get { return doc; }
	        }

	        /// <summary> </summary>
	        /// <value> A List of &lt;see cref=&quot;Lucene.Net.Search.SpanFilterResult.StartEnd&quot; /&gt; objects </value>
	        public virtual IList<StartEnd> Positions
	        {
	            get { return positions; }
	        }
		}
		
		public class StartEnd
		{
			private int start;
			private int end;
			
			
			public StartEnd(int start, int end)
			{
				this.start = start;
				this.end = end;
			}

		    /// <summary> </summary>
		    /// <value> The end position of this match </value>
		    public virtual int End
		    {
		        get { return end; }
		    }

		    /// <summary> The Start position</summary>
		    /// <value> The start position of this match </value>
		    public virtual int Start
		    {
		        get { return start; }
		    }
		}
	}
}