using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        [DllImport(DllName, EntryPoint = "SDL_Delay")]
        public static extern void Delay(uint ms);
    }
}
