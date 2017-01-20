using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl
{

    public static partial class Sdl
    {
        private const string DllName = "/Library/Frameworks/SDL2.framework/SDL2";

        [Flags]
        public enum InitFlag : UInt32
        {
            Timer =             0x00000001,
            Audio =             0x00000010,
            Video =             0x00000020,
            Joystick =          0x00000200,
            Haptic =            0x00001000,
            GameController =    0x00002000,
            Events =            0x00004000,
            NoParachute =       0x00100000,
            Everything =        0x00007231
        }

        [DllImport(DllName, EntryPoint = "SDL_Init")]
        public static extern UInt32 Init(InitFlag flags = 0);
        
        [DllImport(DllName, EntryPoint = "SDL_InitSubSystem")]
        public static extern UInt32 InitSubSystem(InitFlag flags);
        
        [DllImport(DllName, EntryPoint = "SDL_InitSubSystem")]
        public static extern void QuitSubSystem(InitFlag flags);

        [DllImport(DllName, EntryPoint = "SDL_InitSubSystem")]
        public static extern UInt32 WasInit(InitFlag flags);

        [DllImport(DllName, EntryPoint = "SDL_Quit")]
        public static extern void Quit();
    }
}