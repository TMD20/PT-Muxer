// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Open Technologies, Inc.")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Retail")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Open Technologies, Inc.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Reactive Extensions Remoting Library used to expose observable sequences through .NET Remoting.")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.2.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Reactive Extensions")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reactive.Runtime.Remoting")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System.Reactive.Linq
{
    public static partial class RemotingObservable
    {
        public static System.IObservable<TSource> Remotable<TSource>(this System.IObservable<TSource> source) { throw null; }
        public static System.IObservable<TSource> Remotable<TSource>(this System.IObservable<TSource> source, System.Runtime.Remoting.Lifetime.ILease lease) { throw null; }
        public static System.Reactive.Linq.IQbservable<TSource> Remotable<TSource>(this System.Reactive.Linq.IQbservable<TSource> source) { throw null; }
        public static System.Reactive.Linq.IQbservable<TSource> Remotable<TSource>(this System.Reactive.Linq.IQbservable<TSource> source, System.Runtime.Remoting.Lifetime.ILease lease) { throw null; }
    }
}
