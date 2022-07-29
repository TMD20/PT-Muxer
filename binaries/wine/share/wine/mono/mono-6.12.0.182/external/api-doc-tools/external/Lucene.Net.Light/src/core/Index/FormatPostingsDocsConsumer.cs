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
	
	/// <summary> NOTE: this API is experimental and will likely change</summary>
	
	abstract class FormatPostingsDocsConsumer
	{
		
		/// <summary>Adds a new doc in this term.  If this returns null
		/// then we just skip consuming positions/payloads. 
		/// </summary>
		internal abstract FormatPostingsPositionsConsumer AddDoc(int docID, int termDocFreq);
		
		/// <summary>Called when we are done adding docs to this term </summary>
		internal abstract void  Finish();
	}
}