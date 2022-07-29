// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static unsafe partial class mincore
    {
        [DllImport("api-ms-win-core-heap-l1-1-0.dll")]
        internal static extern IntPtr GetProcessHeap();

        [DllImport("api-ms-win-core-heap-l1-1-0.dll")]
        internal static extern IntPtr HeapAlloc(IntPtr hHeap, uint dwFlags, UIntPtr dwBytes);

        [DllImport("api-ms-win-core-heap-l1-1-0.dll")]
        internal static extern int HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);
    }

#if MULTIPLEX_OS
    private static IntPtr Windows_MemAlloc(UIntPtr sizeInBytes)
#else
    internal static IntPtr MemAlloc(UIntPtr sizeInBytes)
#endif
    {
        IntPtr allocatedMemory = Interop.mincore.HeapAlloc(Interop.mincore.GetProcessHeap(), 0, sizeInBytes);
        if (allocatedMemory == IntPtr.Zero)
        {
            throw new OutOfMemoryException();
        }
        return allocatedMemory;
    }

#if MULTIPLEX_OS
    private static void Windows_MemFree(IntPtr allocatedMemory)
#else
    internal static void MemFree(IntPtr allocatedMemory)
#endif
    {
        Interop.mincore.HeapFree(Interop.mincore.GetProcessHeap(), 0, allocatedMemory);
    }
}
