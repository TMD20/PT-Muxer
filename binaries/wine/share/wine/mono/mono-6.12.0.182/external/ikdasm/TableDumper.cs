//
// Copyright (C) 2011 Xamarin Inc (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IKVM.Reflection;
using IKVM.Reflection.Metadata;

namespace Ildasm
{
	enum MetadataTableIndex {
		Module = 0x0,
		CustomAttribute = 0xc,
		ModuleRef = 0x1a,
		Assembly = 0x20,
		AssemblyRef = 0x23,
		ExportedType = 0x27,
		// Portable PDB tables
		Document = 0x30,
		MethodDebugInformation = 0x31,
		LocalScope = 0x32,
		LocalVariable = 0x33,
		LocalConstant = 0x34,
		ImportScope = 0x35,
		StateMachineMethod = 0x36,
		CustomDebugInformation = 0x37
	}

	class TableDumper
	{
		Universe universe;
		Assembly assembly;
		Module module;

		public TableDumper (string inputFile) {
            universe = new Universe (UniverseOptions.None);

            var raw = universe.OpenRawModule (System.IO.File.OpenRead (inputFile), System.IO.Path.GetTempPath () + "/Dummy");
            if (raw.IsManifestModule)
            {
                assembly = universe.LoadAssembly (raw);
                module = assembly.ManifestModule;
            }
            else
            {
                var ab = universe.DefineDynamicAssembly (new AssemblyName ("<ModuleContainer>"), IKVM.Reflection.Emit.AssemblyBuilderAccess.ReflectionOnly);
                assembly = ab;
                module = ab.__AddModule (raw);
            }			
		}

		public void DumpTable (TextWriter w, MetadataTableIndex tableIndex) {
			switch (tableIndex) {
			case MetadataTableIndex.Assembly:
				DumpAssemblyTable (w);
				break;
			case MetadataTableIndex.AssemblyRef:
				DumpAssemblyRefTable (w);
				break;
			case MetadataTableIndex.Module:
				DumpModuleTable (w);
				break;
			case MetadataTableIndex.ModuleRef:
				DumpModuleRefTable (w);
				break;
			case MetadataTableIndex.ExportedType:
				DumpExportedTypeTable (w);
				break;
			case MetadataTableIndex.CustomAttribute:
				DumpCustomAttributeTable (w);
				break;
			case MetadataTableIndex.Document:
				DumpDocumentTable (w);
				break;
			case MetadataTableIndex.MethodDebugInformation:
				DumpMethodDebugInformationTable (w);
				break;
			case MetadataTableIndex.LocalScope:
				DumpLocalScopeTable (w);
				break;
			case MetadataTableIndex.ImportScope:
				DumpImportScopeTable (w);
				break;
			case MetadataTableIndex.CustomDebugInformation:
				DumpCustomDebugInfoTable (w);
				break;
			default:
				throw new NotImplementedException ();
			}
		}

		void HexDump (TextWriter w, byte[] bytes, int len) {
			for (int i = 0; i < len; ++i) {
				if ((i % 16) == 0)
					w.Write (String.Format ("\n0x{0:x08}: ", i));
				w.Write (String.Format ("{0:X02} ", bytes [i]));
			}
		}

		void DumpAssemblyTable (TextWriter w) {
			var t = module.AssemblyTable;
			w.WriteLine ("Assembly Table");
			foreach (var r in t.records) {
				w.WriteLine (String.Format ("Name:          {0}", module.GetString (r.Name)));
				w.WriteLine (String.Format ("Hash Algoritm: 0x{0:x08}", r.HashAlgId));
				w.WriteLine (String.Format ("Version:       {0}.{1}.{2}.{3}", r.MajorVersion, r.MinorVersion, r.BuildNumber, r.RevisionNumber));
				w.WriteLine (String.Format ("Flags:         0x{0:x08}", r.Flags));
				w.WriteLine (String.Format ("PublicKey:     BlobPtr (0x{0:x08})", r.PublicKey));

				var blob = module.GetBlob (r.PublicKey);
				if (blob.Length == 0) {
					w.WriteLine ("\tZero sized public key");
				} else {
					w.Write ("\tDump:");
					byte[] bytes = blob.ReadBytes (blob.Length);
					HexDump (w, bytes, bytes.Length);
					w.WriteLine ();
				}
				w.WriteLine (String.Format ("Culture:       {0}", module.GetString (r.Culture)));
				w.WriteLine ();
			}
		}

