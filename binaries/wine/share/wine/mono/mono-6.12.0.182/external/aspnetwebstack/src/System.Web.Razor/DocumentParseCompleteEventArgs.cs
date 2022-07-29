﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Web.Razor.Text;

namespace System.Web.Razor
{
    /// <summary>
    /// Arguments for the DocumentParseComplete event in RazorEditorParser
    /// </summary>
    public class DocumentParseCompleteEventArgs : EventArgs
    {
        /// <summary>
        /// Indicates if the tree structure has actually changed since the previous reparse.
        /// </summary>
        public bool TreeStructureChanged { get; set; }

        /// <summary>
        /// The results of the code generation and parsing
        /// </summary>
        public GeneratorResults GeneratorResults { get; set; }

        /// <summary>
        /// The TextChange which triggered the reparse
        /// </summary>
        public TextChange SourceChange { get; set; }
    }
}
