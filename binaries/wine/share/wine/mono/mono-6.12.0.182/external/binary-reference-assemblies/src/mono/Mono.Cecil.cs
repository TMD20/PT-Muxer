// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("0.10.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]

// this is not complete, it is just to break the dependency on Mono.Cecil in the Mono.Debugger.Soft assembly
namespace Mono.Cecil
{
    public partial class AssemblyDefinition { }
    public partial class MethodDefinition { }
    public partial class PropertyDefinition { }
    public partial class FieldDefinition { }
    public partial class TypeDefinition { }
}
namespace Mono.Cecil.Cil
{
    public partial struct OpCode { }
}
