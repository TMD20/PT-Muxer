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
using Lucene.Net.Documents;

namespace Lucene.Net.Index
{
	
	/// <summary> Holds all per thread, per field state.</summary>
	
	sealed class DocFieldProcessorPerField
	{
		
		internal DocFieldConsumerPerField consumer;
		internal FieldInfo fieldInfo;
		
		internal DocFieldProcessorPerField next;
		internal int lastGen = - 1;
		
		internal int fieldCount;
		internal IFieldable[] fields = new IFieldable[1];
		
		public DocFieldProcessorPerField(DocFieldProcessorPerThread perThread, FieldInfo fieldInfo)
		{
			this.consumer = perThread.consumer.AddField(fieldInfo);
			this.fieldInfo = fieldInfo;
		}
		
		public void  Abort()
		{
			consumer.Abort();
		}
	}
}