		void DumpAssemblyRefTable (TextWriter w) {
			var t = module.AssemblyRef;
			w.WriteLine ("AssemblyRef Table");
			int rowIndex = 1;
			foreach (var r in t.records) {
				w.WriteLine (String.Format ("{0}: Version={1}.{2}.{3}.{4}", rowIndex, r.MajorVersion, r.MinorVersion, r.BuildNumber, r.RevisionNumber));
				w.WriteLine (String.Format ("\tName={0}", module.GetString (r.Name)));
				w.WriteLine (String.Format ("\tFlags=0x{0:x08}", r.Flags));
				var blob = module.GetBlob (r.PublicKeyOrToken);
				if (blob.Length == 0) {
					w.WriteLine ("\tZero sized public key");
				} else {
					w.Write ("\tPublic Key:");
					byte[] bytes = blob.ReadBytes (blob.Length);
					HexDump (w, bytes, bytes.Length);
					w.WriteLine ();
				}
				w.WriteLine ();
				rowIndex ++;
			}
		}

		void DumpModuleTable (TextWriter w) {
			var t = module.ModuleTable;
			w.WriteLine ("Module Table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				w.WriteLine (String.Format ("{0}: {1} {2} {{{3}}}", rowIndex, module.GetString (r.Name), r.Generation, module.GetGuid (r.Mvid).ToString ().ToUpper ()));
				rowIndex ++;
			}
		}

		void DumpModuleRefTable (TextWriter w) {
			var t = module.ModuleRef;
			w.WriteLine ("ModuleRef Table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				w.WriteLine (String.Format ("{0}: {1}", rowIndex, module.GetString (r)));
				rowIndex ++;
			}
		}

		string GetManifestImpl (int idx) {
			if (idx == 0)
				return "current module";
			uint table = (uint)idx >> 24;
			uint row = (uint)idx & 0xffffff;
			switch (table) {
			case FileTable.Index:
				return "file " + row;
			case (uint)AssemblyRefTable.Index:
				return "assemblyref " + row;
			case (uint)ExportedTypeTable.Index:
				return "exportedtype " + row;
			default:
				return "";
			}
		}

		void DumpExportedTypeTable (TextWriter w) {
			var t = module.ExportedType;
			w.WriteLine ("ExportedType Table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				string name = module.GetString (r.TypeName);
				string nspace = module.GetString (r.TypeNamespace);
				w.WriteLine (String.Format ("{0}: {1}{2}{3} is in {4}, index={5:x}, flags=0x{6:x}", rowIndex, nspace, nspace != "" ? "." : "", name, GetManifestImpl (r.Implementation), r.TypeDefId, r.Flags));
				rowIndex ++;
			}
		}

		string StringifyCattrValue (object val) {
			if (val.GetType () == typeof (string))
				return String.Format ("\"{0}\"", val);
			else if (val == null)
				return "null";
			else
				return val.ToString ();
		}

