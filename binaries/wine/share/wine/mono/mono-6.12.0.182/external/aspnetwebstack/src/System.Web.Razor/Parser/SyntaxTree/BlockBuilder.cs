﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Razor.Generator;

namespace System.Web.Razor.Parser.SyntaxTree
{
    public class BlockBuilder
    {
        public BlockBuilder()
        {
            Reset();
        }

        public BlockBuilder(Block original)
        {
            Type = original.Type;
            Children = new List<SyntaxTreeNode>(original.Children);
            Name = original.Name;
            CodeGenerator = original.CodeGenerator;
        }

        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Justification = "Type is the most appropriate name for this property and there is little chance of confusion with GetType")]
        public BlockType? Type { get; set; }

        public IList<SyntaxTreeNode> Children { get; private set; }
        public string Name { get; set; }
        public IBlockCodeGenerator CodeGenerator { get; set; }

        public Block Build()
        {
            return new Block(this);
        }

        public void Reset()
        {
            Type = null;
            Name = null;
            Children = new List<SyntaxTreeNode>();
            CodeGenerator = BlockCodeGenerator.Null;
        }
    }
}
