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

using IndexReader = Lucene.Net.Index.IndexReader;
using DocIdBitSet = Lucene.Net.Util.DocIdBitSet;

namespace Lucene.Net.Search
{
	
	/// <summary>Abstract base class for restricting which documents may be returned during searching.</summary>
	[Serializable]
	public abstract class Filter
	{
	    ///<summary>
	    ///  <para>Creates a <see cref="DocIdSet" /> enumerating the documents that should be
	    ///  permitted in search results. <b>NOTE:</b> null can be
	    ///  returned if no documents are accepted by this Filter.</para>
	    ///  <p/>
	    ///  <para>Note: This method will be called once per segment in
	    ///  the index during searching.  The returned <see cref="DocIdSet" />
	    ///  must refer to document IDs for that segment, not for
	    ///  the top-level reader.</para>
	    ///</summary>
	    /// <returns> a DocIdSet that provides the documents which should be permitted or
	    /// prohibited in search results. <b>NOTE:</b> null can be returned if
	    /// no documents will be accepted by this Filter.
	    /// </returns>
	    /// <param name="reader">
	    /// A <see cref="IndexReader" /> instance opened on the index currently
	    /// searched on. Note, it is likely that the provided reader does not
	    /// represent the whole underlying index i.e. if the index has more than
	    /// one segment the given reader only represents a single segment.
	    /// </param>
	    /// <seealso cref="DocIdBitSet">
	    /// </seealso>
	    public abstract DocIdSet GetDocIdSet(IndexReader reader);
	}
}