		void DumpCustomAttributeTable (TextWriter w) {
			var t = module.CustomAttribute;
			w.WriteLine ("CustomAttribute Table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
			}

			Dictionary<int, string> table_names = new Dictionary<int, string> () {
					{ MethodDefTable.Index, "MethodDef" },
					{ FieldTable.Index,  "FieldDef" },
					{ TypeRefTable.Index, "TypeRef" },
					{ TypeDefTable.Index, "TypeDef" },
					{ ParamTable.Index, "Param" },
					{ InterfaceImplTable.Index, "InterfaceImpl" },
					{ MemberRefTable.Index, "MemberRef" },
					{ AssemblyTable.Index,  "Assembly" },
					{ ModuleTable.Index, "Module" },
					{ PropertyTable.Index, "Property" },
					{ EventTable.Index, "Event" },
					{ StandAloneSigTable.Index, "StandAloneSignature" },
					{ ModuleRefTable.Index, "ModuleRef" },
					{ TypeSpecTable.Index, "TypeSpec" },
					{ AssemblyRefTable.Index, "AssemblyRef" },
					{ FileTable.Index, "File" },
					{ ExportedTypeTable.Index, "ExportedType" },
					{ ManifestResourceTable.Index, "Manifest" },
					{ GenericParamTable.Index, "GenericParam" }
				};

			foreach (var cattr in module.__EnumerateCustomAttributeTable ()) {
				//Console.WriteLine (cattr);

				int parent_token = cattr.__Parent;

				string parent;
				int table_idx = parent_token >> 24;
				int row = parent_token & 0xffffff;
				if (!table_names.TryGetValue (table_idx, out parent))
					parent = "Unknown";

				var args = new StringBuilder ();
				args.Append ("[");
				var sep = "";
				foreach (var arg in cattr.ConstructorArguments) {
					args.Append (sep).Append (StringifyCattrValue (arg.Value));
					sep = ", ";
				}
				foreach (var named_arg in cattr.NamedArguments) {
					args.Append (sep);
					args.Append ("{");
					args.Append (String.Format ("{0} = {1}", named_arg.MemberName, StringifyCattrValue (named_arg.TypedValue.Value)));
					args.Append ("}");
					sep = ", ";
				}
				args.Append ("]");

				var ctor = cattr.Constructor;
				var method = new StringBuilder ();
				method.Append ("instance void class ");
				method.Append (String.Format ("[{0}]{1}", ctor.DeclaringType.Assembly.GetName ().Name, ctor.DeclaringType.ToString ()));
				method.Append ("::'.ctor'(");
				sep = "";
				foreach (var arg in ctor.GetParameters ()) {
					method.Append (sep).Append (arg.ParameterType);
					sep = ", ";
				}
				method.Append (")");

				w.WriteLine (String.Format ("{0}: {1}: {2} {3} {4}", rowIndex, parent, row, method, args));
				rowIndex ++;
			}
		}

		public byte[] GetBlobCopy (int blobIndex) {
			var r = module.GetBlob (blobIndex);
			return r.ReadBytes (r.Length);
		}

		public string GetBlobString (int blobIndex) {
			var r = module.GetBlob (blobIndex);
			return new String (Encoding.UTF8.GetChars (r.ReadBytes (r.Length)));
		}

		static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
				sb.Append (b.ToString ("x2"));
            return sb.ToString();
        }

		string DecodeDocumentName (DocumentTable.Record r) {
			var nameReader = module.GetBlob (r.Name);
			// FIXME: UTF8
			var sep = nameReader.ReadChar ();
			var name = "";
			while (nameReader.Length > 0) {
				var part = nameReader.ReadCompressedUInt ();
				if (part != 0) {
					var partReader = module.GetBlob (part);
					var partString = new String (Encoding.UTF8.GetChars (partReader.ReadBytes (partReader.Length)));
					if (name == "")
						name = sep + partString;
					else
						name = name + sep + partString;
				}
			}
			return name;
		}

		public void DumpDocumentTable (TextWriter w) {
			var t = module.Document;
			w.WriteLine ("Document table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				string name;
				string hashAlg;
				string hash;
				string lang;
				Guid g;

				name = DecodeDocumentName (r);

				// FIXME: SHA256
				if (r.HashAlgorithm != 0) {
					g = module.GetGuid (r.HashAlgorithm);
					if (g == DocumentTable.SHA1Guid) {
						hashAlg = "sha1";
						hash = HexStringFromBytes (GetBlobCopy (r.Hash));
					} else {
						hashAlg = g.ToString ();
						hash = "<>";
					}
				} else {
					hashAlg = "";
					hash = "<>";
				}

				// FIXME: VB/F#
				if (r.Language != 0) {
					g = module.GetGuid (r.Language);
					if (g == DocumentTable.CSharpGuid) {
						lang = "C#";
					} else {
						lang = g.ToString ();
					}
				} else {
					lang = "";
				}

				w.WriteLine ("" + rowIndex + ": " + name + " lang=" + lang + " hash=[" + hashAlg + " " + hash + "]");
				rowIndex ++;
			}
		}

