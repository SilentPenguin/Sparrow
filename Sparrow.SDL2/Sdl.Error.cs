using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        [DllImport(DllName, EntryPoint = "SDL_GetError")]
        public static extern string GetError();
    }
}
