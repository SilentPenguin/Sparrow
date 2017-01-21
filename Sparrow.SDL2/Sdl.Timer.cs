using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        /// <summary>
        /// Wait a specified number of milliseconds before returning.
        /// </summary>
        /// <param name="ms">the number of milliseconds to delay</param>
        /// <remarks>This function waits at least the specified time, but possibly longer due to OS scheduling.</remarks>
        [DllImport(DllName, EntryPoint = "SDL_Delay")]
        public static extern void Delay(uint ms);
    }
}
