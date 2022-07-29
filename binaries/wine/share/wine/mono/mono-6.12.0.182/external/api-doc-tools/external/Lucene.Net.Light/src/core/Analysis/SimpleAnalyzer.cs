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

namespace Lucene.Net.Analysis
{
	
	/// <summary>An <see cref="Analyzer" /> that filters <see cref="LetterTokenizer" /> 
	/// with <see cref="LowerCaseFilter" /> 
	/// </summary>
	
	public sealed class SimpleAnalyzer : Analyzer
	{
		public override TokenStream TokenStream(System.String fieldName, System.IO.TextReader reader)
		{
			return new LowerCaseTokenizer(reader);
		}
		
		public override TokenStream ReusableTokenStream(System.String fieldName, System.IO.TextReader reader)
		{
			var tokenizer = (Tokenizer) PreviousTokenStream;
			if (tokenizer == null)
			{
				tokenizer = new LowerCaseTokenizer(reader);
				PreviousTokenStream = tokenizer;
			}
			else
				tokenizer.Reset(reader);
			return tokenizer;
		}
	}
}