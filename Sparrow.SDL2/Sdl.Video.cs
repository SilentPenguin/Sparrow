using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        /// <summary>
		/// The properties for a window created with <see cref='CreateWindow()'/>.
		/// </summary>
        /// <seealso cref="CreateWindow()"/>
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

        /// <summary>
		/// Constants for positioning of a window created with <see cref='CreateWindow()'/>.
		/// </summary>
        /// <seealso cref="CreateWindow()"/>
        public static class WindowPosition
        {
            public const int UndefinedMask = 0x1FFF0000;
            public const int CenteredMask =  0x2FFF0000;
            public const int Undefined =     0x1FFF0000;
            public const int Centered =      0x2FFF0000;
        }

        /// <summary>
        /// The window handle obtained when creating a window with <see cref='CreateWindow()'/>.
        /// </summary>
        /// <seealso cref="CreateWindow()"/>
        public class Window : SafeHandle
        {
            Window() : base(new IntPtr(), true){}
            override public bool IsInvalid
            {
                get { return handle == null; }
            }
            override protected bool ReleaseHandle()
            {
                DestroyWindow(this);
                return true;
            }
        }

        /// <summary>
        /// Create a window with the specified position, dimensions, and flags.
        /// </summary>
        /// <param name="title">The title of the window, in UTF-8 encoding</param>
        /// <param name="x">the x position of the window, or a <see cref='WindowPosition'/></param>
        /// <param name="y">the y position of the window, or a <see cref='WindowPosition'/></param>
        /// <param name="w">the width of the window, in screen coordinates</param>
        /// <param name="h">the height of the window, in screen coordinates<see cref='WindowPosition'/></param>
        /// <param name="flags">one or more SDL_WindowFlags<see cref='WindowPosition'/></param>
        /// <returns>Returns the window that was created or null on failure</returns>
        /// <seealso cref="CreateWindowFrom()"/>
        /// <seealso cref="DestroyWindow()"/>
        [DllImport(DllName, EntryPoint = "SDL_CreateWindow")]
        public static extern Window CreateWindow([In]string title, int x, int y, int w, int h, WindowFlags flags=0);

        /// <summary>
        /// Destroy a window.
        /// </summary>
        /// <param name="window">The window to destroy</param>
        /// <seealso cref="CreateWindow()"/>
        /// <seealso cref="CreateWindowFrom()"/>
        [DllImport(DllName, EntryPoint = "SDL_DestroyWindow")]
        public static extern void DestroyWindow(Window window);

        public static class Gl {

            /// <summary>
            /// Different options for the gl context to be set.
            /// </summary>
            /// <seealso cref="GetAttribute()"/>
            /// <seealso cref="SetAttribute()"/>
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

            /// <summary>
            /// Different options for the swap interval
            /// </summary>
            /// <seealso cref="GetSwapInterval()"/>
            /// <seealso cref="SetSwapInterval()"/>
            public enum SwapInterval : int
            {
                Immediate = 0,
                Synchronised = 1,
                LateSwapTearing = -1
            }

            /// <summary>
            /// The OpenGL context handle returned by <see cref="CreateContext()"/>
            /// </summary>
            /// <seealso cref="CreateContext()"/>
            public class Context : SafeHandle
            {
                Context() : base(new IntPtr(), true) {}
                public override bool IsInvalid
                {
                    get { return handle == null; }
                }
                protected override bool ReleaseHandle()
                {
                    DeleteContext(this);
                    return true;
                }
            }

            /// <summary>
            /// Set an OpenGL window attribute before window creation.
            /// </summary>
            /// <param name="attr">The OpenGL attribute to set</param>
            /// <param name="value">The desired value for the attribute</param>
            /// <returns>Returns 0 on success or a negative error code on failure</returns>
            /// <remarks>
            /// This function sets the OpenGL attribute attr to value.
            /// The requested attributes should be set before creating an OpenGL window.
            /// You should use <see cref='GetAttribute()'/> to check the values after creating the OpenGL context, since the values obtained can differ from the requested ones.</remarks>
            /// <seealso cref="GetAttribute()"/>
            /// <seealso cref="ResetAttributes()"/>
            [DllImport(DllName, EntryPoint = "SDL_GL_SetAttribute")]
            public static extern int SetAttribute(Attribute attr, int value);

            /// <summary>
            /// Set the swap interval for the current OpenGL context.
            /// </summary>
            /// <param name="interval"></param>
            /// <returns>Returns 0 on success or -1 if setting the swap interval is not supported</returns>
            /// <remarks>
            /// Some systems allow specifying <see cref='SwapInterval.LateSwapTearing'/> for the interval, to enable late swap tearing.
            /// Late swap tearing works the same as vsync, but if you've already missed the vertical retrace for a given frame,
            /// it swaps buffers immediately, which might be less jarring for the user during occasional framerate drops.
            /// If application requests late swap tearing and the system does not support it, this function will fail and return -1.
            /// In such a case, you should probably retry the call with  <see cref='SwapInterval.Synchronised'/>  for the interval.
            /// </remarks>
            /// <seealso cref="GetSwapInterval()"/>
            [DllImport(DllName, EntryPoint = "SDL_GL_SetSwapInterval")]
            public static extern int SetSwapInterval(SwapInterval interval);

            /// <summary>
            /// Update a window with OpenGL rendering.
            /// </summary>
            /// <param name="window">the window to change</param>
            /// <remarks>
            /// This is used with double-buffered OpenGL contexts, which are the default.
            /// On Mac OS X make sure you bind 0 to the draw framebuffer before swapping the window, otherwise nothing will happen.
            /// </remarks>
            [DllImport(DllName, EntryPoint = "SDL_GL_SwapWindow")]
            public static extern void SwapWindow(Window window);

            /// <summary>
            /// Create an OpenGL context for use with an OpenGL window, and make it current.
            /// </summary>
            /// <param name="window">The window to associate with the context</param>
            /// <returns>Returns the OpenGL context associated with window or null on error</returns>
            /// <remarks>Windows users new to OpenGL should note that, for historical reasons, GL functions added after OpenGL version 1.1 are not available by default.
            /// Those functions must be loaded at run-time, either with an OpenGL extension-handling library or with <see cref='GetProcAddress()'/> and its related functions.
            /// </remarks>
            /// <seealso cref="DeleteContext()"/>
            /// <seealso cref="MakeCurrent()"/>
            [DllImport(DllName, EntryPoint = "SDL_GL_CreateContext")]
            public static extern Gl.Context CreateContext(Window window);

            /// <summary>
            /// Delete an OpenGL context.
            /// </summary>
            /// <param name="context">The OpenGL context to be deleted</param>
            /// <seealso cref="CreateContext()"/>
            [DllImport(DllName, EntryPoint = "SDL_GL_DeleteContext")]
            public static extern void DeleteContext(Gl.Context context);
        }
    }
}
