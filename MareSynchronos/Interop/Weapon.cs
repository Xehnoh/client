﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FFXIVClientStructs.FFXIV.Client.Graphics.Scene;
using Penumbra.Interop.Structs;

namespace MareSynchronos.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Weapon
    {
        [FieldOffset(0xA8)] public WeaponDrawObject* WeaponRenderModel;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct WeaponDrawObject
    {
        [FieldOffset(0x00)] public RenderModel* RenderModel;
    }
}
