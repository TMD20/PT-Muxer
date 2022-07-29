﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Globalization;
using System.Linq;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;
using Microsoft.Internal.Web.Utils;

namespace System.Web.Razor.Generator
{
    public class DynamicAttributeBlockCodeGenerator : BlockCodeGenerator
    {
        private const string ValueWriterName = "__razor_attribute_value_writer";
        private string _oldTargetWriter;
        private bool _isExpression;
        private ExpressionRenderingMode _oldRenderingMode;

        public DynamicAttributeBlockCodeGenerator(LocationTagged<string> prefix, int offset, int line, int col)
            : this(prefix, new SourceLocation(offset, line, col))
        {
        }

        public DynamicAttributeBlockCodeGenerator(LocationTagged<string> prefix, SourceLocation valueStart)
        {
            Prefix = prefix;
            ValueStart = valueStart;
        }

        public LocationTagged<string> Prefix { get; private set; }
        public SourceLocation ValueStart { get; private set; }

        public override void GenerateStartBlockCode(Block target, CodeGeneratorContext context)
        {
            if (context.Host.DesignTimeMode)
            {
                return; // Don't generate anything!
            }

            // What kind of block is nested within
            string generatedCode;
            Block child = target.Children.Where(n => n.IsBlock).Cast<Block>().FirstOrDefault();
            if (child != null && child.Type == BlockType.Expression)
            {
                _isExpression = true;
                generatedCode = context.BuildCodeString(cw =>
                {
                    cw.WriteParameterSeparator();
                    cw.WriteStartMethodInvoke("Tuple.Create");
                    cw.WriteLocationTaggedString(Prefix);
                    cw.WriteParameterSeparator();
                    cw.WriteStartMethodInvoke("Tuple.Create", "System.Object", "System.Int32");
                });

                _oldRenderingMode = context.ExpressionRenderingMode;
                context.ExpressionRenderingMode = ExpressionRenderingMode.InjectCode;
            }
            else
            {
                generatedCode = context.BuildCodeString(cw =>
                {
                    cw.WriteParameterSeparator();
                    cw.WriteStartMethodInvoke("Tuple.Create");
                    cw.WriteLocationTaggedString(Prefix);
                    cw.WriteParameterSeparator();
                    cw.WriteStartMethodInvoke("Tuple.Create", "System.Object", "System.Int32");
                    cw.WriteStartConstructor(context.Host.GeneratedClassContext.TemplateTypeName);
                    cw.WriteStartLambdaDelegate(ValueWriterName);
                });
            }

            context.MarkEndOfGeneratedCode();
            context.BufferStatementFragment(generatedCode);

            _oldTargetWriter = context.TargetWriterName;
            context.TargetWriterName = ValueWriterName;
        }

        public override void GenerateEndBlockCode(Block target, CodeGeneratorContext context)
        {
            if (context.Host.DesignTimeMode)
            {
                return; // Don't generate anything!
            }

            string generatedCode;
            if (_isExpression)
            {
                generatedCode = context.BuildCodeString(cw =>
                {
                    cw.WriteParameterSeparator();
                    cw.WriteSnippet(ValueStart.AbsoluteIndex.ToString(CultureInfo.CurrentCulture));
                    cw.WriteEndMethodInvoke();
                    cw.WriteParameterSeparator();
                    // literal: false - This attribute value is not a literal value, it is dynamically generated
                    cw.WriteBooleanLiteral(false);
                    cw.WriteEndMethodInvoke();
                    cw.WriteLineContinuation();
                });
                context.ExpressionRenderingMode = _oldRenderingMode;
            }
            else
            {
                generatedCode = context.BuildCodeString(cw =>
                {
                    cw.WriteEndLambdaDelegate();
                    cw.WriteEndConstructor();
                    cw.WriteParameterSeparator();
                    cw.WriteSnippet(ValueStart.AbsoluteIndex.ToString(CultureInfo.CurrentCulture));
                    cw.WriteEndMethodInvoke();
                    cw.WriteParameterSeparator();
                    // literal: false - This attribute value is not a literal value, it is dynamically generated
                    cw.WriteBooleanLiteral(false);
                    cw.WriteEndMethodInvoke();
                    cw.WriteLineContinuation();
                });
            }

            context.AddStatement(generatedCode);
            context.TargetWriterName = _oldTargetWriter;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.CurrentCulture, "DynAttr:{0:F}", Prefix);
        }

        public override bool Equals(object obj)
        {
            DynamicAttributeBlockCodeGenerator other = obj as DynamicAttributeBlockCodeGenerator;
            return other != null &&
                   Equals(other.Prefix, Prefix);
        }

        public override int GetHashCode()
        {
            return HashCodeCombiner.Start()
                .Add(Prefix)
                .CombinedHash;
        }
    }
}
