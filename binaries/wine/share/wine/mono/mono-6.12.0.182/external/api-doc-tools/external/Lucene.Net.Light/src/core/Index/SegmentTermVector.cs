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

namespace Lucene.Net.Index
{
	
	
	class SegmentTermVector : ITermFreqVector
	{
		private System.String field;
		private System.String[] terms;
		private int[] termFreqs;
		
		internal SegmentTermVector(System.String field, System.String[] terms, int[] termFreqs)
		{
			this.field = field;
			this.terms = terms;
			this.termFreqs = termFreqs;
		}

	    /// <summary> </summary>
	    /// <value> The number of the field this vector is associated with </value>
	    public virtual string Field
	    {
	        get { return field; }
	    }

	    public override System.String ToString()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append('{');
			sb.Append(field).Append(": ");
			if (terms != null)
			{
				for (int i = 0; i < terms.Length; i++)
				{
					if (i > 0)
						sb.Append(", ");
					sb.Append(terms[i]).Append('/').Append(termFreqs[i]);
				}
			}
			sb.Append('}');
			
			return sb.ToString();
		}

	    public virtual int Size
	    {
	        get { return terms == null ? 0 : terms.Length; }
	    }

	    public virtual System.String[] GetTerms()
		{
			return terms;
		}
		
		public virtual int[] GetTermFrequencies()
		{
			return termFreqs;
		}
		
		public virtual int IndexOf(System.String termText)
		{
			if (terms == null)
				return - 1;
            int res = System.Array.BinarySearch(terms, termText, System.StringComparer.Ordinal);
			return res >= 0?res:- 1;
		}
		
		public virtual int[] IndexesOf(System.String[] termNumbers, int start, int len)
		{
			// TODO: there must be a more efficient way of doing this.
			//       At least, we could advance the lower bound of the terms array
			//       as we find valid indexes. Also, it might be possible to leverage
			//       this even more by starting in the middle of the termNumbers array
			//       and thus dividing the terms array maybe in half with each found index.
			int[] res = new int[len];
			
			for (int i = 0; i < len; i++)
			{
				res[i] = IndexOf(termNumbers[start + i]);
			}
			return res;
		}
	}
}