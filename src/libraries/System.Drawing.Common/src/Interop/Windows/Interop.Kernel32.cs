// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        [GeneratedDllImport(Libraries.Kernel32, SetLastError = true)]
        public static partial int GetSystemDefaultLCID();

        [GeneratedDllImport(Libraries.Kernel32, EntryPoint = "GlobalAlloc", SetLastError = true)]
        internal static partial IntPtr IntGlobalAlloc(int uFlags, UIntPtr dwBytes); // size should be 32/64bits compatible

        internal static IntPtr GlobalAlloc(int uFlags, uint dwBytes)
        {
            return IntGlobalAlloc(uFlags, new UIntPtr(dwBytes));
        }

        [DllImport(Libraries.Gdi32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr SelectObject(HandleRef hdc, HandleRef obj);
    }
}