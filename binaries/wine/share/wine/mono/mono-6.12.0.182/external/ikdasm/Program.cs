/*
  Copyright (C) 2012-2013 Jeroen Frijters

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
using Mono.Options;

namespace Ildasm
{
    class Program
    {
        static int Main(string[] args)
        {
            string outputFile = null;
            string inputFile = null;
            MetadataTableIndex? tableToDump = null;
            var compatLevel = CompatLevel.None;
            var flags = Flags.None;

			if (typeof (int).Assembly.GetType ("Mono.Runtime") != null) {
				bool printUsage = false;

				var p = new OptionSet () {
						{ "help", v => printUsage = true },
						{ "out", v => outputFile = v },
						{ "assembly", v =>tableToDump = MetadataTableIndex.Assembly },
						{ "assemblyref", v =>tableToDump = MetadataTableIndex.AssemblyRef },
						{ "moduleref", v =>tableToDump = MetadataTableIndex.ModuleRef },
						{ "exported", v =>tableToDump = MetadataTableIndex.ExportedType },
						{ "customattr", v =>tableToDump = MetadataTableIndex.CustomAttribute },
						{ "module", v => tableToDump = MetadataTableIndex.Module },
						{ "document", v => tableToDump = MetadataTableIndex.Document },
						{ "methoddebuginformation", v => tableToDump = MetadataTableIndex.MethodDebugInformation },
						{ "localscope", v => tableToDump = MetadataTableIndex.LocalScope },
						{ "localvariable", v => tableToDump = MetadataTableIndex.LocalVariable },
						{ "localconstant", v => tableToDump = MetadataTableIndex.LocalConstant },
						{ "importscope", v =>tableToDump = MetadataTableIndex.ImportScope },
						{ "customdebuginfo", v => tableToDump = MetadataTableIndex.CustomDebugInformation },
					};
				args = p.Parse (args).ToArray ();
				if (printUsage) {
					PrintUsage ();
					return 0;
				}
				if (args.Length < 1) {
					PrintUsage ();
					return 1;
				}
				inputFile = args [0];
			} else {
				foreach (var arg in args)
				{
					if (arg.StartsWith("-", StringComparison.Ordinal) || arg.StartsWith("/", StringComparison.Ordinal))
					{
						string value;
						if (TryMatchOption(arg, "out", out value))
						{
							outputFile = value;
						}
						else if (TryMatchOption(arg, "compat", out value))
						{
							switch (value)
							{
                            case "2.0":
                                compatLevel = CompatLevel.V20;
                                break;
                            case "4.0":
                                compatLevel = CompatLevel.V40;
                                break;
                            case "4.5":
                                compatLevel = CompatLevel.V45;
                                break;
                            default:
                                PrintUsage();
                                return 1;
							}
						}
						else if (String.Compare(arg, 1, "diffmode", 0, 8, StringComparison.OrdinalIgnoreCase) == 0)
						{
							flags |= Flags.DiffMode;
						}
						else if (IsIldasmOption(arg, "caverbal"))
						{
							flags |= Flags.Caverbal;
						}
                        else if (IsIldasmOption(arg, "project"))
                        {
                            flags |= Flags.Project;
                        }
                    }
                    else
                    {
                        if (inputFile != null)
                        {
                            PrintUsage();
                            return 1;
                        }
                        else
                        {
                            inputFile = arg;
                        }
                    }
                }
            }

            if (inputFile == null)
            {
                PrintUsage();
                return 1;
            }
			if (tableToDump.HasValue)
			{
				var tableDumper = new TableDumper(inputFile);
				if (outputFile != null)
				{
					using (StreamWriter sw = new StreamWriter(outputFile, false))
					{
						tableDumper.DumpTable(sw, tableToDump.Value);
					}
				}
				else
				{
					tableDumper.DumpTable(Console.Out, tableToDump.Value);
				}
				return 0;
			}
            var disassembler = new Disassembler(inputFile, outputFile, compatLevel, flags);
            if (outputFile != null)
            {
                Encoding enc;
                switch (compatLevel)
                {
                    case CompatLevel.None:
                        enc = Encoding.UTF8;
                        break;
                    case CompatLevel.V20:
                    case CompatLevel.V40:
                        // instantiate new UTF8Encoding to avoid the preamble that Encoding.UTF8 has
                        // (note that the only non-ASCII character that we're encoding is the \uFFFD placeholder for non-ASCII characters)
                        enc = new UTF8Encoding();
                        break;
                    default:
                        enc = Console.OutputEncoding;
                        break;
                }
                using (StreamWriter sw = new StreamWriter(outputFile, false, enc))
                {
                    disassembler.Save(sw);
                }
            }
            else
            {
                disassembler.Save(Console.Out);
            }
			return 0;
        }

        static bool TryMatchOption(string arg, string key, out string value)
        {
            if (arg.Length > key.Length + 2 && (arg[key.Length + 1] == ':' || arg[key.Length + 1] == '=') && String.Compare(arg, 1, key, 0, key.Length, true) == 0)
            {
                value = arg.Substring(key.Length + 2);
                return true;
            }
            value = null;
            return false;
        }

        static bool IsIldasmOption(string arg, string option)
        {
            // we match ildasm options on the first three letters (like ildasm)
            return String.Compare(arg, 1, option, 0, 3, StringComparison.OrdinalIgnoreCase) == 0;
        }

        static void PrintUsage()
        {
            Console.WriteLine("IKDASM - IL disassembler example for IKVM.Reflection");
            Console.WriteLine("Copyright (C) 2012-2013 Jeroen Frijters");
            Console.WriteLine();
            Console.WriteLine("Usage: ikdasm [options] <file_name> [options]");
            Console.WriteLine();
            Console.WriteLine("Options:");
            if (typeof (int).Assembly.GetType ("Mono.Runtime") != null) {
                Console.WriteLine ("  -out=<file name>   Direct output to file rather than stdout");
                Console.WriteLine ("  -help              Print this help");

                Console.WriteLine ("  -assembly          Dumps the contents of the Assembly table");
                Console.WriteLine ("  -assemblyref       Dumps the contents of the AssemblyRef table");
                Console.WriteLine ("  -moduleref         Dumps the contents of the ModuleRef table");
                Console.WriteLine ("  -exported          Dumps the contents of the ExportedType table");
                Console.WriteLine ("  -customattr        Dumps the contents of the CustomAttribute table");
            } else {
                Console.WriteLine("  /OUT=<file name>    Direct output to file rather than to stdout.");
				Console.WriteLine("  /COMPAT=<version>   Match ildasm behavior. (<version> = 2.0 | 4.0 | 4.5)");
				Console.WriteLine("  /DIFFMODE           Remove superficial differences to allow assembly comparisons");
				Console.WriteLine("  /CAVERBAL           Try to decode custom attribute blobs");
                Console.WriteLine("  /PROJECT            Project WinMD metadata into .NET format");
			}
        }
    }
}
