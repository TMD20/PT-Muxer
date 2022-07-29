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
	
	/// <summary> Subclasses of CharFilter can be chained to filter CharStream.
	/// They can be used as <see cref="System.IO.TextReader" /> with additional offset
	/// correction. <see cref="Tokenizer" />s will automatically use <see cref="CorrectOffset" />
	/// if a CharFilter/CharStream subclass is used.
	/// 
	/// </summary>
	/// <version>  $Id$
	/// 
	/// </version>
	public abstract class CharFilter : CharStream
	{
        private long currentPosition = -1;
	    private bool isDisposed;
		protected internal CharStream input;
		
		protected internal CharFilter(CharStream in_Renamed) : base(in_Renamed)
		{
			input = in_Renamed;
		}
		
		/// <summary>Subclass may want to override to correct the current offset.</summary>
		/// <param name="currentOff">current offset</param>
		/// <returns>corrected offset</returns>
		protected internal virtual int Correct(int currentOff)
        {
			return currentOff;
		}
		
		/// <summary> Chains the corrected offset through the input
		/// CharFilter.
		/// </summary>
		public override int CorrectOffset(int currentOff)
		{
			return input.CorrectOffset(Correct(currentOff));
		}

        protected override void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if (disposing)
            {
                if (input != null)
                {
                    input.Close();
                }
            }

            input = null;
            isDisposed = true;
            base.Dispose(disposing);
        }
		
		public override int Read(System.Char[] cbuf, int off, int len)
        {
			return input.Read(cbuf, off, len);
		}
		
		public bool MarkSupported()
        {
            return input.BaseStream.CanSeek;
		}
		
		public void Mark(int readAheadLimit)
        {
            currentPosition = input.BaseStream.Position;
			input.BaseStream.Position = readAheadLimit;
		}
		
		public void Reset()
        {
			input.BaseStream.Position = currentPosition;
		}
	}
}