		public void DumpMethodDebugInformationTable (TextWriter w) {
			var t = module.MethodDebugInformation;
			w.WriteLine ("MethodDebugInformation table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				w.WriteLine ("" + rowIndex + ":");

				if (r.SequencePoints == 0) {
					rowIndex ++;
					continue;
				}

				var docIndex = r.Document;

				var reader = module.GetBlob (r.SequencePoints);

				var localSig = reader.ReadCompressedUInt ();
				if (docIndex == 0)
					docIndex = reader.ReadCompressedUInt ();
				var docName = DecodeDocumentName (module.Document.records [docIndex - 1]);

				int ilOffset = 0;
				int startLine = 0;
				int startColumn = 0;
				bool first = true;
				bool firstNonHidden = false;
				while (reader.Length > 0) {
					var deltaIlOffset = reader.ReadCompressedUInt ();
					if (!first && deltaIlOffset == 0) {
						/* subsequent-document-record */
						docIndex = reader.ReadCompressedUInt ();
						docName = DecodeDocumentName (module.Document.records [docIndex - 1]);
						continue;
					}
					ilOffset += deltaIlOffset;
					first = false;

					var deltaLines = reader.ReadCompressedUInt ();
					int deltaColumns;
					if (deltaLines == 0)
						deltaColumns = reader.ReadCompressedUInt ();
					else
						deltaColumns = reader.ReadCompressedInt ();

					if (deltaLines == 0 && deltaColumns == 0) {
						/* Hidden sequence point */
						continue;
					}

					if (firstNonHidden) {
						startLine = reader.ReadCompressedUInt ();
						startColumn = reader.ReadCompressedUInt ();
					} else {
						int advLine = reader.ReadCompressedInt ();
						int advCol = reader.ReadCompressedInt ();
						startLine += advLine;
						startColumn += advCol;
					}
					firstNonHidden = false;

					w.WriteLine (docName + " il=" + ilOffset + " line=" + startLine + " col=" + startColumn + " endline=" + (startLine + deltaLines) + " endcol=" + (startColumn + deltaColumns));
				}

				rowIndex ++;
			}
		}

		public void DumpLocalScopeTable (TextWriter w) {
			var t = module.LocalScope;
			w.WriteLine ("LocalScope table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				w.WriteLine ("" + rowIndex + ": method=" + r.Method + " import=" + r.ImportScope + " locals=" + r.VariableList);
				rowIndex ++;
			}
		}

		public void DumpImportScopeTable (TextWriter w) {
			var t = module.ImportScope;
			w.WriteLine ("ImportScope table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				w.WriteLine ("" + rowIndex + ": parent=" + r.Parent + " imports=" + r.Imports);

				var reader = module.GetBlob (r.Imports);
				while (reader.Length > 0) {
					var kind = reader.ReadCompressedUInt ();
					// FIXME: Constants
					switch (kind) {
					case 1:
						var nsIndex = reader.ReadCompressedUInt ();
						w.WriteLine ("\t ns=" + GetBlobString (nsIndex));
						break;
					default:
						w.WriteLine ("K: " + kind);
						throw new NotImplementedException ();
					}
				}
				rowIndex ++;
			}
		}

		static Guid StateMachineHoistedLocalScopesGuid = new Guid ("6da9a61e-f8c7-4874-be62-68bc5630df71");
		static Guid SourceLinkGuid = new Guid ("cc110556-a091-4d38-9fec-25ab9a351a6a");

		public void DumpCustomDebugInfoTable (TextWriter w) {
			var t = module.CustomDebugInformation;
			w.WriteLine ("CustomDebugInformation table (1.." + t.RowCount + ")");
			int rowIndex = 1;
			foreach (var r in t.records) {
				var g = module.GetGuid (r.Kind);
				string kind = "";
				if (g == StateMachineHoistedLocalScopesGuid)
					kind = "<state-machine hoisted local scopes>";
				else if (g == SourceLinkGuid)
					kind = "<source link>";
				else
					kind = g.ToString ();
				int parent_kind = r.Parent & 0x1f;
				int parent_idx = r.Parent >> 5;
				w.WriteLine ("" + rowIndex + ": " + kind + " [" + parent_kind + "-" + parent_idx + "]");
				if (g == StateMachineHoistedLocalScopesGuid) {
					var blob = module.GetBlob (r.Value);
					while (blob.Length > 0) {
						int start_offset = blob.ReadInt32 ();
						int len = blob.ReadInt32 ();
						w.WriteLine (String.Format ("\t0x{0:x}-0x{1:x}", start_offset, start_offset + len));
					}
				} else if (g == SourceLinkGuid) {
					var blob = module.GetBlob (r.Value);
					var bytes = blob.ReadBytes (blob.Length);
					Console.WriteLine ("======================================");
					Console.Write (Encoding.UTF8.GetString (bytes));
					Console.WriteLine ("======================================");
				}
				rowIndex ++;
			}
		}
	}
}
