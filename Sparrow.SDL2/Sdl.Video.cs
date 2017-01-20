using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl
{
    public static partial class Sdl
    {
        [Flags]
        public enum WindowFlags : uint
        {
            Fullscreen =        0x00000001,
            OpenGL =            0x00000002,
            Shown =             0x00000004,
            Hidden =            0x00000008,
            Borderless =        0x00000010,
            Resizable =         0x00000020,
            Minimized =         0x00000040,
            Maximized =         0x00000080,
            InputGrabbed =      0x00000100,
            InputFocus =        0x00000200,
            MouseFocus =        0x00000400,
            FullscreenDesktop = 0x00001000 | Fullscreen,
            Foreign =           0x00000800,
            AllowHighDpi =      0x00002000,
            MouseCapture =      0x00004000,
        }

        public static class WindowPosition
        {
            public const int UndefinedMask = 0x1FFF0000;
            public const int CenteredMask =  0x2FFF0000;
            public const int Undefined =     0x1FFF0000;
            public const int Centered =      0x2FFF0000;
        }

        [DllImport(DllName, EntryPoint = "SDL_CreateWindow")]
        public static extern IntPtr CreateWindow([In]string title, int x, int y, int w, int h, WindowFlags flags);

        public static class Gl {

            public enum Attribute
            {
                RedSize,
                GreenSize,
                BlueSize,
                AlphaSize,
                BufferSize,
                DoubleBuffer,
                DepthSize,
                StencilSize,
                AccumRedSize,
                AccumGreenSize,
                AccumBlueSize,
                AccumAlphaSize,
                Stereo,
                MultisampleBuffers,
                MultisampleSamples,
                AcceleratedVisual,
                RetainingBacking,
                ContextMajorVersion,
                ContextMinorVersion,
                ContextEgl,
                ContextFlags,
                ContextProfileMask,
                ShareWithCurrentContext,
                FramebufferSrgbCapable,
                ContextReleaseBehaviour
            }

            [DllImport(DllName, EntryPoint = "SDL_GL_SetAttribute")]
            public static extern int SetAttribute(Attribute attr, int value);

            [DllImport(DllName, EntryPoint = "SDL_GL_SetSwapInterval")]
            public static extern int SetSwapInterval(int interval);

            [DllImport(DllName, EntryPoint = "SDL_GL_CreateContext")]
            public static extern IntPtr CreateContext(IntPtr window);

            [DllImport(DllName, EntryPoint = "SDL_GL_DeleteContext")]
            public static extern void DeleteContext(IntPtr context);
        }
    }
}
