﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.CodeDom;
using System.Web.Razor.Parser.SyntaxTree;

namespace System.Web.Razor.Generator
{
    public class SetBaseTypeCodeGenerator : SpanCodeGenerator
    {
        public SetBaseTypeCodeGenerator(string baseType)
        {
            BaseType = baseType;
        }

        public string BaseType { get; private set; }

        public override void GenerateCode(Span target, CodeGeneratorContext context)
        {
            context.GeneratedClass.BaseTypes.Clear();
            context.GeneratedClass.BaseTypes.Add(new CodeTypeReference(ResolveType(context, BaseType.Trim())));

            if (context.Host.DesignTimeMode)
            {
                int generatedCodeStart = 0;
                string code = context.BuildCodeString(cw =>
                {
                    generatedCodeStart = cw.WriteVariableDeclaration(target.Content, "__inheritsHelper", null);
                    cw.WriteEndStatement();
                });

                int padding = CalculatePadding(target, generatedCodeStart);

                CodeSnippetStatement stmt = new CodeSnippetStatement(
                    Pad(code, target, generatedCodeStart))
                {
                    LinePragma = context.GenerateLinePragma(target, generatedCodeStart + padding)
                };
                context.AddDesignTimeHelperStatement(stmt);
            }
        }

        protected virtual string ResolveType(CodeGeneratorContext context, string baseType)
        {
            return baseType;
        }

        public override string ToString()
        {
            return "Base:" + BaseType;
        }

        public override bool Equals(object obj)
        {
            SetBaseTypeCodeGenerator other = obj as SetBaseTypeCodeGenerator;
            return other != null &&
                   String.Equals(BaseType, other.BaseType, StringComparison.Ordinal);
        }

        public override int GetHashCode()
        {
            return BaseType.GetHashCode();
        }
    }
}
