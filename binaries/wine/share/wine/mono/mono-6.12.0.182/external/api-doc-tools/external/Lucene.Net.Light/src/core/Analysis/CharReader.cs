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
	
	/// <summary> CharReader is a Reader wrapper. It reads chars from
	/// Reader and outputs <see cref="CharStream" />, defining an
	/// identify function <see cref="CorrectOffset" /> method that
	/// simply returns the provided offset.
	/// </summary>
	public sealed class CharReader:CharStream
	{
        private long currentPosition = -1;

	    private bool isDisposed;

		internal System.IO.StreamReader input;
		
		public static CharStream Get(System.IO.TextReader input)
		{
			var charStream = input as CharStream;
			if (charStream != null)
				return charStream;
			
			// {{Aroush-2.9}} isn't there a better (faster) way to do this?
			var theString = new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(input.ReadToEnd()));
			return new CharReader(new System.IO.StreamReader(theString));
			//return input is CharStream?(CharStream) input:new CharReader(input);
		}
		
		private CharReader(System.IO.StreamReader in_Renamed) : base(in_Renamed)
		{
			input = in_Renamed;
		}
		
		public override int CorrectOffset(int currentOff)
		{
			return currentOff;
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
		
		public  override int Read(System.Char[] cbuf, int off, int len)
		{
			return input.Read(cbuf, off, len);
		}
		
		public bool MarkSupported()
		{
			return input.BaseStream.CanSeek;
		}
		
		public void  Mark(int readAheadLimit)
		{
			currentPosition = input.BaseStream.Position;
			input.BaseStream.Position = readAheadLimit;
        }
		
		public void  Reset()
		{
			input.BaseStream.Position = currentPosition;
        }
	}
}