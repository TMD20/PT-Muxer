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
using FieldCache = Lucene.Net.Search.FieldCache;

namespace Lucene.Net.Search.Function
{
	
	/// <summary> Expert: obtains float field values from the 
	/// <see cref="Lucene.Net.Search.FieldCache">FieldCache</see>
	/// using <c>getFloats()</c> and makes those values 
	/// available as other numeric types, casting as needed.
	/// 
	/// <p/><font color="#FF0000">
	/// WARNING: The status of the <b>Search.Function</b> package is experimental. 
	/// The APIs introduced here might change in the future and will not be 
	/// supported anymore in such a case.</font>
	/// 
	/// </summary>
	/// <seealso cref="Lucene.Net.Search.Function.FieldCacheSource"> for requirements"
	/// on the field.
	/// 
	/// <p/><b>NOTE</b>: with the switch in 2.9 to segment-based
    /// searching, if <see cref="FieldCacheSource.GetValues" /> is invoked with a
	/// composite (multi-segment) reader, this can easily cause
	/// double RAM usage for the values in the FieldCache.  It's
	/// best to switch your application to pass only atomic
	/// (single segment) readers to this API.<p/>
	/// </seealso>
	[Serializable]
	public class FloatFieldSource:FieldCacheSource
	{
		private class AnonymousClassDocValues:DocValues
		{
			public AnonymousClassDocValues(float[] arr, FloatFieldSource enclosingInstance)
			{
				InitBlock(arr, enclosingInstance);
			}
			private void  InitBlock(float[] arr, FloatFieldSource enclosingInstance)
			{
				this.arr = arr;
				this.enclosingInstance = enclosingInstance;
			}
			private float[] arr;
			private FloatFieldSource enclosingInstance;
			public FloatFieldSource Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			/*(non-Javadoc) <see cref="Lucene.Net.Search.Function.DocValues.floatVal(int) */
			public override float FloatVal(int doc)
			{
				return arr[doc];
			}
			/*(non-Javadoc) <see cref="Lucene.Net.Search.Function.DocValues.toString(int) */
			public override System.String ToString(int doc)
			{
				return Enclosing_Instance.Description() + '=' + arr[doc];
			}
			/*(non-Javadoc) <see cref="Lucene.Net.Search.Function.DocValues.getInnerArray() */

            protected internal override object InnerArray
		    {
		        get { return arr; }
		    }
		}
		private Lucene.Net.Search.FloatParser parser;
		
		/// <summary> Create a cached float field source with default string-to-float parser. </summary>
		public FloatFieldSource(System.String field):this(field, null)
		{
		}
		
		/// <summary> Create a cached float field source with a specific string-to-float parser. </summary>
		public FloatFieldSource(System.String field, Lucene.Net.Search.FloatParser parser):base(field)
		{
			this.parser = parser;
		}
		
		/*(non-Javadoc) <see cref="Lucene.Net.Search.Function.ValueSource.description() */
		public override System.String Description()
		{
			return "float(" + base.Description() + ')';
		}
		
		/*(non-Javadoc) <see cref="Lucene.Net.Search.Function.FieldCacheSource.getCachedValues(Lucene.Net.Search.FieldCache, java.lang.String, Lucene.Net.Index.IndexReader) */
		public override DocValues GetCachedFieldValues(FieldCache cache, System.String field, IndexReader reader)
		{
			float[] arr = cache.GetFloats(reader, field, parser);
			return new AnonymousClassDocValues(arr, this);
		}
		
		/*(non-Javadoc) <see cref="Lucene.Net.Search.Function.FieldCacheSource.cachedFieldSourceEquals(Lucene.Net.Search.Function.FieldCacheSource) */
		public override bool CachedFieldSourceEquals(FieldCacheSource o)
		{
			if (o.GetType() != typeof(FloatFieldSource))
			{
				return false;
			}
			FloatFieldSource other = (FloatFieldSource) o;
			return this.parser == null?other.parser == null:this.parser.GetType() == other.parser.GetType();
		}
		
		/*(non-Javadoc) <see cref="Lucene.Net.Search.Function.FieldCacheSource.cachedFieldSourceHashCode() */
		public override int CachedFieldSourceHashCode()
		{
			return parser == null?typeof(System.Single).GetHashCode():parser.GetType().GetHashCode();
		}
	}
}