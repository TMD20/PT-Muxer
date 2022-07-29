/*
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 *
*/

using System.Reflection;

namespace Lucene.Net.Support
{
    public class SharpZipLib
    {
        static System.Reflection.Assembly asm = null;

        static SharpZipLib()
        {
            try
            {
                asm = Assembly.Load("ICSharpCode.SharpZipLib");
            }
            catch { }
        }

        public static Deflater CreateDeflater()
        {
            if (asm == null) throw new System.IO.FileNotFoundException("Can not load ICSharpCode.SharpZipLib.dll");
            return new Deflater(asm.CreateInstance("ICSharpCode.SharpZipLib.Zip.Compression.Deflater"));
        }

        public static Inflater CreateInflater()
        {
            if (asm == null) throw new System.IO.FileNotFoundException("Can not load ICSharpCode.SharpZipLib.dll");
            return new Inflater(asm.CreateInstance("ICSharpCode.SharpZipLib.Zip.Compression.Inflater"));
        }
    }
}
