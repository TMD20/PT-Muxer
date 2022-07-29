// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal unsafe partial class Sys
    {
        [DllImport(Interop.Libraries.CoreLibNative, EntryPoint = "CoreLibNative_MemAlloc")]
        internal static extern IntPtr MemAlloc(UIntPtr sizeInBytes);

        [DllImport(Interop.Libraries.CoreLibNative, EntryPoint = "CoreLibNative_MemFree")]
        internal static extern void MemFree(IntPtr ptr);
    }

#if MONO
    private static IntPtr Unix_MemAlloc(UIntPtr sizeInBytes)
#else
    internal static IntPtr MemAlloc(UIntPtr sizeInBytes)
#endif
    {
        IntPtr allocatedMemory = Interop.Sys.MemAlloc(sizeInBytes);
        if (allocatedMemory == IntPtr.Zero)
        {
            throw new OutOfMemoryException();
        }
        return allocatedMemory;
    }

#if MONO
    private static void Unix_MemFree(IntPtr allocatedMemory)
#else
    internal static void MemFree(IntPtr allocatedMemory)
#endif
    {
        Interop.Sys.MemFree(allocatedMemory);
    }
}
