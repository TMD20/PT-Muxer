/*
  Copyright (C) 2012 Jeroen Frijters

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.

  Jeroen Frijters
  jeroen@frijters.net
  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ildasm
{
    sealed class LineWriter
    {
        readonly TextWriter writer;
        int column;
        bool wrapped;
        StringBuilder sb;

        internal LineWriter(TextWriter writer)
        {
            this.writer = writer;
            sb = new StringBuilder (256);
        }

        internal int Column
        {
            get { return column; }
        }

        internal bool Wrapped
        {
            get { return wrapped; }
        }

        internal void ClearWrappedFlag()
        {
            wrapped = false;
        }

        internal void Write(string str, object arg0)
        {
            int len = sb.Length;
            sb.AppendFormat (str, arg0);
            column += sb.Length - len;
        }

        internal void Write(string str, params object[] args)
        {
            int len = sb.Length;
            sb.AppendFormat (str, args);
            column += sb.Length - len;
        }

        internal void Write(string str)
        {
            sb.Append (str);
            column += str.Length;
        }

        internal void WriteLine(string str)
        {
            if (sb.Length > 0) {
                sb.Append (str);
                writer.WriteLine (sb.ToString ());
                sb.Clear ();
            } else {
                writer.WriteLine (str);
            }
            column = 0;
            wrapped = true;
        }

        internal void WriteLine(string str, params object[] args)
        {
            if (sb.Length > 0) {
                sb.AppendFormat (str, args);
                writer.WriteLine(sb.ToString ());
                sb.Clear ();
            } else {
                writer.WriteLine (String.Format (str, args));
            }
            column = 0;
            wrapped = true;
        }

        internal void WriteLine()
        {
            if (sb.Length > 0) {
                writer.WriteLine (sb.ToString ());
                sb.Clear ();
            } else {
                writer.WriteLine ();
            }
            column = 0;
            wrapped = true;
        }

        internal void GoToColumn(int column)
        {
            sb.Append (' ', column - this.column);
            this.column = column;
        }

        internal void Flush()
        {
            writer.Flush();
        }
    }
}
