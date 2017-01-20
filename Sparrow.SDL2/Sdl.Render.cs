using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl
{
    public static partial class Sdl
    {
        [Flags]
        public enum RendererFlags : uint
        {
            Software =      0x00000001,
            Accelerated =   0x00000002,
            PresentVSync =  0x00000004,
            TargetTexture = 0x00000008
        }

        [DllImport(DllName, EntryPoint = "SDL_CreateRenderer")]
        public static extern IntPtr CreateRenderer(IntPtr window, int index = -1, RendererFlags flags = 0);

        [DllImport(DllName, EntryPoint = "SDL_DestroyRenderer")]
        public static extern void DestroyRenderer(IntPtr renderer);
    }
}