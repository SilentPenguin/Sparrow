using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        /// <summary>
        /// The types of renderer that can be created with <see cref='CreateRenderer()'/>
        /// </summary>
        /// <seealso cref="CreateRenderer()"/>
        [Flags]
        public enum RendererFlags : uint
        {
            Software =      0x00000001,
            Accelerated =   0x00000002,
            PresentVSync =  0x00000004,
            TargetTexture = 0x00000008
        }

        /// <summary>
        /// Renderer handle returned by <see cref="CreateRenderer()"/>
        /// </summary>
        /// <seealso cref="CreateRenderer()"/>
        public class Renderer : SafeHandle
        {
            Renderer() : base(new IntPtr(), true){}

            public override bool IsInvalid
            {
                get { return handle == null; }
            }

            protected override bool ReleaseHandle()
            {
                DestroyRenderer(this);
                return true;
            }
        }

        /// <summary>
        /// Create a 2D rendering context for a window.
        /// </summary>
        /// <param name="window">The window where rendering is displayed</param>
        /// <param name="index">The index of the rendering driver to initialize, omit to initialize the first one supporting the requested flags</param>
        /// <param name="flags">Zero or more <see cref'RendererFlags'/></param>
        /// <returns>Returns a valid rendering context or null if there was an error.</returns>
        /// <remarks>
        /// Flags may be any combination of <see cref='RendererFlags'/>.
        /// Providing no flags gives priority to available SDL_RENDERER_ACCELERATED renderers.
        /// </remarks>
        /// <seealso cref="CreateSoftwareRenderer()"/>
        /// <seealso cref="DestroyRenderer()"/>
        /// <seealso cref="GetNumRenderDrivers()"/>
        /// <seealso cref="GetRendererInfo()"/>
        [DllImport(DllName, EntryPoint = "SDL_CreateRenderer")]
        public static extern Renderer CreateRenderer(Window window, int index = -1, RendererFlags flags = 0);

        /// <summary>
        /// Destroy the rendering context for a window and free associated textures.
        /// </summary>
        /// <param name="renderer">A previously created rendering context.</param>
        /// <seealso cref="CreateRenderer()"/>
        [DllImport(DllName, EntryPoint = "SDL_DestroyRenderer")]
        public static extern void DestroyRenderer(Renderer renderer);
    }
}